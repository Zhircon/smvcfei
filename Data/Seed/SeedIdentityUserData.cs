using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using smvcfei.Models;
namespace smvcfei.Data.Seed 
{
    public static class SeedIdentityData{
        public static void SeedUserIdentityData(this ModelBuilder modelBuilder)
        {
            string AdministradorGeneralRoleId = Guid.NewGuid().ToString();
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = AdministradorGeneralRoleId,
                Name = "Adminsitrador",
                NormalizedName ="Administrador".ToUpper()
            }); 
            string UsuarioGeneralRoleId = Guid.NewGuid().ToString();
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = UsuarioGeneralRoleId,
                Name = "Usuario general ",
                NormalizedName ="Usuario General".ToUpper()
            }); 
            string Usuario = Guid.NewGuid().ToString();
            modelBuilder.Entity<CustomIdentityUser>().HasData(new CustomIdentityUser
            {
                Id = UsuarioId,
                UserName = "agnizahir@gmail.com ",
                Email = "agnizahir@gmail.com",
                NormalizedName ="zhircon".ToUpper(),
                Nombrecompleto = "Agni Zahir Yañez Vences",
                NormalizedUserName = "zhircon".ToUpper(),
                PasswordHash = new PasswordHasher<CustomIdentityUser>().HashPassword(null,"patito")
            }); 
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = AdministradorGeneralRoleId,
                    UserId = UsuarioId
                }
            );
        }
    }
}