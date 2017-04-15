using System;
using System.Collections.Generic;
using System.Text;

namespace WebServiceDes.TypeDefine
{
    public enum RequestType
    {
        GET = 0,
        POST = 1,
        PUT = 2,
        PATCH = 3,
        DELETE = 4,
        COPY = 5
    }
    public enum SignMethod
    {
        MD5 = 0,
    }
    public enum DataFormat
    {
        ConnectWithCharactor = 0,
        ConnectWithCharactorUpOrder = 1,
        ConnectWithCharactorDownOrder = 2,
        JSON = 10,
        XML = 100
    }
}
