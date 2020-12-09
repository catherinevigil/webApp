
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.Extensions.Logging;
//using uiExp.Shared;

//namespace uiExp.Server.Controllers
//{
//    [ApiController]
//    [Route("[controller]")]
//    public class FeedController : ControllerBase
//    {
       
//        //private readonly ILogger<FeedController> _logger;

//        //public FeedController(ILogger<FeedController> logger)
//        //{
//        //    _logger = logger;
//        //}

//        [HttpGet]
//        public Feed Get()
//        {
//            var lines = System.IO.File.ReadAllLines("/Users/eliburnes/Projects/webApp/uiExp/Server/textThreadFeed.txt");
//            //Console.WriteLine(lines[9]);
//            Feed data = new Feed();
//            Console.WriteLine(data);
//            return data;
//        }
//    }
//}


////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Threading.Tasks;
////using Microsoft.AspNetCore.Mvc;

////using uiExp.Shared;


////// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

////namespace uiExp.Server.Controllers
////{
////    [Route("api/[controller]")]
////    public class FeedController : Controller
////    {
////        // GET: /<controller>/
////        public IActionResult Index()
////        {
////            return View();
////        }
////        [HttpGet("[action]")]
////        public Feed GetData(string action, string id)
////        {
////            var lines = System.IO.File.ReadAllLines("textThreadFeed.txt");
////            return new Feed(lines);
////        }
////    }
////}