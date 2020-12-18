using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicTestService.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public UserController()
        {

        }
        /// <summary>
        /// 返回用户名
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public string GetUserName()
        {
            return "ershao";
        }
    }
}
