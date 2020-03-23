using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace UnitedSleepInventoryForms.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public string[] files;
        public void OnGet()
        {
            System.IO.Directory.CreateDirectory(@"\\usdfileserver\sleeptech\Inventory\Sleep Lab Inventory Logs");
            files = new DirectoryInfo(@"\\usdfileserver\sleeptech\inventory\Sleep Lab Inventory Logs").GetFiles().Where(f => f.LastWriteTime > DateTime.Today).OrderByDescending(f => f.LastWriteTime).Select(o => o.Name).ToArray();
            ViewData["files"] = files;

        }
    }
}
