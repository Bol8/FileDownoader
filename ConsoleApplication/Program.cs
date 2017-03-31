using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            const string pathLocalResource = @"C:\Users\Oscar\Documents\Ficheros\Euromillones\";
            var remoteUri =
               "https://docs.google.com/spreadsheet/pub?key=0AhqMeY8ZOrNKdEFUQ3VaTHVpU29UZ3l4emFQaVZub3c&output=csv";

            var fileDownloader = new FileDownloader.Core.FileDownloader();
            fileDownloader.DownloadFile(remoteUri, pathLocalResource, "Historico.csv");
            
        }
    }
}
