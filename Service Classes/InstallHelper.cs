using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SecondHelperLibrary.ServiceClasses
{
    //Helper method to install files with the customer name and installer namer 
    public class InstallHelper
    {
        //Declare my destination file
        private string _setupDestinationFile;

        public bool DownloadInstaller(string customerName, string installerName)
        {
            //Create a new web client 
            var client = new WebClient();

            try
            {
                //Download my file TODO: Add reference to System.ComponentModel.Primitives
                //client.DownloadFile(string.Format("http://example.com/{0}/{1}", customerName, installerName), _setupDestinationFile));

                return true;
            }
            //Catch any bugs for 
            catch (WebException)
            {
                return false;
            }
        }

    }
}
