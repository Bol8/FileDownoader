using System.Collections.Generic;
using System.Net;
using FileDownloader.Interfaces;

namespace FileDownloader.Core
{
    public class FileDownloader : IFileManageServices
    {
        private readonly WebClient _webClient;


        public FileDownloader()
        {
            _webClient = new WebClient();
        }



        /// <summary>
        /// Método que descarga un fichero de la ruta pasada como parámetro 
        /// y lo guarda con el nombre indicado en una ruta local.
        /// </summary>
        /// <param name="pathRemoteResource"></param>
        /// <param name="pathLocalResource"></param>
        /// <param name="localFileName"></param>
        public void DownloadFile(string pathRemoteResource, string pathLocalResource, string localFileName)
        {
            using (_webClient)
            {
                var localPath = pathLocalResource + "" + localFileName;

                _webClient.DownloadFile(pathRemoteResource, localPath);
            }
        }

        /// <summary>
        /// Método que descarga secuencialmente una lista ficheros con los nombres 
        /// indicados en la lista.
        /// Los guardará en local con los mismos nombres.
        /// </summary>
        /// <param name="fileNameList"></param>
        /// <param name="pathRemoteResource"></param>
        /// <param name="pathLocalResource"></param>
        public void DownloadFiles(List<string> fileNameList, string pathRemoteResource, string pathLocalResource)
        {
            using (_webClient)
            {
                foreach (var fileName in fileNameList)
                {
                    var localPath = pathLocalResource + "" + fileName;
                    var remoteResource = pathRemoteResource + "" + fileName;

                    _webClient.DownloadFile(remoteResource, localPath);
                }
            }
        }

        /// <summary>
        /// Método que recupera una lista de ficheros.
        /// </summary>
        /// <param name="pathList"></param>
        /// <returns></returns>
        public List<string[]> getFiles(List<string> pathList)
        {
            var list = new List<string[]>();

            foreach (var path in pathList)
            {
                list.Add(System.IO.File.ReadAllLines(path));
            }

            return list;
        }

        public string[] getFile(string path)
        {
            return System.IO.File.ReadAllLines(path);
        }
    }
}
