using System.Configuration;
using System.Linq;
using System.Web.Security;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.Security;

namespace EPiServerDemo.Business.Initialization
{
    [InitializableModule]
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    public class RegisterAdminInitializationModule : IInitializableModule
    {
        private const string virtualRoleName = "CmsAdmins";
        private const string storedRoleName = "WebAdmins";
        private const string userName = "Admin";
        private const string password = "Pa$$w0rd";
        private const string email = "admin@alloy.com";

        public void Initialize(InitializationEngine context)
        {
            string enabledString = ConfigurationManager.AppSettings["alloy:RegisterAdmin"];

            bool enabled;
            if (bool.TryParse(enabledString, out enabled))
            {
                if (enabled)
                {
                    #region Use ASP.NET Membership classes to create the role and user

                    // if the stored role does not exist, create it
                    if (!Roles.RoleExists(storedRoleName))
                    {
                        Roles.CreateRole(storedRoleName);
                    }

                    // if the user already exists, delete it
                    MembershipUser user = Membership.GetUser(userName);
                    if (user != null)
                    {
                        Membership.DeleteUser(userName);
                    }

                    // create the user with password and add it to role
                    Membership.CreateUser(userName, password, email);
                    Roles.AddUserToRole(userName, storedRoleName);

                    #endregion

                    #region Use EPiServer classes to give full access to root of content tree

                    var security = context.Locate.Advanced.GetInstance<IContentSecurityRepository>();

                    IContentSecurityDescriptor permissions = security
                        .Get(ContentReference.RootPage)
                        .CreateWritableClone() as IContentSecurityDescriptor;

                    var adminEntries = permissions
                        .Entries
                        .Where(entry => entry.Name.Contains("Admin"))
                        .ToArray();

                    foreach (var entry in adminEntries)
                    {
                        permissions.RemoveEntry(entry);
                    }

                    permissions.AddEntry(new AccessControlEntry(virtualRoleName, AccessLevel.FullAccess));
                    security.Save(ContentReference.RootPage, permissions, SecuritySaveType.Replace);

                    permissions = security
                        .Get(ContentReference.WasteBasket)
                        .CreateWritableClone() as IContentSecurityDescriptor;

                    adminEntries = permissions
                        .Entries
                        .Where(entry => entry.Name.Contains("Admin"))
                        .ToArray();

                    foreach (var entry in adminEntries)
                    {
                        permissions.RemoveEntry(entry);
                    }

                    permissions.AddEntry(new AccessControlEntry(virtualRoleName, AccessLevel.FullAccess));
                    security.Save(ContentReference.WasteBasket, permissions, SecuritySaveType.Replace);

                    #endregion
                }
            }
        }

        public void Uninitialize(InitializationEngine context)
        {
        }
    }
}
