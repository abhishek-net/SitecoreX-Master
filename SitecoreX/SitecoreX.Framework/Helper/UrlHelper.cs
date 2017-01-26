using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecoreX.Framework.Helper
{
    public static class UrlHelper
    {
        static Func<string, string> GetItemUrl = param =>
        {
            var sitecoreItem = Sitecore.Context.Database.GetItem(param);
            return Sitecore.Links.LinkManager.GetItemUrl(sitecoreItem);
        };

        static string _LoginUrl = GetItemUrl(Constants.LoginItem);
        public static string LoginUrl
        {
            get
            {
                return _LoginUrl;
            }
        }

        static string _HomeUrl = GetItemUrl(Constants.HomeItem);
        public static string HomeUrl
        {
            get
            {
                return _HomeUrl;
            }
        }

        static string _RegistrationUrl = GetItemUrl(Constants.RegistrationItem);
        public static string RegistrationUrl
        {
            get
            {
                return _RegistrationUrl;
            }
        }


    }
}
