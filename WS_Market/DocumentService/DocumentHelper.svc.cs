﻿using System;
using System.Web.Services;
using System.IO;
using System.ServiceModel.Activation;
using log4net;

namespace DocumentService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class DocumentHelper : IDocumentHelper
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(DocumentHelper).Name);

        [WebMethod]
        public string UploadFile(byte[] fileBytes, DocumentTypes type, string extention)
        {
            string folder = Path.GetFullPath(System.Environment.CurrentDirectory + "/../../DocumentStore/" + type.ToString());
            log.Debug("folder path = " + folder);

            string fileName = System.Guid.NewGuid().ToString() + "." + extention;
            log.Debug("file name = " + fileName);

            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            using (MemoryStream mstream = new MemoryStream(fileBytes))
                using (FileStream fstream = new FileStream(folder + "/" + fileName, FileMode.Create))
                    mstream.WriteTo(fstream);
            
            return fileName;
        }

        public byte[] GetFile(DocumentTypes type, string fileName)
        {
            return null;
        }
    }
}
