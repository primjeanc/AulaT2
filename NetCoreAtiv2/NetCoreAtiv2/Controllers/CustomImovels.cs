using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetCoreAtiv2.Models;

namespace NetCoreAtiv2.Controllers
{
    [Route("api/Imovels/Co")]    
    public partial class ImovelsController
    {

        [HttpGet("ret")]
        public object GetImoveis(Imovel item)
        {
            return item;
        }
    }
}
