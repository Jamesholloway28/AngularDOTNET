using System;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class DataContext(DbContextOptions options) : DbContext(options)
{
//Users will be the name of the table in our database
    public required DbSet<AppUser> Users { get; set; }
}
