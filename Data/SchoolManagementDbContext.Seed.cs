using System;
using Microsoft.EntityFrameworkCore;

namespace SchoolManagement.Mvc.Data;

public partial class SchoolManagementDbContext
{
    // Implement the partial method declared in the generated DbContext to add seed data
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
    {
        SeedData.Apply(modelBuilder);
    }
}
