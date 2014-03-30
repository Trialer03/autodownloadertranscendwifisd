using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.UI.WebControls;

namespace TranscendAutoDownloader
{
    public class DownloaderClass
    {
        private static string content = "";



        public static bool DownloadFile(Uri fileUri, Dictionary<string, string> parameterDictionary, string zielFilename)
        {
           
            var adresse = GetUrlWithParameter(fileUri, parameterDictionary);

            var p =Process.Start("wget", String.Format("--output-document=\"{0}\" \"{1}\"", zielFilename, adresse));
            while (p != null && !p.HasExited)
            {
                Thread.Sleep(500);
            }

            return true;
        }

        private static string GetUrlWithParameter(Uri fileUri, Dictionary<string, string> parameterDictionary)
        {
            var adresse = fileUri.ToString();
            if (parameterDictionary.Count > 0) adresse += adresse.Contains("?") ? "" : "?";
            var liste = new List<string>();
            foreach (KeyValuePair<string, string> keyValuePair in parameterDictionary)
            {
                liste.Add(HttpUtility.UrlEncode(keyValuePair.Key) + "=" + HttpUtility.UrlEncode(keyValuePair.Value));
            }
            adresse += String.Join("&", liste);
            return adresse;
        }

        public static string GetHttpFile(Uri fileUri, Dictionary<string, string> parameterDictionary)
        {
            var adresse = GetUrlWithParameter(fileUri, parameterDictionary);
            try
            {
                var client = new WebClient();
                content = client.DownloadString(adresse);
            }
            catch (Exception e)
            {
                content = "";
            }

            return content;

        }
    }
}
