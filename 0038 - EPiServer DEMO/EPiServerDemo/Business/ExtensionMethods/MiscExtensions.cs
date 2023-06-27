using System;
using System.Text;
using EPiServer;
using EPiServer.Core;
using EPiServer.ServiceLocation;

namespace EPiServerDemo.Business.ExtensionMethods
{
    public static class MiscExtensions
    {
        public static string TruncateAtWord(this string input, int noWords)
        {
            string output = string.Empty;

            string[] inputArr = input.Split(new[] { ' ' }); 
            if (inputArr.Length <= noWords)
                return input; if (noWords > 0)
            {
                for (int i = 0; i < noWords; i++)
                {
                    output += inputArr[i] + " ";
                }
                output += "...";
                return output;
            }
            return input;
        }

        public static string ExternalURLFromReference(this PageReference p)
        {
            var loader = ServiceLocator.Current.GetInstance<IContentLoader>();
            PageData page = loader.Get<PageData>(p);

            UrlBuilder pageURLBuilder = new UrlBuilder(page.LinkURL);

            Global.UrlRewriteProvider.ConvertToExternal(pageURLBuilder, page.PageLink, UTF8Encoding.UTF8);

            string pageURL = pageURLBuilder.ToString();

            UriBuilder uriBuilder = new UriBuilder(EPiServer.Web.SiteDefinition.Current.SiteUrl);

            uriBuilder.Path = pageURL;

            return uriBuilder.Uri.AbsoluteUri;
        }
    }
}