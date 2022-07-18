using RegexProject.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProject.Sevice
{
    public class ReadWebpage : IReadWebpage
    {
        public Task ReadWebPage(string url)
        {
            HttpWebRequest wrWebRequest = WebRequest.Create(url) as HttpWebRequest;
            HttpWebResponse hwrWebResponse = (HttpWebResponse)wrWebRequest.GetResponse();

            StreamReader srResponseReader = new StreamReader(hwrWebResponse.GetResponseStream());
            string strResponseData = srResponseReader.ReadToEnd();
            srResponseReader.Close();

            Regex match = new Regex(@"\b(?:https?://|www\.)\S+\b", RegexOptions.IgnoreCase);

            var Matches = match.Matches(strResponseData);

            ArrayList list = new ArrayList();
            foreach (Match m in Matches)
            {
                list.Add(m);
            }

            WriteInConsole(list);

            return Task.CompletedTask;
        }

        void WriteInConsole(ArrayList list)
        {
            foreach (var lst in list)
            {
                Console.WriteLine(lst);
            }
        }
    }
}
