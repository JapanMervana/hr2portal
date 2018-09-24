using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DataAccessLayer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IHR2DataAccessLayer" in both code and config file together.
    [ServiceContract]
    public interface IHR2DataAccessLayer
    {
        [OperationContract]
        void DoWork();
    }
}
