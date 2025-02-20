using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LoadTestDemo.Pages;

public class PrivacyModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;
    
    [BindProperty(SupportsGet = true)]
    public int Delay { get; set; }

    public PrivacyModel(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public async Task OnGet()
    {
      Delay = Random.Shared.Next(300);
      await Task.Delay(Delay);
    }
}

