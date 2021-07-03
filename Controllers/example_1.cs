using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]/[action]")]//控制了其路由的规则，如何获取方法，通过该路由，加上action可以调用方法
    [ApiController]//表示使用于api的特性
    public class example_1 : ControllerBase
    {
        public string GetTest()
        {
            return "test";
        }
    }
}
