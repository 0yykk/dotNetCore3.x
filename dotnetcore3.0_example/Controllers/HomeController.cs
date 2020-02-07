using dotnetcore3._0_example.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetcore3._0_example.Controllers
{
    public class HomeController:Controller
    {
        public HomeController(IClock clock)
        {

        }
    }
}
