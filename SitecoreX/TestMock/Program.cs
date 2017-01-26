using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Security;

namespace TestMock
{
    class Program
    {
        #region
        public class dwParam
        {
            public dynamic c_body { get; set; }
        }
        #endregion
        static void Main(string[] args)
        {
            try
            {
                ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls;
                dwParam obj = new dwParam();
                obj.c_body = new Dictionary<string, string>();
                obj.c_body["default"] = "Hi I am default";
                obj.c_body["fr-FR"] = "<div class=\"test\">Hi I am france footer</div>";
                obj.c_body["fr-CA"] = "Hi I am france canada footer";
                string temp = Newtonsoft.Json.JsonConvert.SerializeObject(obj);
                Console.WriteLine(temp);
                dynamic oauthResponse = Newtonsoft.Json.JsonConvert.DeserializeObject(GetToken());
                string token = oauthResponse.access_token.ToString();
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://sapient3.evaluation.dw.demandware.net");
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                Console.WriteLine(temp);
                System.Net.Http.HttpContent content = new StringContent(temp, UTF8Encoding.UTF8, "application/json");
                HttpResponseMessage messge = client.PutAsync("/s/-/dw/data/v17_1/libraries/SiteGenesisSharedLibrary/content/footer-copy-test", content).Result;
                string description = messge.Content.ReadAsStringAsync().Result;
                if (messge.IsSuccessStatusCode)
                {
                    string result = messge.Content.ReadAsStringAsync().Result;
                    description = result;
                }
                Console.WriteLine(description);
                Console.WriteLine(messge);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadKey();
            }
        }
        static bool CreateUser()
        {
            try
            {
                var userName = string.Format(@"{0}\aka{1}@yopmail.com", "extranet", DateTime.Now.Ticks.ToString());
                if (!Sitecore.Security.Accounts.User.Exists(userName))
                {
                    Membership.CreateUser(userName, "123456");
                    var _user = Sitecore.Security.Accounts.UserManager.GetUsers().Where(x => x.Profile.Email == userName).SingleOrDefault();
                    // Edit the profile information
                    //Sitecore.Security.Accounts.User user = Sitecore.Security.Accounts.User.FromName(string.Format(@"{0}\{1}", this.Domain, model.Email), true);
                    Sitecore.Security.UserProfile userProfile = _user.Profile;
                    userProfile.FullName = string.Format("{0} {1}", "Abhishek", "Mishra");
                }
            }
            catch (Exception ex)
            {
                Sitecore.Diagnostics.Log.Error(ex.InnerException.Message, "TestMock");
                return false;
            }
            return true;
        }
        static string GetToken()
        {
            string url = "https://account.demandware.com/";
            //Item footer = Sitecore.Data.Database.GetDatabase("web").GetItem("/Sitecore/Content/Components/Footer");
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url);

            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", "YWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhOmFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYWFhYQ==");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded"));
            #region param

            #endregion
            System.Net.Http.HttpContent content = new StringContent("grant_type=client_credentials", UTF8Encoding.UTF8, "application/x-www-form-urlencoded");
            HttpResponseMessage messge = client.PostAsync("/dw/oauth2/access_token", content).Result;
            string description = messge.Content.ReadAsStringAsync().Result;
            if (messge.IsSuccessStatusCode)
            {
                string result = messge.Content.ReadAsStringAsync().Result;
                description = result;
            }
            Console.WriteLine(messge);
            return description;
        }
    }
}
