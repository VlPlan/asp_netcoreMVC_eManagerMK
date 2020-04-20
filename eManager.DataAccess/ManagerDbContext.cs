using System;
using eManager.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace eManager.DataAccess
{
    public class ManagerDbContext : IdentityDbContext<User>
    {

        public ManagerDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Procurement> Procurements { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<ActivityEmployee> EmployeeActivities { get; set; }
        public DbSet<ProcurementProduct> ProcurementProducts { get; set; }
        public DbSet<ClientServiceDTO> InvoiceServices { get; set; }
        public DbSet<ClientInvoice> ClientInvoices { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {


            base.OnModelCreating(builder);




            builder.Entity<ProcurementProduct>().HasIndex(p => new { p.ProductId, p.ProcurementId });
            builder.Entity<ClientServiceDTO>().HasIndex(p => new { p.InvoiceId, p.ServiceId });
            builder.Entity<ActivityEmployee>().HasIndex(p => new { p.ActivityId, p.EmployeeId });
            builder.Entity<ClientInvoice>().HasIndex(p => new { p.Invoice_Id, p.ClientId });
            builder.Entity<User>().HasMany(u => u.Procurements).WithOne(p => p.User).HasForeignKey(p => p.UserId);
            builder.Entity<Invoice>().HasMany(x => x.InvoiceServices).WithOne(x => x.Invoice).HasForeignKey(x => x.InvoiceId);
            builder.Entity<Service>().HasMany(x => x.InvoiceServices).WithOne(x => x.Service).HasForeignKey(x => x.ServiceId);
            builder.Entity<Client>().HasMany(x => x.ClientInvoices).WithOne(x => x.Client).HasForeignKey(x => x.ClientId);
            builder.Entity<Invoice>().HasMany(x => x.ClientInvoices).WithOne(x => x.Invoice).HasForeignKey(x => x.Invoice_Id);
            builder.Entity<User>().HasMany(x => x.Invoices).WithOne(x => x.User).HasForeignKey(x => x.UserId);
            builder.Entity<Activity>().HasMany(a => a.EmployeeActivities).WithOne(e => e.Activity).HasForeignKey(e => e.ActivityId);
            builder.Entity<Employee>().HasMany(a => a.EmployeeActivities).WithOne(e => e.Employee).HasForeignKey(e => e.EmployeeId);
            builder.Entity<Product>().HasMany(p => p.ProcurementProducts).WithOne(p => p.Product).HasForeignKey(p => p.ProductId);
            builder.Entity<Procurement>().HasMany(pp => pp.ProcurementProducts).WithOne(p => p.Procurement).HasForeignKey(p => p.ProcurementId);





            // SEED THE SUPPLIER ACCOUNT AND ROLES
            // NEW SUPPLIER ID ( ADMIN USER )
            string supplierId = Guid.NewGuid().ToString();
            // ADMIN ROLE ID
            string roleId = Guid.NewGuid().ToString();
            // USER ROLE ID
            string procurementId = Guid.NewGuid().ToString();
            string managerId = Guid.NewGuid().ToString();
            string technicalId = Guid.NewGuid().ToString();
            string hrId = Guid.NewGuid().ToString();
            string engineerId = Guid.NewGuid().ToString();
            string financeId = Guid.NewGuid().ToString();
            string operationsOneId = Guid.NewGuid().ToString();
            string operationsTwoId = Guid.NewGuid().ToString();
            string operationsThreeId = Guid.NewGuid().ToString();

            string VPUserId = Guid.NewGuid().ToString();
            string SNUserId = Guid.NewGuid().ToString();
            string TPUserId = Guid.NewGuid().ToString();
            string AMGUserId = Guid.NewGuid().ToString();
            string ENUserId = Guid.NewGuid().ToString();
            string SPUserId = Guid.NewGuid().ToString();
            string GKUserId = Guid.NewGuid().ToString();
            string KKUserId = Guid.NewGuid().ToString();
            string DRUserId = Guid.NewGuid().ToString();

            // SEEDING ROLES ONLY IN DB
            builder.Entity<IdentityRole>().HasData(
            new IdentityRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "ADMIN"
            },
            new IdentityRole
            {
                Id = procurementId,
                Name = "userVP",
                NormalizedName = "USERVP"
            },
            new IdentityRole
            {
                Id = managerId,
                Name = "userSN",
                NormalizedName = "USERSN"
            },
            new IdentityRole
            {
                Id = technicalId,
                Name = "userTP",
                NormalizedName = "USERTP"
            },
            new IdentityRole
            {
                Id = hrId,
                Name = "userAMG",
                NormalizedName = "USERAMG"
            },
            new IdentityRole
            {
                Id = engineerId,
                Name = "userEN",
                NormalizedName = "USEREN"
            },
            new IdentityRole
            {
                Id = financeId,
                Name = "userSP",
                NormalizedName = "USERSP"
            },
            new IdentityRole
            {
                Id = operationsOneId,
                Name = "userGK",
                NormalizedName = "USERGK"
            },
            new IdentityRole
            {
                Id = operationsTwoId,
                Name = "userKK",
                NormalizedName = "USERKK"
            },
            new IdentityRole
            {
                Id = operationsThreeId,
                Name = "userDR",
                NormalizedName = "USERDR"
            }
            );

            var hasher = new PasswordHasher<User>();
            var hasher1 = new PasswordHasher<User>();
            var hasher2 = new PasswordHasher<User>();
            var hasher3 = new PasswordHasher<User>();
            var hasher4 = new PasswordHasher<User>();
            var hasher5 = new PasswordHasher<User>();
            var hasher6 = new PasswordHasher<User>();
            var hasher7 = new PasswordHasher<User>();
            var hasher8 = new PasswordHasher<User>();
            var hasher9 = new PasswordHasher<User>();
            // SEEDING ADMIN USER WITHOUT ROLE
            builder.Entity<User>().HasData(
                new User
                {
                    Id = supplierId,
                    UserName = "ogno2020",
                    NormalizedUserName = "OGNO2020",
                    Email = "supplier@mail.com",
                    NormalizedEmail = "supplier@mail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "@Ognootporno2020"),
                    SecurityStamp = string.Empty
                },
            new User
            {
                Id = VPUserId,
                UserName = "VladPlan",
                FullName = "Владимир Планојевиќ",
                NormalizedUserName = "VLADPLAN",
                Email = "planojevic@ognootporno.com.mk",
                NormalizedEmail = "PLANOJEVIC@OGNOOTPORNO.COM.MK",
                EmailConfirmed = true,
                PasswordHash = hasher1.HashPassword(null, "VladimirPlanojevic2020"),
                SecurityStamp = string.Empty
            },
            new User
            {
                Id = SNUserId,
                UserName = "SashoNikolchov",
                FullName = "Сашо Николчов",
                NormalizedUserName = "SASHONIKOLCHOV",
                Email = "nikolchov@ognootporno.com.mk",
                NormalizedEmail = "nikolchov@ognootporno.com.mk",
                EmailConfirmed = true,
                PasswordHash = hasher2.HashPassword(null, "SashoNikolchov2020"),
                SecurityStamp = string.Empty
            },
                        new User
                        {
                            Id = TPUserId,
                            UserName = "ToniPeshevski",
                            FullName = "Тони Пешевски",
                            NormalizedUserName = "TONIPESHEVSKI",
                            Email = "peshovski@ognootporno.com.mk",
                            NormalizedEmail = "peshovski@ognootporno.com.mk",
                            EmailConfirmed = true,
                            PasswordHash = hasher3.HashPassword(null, "ToniPeshevski2020"),
                            SecurityStamp = string.Empty
                        },
                                                new User
                                                {
                                                    Id = AMGUserId,
                                                    UserName = "AnaMGavrilov",
                                                    FullName = "Ана Мирковска Гаврилов",
                                                    NormalizedUserName = "ANAMIRKOVSKAGAVRILOV",
                                                    Email = "mirkovska@ognootporno.com.mk",
                                                    NormalizedEmail = "mirkovska@ognootporno.com.mk",
                                                    EmailConfirmed = true,
                                                    PasswordHash = hasher4.HashPassword(null, "AnaMirkovskaGavrilov2020"),
                                                    SecurityStamp = string.Empty
                                                },
                                                                       new User
                                                                       {
                                                                           Id = ENUserId,
                                                                           UserName = "EvtimNikolchov",
                                                                           FullName = "Евтим Николчов",
                                                                           NormalizedUserName = "EVTIMNIKOLCHOV",
                                                                           Email = "nikolchov@ognootporno.com.mk",
                                                                           NormalizedEmail = "nikolchov@ognootporno.com.mk",
                                                                           EmailConfirmed = true,
                                                                           PasswordHash = hasher5.HashPassword(null, "EvtimNikolchov2020"),
                                                                           SecurityStamp = string.Empty
                                                                       },
                                                                                               new User
                                                                                               {
                                                                                                   Id = SPUserId,
                                                                                                   UserName = "SashoPeshovski",
                                                                                                   FullName = "Сашо Пешовски",
                                                                                                   NormalizedUserName = "SASHOPESHOVSKI",
                                                                                                   Email = "peshovski@ognootporno.com.mk",
                                                                                                   NormalizedEmail = "peshovski@ognootporno.com.mk",
                                                                                                   EmailConfirmed = true,
                                                                                                   PasswordHash = hasher6.HashPassword(null, "SashoPeshovski2020"),
                                                                                                   SecurityStamp = string.Empty
                                                                                               },
                                                                                                                                                                                              new User
                                                                                                                                                                                              {
                                                                                                                                                                                                  Id = GKUserId,
                                                                                                                                                                                                  UserName = "GoranKotev",
                                                                                                                                                                                                  FullName = "Горан Котев",
                                                                                                                                                                                                  NormalizedUserName = "GORANKOTEV",
                                                                                                                                                                                                  Email = "kotev@ognootporno.com.mk",
                                                                                                                                                                                                  NormalizedEmail = "kotev@ognootporno.com.mk",
                                                                                                                                                                                                  EmailConfirmed = true,
                                                                                                                                                                                                  PasswordHash = hasher7.HashPassword(null, "GoranKotev2020"),
                                                                                                                                                                                                  SecurityStamp = string.Empty
                                                                                                                                                                                              },
                                                                                                                                                                                                                                                                                                                                                                                            new User
                                                                                                                                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                                                                                                                                Id = KKUserId,
                                                                                                                                                                                                                                                                                                                                                                                                UserName = "KostaKotev",
                                                                                                                                                                                                                                                                                                                                                                                                FullName = "Коста Котев",
                                                                                                                                                                                                                                                                                                                                                                                                NormalizedUserName = "KOSTAKOTEV",
                                                                                                                                                                                                                                                                                                                                                                                                Email = "kotev@ognootporno.com.mk",
                                                                                                                                                                                                                                                                                                                                                                                                NormalizedEmail = "kotev@ognootporno.com.mk",
                                                                                                                                                                                                                                                                                                                                                                                                EmailConfirmed = true,
                                                                                                                                                                                                                                                                                                                                                                                                PasswordHash = hasher8.HashPassword(null, "KostaKotev2020"),
                                                                                                                                                                                                                                                                                                                                                                                                SecurityStamp = string.Empty
                                                                                                                                                                                                                                                                                                                                                                                            },
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 new User
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     Id = DRUserId,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     UserName = "DrageRistevski",
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     FullName = "Драге Ристевски",
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     NormalizedUserName = "DRAGERISTEVSKI",
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     Email = "kotev@ognootporno.com.mk",
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     NormalizedEmail = "kotev@ognootporno.com.mk",
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     EmailConfirmed = true,
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     PasswordHash = hasher9.HashPassword(null, "DrageRistevski2020"),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     SecurityStamp = string.Empty
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 }
            );
            // ADD CONNECTION BETWEEN SUPPLIER ROLE AND SUPPLIER USER TO HAVE ADMIN RIGHTS
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = roleId,
                    UserId = supplierId
                },
            new IdentityUserRole<string>
            {
                RoleId = procurementId,
                UserId = VPUserId
            },
                        new IdentityUserRole<string>
                        {
                            RoleId = managerId,
                            UserId = SNUserId
                        },
                                    new IdentityUserRole<string>
                                    {
                                        RoleId = technicalId,
                                        UserId = TPUserId
                                    },
                                                new IdentityUserRole<string>
                                                {
                                                    RoleId = hrId,
                                                    UserId = AMGUserId
                                                },
                                                            new IdentityUserRole<string>
                                                            {
                                                                RoleId = engineerId,
                                                                UserId = ENUserId
                                                            },
                                                                        new IdentityUserRole<string>
                                                                        {
                                                                            RoleId = operationsOneId,
                                                                            UserId = GKUserId
                                                                        },
                                                                                    new IdentityUserRole<string>
                                                                                    {
                                                                                        RoleId = operationsTwoId,
                                                                                        UserId = KKUserId
                                                                                    },
                                                                                                new IdentityUserRole<string>
                                                                                                {
                                                                                                    RoleId = operationsThreeId,
                                                                                                    UserId = DRUserId
                                                                                                }

             );


        }
    }
}
