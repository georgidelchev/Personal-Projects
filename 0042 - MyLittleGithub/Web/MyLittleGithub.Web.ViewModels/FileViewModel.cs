using System;

namespace MyLittleGithub.Web.ViewModels;

public class FileViewModel
{
    public string Name { get; set; }

    public string Path { get; set; }

    public double Size { get; set; }

    public DateTime CreatedOn { get; set; }

    public string CreatedOnAsString => this.CreatedOn.ToString("G");

    public DateTime LastModified { get; set; }

    public string LastModifiedAsString => this.LastModified == null ? this.CreatedOnAsString : this.LastModified.ToString("G");
}
