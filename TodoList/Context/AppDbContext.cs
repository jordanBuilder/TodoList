using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using TodoList.Classes;
using TodoList.Models;
using Microsoft.AspNetCore.Identity;
namespace TodoList.Context
{
    public class AppDbContext: IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        // To create users roles we need to implement the onModelCreating method
        //
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //The user role is described by the identity role class
            //the parameter of new IdentityRole is the name of the role(here : admin)
            //we also have to set a normalized name, which will be when we'll set a role to a user
            var admin = new IdentityRole("admin");
            admin.NormalizedName="admin";

            var client = new IdentityRole("client");
            client.NormalizedName = "client";

            var seller = new IdentityRole("seller");
            seller.NormalizedName = "seller";

            //To add those roles to the roles table we have to call the statement builder

            // we need to fill the roles table which is described by the IdentityRole
            
            // HasData accepts any numbers of parameters which are identity roles

            builder.Entity<IdentityRole>().HasData(admin, client, seller);

        }
        public DbSet<Todo> Todos { get; set; }
    }
}
