using GameStore.DAL.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Data;

namespace GameStore.DAL.Domain
{
    public class GsDbContext : IdentityDbContext<AppUser>
    {
        public GsDbContext(DbContextOptions<GsDbContext> options) : base(options) { }

        #region DB SETS
        //-- Identity
        public DbSet<AppUser> AppUsers { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            #region DB CREATION
            ///
            /// --Identity
            /// 
            builder.Entity<AppUser>().ToTable("Users");
            #endregion

            #region SEED DATA
            ///
            /// -- Identity Roles  
            /// 
            builder.Entity<IdentityRole>().HasData(new Predefined.Identity.PdRoles().RoleList);
            #endregion
        }

        #region CREATION DEFAULT ACCOUNT
        public static async Task CreationDefaultAccount(IServiceProvider serviceProvider)
        {
            UserManager<AppUser> userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();
            string role_admin = "Администратор";
            string role_user = "Пользователь";
            string defPassword = "Admin1234!";

            AppUser user_role_admin = new()
            {
                UserName = "admin@test.com",
                Email = "admin@test.com",
                EmailConfirmed = true,
                UserRoleName = role_admin,
                CustomUserId = 1,
            };

            AppUser user_role_user = new()
            {
                UserName = "user@test.com",
                Email = "user@test.com",
                EmailConfirmed = true,
                UserRoleName = role_user,
                CustomUserId = 2,
            };

            IdentityResult resultAdd_user_admin = await userManager.CreateAsync(user_role_admin, defPassword);
            if (resultAdd_user_admin.Succeeded) { await userManager.AddToRoleAsync(user_role_admin, role_admin); }

            IdentityResult resultAdd_user = await userManager.CreateAsync(user_role_user, defPassword);
            if (resultAdd_user_admin.Succeeded) { await userManager.AddToRoleAsync(user_role_user, role_user); }
        }
        #endregion
    }
}
