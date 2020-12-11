using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PracFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperacionesController : ControllerBase {
        [HttpGet]
        public string Add(int numero)
        {
            if (numero == 0)
                return "Rodolfo";
            else if (numero < 0)
                return "Error";
            else
                return $"{numero}";

        }
    
    }
}
