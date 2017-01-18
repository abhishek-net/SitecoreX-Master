using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace SitecoreX.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            try
            {
                Item footer = Sitecore.Data.Database.GetDatabase("web").GetItem("/Sitecore/Content/Components/Footer");
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://sapient3.evaluation.dw.demandware.net");

                byte[] cred = UTF8Encoding.UTF8.GetBytes("cd22bac6-34ad-4bf1-9162-e82c7dcfd6a8");
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", "cd22bac6-34ad-4bf1-9162-e82c7dcfd6a8");
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                #region param
                string DATA = @"{""name"":{
                    ""default"":""About Us""
  },
  ""page_title"":
  {
                    ""default"":""Page Title""
  },
  ""page_description"":
  {
                    ""default"":""Page Description""
  },
  ""page_keywords"":
  {
                    ""default"":""Keyword1""
  },
  ""page_url"":
  {
                    ""default"":""default.ocapi.net""
  },
  ""online"":
  {
                    ""default"":false
  },
  ""searchable"":
  {
                    ""default"":false
  },
  ""template"":""template1"",
  ""site_map_change_frequency"":
  {
                    ""default"":""never""
  },
  ""site_map_included"":
  {
                    ""default"":0
  },
  ""site_map_priority"":
  {
                    ""default"":0.5
  }
                ""c_body"":""<p>This is the about us body.</p>""
}";
                #endregion
                System.Net.Http.HttpContent content = new StringContent(DATA, UTF8Encoding.UTF8, "application/json");
                HttpResponseMessage messge = client.PostAsync("/s/-/dw/data/v17_1/libraries/SiteGenesisSharedLibrary/content/footer-copy-test", content).Result;
                string description = string.Empty;
                if (messge.IsSuccessStatusCode)
                {
                    string result = messge.Content.ReadAsStringAsync().Result;
                    description = result;
                }
            }
            catch (Exception ex)
            {
                var x = ex;
            }
            return View("Index");
        }
    }
}