using System.Linq;

using Microsoft.EntityFrameworkCore;
using MyLittleGithub.Data.Common.Models;

namespace MyLittleGithub.Data;

internal static class EntityIndexesConfiguration
{
    public static void Configure(ModelBuilder modelBuilder)
    {
        // IDeletableEntity.IsDeleted index
        var deletableEntityTypes = modelBuilder.Model
            .GetEntityTypes()
            .Where(et => typeof(IDeletableEntity).IsAssignableFrom(et.ClrType));

        foreach (var deletableEntityType in deletableEntityTypes)
        {
            modelBuilder.Entity(deletableEntityType.ClrType).HasIndex(nameof(IDeletableEntity.IsDeleted));
        }
    }
}
