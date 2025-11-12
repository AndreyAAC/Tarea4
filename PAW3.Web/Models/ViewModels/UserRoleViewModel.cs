namespace PAW3.Web.Models.ViewModels;
public class UserRolePageViewModel
{
    public IEnumerable<UserRoleViewModel> UserRoles { get; set; } = [];
    public List<SummaryViewModel> Summaries { get; set; } = [];
}
public class UserRoleViewModel
{
    public decimal? Id { get; set; }
    public decimal? RoldId { get; set; }
    public decimal? UserId { get; set; }
}

