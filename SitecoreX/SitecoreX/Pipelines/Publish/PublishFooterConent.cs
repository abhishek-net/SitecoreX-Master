using Sitecore.Publishing.Pipelines.Publish;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecoreX.Pipelines.Publish
{
    class PublishFooterContent
    {
        public void OnPublishEnd(object sender, EventArgs args)
        {
            try
            {
                var footer = Sitecore.Data.Database.GetDatabase("web").GetItem("/Sitecore/Content/Components/Footer");
                //var item = Sitecore.Context.Database.GetItem("{067F36FD-E2EF-4693-BB53-409278601BF4}");
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
