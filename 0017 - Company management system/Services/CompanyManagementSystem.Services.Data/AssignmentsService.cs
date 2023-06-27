using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using CompanyManagementSystem.Data.Common.Repositories;
using CompanyManagementSystem.Data.Models;
using CompanyManagementSystem.Services.Mapping;
using CompanyManagementSystem.Web.ViewModels.Users;
using Microsoft.EntityFrameworkCore;

namespace CompanyManagementSystem.Services.Data
{
    public class AssignmentsService : IAssignmentsService
    {
        private readonly IDeletableEntityRepository<Assignment> assignmentsRepository;
        private readonly IUsersService usersService;

        public AssignmentsService(
            IDeletableEntityRepository<Assignment> assignmentsRepository,
            IUsersService usersService)
        {
            this.assignmentsRepository = assignmentsRepository;
            this.usersService = usersService;
        }

        public async Task GiveAsync(GiveAssignmentInputModel input, string employeeId)
        {
            var assignment = new Assignment()
            {
                Content = input.Content,
            };

            await this.assignmentsRepository.AddAsync(assignment);
            await this.assignmentsRepository.SaveChangesAsync();

            assignment.EmployeeAssignments.Add(new EmployeeAssignment()
            {
                AssignmentId = assignment.Id,
                EmployeeId = employeeId,
            });

            await this.assignmentsRepository.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> All<T>(string id)
            => await this.assignmentsRepository
                .All()
                .Where(a => a.EmployeeAssignments.Any(ea => ea.EmployeeId == id))
                .To<T>()
                .ToListAsync();
    }
}
