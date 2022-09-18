using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment2_1.Pages
{
     public class LoginModel : PageModel
    {

        [BindProperty]
        [Display(Name = "Username")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Username {get; set;}

        [BindProperty]
        [Display(Name = "Password")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Password {get; set;}
        private readonly ILogger<LoginModel> _logger;

        public LoginModel(ILogger<LoginModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            _logger.LogInformation($"OnPost() {Username} {Password}");
        }
    }
}