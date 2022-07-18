using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace RegexProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            ArrayList al = p.ReadWebPage("https://tretton37.com/");

            foreach (var i in al)
            {
                Console.WriteLine(i);
            }
        }

        public ArrayList ReadWebPage(string url)
        {
            HttpWebRequest wrWebRequest = WebRequest.Create(url) as HttpWebRequest;
            HttpWebResponse hwrWebResponse = (HttpWebResponse)wrWebRequest.GetResponse();

            StreamReader srResponseReader = new StreamReader(hwrWebResponse.GetResponseStream());
            string strResponseData = srResponseReader.ReadToEnd();
            srResponseReader.Close();
            return FindMatches(strResponseData);
        }

        public ArrayList FindMatches(string page)
        {
            Regex match = new Regex(@"\b(?:https?://|www\.)\S+\b", RegexOptions.IgnoreCase);

            var Matches = match.Matches(page);

            ArrayList list = new ArrayList();
            foreach (Match m in Matches)
            {
                list.Add(m);
            }
            return list;
        }
    }
}
