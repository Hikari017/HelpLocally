﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace HelpLocally.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [BindProperty]
        public Employee Employee { get; set; }

        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }


        public void OnGet()
        {
            _logger.LogInformation($"Id: {Id}");
        }

        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }

            _logger.LogInformation("Wszystko ok");
        }
    }

    public class Employee
    {
        [Required]
        public string FirstName { get; set; }
     
        [Required]
        public string LastName { get; set; }
    }
}