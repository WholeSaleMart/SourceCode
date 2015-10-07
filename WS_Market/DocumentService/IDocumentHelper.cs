using System.ServiceModel;

namespace DocumentService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IDocumentHelper
    {

        [OperationContract]
        string UploadFile(byte[] fileBytes, DocumentTypes type, string extention);

        [OperationContract]
        byte[] GetFile(DocumentTypes type, string fileBytes);

        // TODO: Add your service operations here
    }

}
