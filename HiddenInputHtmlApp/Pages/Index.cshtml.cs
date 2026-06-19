using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HiddenInputHtmlApp.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public string GeneratedHiddenInputHtml { get; private set; } = string.Empty;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        GeneratedHiddenInputHtml = "<input type='hidden' name='DynamicHidden' value='dynamic-value' />";
    }

    public string BuildHiddenInput()
    {
        // Example of hidden input generation using string concatenation.
        var name = "HiddenLegacy";
        var value = "legacy-generated";
        // Test
        return $"<input type=\"hidden\" name=\"{name}\" value=\"{value}\" />";
    }
}
