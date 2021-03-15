using Microsoft.EntityFrameworkCore;
using SpecTechApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecTechApp.Data
{
    public class TechContext : DbContext
    {
        public TechContext()
        {
            Database.Migrate();
        }

        public DbSet<User> Users {get;set;}
        public DbSet<Role> Roles {get;set;}
        public DbSet<Tech> Techs {get;set;}
        public DbSet<TypeOfTech> TypeOfTech { get;set;}
        public DbSet<Quest> Quests {get;set;}
        public DbSet<Status> Statuses {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-0V33MK0\\MSSQLSERVER01; Database = SpecTechApp; Trusted_Connection=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TypeOfTech>()
                .HasData(
                new TypeOfTech { 
                    Id = new Guid("30FE6C87-4123-4AC4-9F95-F2788CD2B92B"), 
                    Name = "Кран", 
                    Feautures = new List<Feature> { 
                        new Feature { Name = "Длина стрелы", }, 
                        new Feature {Name = "Грузоподъемность", }, 
                        new Feature {Name = "Объем двигателя", }, 
                    } 
                },
                new TypeOfTech { 
                    Id = new Guid("A957CCE7-6B25-4050-9BF9-2EB27D7D71CE"),
                    Name = "Грузовик" 
                },
                new TypeOfTech { 
                    Id = new Guid("C67DFF8E-B2E7-4068-A7F0-5130619F7130"), 
                    Name = "Бульдозер" 
                },
                new TypeOfTech { 
                    Id = new Guid("516D3CA0-4BDB-488B-A1CB-FCB0174127D3"), 
                    Name = "Трактор" 
                },
                new TypeOfTech { 
                    Id = new Guid("62ABD389-1276-42BD-A6EF-1960CA184258"), 
                    Name = "Газель" 
                }
                );

            modelBuilder.Entity<Status>()
                .HasData(
                new Status { Id = new Guid("406DA934-8D82-4874-BB77-EBD698CE6E0B"), Name = "Создано" },
                new Status { Id = new Guid("7F6DA3CB-54A4-4385-A1D4-BACDC89FCB6D"), Name = "Поиск" },
                new Status { Id = new Guid("8CF2C3F4-FB6F-4DD2-A942-476B92665CEE"), Name = "Предложено" },
                new Status { Id = new Guid("5E719636-110D-4E09-8BC8-F21FFAD6FB4E"), Name = "Отказано" },
                new Status { Id = new Guid("FFF4691E-43B4-42DE-B8A1-656705967D7C"), Name = "Отмена" },
                new Status { Id = new Guid("7630CAD8-6EED-4E06-8A73-3D0AA2FBCE99"), Name = "В работе" },
                new Status { Id = new Guid("56FC39C1-41C1-484B-8E65-D32F9A403B42"), Name = "Выполнено" }
                );

            modelBuilder.Entity<Role>()
                .HasData(
                        new Role { Id = new Guid("5D12665E-7B9F-4625-B450-E20825C5B6BD"), Name = "Заказчик" },
                        new Role { Id = new Guid("E5DF3611-1E64-420D-87D6-D408B1434481"), Name = "Исполнитель" },
                        new Role { Id = new Guid("F1E4E859-AA75-4B31-9F1C-132621172160"), Name = "Система" },
                        new Role { Id = new Guid("A67FEE06-72A8-469F-A615-ABA1BAF361B3"), Name = "Администратор" }
                );

            modelBuilder.Entity<Sign>()
                .HasData(
                    new Sign { Id= new Guid("690BB99A-353C-4A08-9CD9-BD2358997E8E"),Name="л.с." },
                    new Sign { Id= new Guid("05265039-F6A1-4E9D-B11B-DF30CD608922"),Name="т." },
                    new Sign { Id= new Guid("541ADBA9-C342-419A-84BA-0570B7E89721"),Name="м." },
                    new Sign { Id= new Guid("541ADBA9-C342-419A-84BA-0570B7E89721"),Name="л." }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
