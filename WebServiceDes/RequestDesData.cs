using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WebServiceDes.TypeDefine;
namespace WebServiceDes
{
    public class RequestDesData : DesSerializerInterface
    {
        public ParamDesData[] allParams;
        
        public ParamDesData[] signedParams;
        public ParamDesData signStrParam;
        public ParamDesData dataContentParam;

        public SignMethod signMethod;
        public DataFormat dataFormat;
        public RequestType requestType;

        public void LoadDesData(String obj)
        {

        }
    }
}
