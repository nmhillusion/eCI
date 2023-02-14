using System.Net;
using System.Text;

namespace eCI.helper
{
    internal class HttpHelper
    {
        public string GetContentOfUrl(string url)
        {
            using (WebClient client = new WebClient())
            {
                client.Encoding = Encoding.UTF8;
                string downloadString = Encoding.UTF8.GetString(client.DownloadData(url));
                return downloadString;
            }
        }
    }
}
