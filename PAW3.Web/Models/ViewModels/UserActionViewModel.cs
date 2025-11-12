namespace PAW3.Web.Models.ViewModels;

public class UserActionPageViewModel
{
    public IEnumerable<UserActionViewModel> UserActions { get; set; } = [];
    public List<SummaryViewModel> Summaries { get; set; } = [];
}

public class UserActionViewModel
{
    public decimal? Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
}

