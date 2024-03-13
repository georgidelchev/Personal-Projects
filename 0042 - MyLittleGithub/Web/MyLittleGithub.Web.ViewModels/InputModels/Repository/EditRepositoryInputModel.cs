using MyLittleGithub.Services.Mapping;

namespace MyLittleGithub.Web.ViewModels.InputModels.Repository;

public class EditRepositoryInputModel : CreateRepositoryInputModel, IMapFrom<Data.Models.Repository>
{
}
