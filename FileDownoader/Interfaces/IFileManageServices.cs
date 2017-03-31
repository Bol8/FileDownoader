using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDownloader.Interfaces
{
    public interface IFileManageServices
    {
        void DownloadFile(string pathRemoteResource, string pathLocalResource, string localFileName);
        void DownloadFiles(List<string> fileNameList, string pathRemoteResource, string pathLocalResource);
        List<string[]> getFiles(List<string> pathList);

    }
}
