using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using service;

namespace WebApplication2.Controllers
{

    
    public class MainController : ApiController
    {
        public readonly TestService _departmentService;

        public MainController(TestService departmentService)
        {
            _departmentService = departmentService;
        }

        //public int Get(string id, int score, int level, Stack<char> qw)
        //{
        //    return _departmentService.ADD(id, score, level, qw);
        //}

        [HttpGet]
       
        public IHttpActionResult Score(string id)
        {
            int score = 0;
            int level = 0;
            
            int fi = _departmentService.ADD(id, score, level);
            return Ok(fi);
        }

    }
}
