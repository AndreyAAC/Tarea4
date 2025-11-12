namespace PAW3.Web.Models.ViewModels;

public class RolePageViewModel
{
    public IEnumerable<RoleViewModel> Roles { get; set; } = [];
    public List<SummaryViewModel> Summaries { get; set; } = [];
}
public class RoleViewModel
{
    public int RoleId { get; set; }
    public string? RoleName { get; set; }
}

