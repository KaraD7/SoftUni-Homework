using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _00.Lab_WebClient
{
    class DownloadFile
    {
        static void Main(string[] args)
        {
            var webClient = new WebClient();
            webClient.DownloadFile(
                "https://softuni.bg/downloads/svn/soft-tech/Jan-2017/Programming-Fundamentals-Extended-Jan-2017/12.Programming-Fundamentals-Objects-and-Simple-Classes/12.Programming-Fundamentals-Objects-and-Simple-Classes.pptx",
                "webClient.pptx");

            Process.Start("webClient.pptx");
        }
    }
}
