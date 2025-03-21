using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace MathService
{
    [ServiceContract]
    public interface IMath
    {
        [OperationContract]
        bool Prime(int value);
    }
}
