﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Formulario.Pages
{
    public class SegumientoModel : PageModel
    {
        private readonly ILogger<SegumientoModel> _logger;

        public SegumientoModel(ILogger<SegumientoModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
