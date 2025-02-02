using Umbraco.Cms.Core.Models.ContentEditing;
using Umbraco.Cms.Core.Web;

namespace Umbraco.Cms.Core.Notifications
{
    public class SendingContentNotification : INotification
    {
        public IUmbracoContext UmbracoContext { get; }

        public ContentItemDisplay Content { get; }

        public SendingContentNotification(ContentItemDisplay content, IUmbracoContext umbracoContext)
        {
            Content = content;
            UmbracoContext = umbracoContext;
        }
    }
}
