using {{cookiecutter.project_name}}.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace {{cookiecutter.project_name}}.Service.Controllers
{
    public class Demo : IDemo
    {
        ApiResult<string> IDemo.Demo()
        {
            throw new NotImplementedException();
        }
    }
}
