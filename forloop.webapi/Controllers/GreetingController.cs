using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace forloop.webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreetingController : ControllerBase
    {
        
        [HttpGet]
        [Route("get-basic-greeting")]
        public IActionResult GetBasicGreeting(){
            return Ok("Hello ForLoop People!");
        }
        [HttpGet]
        [Route("get-greeting-by-time")]
        public IActionResult GetGreetingByTime(){
            string Greeting="";
            if(DateTime.Now.Hour<12){
               Greeting=$"Good morning, the time is {DateTime.Now.ToShortTimeString()}";
            }
           else if(DateTime.Now.Hour==12 || DateTime.Now.Hour<=16){
                Greeting=$"Good afternoon, the time is {DateTime.Now.ToShortTimeString()}";
           }
           else if (DateTime.Now.Hour>16){
               Greeting=$"Good evening, the time is {DateTime.Now.ToShortTimeString()}";
           }
            return Ok(Greeting);
        }
    }
}
