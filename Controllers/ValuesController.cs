using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sendingMail_mailkit.Services;
using sendingMail_mailkit.Model;
namespace sendingMail_mailkit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

            IEmailService EmailService;
            public ValuesController(IEmailService EmailService)
            {
                this.EmailService = EmailService;
            }

   [HttpPost("contactUs")] 
         public void c([FromBody]EmailMessage e)
        {

               EmailService.Send(e);
                   
        }

    }
}
