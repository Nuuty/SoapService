using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFSoapService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<Dummy> GetAll();

        [OperationContract]
        IEnumerable<Dummy> GetDummy(string name);

        [OperationContract]
        void Add(string name);

        [OperationContract]
        void Edit(int id, string newname);

        [OperationContract]
        void Delete(string name);
    }
}
