﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using PFD_GroupA.Models;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Runtime.ConstrainedExecution;

namespace PFD_GroupA.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}

//test commit