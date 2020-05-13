using System;
using System.IO;
using System.IO.Compression;
using System.Net;

namespace ztm
{
    class Program
    {
        static void Main(string[] args)
        {
            ZTM obj = new ZTM();
            obj.GetZipGTFS();
            obj.ExtractZipGTFS();
        }
    }
     class ZTM
    {
        private WebClient webClient = null;
        string source = @"https://ckan.multimediagdansk.pl/dataset/c24aa637-3619-4dc2-a171-a23eec8f2172/resource/30e783e4-2bec-4a7d-bb22-ee3e3b26ca96/download/gtfsgoogle.zip";
        string destination = @"c:\Users\Piotrek\Documents\Projekty VSC\ztm\file.zip";
        string destinationEx = @"c:\Users\Piotrek\Documents\Projekty VSC\ztm\destination\";

        public void GetZipGTFS() {
             // Is file downloading yet?
            if (webClient != null)
            return;

            webClient = new WebClient();
            webClient.DownloadFile(source,destination);
        }
        public void ExtractZipGTFS(){
            ZipFile.ExtractToDirectory(destination, destinationEx);
        }
    }
    
    
   
}