using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MyLittleGithub.Data.Models;

namespace MyLittleGithub.Data.Seeding;

public class LicensesSeeder : ISeeder
{
    public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
    {
        if (dbContext.Licenses.Any())
        {
            return;
        }

        var licensesList = new List<License>
        {
            new License
            {
                Name = "No License",
                Description = "No License has been applied",
            },
            new License
            {
                Name = "GNU General Public License v3.0",
                Description = "Everyone is permitted to copy and distribute verbatim copies of this license document, but changing it is not allowed.",
            },
            new License
            {
                Name ="MIT License",
                Description = "Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the \"Software\"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software. THE SOFTWARE IS PROVIDED \"AS IS\", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE."
            },
        };

        dbContext.Licenses.AddRange(licensesList);
        await dbContext.SaveChangesAsync();
    }
}
