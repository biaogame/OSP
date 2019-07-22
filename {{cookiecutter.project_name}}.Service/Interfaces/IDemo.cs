using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace {{cookiecutter.project_name}}.Service.Interfaces
{
    [ServiceContract]
    interface IDemo
    {
        //添加SP用户组
        [OperationContract(Name = "Demo")]
        [WebInvoke(Method = "POST", UriTemplate = "Demo", BodyStyle = WebMessageBodyStyle.WrappedRequest, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        ApiResult<string> Demo();
    }
}
