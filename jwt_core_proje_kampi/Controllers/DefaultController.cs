﻿using jwt_core_proje_kampi.DAL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jwt_core_proje_kampi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet("[action]")]
        public IActionResult Login()
        {
            return Created("", new BuildToken().CreateToken());
        }
        [HttpGet("[action]")]
        [Authorize]
        public IActionResult Page1()
        {
            return Ok("Sayfa 1 İçin Girişiniz Başarılı");
        }
    }
}
