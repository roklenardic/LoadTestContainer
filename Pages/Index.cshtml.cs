using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LoadTestDemo.Pages;

public class IndexModel : PageModel
{
  private readonly ILogger<IndexModel> _logger;
  [BindProperty(SupportsGet = true)]
  public int Delay { get; set; }

  public IndexModel(ILogger<IndexModel> logger)
  {
    _logger = logger;
  }

  public async Task OnGet()
  {
    Delay = Random.Shared.Next(300);
    await Task.Delay(Delay);
  }
}
