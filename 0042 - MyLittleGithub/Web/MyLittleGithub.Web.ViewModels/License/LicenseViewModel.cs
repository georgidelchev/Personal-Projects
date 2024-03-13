using MyLittleGithub.Services.Mapping;

namespace MyLittleGithub.Web.ViewModels.License;

public class LicenseViewModel : IMapFrom<Data.Models.License>
{
    public string Name { get; set; }

    public string Description { get; set; }
}
