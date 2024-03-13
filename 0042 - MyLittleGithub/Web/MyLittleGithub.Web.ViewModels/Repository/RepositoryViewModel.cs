using System;

using MyLittleGithub.Services.Mapping;

namespace MyLittleGithub.Web.ViewModels.Repository;

public class RepositoryViewModel : IMapFrom<Data.Models.Repository>
{
    public string Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public string ApplicationUserUserName { get; set; }

    public DateTime CreatedOn { get; set; }

    public string CreatedOnAsString
        => this.CreatedOn.ToString("D");

    public DateTime ModifiedOn { get; set; }

    public string ModifiedOnAsString
        => this.ModifiedOn != default ? this.ModifiedOn.ToString("D") : "N/A";
}
