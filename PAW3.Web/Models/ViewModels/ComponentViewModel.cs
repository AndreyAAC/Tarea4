namespace PAW3.Web.Models.ViewModels;


public class ComponentPageViewModel
{
    public IEnumerable<ComponentViewModel> Components { get; set; } = [];
    public List<SummaryViewModel> Summaries { get; set; } = [];
}

public class ComponentViewModel
{
    public decimal Id { get; set; }
    public string Name { get; set; } = null!;
    public string Content { get; set; } = null!;
}

