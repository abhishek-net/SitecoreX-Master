using Sitecore.Data.Items;
using Sitecore.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;

namespace SitecoreX.Framework.Pipelines
{
    class PublishFooter
    {
        class ContentAssetParam
        {
            public dynamic c_body { get; set; }

        }
        public void OnPublishEnd(object sender, EventArgs args)
        {
            #region Publish custom message
            var publishJobs = Sitecore.Jobs.JobManager
                    .GetJobs().Where(x => x.Category.Equals("publish"))
                    .ToList();

            string customMessage = string.Empty;
            #endregion

            Sitecore.Diagnostics.Log.Info("In footer publish", this);
            Item footer = Sitecore.Data.Database.GetDatabase("web").GetItem("/Sitecore/Content/Components/Footer");
            try
            {
                Sitecore.Diagnostics.Log.Info("footer content", footer.Fields);
               
                ContentAssetParam paramObj = new ContentAssetParam();
                paramObj.c_body = new Dictionary<string, string>();
                paramObj.c_body["default"] = footer.Fields["FooterText"].Value.ToString();
                string paramString = Newtonsoft.Json.JsonConvert.SerializeObject(paramObj);
                Sitecore.Diagnostics.Log.Info("DW parameters:" + paramString, this);

                foreach (var itemLanguage in footer.Languages)
                {
                    var item = footer.Database.GetItem(footer.ID, itemLanguage);
                    if (item.Versions.Count > 0)
                    {
                        paramObj.c_body[itemLanguage.ToString()] = item.Fields["FooterText"].Value.ToString();
                    }
                }

                dynamic oauthResponse = Newtonsoft.Json.JsonConvert.DeserializeObject(GetToken());
                string token = oauthResponse.access_token.ToString();
                Sitecore.Diagnostics.Log.Info("DW OAuth token: " + token, this);

                ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls;
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://sapient3.evaluation.dw.demandware.net");
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
             
                System.Net.Http.HttpContent content = new StringContent(paramString, UTF8Encoding.UTF8, "application/json");
                HttpResponseMessage messge = client.PutAsync("/s/-/dw/data/v17_1/libraries/SiteGenesisSharedLibrary/content/footer-copy-test", content).Result;
                string description = messge.Content.ReadAsStringAsync().Result;
                if (messge.IsSuccessStatusCode)
                {
                    string result = messge.Content.ReadAsStringAsync().Result;
                    description = result;
                }
                customMessage = messge.StatusCode.ToString();
                Sitecore.Diagnostics.Log.Info("Response from DW OCAPI: " + description, this);
            }
            catch (Exception ex)
            {
                customMessage = ex.InnerException.Message;
                Sitecore.Diagnostics.Log.Info("Error occured:" + ex.InnerException.Message, ex);
            }
            foreach (Job j in publishJobs)
            {
                if (j.Handle.IsLocal)
                {
                    j.Status.Messages.Add(System.Environment.NewLine + "Footer publish status: " + customMessage + System.Environment.NewLine);
                }

            }
        }
        string GetToken()
        {
            string url = "https://account.demandware.com/";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", "YWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhOmFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYQ==");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded"));
            System.Net.Http.HttpContent content = new StringContent("grant_type=client_credentials", UTF8Encoding.UTF8, "application/x-www-form-urlencoded");
            HttpResponseMessage messge = client.PostAsync("/dw/oauth2/access_token", content).Result;
            string description = messge.Content.ReadAsStringAsync().Result;
            if (messge.IsSuccessStatusCode)
            {
                string result = messge.Content.ReadAsStringAsync().Result;
                description = result;
            }
            Sitecore.Diagnostics.Log.Info("Response from DW Oauth:" + messge, this);
            return description;
        }
    }
}
