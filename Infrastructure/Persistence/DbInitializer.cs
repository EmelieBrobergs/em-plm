using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class DbInitializer
    {
        private readonly ModelBuilder modelBuilder;

        public DbInitializer(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }

        public void Seed()
        {
            modelBuilder.Entity<Company>().HasData(
                new Company { Name = "Bruw Brey", Id = 1 },
                new Company { Name = "Allissons CO", Id = 2 },
                new Company { Name = "Bellaroom", Id = 3 },
                new Company { Name = "Dreeble", Id = 4 },
                new Company { Name = "Emelie style", Id = 5 },
                new Company { Name = "Jesus Bak & Slakt AB", Id = 6 }
            );


            //AppUser x 3

            //create user
            var appUser1 = new AppUser
            {
                Id = 1,
                CompanyId = 1,
                Email = "em@mail.com",
                NormalizedEmail = "EM@MAIL.COM",
                EmailConfirmed = true,
                FirstName = "Emssi",
                LastName = "House",
                UserName = "emhouse",
                NormalizedUserName = "EMHOUSE"
            };
            var appUser2 = new AppUser
            {
                Id = 2,
                CompanyId = 3,
                Email = "bella@mail.com",
                NormalizedEmail = "BELLA@MAIL.COM",
                //EmailConfirmed = true,
                FirstName = "Bella",
                LastName = "House",
                UserName = "bella@mail.com",
                NormalizedUserName = "BELLA@MAIL.COM"
            };
            var appUser3 = new AppUser
            {
                Id = 3,
                CompanyId = 1,
                Email = "b@mail.com",
                NormalizedEmail = "B@MAIL.COM",
                EmailConfirmed = false,
                FirstName = "Basic",
                LastName = "House",
                UserName = "b@mail.com",
                NormalizedUserName = "B@MAIL.COM"
            };
            var appUser4 = new AppUser
            {
                Id = 4,
                CompanyId = 1,
                Email = "emma@mail.com",
                NormalizedEmail = "EMMA@MAIL.COM",
                EmailConfirmed = true,
                FirstName = "Emma",
                LastName = "House",
                UserName = "emmah",
                NormalizedUserName = "EMMAH"
            };

            //set user password
            PasswordHasher<AppUser> ph1 = new PasswordHasher<AppUser>();
            appUser1.PasswordHash = ph1.HashPassword(appUser1, "emmailCOM1");
            
            PasswordHasher<AppUser> ph2 = new PasswordHasher<AppUser>();
            appUser2.PasswordHash = ph2.HashPassword(appUser2, "emmailCOM1");
            
            PasswordHasher<AppUser> ph3 = new PasswordHasher<AppUser>();
            appUser3.PasswordHash = ph3.HashPassword(appUser3, "emmailCOM1");

            PasswordHasher<AppUser> ph4 = new PasswordHasher<AppUser>();
            appUser3.PasswordHash = ph4.HashPassword(appUser4, "emmailCOM1");


            //seed user
            modelBuilder.Entity<AppUser>().HasData(appUser1);
            modelBuilder.Entity<AppUser>().HasData(appUser2);
            modelBuilder.Entity<AppUser>().HasData(appUser3);
            modelBuilder.Entity<AppUser>().HasData(appUser4);

            // Styles ( some assigned to User )
            modelBuilder.Entity<Style>().HasData(
            new Style { Id = 1, CompanyId = 1, AssignedToUserId = 4, Description = "Classic trouser with low wist and staight leg.", Name = "Tshirt Smile", ProductGroup = "Women top", ProductType = "Tricot", OrderNumber = "lkj76aa4-12", StyleNumber = "a0", Tags = new List<string> { "t-shirt", "chestpocket", "off-shoulder" } },
            new Style { Id = 2, CompanyId = 1, AssignedToUserId = 4, Description = "Lose fitted long sleeve shirt with tilored fitt at waist. Print at center front chest.", Name = "Lounge shirt", ProductGroup = "High fashion", ProductType = "Tricot", OrderNumber = "aaqs21", StyleNumber = "a1", Tags = new List<string> { "chestprint", "figure", "long-sleeve" } },
            new Style { Id = 3, CompanyId = 1, AssignedToUserId = 4, Description = "Seamless yoga pants in elastic organic cotton mixed with elastane. High waist and pocket on left thigh.", Name = "Yoga tights", ProductGroup = "Women Sport", ProductType = "Training", OrderNumber = "123abc", StyleNumber = "a2", Tags = new List<string> { "compress", "lycra" } },
            new Style { Id = 4, CompanyId = 1, AssignedToUserId = 1, Description = "Lorem ipsum hapsum di ab sa nog live av list mos dent italid flori data min gonsedl moli.", Name = "Vivvi", ProductGroup = "Underwear", ProductType = "Bikini top", OrderNumber = "AW22-981", StyleNumber = "a3", Tags = new List<string> { "mockfabric", "brazilian" } },
            
            new Style { Id = 5, CompanyId = 1, AssignedToUserId = 1, Description = "Lorem ipsum hapsum di ab sa nog live av list mos dent italid flori data min gonsedl moli.", Name = "Annz", ProductGroup = "Underwear", ProductType = "Bikini top", OrderNumber = "AW22-982", StyleNumber = "a4", Tags = new List<string> { "mockfabric", "triangle", "fashion" } },
            new Style { Id = 6, CompanyId = 1, AssignedToUserId = 1, Description = "Lorem ipsum hapsum di ab sa nog live av list mos dent italid flori data min gonsedl moli.", Name = "Vivvi", ProductGroup = "Underwear", ProductType = "Bikini bottom", OrderNumber = "AW22-983", StyleNumber = "a5", Tags = new List<string> { "highwaist", "wideside", "compression" } },
            new Style { Id = 7, CompanyId = 1, AssignedToUserId = 1, Description = "Lorem ipsum hapsum di ab sa nog live av list mos dent italid flori data min gonsedl moli.", Name = "Annz", ProductGroup = "Underwear", ProductType = "Bikini bottom", OrderNumber = "AW22-984", StyleNumber = "a6", Tags = new List<string> { "regularFitt", "noseams" } },
            new Style { Id = 8, CompanyId = 1, AssignedToUserId = 4, Description = "Lorem ipsum hapsum di ab sa nog live av list mos dent italid flori data min gonsedl moli.", Name = "Elsa swim", ProductGroup = "Underwear", ProductType = "Swimsuit child", OrderNumber = "AW22-985", StyleNumber = "a7", Tags = new List<string> { "skirt", "crossback" } },
            new Style { Id = 9, CompanyId = 1, AssignedToUserId = 4, Description = "Lorem ipsum hapsum di ab sa nog live av list mos dent italid flori data min gonsedl moli.", Name = "Elva yos", ProductGroup = "Sport", ProductType = "Yoga pants", OrderNumber = "AW22-986", StyleNumber = "a8", Tags = new List<string> { "looseleg", "wideleg", "highwaist", "foldedwaistband" } },
            new Style { Id = 10, CompanyId = 1, AssignedToUserId = 4, Description = "Lorem ipsum hapsum di ab sa nog live av list mos dent italid flori data min gonsedl moli.", Name = "Elva pas", ProductGroup = "Sport", ProductType = "Yoga pants", OrderNumber = "AW22-987", StyleNumber = "a9", Tags = new List<string> { "straightleg", "highwaist", "7/8-length" } },
            new Style { Id = 11, CompanyId = 1, AssignedToUserId = 4, Description = "Lorem ipsum hapsum di ab sa nog live av list mos dent italid flori data min gonsedl moli.", Name = "Pas esma", ProductGroup = "Sport", ProductType = "Yoga top", OrderNumber = "AW22-988", StyleNumber = "b1", Tags = new List<string> { "loosefitt", "tshirt", "openback" } },
            new Style { Id = 12, CompanyId = 1, AssignedToUserId = 4, Description = "Lorem ipsum hapsum di ab sa nog live av list mos dent italid flori data min gonsedl moli.", Name = "Seamless Ribb Tights", ProductGroup = "Sport", ProductType = "Tights", OrderNumber = "AW22-989", StyleNumber = "b2", Tags = new List<string> { "compression", "legpocket", "7/8-length" } },
            new Style { Id = 13, CompanyId = 1, AssignedToUserId = 4, Description = "Lorem ipsum hapsum di ab sa nog live av list mos dent italid flori data min gonsedl moli.", Name = "Fancyann Tights", ProductGroup = "Sport", ProductType = "Tights", OrderNumber = "AW22-921", StyleNumber = "b3", Tags = new List<string> { "thinfabric", "waistpocket", "full-length" } },
            new Style { Id = 14, CompanyId = 1, AssignedToUserId = 3, Description = "Lorem ipsum hapsum di ab sa nog live av list mos dent italid flori data min gonsedl moli.", Name = "Seamless Anna Top", ProductGroup = "Sport", ProductType = "Bra", OrderNumber = "AW22-922", StyleNumber = "b4", Tags = new List<string> { "crossback", "keypocket", "padding" } },
            new Style { Id = 15, CompanyId = 1, AssignedToUserId = 4, Description = "Lorem ipsum hapsum di ab sa nog live av list mos dent italid flori data min gonsedl moli.", Name = "Lova Top", ProductGroup = "Sport", ProductType = "Bra", OrderNumber = "AW22-923", StyleNumber = "b5", Tags = new List<string> { "compression", "nopadding", "v-ring" } },
            new Style { Id = 16, CompanyId = 1, AssignedToUserId = 3, Description = "Lose fitted bluse in shire vowen satin with voulumos sleev with elastic mudd.", Name = "Lovalia", ProductGroup = "Tricot", ProductType = "Long dress", OrderNumber = "AW22-924", StyleNumber = "b6", Tags = new List<string> { "volumeskirt", "strassfeeling", "summerdress" } },
            new Style { Id = 17, CompanyId = 1, AssignedToUserId = 4, Description = "Lorem ipsum hapsum di ab sa nog live av list mos dent italid flori data min gonsedl moli.", Name = "Jhonna printed dress", ProductGroup = "Tricot", ProductType = "Short dress", OrderNumber = "AW22-925", StyleNumber = "b7", Tags = new List<string> { "classic", "tailoredfitt", "elastic" } },
            new Style { Id = 18, CompanyId = 1, AssignedToUserId = 4, Description = "Lorem ipsum hapsum di ab sa nog live av list mos dent italid flori data min gonsedl moli.", Name = "Alva ", ProductGroup = "Tricot", ProductType = "Pants", OrderNumber = "AW22-926", StyleNumber = "b8", Tags = new List<string> { "classic", "tailoredfitt", "elastic" } },
            new Style { Id = 19, CompanyId = 1, AssignedToUserId = 3, Description = "Lorem ipsum hapsum di ab sa nog live av list mos dent italid flori data min gonsedl moli.", Name = "Alva ankle length", ProductGroup = "Tricot", ProductType = "Pants", OrderNumber = "AW22-927", StyleNumber = "b9", Tags = new List<string> { "7/8-length", "elasticwaist", "nice" } },
            new Style { Id = 20, CompanyId = 1, AssignedToUserId = 4, Description = "Lorem ipsum hapsum di ab sa nog live av list mos dent italid flori data min gonsedl moli.", Name = "Flica Basic T-shirt", ProductGroup = "Tricot", ProductType = "T-shirt", OrderNumber = "AW22-928", StyleNumber = "c1", Tags = new List<string> { "highfashion", "spring32", "londonCollection", "colab-joss" } },
            new Style { Id = 21, CompanyId = 1, Description = "Lorem ipsum hapsum di ab sa nog live av list mos dent italid flori data min gonsedl moli.", Name = "Flica Basic Blouse", ProductGroup = "Light vowen", ProductType = "Blouse", OrderNumber = "AW22-929", StyleNumber = "c2", Tags = new List<string> { "colab-joss", "premium", "classic" } },
            new Style { Id = 22, CompanyId = 1, Description = "Lorem ipsum hapsum di ab sa nog live av list mos dent italid flori data min gonsedl moli.", Name = "Nna Shirt", ProductGroup = "Light vowen", ProductType = "Shirt", OrderNumber = "AW22-871", StyleNumber = "c3", Tags = new List<string> { "colab-elsa", "premium", "classic" } },

            new Style { Id = 23, CompanyId = 3, AssignedToUserId = 2, Description = "Denna tillhör företag 3 och ska endast synas på dennes användares inlogg! :).", Name = "Yoga", ProductGroup = "Light vowen", ProductType = "Blouse", OrderNumber = "AW22-872", StyleNumber = "c4", Tags = new List<string> { "colab-elsa", "premium", "classic" } },
            new Style { Id = 24, CompanyId = 3, Description = "Lorem lipsum comapny 3 here", Name = "Yoga no.3", ProductGroup = "Yoga", ProductType = "Pants women", OrderNumber = "AW22-873", StyleNumber = "c5", Tags = new List<string> { "colab-elsa", "premium", "classic" } }

            );

            //**********
            //Seed data below are connected to style Id: 1, 2, 3, 4
            //**********

            // Measurements
            modelBuilder.Entity<Measurement>().HasData(
                // Style 1
                new Measurement { Id = 1, Name = "1st", UnitOfMeasure = Domain.Common.Enums.UnitOfMeasureEnum.cm, StyleId = 1},
                new Measurement { Id = 2, Name = "2nd", UnitOfMeasure = Domain.Common.Enums.UnitOfMeasureEnum.cm, StyleId = 1 },
                new Measurement { Id = 3, Name = "3d", UnitOfMeasure = Domain.Common.Enums.UnitOfMeasureEnum.cm, StyleId = 1 },

                // style 2,3
                new Measurement { Id = 4, Name = "1st", UnitOfMeasure = Domain.Common.Enums.UnitOfMeasureEnum.cm, StyleId = 2, ParentMeasurementId = 3 },
                new Measurement { Id = 5, Name = "1st", UnitOfMeasure = Domain.Common.Enums.UnitOfMeasureEnum.cm, StyleId = 3 },
                
                // style 4
                new Measurement { Id = 6, Name = "1st", UnitOfMeasure = Domain.Common.Enums.UnitOfMeasureEnum.cm, StyleId = 4 },
                new Measurement { Id = 7, Name = "2nd", UnitOfMeasure = Domain.Common.Enums.UnitOfMeasureEnum.cm, StyleId = 4}
            );

            // SizeRange
            modelBuilder.Entity<SizeRange>().HasData(
                // style 1
                new SizeRange { Id = 1, MeasurementId = 1, BaseSizeName = "M" },
                new SizeRange { Id = 2, MeasurementId = 2, BaseSizeName = "M" },
                new SizeRange { Id = 3, MeasurementId = 3, BaseSizeName = "M" },

                // style 2,3
                new SizeRange { Id = 4, MeasurementId = 4, BaseSizeName = "M" },
                new SizeRange { Id = 5, MeasurementId = 5, BaseSizeName = "36" },

                //style 4
                new SizeRange { Id = 6, MeasurementId = 6, BaseSizeName ="38" },
                new SizeRange { Id = 7, MeasurementId = 7, BaseSizeName = "38" }
            );

            // Sizes
            modelBuilder.Entity<Size>().HasData(
                // style 1 = 3 Measurement
                new Size { Id = 1, SizeRangeId = 1, Name = "XS", OrderdIndex = 1},
                new Size { Id = 2, SizeRangeId = 1, Name = "S", OrderdIndex = 2 },
                new Size { Id = 3, SizeRangeId = 1, Name = "M", OrderdIndex = 3 },
                new Size { Id = 4, SizeRangeId = 1, Name = "L", OrderdIndex = 4 },
                new Size { Id = 5, SizeRangeId = 1, Name = "XL", OrderdIndex = 5 },

                new Size { Id = 6, SizeRangeId = 2, Name = "XS", OrderdIndex = 1 },
                new Size { Id = 7, SizeRangeId = 2, Name = "S", OrderdIndex = 2 },
                new Size { Id = 8, SizeRangeId = 2, Name = "M", OrderdIndex = 3 },
                new Size { Id = 9, SizeRangeId = 2, Name = "L", OrderdIndex = 4 },
                new Size { Id = 10, SizeRangeId = 2, Name = "XL", OrderdIndex = 5 },

                new Size { Id = 11, SizeRangeId = 3, Name = "XS", OrderdIndex = 1 },
                new Size { Id = 12, SizeRangeId = 3, Name = "S", OrderdIndex = 2 },
                new Size { Id = 13, SizeRangeId = 3, Name = "M", OrderdIndex = 3 },
                new Size { Id = 14, SizeRangeId = 3, Name = "L", OrderdIndex = 4 },
                new Size { Id = 15, SizeRangeId = 3, Name = "XL", OrderdIndex = 5 },

                // style 2 = 1 Measurement
                new Size { Id = 16, SizeRangeId = 3, Name = "XS", OrderdIndex = 1 },
                new Size { Id = 17, SizeRangeId = 3, Name = "S", OrderdIndex = 2 },
                new Size { Id = 18, SizeRangeId = 3, Name = "M", OrderdIndex = 3 },
                new Size { Id = 19, SizeRangeId = 3, Name = "L", OrderdIndex = 4 },
                new Size { Id = 20, SizeRangeId = 3, Name = "XL", OrderdIndex = 5 },
                
                // style 3 = 1 Measurement
                new Size { Id = 21, SizeRangeId = 3, Name = "34", OrderdIndex = 1 },
                new Size { Id = 22, SizeRangeId = 3, Name = "36", OrderdIndex = 2 },
                new Size { Id = 23, SizeRangeId = 3, Name = "38", OrderdIndex = 3 },
                new Size { Id = 24, SizeRangeId = 3, Name = "40", OrderdIndex = 4 },
                new Size { Id = 25, SizeRangeId = 3, Name = "42", OrderdIndex = 5 },
                new Size { Id = 26, SizeRangeId = 3, Name = "44", OrderdIndex = 6 },

                // style 4 = 2 Measurement
                new Size { Id = 27, SizeRangeId = 3, Name = "34", OrderdIndex = 1 },
                new Size { Id = 28, SizeRangeId = 3, Name = "36", OrderdIndex = 2 },
                new Size { Id = 29, SizeRangeId = 3, Name = "38", OrderdIndex = 3 },
                new Size { Id = 30, SizeRangeId = 3, Name = "40", OrderdIndex = 4 },
                new Size { Id = 31, SizeRangeId = 3, Name = "42", OrderdIndex = 5 },
                new Size { Id = 32, SizeRangeId = 3, Name = "44", OrderdIndex = 6 },

                new Size { Id = 33, SizeRangeId = 3, Name = "34", OrderdIndex = 1 },
                new Size { Id = 34, SizeRangeId = 3, Name = "36", OrderdIndex = 2 },
                new Size { Id = 35, SizeRangeId = 3, Name = "38", OrderdIndex = 3 },
                new Size { Id = 36, SizeRangeId = 3, Name = "40", OrderdIndex = 4 },
                new Size { Id = 37, SizeRangeId = 3, Name = "42", OrderdIndex = 5 },
                new Size { Id = 38, SizeRangeId = 3, Name = "44", OrderdIndex = 6 }
            );
            // MeasurementPoint
            modelBuilder.Entity<MeasurementPoint>().HasData(
                // Style 1, Measurement 1 (t-shirt)
                new MeasurementPoint { Id = 1, ShortName = "A", Description = "½ chest", Tolerance = 0.5f, MeasurementId = 1 },
                new MeasurementPoint { Id = 2, ShortName = "B", Description = "½ waist", Tolerance = 0.5f, MeasurementId = 1 },
                new MeasurementPoint { Id = 3, ShortName = "C", Description = "½ hip", Tolerance = 0.5f, MeasurementId = 1 },
                new MeasurementPoint { Id = 4, ShortName = "D", Description = "Front length from HPS", Tolerance = 1f, MeasurementId = 1 },
                new MeasurementPoint { Id = 5, ShortName = "E", Description = "Neck width", Tolerance = 0.5f, MeasurementId = 1 },
                new MeasurementPoint { Id = 6, ShortName = "F", Description = "Neck drop front", Tolerance = 0.25f, MeasurementId = 1 },
                new MeasurementPoint { Id = 7, ShortName = "G", Description = "Neck drop back", Tolerance = 0.25f, MeasurementId = 1 },
                new MeasurementPoint { Id = 8, ShortName = "H", Description = "Across shoulder", Tolerance = 0.5f, MeasurementId = 1 },
                new MeasurementPoint { Id = 9, ShortName = "I", Description = "Sleeve length from CB", Tolerance = 0.5f, MeasurementId = 1 },
                new MeasurementPoint { Id = 10, ShortName = "J", Description = "½ upper sleeve with", Tolerance = 0.5f, MeasurementId = 1 },
                new MeasurementPoint { Id = 11, ShortName = "K", Description = "½ sleeve opening", Tolerance = 0.5f, MeasurementId = 1 },
                new MeasurementPoint { Id = 12, ShortName = "L", Description = "Neck rib height", Tolerance = 0.3f, MeasurementId = 1 },
                new MeasurementPoint { Id = 13, ShortName = "M1", Description = "Pocket width", Tolerance = 0.3f, MeasurementId = 1 },
                new MeasurementPoint { Id = 14, ShortName = "M2", Description = "Pocket height", Tolerance = 0.3f, MeasurementId = 1 },
                new MeasurementPoint { Id = 15, ShortName = "M3", Description = "Pocket from CF neck", Tolerance = 0.5f, MeasurementId = 1 },

                // Style 1, Measurement 2
                new MeasurementPoint { Id = 16, ShortName = "A", Description = "½ chest", Tolerance = 0.5f, MeasurementId = 2 },
                new MeasurementPoint { Id = 17, ShortName = "B", Description = "½ waist", Tolerance = 0.5f, MeasurementId = 2 },
                new MeasurementPoint { Id = 18, ShortName = "C", Description = "½ hip", Tolerance = 0.5f, MeasurementId = 2 },
                new MeasurementPoint { Id = 19, ShortName = "D", Description = "Front length from HPS", Tolerance = 1f, MeasurementId = 2 },
                new MeasurementPoint { Id = 20, ShortName = "E", Description = "Neck width", Tolerance = 0.5f, MeasurementId = 2 },
                new MeasurementPoint { Id = 21, ShortName = "F", Description = "Neck drop front", Tolerance = 0.25f, MeasurementId = 2 },
                new MeasurementPoint { Id = 22, ShortName = "G", Description = "Neck drop back", Tolerance = 0.25f, MeasurementId = 2 },
                new MeasurementPoint { Id = 23, ShortName = "H", Description = "Across shoulder", Tolerance = 0.5f, MeasurementId = 2 },
                new MeasurementPoint { Id = 24, ShortName = "I", Description = "Sleeve length from CB", Tolerance = 0.5f, MeasurementId = 2 },
                new MeasurementPoint { Id = 25, ShortName = "J", Description = "½ upper sleeve with", Tolerance = 0.5f, MeasurementId = 2 },
                new MeasurementPoint { Id = 26, ShortName = "K", Description = "½ sleeve opening", Tolerance = 0.5f, MeasurementId = 2 },
                new MeasurementPoint { Id = 27, ShortName = "L", Description = "Neck rib height", Tolerance = 0.3f, MeasurementId = 2 },
                new MeasurementPoint { Id = 28, ShortName = "M1", Description = "Pocket width", Tolerance = 0.3f, MeasurementId = 2 },
                new MeasurementPoint { Id = 29, ShortName = "M2", Description = "Pocket height", Tolerance = 0.3f, MeasurementId = 2 },
                new MeasurementPoint { Id = 30, ShortName = "M3", Description = "Pocket placement from HPS", Tolerance = 0.5f, MeasurementId = 2 }, // NOTE: Revised Description

                // Style 1, Measurement 3
                new MeasurementPoint { Id = 31, ShortName = "A", Description = "½ chest", Tolerance = 0.5f, MeasurementId = 3 },
                new MeasurementPoint { Id = 32, ShortName = "B", Description = "½ waist", Tolerance = 0.5f, MeasurementId = 3 },
                new MeasurementPoint { Id = 33, ShortName = "C", Description = "½ hip", Tolerance = 0.5f, MeasurementId = 3 },
                new MeasurementPoint { Id = 34, ShortName = "D", Description = "Front length from HPS", Tolerance = 1f, MeasurementId = 3 },
                new MeasurementPoint { Id = 35, ShortName = "E", Description = "Neck width", Tolerance = 0.5f, MeasurementId = 3 },
                new MeasurementPoint { Id = 36, ShortName = "F", Description = "Neck drop front", Tolerance = 0.25f, MeasurementId = 3 },
                new MeasurementPoint { Id = 37, ShortName = "G", Description = "Neck drop back", Tolerance = 0.25f, MeasurementId = 3 },
                new MeasurementPoint { Id = 38, ShortName = "H", Description = "Across shoulder", Tolerance = 0.5f, MeasurementId = 3 },
                new MeasurementPoint { Id = 39, ShortName = "I", Description = "Sleeve length from CB", Tolerance = 0.5f, MeasurementId = 3 },
                new MeasurementPoint { Id = 40, ShortName = "J", Description = "½ upper sleeve with", Tolerance = 0.5f, MeasurementId = 3 },
                new MeasurementPoint { Id = 41, ShortName = "K", Description = "½ sleeve opening", Tolerance = 0.5f, MeasurementId = 3 },
                new MeasurementPoint { Id = 42, ShortName = "L", Description = "Neck rib height", Tolerance = 0.3f, MeasurementId = 3 },
                new MeasurementPoint { Id = 43, ShortName = "M1", Description = "Pocket width", Tolerance = 0.3f, MeasurementId = 3 },
                new MeasurementPoint { Id = 44, ShortName = "M2", Description = "Pocket height", Tolerance = 0.3f, MeasurementId = 3 },
                new MeasurementPoint { Id = 45, ShortName = "M3", Description = "Pocket placement from HPS", Tolerance = 0.5f, MeasurementId = 3 },
                new MeasurementPoint { Id = 83, ShortName = "1", Description = "Shoulderslope", Tolerance = 0.2f, MeasurementId = 3 },


                // Style 2, Measurement 1 (long sleeve shirt, with style 1 as parent)
                new MeasurementPoint { Id = 46, ShortName = "A", Description = "½ chest", Tolerance = 0.5f, MeasurementId = 4 },
                new MeasurementPoint { Id = 47, ShortName = "B", Description = "½ waist", Tolerance = 0.5f, MeasurementId = 4 },
                new MeasurementPoint { Id = 48, ShortName = "C", Description = "½ hip", Tolerance = 0.5f, MeasurementId = 4 },
                new MeasurementPoint { Id = 49, ShortName = "D", Description = "Front length from HPS", Tolerance = 1f, MeasurementId = 4 },
                new MeasurementPoint { Id = 50, ShortName = "E", Description = "Neck width", Tolerance = 0.5f, MeasurementId = 4 },
                new MeasurementPoint { Id = 51, ShortName = "F", Description = "Neck drop front", Tolerance = 0.25f, MeasurementId = 4 },
                new MeasurementPoint { Id = 52, ShortName = "G", Description = "Neck drop back", Tolerance = 0.25f, MeasurementId = 4 },
                new MeasurementPoint { Id = 53, ShortName = "H", Description = "Shoulder width", Tolerance = 0.5f, MeasurementId = 4 },
                new MeasurementPoint { Id = 54, ShortName = "I", Description = "Sleeve length from CB", Tolerance = 0.5f, MeasurementId = 4 },
                new MeasurementPoint { Id = 55, ShortName = "J", Description = "½ upper sleeve with", Tolerance = 0.5f, MeasurementId = 4 },
                new MeasurementPoint { Id = 56, ShortName = "K", Description = "½ sleeve opening", Tolerance = 0.5f, MeasurementId = 4 },
                new MeasurementPoint { Id = 57, ShortName = "L", Description = "Neck rib height", Tolerance = 0.3f, MeasurementId = 4 },
                new MeasurementPoint { Id = 58, ShortName = "M1", Description = "Print width", Tolerance = 0.3f, MeasurementId = 4 },
                new MeasurementPoint { Id = 59, ShortName = "M2", Description = "Print height", Tolerance = 0.3f, MeasurementId = 4 },
                new MeasurementPoint { Id = 60, ShortName = "M3", Description = "Print placement from HPS", Tolerance = 0.5f, MeasurementId = 4 },
                new MeasurementPoint { Id = 84, ShortName = "1", Description = "Shoulderslope", Tolerance = 0.2f, MeasurementId = 4 },

                // Style 3, Measurement 1 (yoga tights)
                new MeasurementPoint { Id = 61, ShortName = "A1", Description = "½ waist, relaxed", Tolerance = 0.5f, MeasurementId = 5 },
                new MeasurementPoint { Id = 62, ShortName = "A2", Description = "½ waist, extended", MeasurementId = 5 }, // NOTE: No value for tolerance
                new MeasurementPoint { Id = 63, ShortName = "A3", Description = "½ waist, at seam", Tolerance = 0.5f, MeasurementId = 5 },
                new MeasurementPoint { Id = 64, ShortName = "A4", Description = "Waistband height", Tolerance = 0.3f, MeasurementId = 5 },
                new MeasurementPoint { Id = 88, ShortName = "A5", Description = "String length at waist", Tolerance = 0.5f, MeasurementId = 5 },
                new MeasurementPoint { Id = 65, ShortName = "B", Description = "½ hip, 8cm from waist seam at CF", Tolerance = 0.5f, MeasurementId = 5 },
                new MeasurementPoint { Id = 66, ShortName = "C", Description = "½ thigh", Tolerance = 0.5f, MeasurementId = 5 },
                new MeasurementPoint { Id = 85, ShortName = "C", Description = "½ knee, at ½ inseam", Tolerance = 0.5f, MeasurementId = 5 },
                new MeasurementPoint { Id = 86, ShortName = "D1", Description = "½ leg opening,5cm above seam", Tolerance = 0.5f, MeasurementId = 5 },
                new MeasurementPoint { Id = 87, ShortName = "D2", Description = "½ leg opening", Tolerance = 0.3f, MeasurementId = 5 },
                new MeasurementPoint { Id = 67, ShortName = "D3", Description = "mudd height", Tolerance = 0.3f, MeasurementId = 5 },
                new MeasurementPoint { Id = 68, ShortName = "E", Description = "CF length", Tolerance = 0.5f, MeasurementId = 5 },
                new MeasurementPoint { Id = 69, ShortName = "F", Description = "Cb length", Tolerance = 0.5f, MeasurementId = 5 },
                new MeasurementPoint { Id = 70, ShortName = "G", Description = "Inseam length", Tolerance = 0.5f, MeasurementId = 5 },

                // Style 4, Measurement 1 (bikini top)
                new MeasurementPoint { Id = 71, ShortName = "A", Description = "Cup height", Tolerance = 0.5f, MeasurementId = 6 },
                new MeasurementPoint { Id = 72, ShortName = "B1", Description = "Cup width, at bottom", Tolerance = 0.5f, MeasurementId = 6 },
                new MeasurementPoint { Id = 73, ShortName = "B2", Description = "Cup width, at ½ height", Tolerance = 0.5f, MeasurementId = 6 },
                new MeasurementPoint { Id = 74, ShortName = "C", Description = "String length, at neck", Tolerance = 0.5f, MeasurementId = 6 },
                new MeasurementPoint { Id = 75, ShortName = "D", Description = "String length, at waist", Tolerance = 0.5f, MeasurementId = 6 },

                // Style 4, Measurement 2
                new MeasurementPoint { Id = 76, ShortName = "A", Description = "Cup height", Tolerance = 0.5f, MeasurementId = 6 },
                new MeasurementPoint { Id = 77, ShortName = "B1", Description = "Cup width, at bottom", Tolerance = 0.5f, MeasurementId = 6 },
                new MeasurementPoint { Id = 78, ShortName = "B2", Description = "Cup width, at ½ height", Tolerance = 0.5f, MeasurementId = 6 },
                new MeasurementPoint { Id = 79, ShortName = "C", Description = "String length, at neck", Tolerance = 0.5f, MeasurementId = 6 },
                new MeasurementPoint { Id = 80, ShortName = "D", Description = "String length, at waist", Tolerance = 2f, MeasurementId = 6 },  // NOTE: Revised tolerance value
                new MeasurementPoint { Id = 81, ShortName = "1", Description = "Print width", Tolerance = 0.3f, MeasurementId = 6 },  // NOTE: Added new
                new MeasurementPoint { Id = 82, ShortName = "2", Description = "Print placement from seam", Tolerance = 0.3f, MeasurementId = 6 } // NOTE: Added new
            );

            ////******************************************************
            //// The Grading table will have a lot of seed data....!!
            ////GRADING = one MeasurementPoint x number of sizes

            //// Grading  
            modelBuilder.Entity<Grading>().HasData(

                // Style 1
                new Grading { Id = 1, MeasurementPointId = 1, SizeId = 1, Value = -2f },  //for Style 1, Measurument 1
                new Grading { Id = 2, MeasurementPointId = 1, SizeId = 2, Value = -2f },
                new Grading { Id = 3, MeasurementPointId = 1, SizeId = 3, Value = 33f },
                new Grading { Id = 4, MeasurementPointId = 1, SizeId = 4, Value = 2f },
                new Grading { Id = 5, MeasurementPointId = 1, SizeId = 5, Value = 2f },
                new Grading { Id = 6, MeasurementPointId = 2, SizeId = 1, Value = -2f },  //waist
                new Grading { Id = 7, MeasurementPointId = 2, SizeId = 2, Value = -2f },
                new Grading { Id = 8, MeasurementPointId = 2, SizeId = 3, Value = 30f },
                new Grading { Id = 9, MeasurementPointId = 2, SizeId = 4, Value = 2f },
                new Grading { Id = 10, MeasurementPointId = 2, SizeId = 5, Value = 2f },
                new Grading { Id = 11, MeasurementPointId = 3, SizeId = 1, Value = -2f },  //hip
                new Grading { Id = 12, MeasurementPointId = 3, SizeId = 2, Value = -2f },
                new Grading { Id = 13, MeasurementPointId = 3, SizeId = 3, Value = 31.5f },
                new Grading { Id = 14, MeasurementPointId = 3, SizeId = 4, Value = 2f },
                new Grading { Id = 15, MeasurementPointId = 3, SizeId = 5, Value = 2f },
                new Grading { Id = 16, MeasurementPointId = 4, SizeId = 1, Value = -0.5f },  //Front length from HPS
                new Grading { Id = 17, MeasurementPointId = 4, SizeId = 2, Value = -0.5f },
                new Grading { Id = 18, MeasurementPointId = 4, SizeId = 3, Value = 61f },
                new Grading { Id = 19, MeasurementPointId = 4, SizeId = 4, Value = 1f },
                new Grading { Id = 20, MeasurementPointId = 4, SizeId = 5, Value = 1f },
                new Grading { Id = 21, MeasurementPointId = 5, SizeId = 1, Value = -0.5f },  //Neck width
                new Grading { Id = 22, MeasurementPointId = 5, SizeId = 2, Value = -0.5f },
                new Grading { Id = 23, MeasurementPointId = 5, SizeId = 3, Value = 15f },
                new Grading { Id = 24, MeasurementPointId = 5, SizeId = 4, Value = 0.5f },
                new Grading { Id = 25, MeasurementPointId = 5, SizeId = 5, Value = 0.5f },
                new Grading { Id = 26, MeasurementPointId = 6, SizeId = 1, Value = -0.5f },  //Neck drop front
                new Grading { Id = 27, MeasurementPointId = 6, SizeId = 2, Value = -0.5f },
                new Grading { Id = 28, MeasurementPointId = 6, SizeId = 3, Value = 12f },
                new Grading { Id = 29, MeasurementPointId = 6, SizeId = 4, Value = 0.5f },
                new Grading { Id = 30, MeasurementPointId = 6, SizeId = 5, Value = 0.5f },
                new Grading { Id = 31, MeasurementPointId = 7, SizeId = 1, Value = -0.5f },  //Neck drop back
                new Grading { Id = 32, MeasurementPointId = 7, SizeId = 2, Value = -0.5f },
                new Grading { Id = 33, MeasurementPointId = 7, SizeId = 3, Value = 12f },
                new Grading { Id = 34, MeasurementPointId = 7, SizeId = 4, Value = 0.5f },
                new Grading { Id = 35, MeasurementPointId = 7, SizeId = 5, Value = 0.5f },
                new Grading { Id = 36, MeasurementPointId = 8, SizeId = 1, Value = -1f },  //Across shoulder
                new Grading { Id = 37, MeasurementPointId = 8, SizeId = 2, Value = -1f },
                new Grading { Id = 38, MeasurementPointId = 8, SizeId = 3, Value = 34f },
                new Grading { Id = 39, MeasurementPointId = 8, SizeId = 4, Value = 2f },
                new Grading { Id = 40, MeasurementPointId = 8, SizeId = 5, Value = 2f },
                new Grading { Id = 41, MeasurementPointId = 9, SizeId = 1, Value = -1f },  //Sleeve length fr CB
                new Grading { Id = 42, MeasurementPointId = 9, SizeId = 2, Value = -1f },
                new Grading { Id = 43, MeasurementPointId = 9, SizeId = 3, Value = 27f },
                new Grading { Id = 44, MeasurementPointId = 9, SizeId = 4, Value = 1.5f },
                new Grading { Id = 45, MeasurementPointId = 9, SizeId = 5, Value = 1.5f },
                new Grading { Id = 46, MeasurementPointId = 10, SizeId = 1, Value = -0.5f },  //½ upper sleeve with
                new Grading { Id = 47, MeasurementPointId = 10, SizeId = 2, Value = -0.5f },
                new Grading { Id = 48, MeasurementPointId = 10, SizeId = 3, Value = 16f },
                new Grading { Id = 49, MeasurementPointId = 10, SizeId = 4, Value = 1f },
                new Grading { Id = 50, MeasurementPointId = 10, SizeId = 5, Value = 1f },
                new Grading { Id = 51, MeasurementPointId = 11, SizeId = 1, Value = -0.25f },  //½ sleeve opening
                new Grading { Id = 52, MeasurementPointId = 11, SizeId = 2, Value = -0.25f },
                new Grading { Id = 53, MeasurementPointId = 11, SizeId = 3, Value = 16f },
                new Grading { Id = 54, MeasurementPointId = 11, SizeId = 4, Value = 0.5f },
                new Grading { Id = 55, MeasurementPointId = 11, SizeId = 5, Value = 0.5f },
                new Grading { Id = 56, MeasurementPointId = 12, SizeId = 1, Value = 0f },  //neck rib height
                new Grading { Id = 57, MeasurementPointId = 12, SizeId = 2, Value = 0f },
                new Grading { Id = 58, MeasurementPointId = 12, SizeId = 3, Value = 1.8f },
                new Grading { Id = 59, MeasurementPointId = 12, SizeId = 4, Value = 0f },
                new Grading { Id = 60, MeasurementPointId = 12, SizeId = 5, Value = 0f },
                new Grading { Id = 61, MeasurementPointId = 13, SizeId = 1, Value = 0f },  //pocket width
                new Grading { Id = 62, MeasurementPointId = 13, SizeId = 2, Value = 0f },
                new Grading { Id = 63, MeasurementPointId = 13, SizeId = 3, Value = 11f },
                new Grading { Id = 64, MeasurementPointId = 13, SizeId = 4, Value = 0.5f },
                new Grading { Id = 65, MeasurementPointId = 13, SizeId = 5, Value = 0f },
                new Grading { Id = 66, MeasurementPointId = 14, SizeId = 1, Value = 0f },  //pocket height
                new Grading { Id = 67, MeasurementPointId = 14, SizeId = 2, Value = 0f },
                new Grading { Id = 68, MeasurementPointId = 14, SizeId = 3, Value = 11f },
                new Grading { Id = 69, MeasurementPointId = 14, SizeId = 4, Value = 1f },
                new Grading { Id = 70, MeasurementPointId = 14, SizeId = 5, Value = 0f },
                new Grading { Id = 71, MeasurementPointId = 15, SizeId = 1, Value = 0f },  //pocket placement from Neck drop front  (edit this when copy!)
                new Grading { Id = 72, MeasurementPointId = 15, SizeId = 2, Value = 0f },
                new Grading { Id = 73, MeasurementPointId = 15, SizeId = 3, Value = 4f },
                new Grading { Id = 74, MeasurementPointId = 15, SizeId = 4, Value = 0f },
                new Grading { Id = 75, MeasurementPointId = 15, SizeId = 5, Value = 0f },


                new Grading { Id = 76, MeasurementPointId = 16, SizeId = 6, Value = -2f },  //for Style 1, Measurument 2
                new Grading { Id = 77, MeasurementPointId = 16, SizeId = 7, Value = -2f },
                new Grading { Id = 78, MeasurementPointId = 16, SizeId = 8, Value = 33f },
                new Grading { Id = 79, MeasurementPointId = 16, SizeId = 9, Value = 2f },
                new Grading { Id = 80, MeasurementPointId = 16, SizeId = 10, Value = 2f },
                new Grading { Id = 81, MeasurementPointId = 17, SizeId = 6, Value = -2f },  //waist
                new Grading { Id = 82, MeasurementPointId = 17, SizeId = 7, Value = -2f },
                new Grading { Id = 83, MeasurementPointId = 17, SizeId = 8, Value = 30f },
                new Grading { Id = 84, MeasurementPointId = 17, SizeId = 9, Value = 2f },
                new Grading { Id = 85, MeasurementPointId = 17, SizeId = 10, Value = 2f },
                new Grading { Id = 86, MeasurementPointId = 18, SizeId = 6, Value = -2f },  //hip
                new Grading { Id = 87, MeasurementPointId = 18, SizeId = 7, Value = -2f },
                new Grading { Id = 88, MeasurementPointId = 18, SizeId = 8, Value = 31.5f },
                new Grading { Id = 89, MeasurementPointId = 18, SizeId = 9, Value = 2f },
                new Grading { Id = 90, MeasurementPointId = 18, SizeId = 10, Value = 2f },
                new Grading { Id = 91, MeasurementPointId = 19, SizeId = 6, Value = -0.5f },  //Front length from HPS
                new Grading { Id = 92, MeasurementPointId = 19, SizeId = 7, Value = -0.5f },
                new Grading { Id = 93, MeasurementPointId = 19, SizeId = 8, Value = 61f },
                new Grading { Id = 94, MeasurementPointId = 19, SizeId = 9, Value = 1f },
                new Grading { Id = 95, MeasurementPointId = 19, SizeId = 10, Value = 1f },
                new Grading { Id = 96, MeasurementPointId = 20, SizeId = 6, Value = -0.5f },  //Neck width
                new Grading { Id = 97, MeasurementPointId = 20, SizeId = 7, Value = -0.5f },
                new Grading { Id = 98, MeasurementPointId = 20, SizeId = 8, Value = 15f },
                new Grading { Id = 99, MeasurementPointId = 20, SizeId = 9, Value = 0.5f },
                new Grading { Id = 100, MeasurementPointId = 20, SizeId = 10, Value = 0.5f },
                new Grading { Id = 101, MeasurementPointId = 21, SizeId = 6, Value = -0.5f },  //Neck drop front EDIT
                new Grading { Id = 102, MeasurementPointId = 21, SizeId = 7, Value = -0.5f },
                new Grading { Id = 103, MeasurementPointId = 21, SizeId = 8, Value = 12.5f },
                new Grading { Id = 104, MeasurementPointId = 21, SizeId = 9, Value = 0.5f },
                new Grading { Id = 105, MeasurementPointId = 21, SizeId = 10, Value = 0.5f },
                new Grading { Id = 106, MeasurementPointId = 22, SizeId = 6, Value = -0.5f },  //Neck drop back
                new Grading { Id = 107, MeasurementPointId = 22, SizeId = 7, Value = -0.5f },
                new Grading { Id = 108, MeasurementPointId = 22, SizeId = 8, Value = 12f },
                new Grading { Id = 109, MeasurementPointId = 22, SizeId = 9, Value = 0.5f },
                new Grading { Id = 110, MeasurementPointId = 22, SizeId = 10, Value = 0.5f },
                new Grading { Id = 111, MeasurementPointId = 23, SizeId = 6, Value = -1f },  //Across shoulder EDIT
                new Grading { Id = 112, MeasurementPointId = 23, SizeId = 7, Value = -1f },
                new Grading { Id = 113, MeasurementPointId = 23, SizeId = 8, Value = 33f },
                new Grading { Id = 114, MeasurementPointId = 23, SizeId = 9, Value = 2f },
                new Grading { Id = 115, MeasurementPointId = 23, SizeId = 10, Value = 2f },
                new Grading { Id = 116, MeasurementPointId = 24, SizeId = 6, Value = -1f },  //Sleeve length fr CB
                new Grading { Id = 117, MeasurementPointId = 24, SizeId = 7, Value = -1f },
                new Grading { Id = 118, MeasurementPointId = 24, SizeId = 8, Value = 27f },
                new Grading { Id = 119, MeasurementPointId = 24, SizeId = 9, Value = 1.5f },
                new Grading { Id = 120, MeasurementPointId = 24, SizeId = 10, Value = 1.5f },
                new Grading { Id = 121, MeasurementPointId = 25, SizeId = 6, Value = -0.5f },  //½ upper sleeve with
                new Grading { Id = 122, MeasurementPointId = 25, SizeId = 7, Value = -0.5f },
                new Grading { Id = 123, MeasurementPointId = 25, SizeId = 8, Value = 16f },
                new Grading { Id = 124, MeasurementPointId = 25, SizeId = 9, Value = 1f },
                new Grading { Id = 125, MeasurementPointId = 25, SizeId = 10, Value = 1f },
                new Grading { Id = 126, MeasurementPointId = 26, SizeId = 6, Value = -0.5f },  //½ sleeve opening EDIT
                new Grading { Id = 127, MeasurementPointId = 26, SizeId = 7, Value = -0.5f },
                new Grading { Id = 128, MeasurementPointId = 26, SizeId = 8, Value = 14f },
                new Grading { Id = 129, MeasurementPointId = 26, SizeId = 9, Value = 0.5f },
                new Grading { Id = 130, MeasurementPointId = 26, SizeId = 10, Value = 0.5f },
                new Grading { Id = 131, MeasurementPointId = 27, SizeId = 6, Value = 0f },  //neck rib height
                new Grading { Id = 132, MeasurementPointId = 27, SizeId = 7, Value = 0f },
                new Grading { Id = 133, MeasurementPointId = 27, SizeId = 8, Value = 1.8f },
                new Grading { Id = 134, MeasurementPointId = 27, SizeId = 9, Value = 0f },
                new Grading { Id = 135, MeasurementPointId = 27, SizeId = 10, Value = 0f },
                new Grading { Id = 136, MeasurementPointId = 28, SizeId = 6, Value = 0f },  //pocket width
                new Grading { Id = 137, MeasurementPointId = 28, SizeId = 7, Value = 0f },
                new Grading { Id = 138, MeasurementPointId = 28, SizeId = 8, Value = 11f },
                new Grading { Id = 139, MeasurementPointId = 28, SizeId = 9, Value = 0.5f },
                new Grading { Id = 140, MeasurementPointId = 28, SizeId = 10, Value = 0f },
                new Grading { Id = 141, MeasurementPointId = 29, SizeId = 6, Value = 0f },  //pocket height
                new Grading { Id = 142, MeasurementPointId = 29, SizeId = 7, Value = 0f },
                new Grading { Id = 143, MeasurementPointId = 29, SizeId = 8, Value = 11f },
                new Grading { Id = 144, MeasurementPointId = 29, SizeId = 9, Value = 1f },
                new Grading { Id = 145, MeasurementPointId = 29, SizeId = 10, Value = 0f },
                new Grading { Id = 146, MeasurementPointId = 30, SizeId = 6, Value = -0.5f },  //Pocket placement from HPS EDITED
                new Grading { Id = 147, MeasurementPointId = 30, SizeId = 7, Value = -0.5f },
                new Grading { Id = 148, MeasurementPointId = 30, SizeId = 8, Value = 16.5f },
                new Grading { Id = 149, MeasurementPointId = 30, SizeId = 9, Value = 0.5f },
                new Grading { Id = 150, MeasurementPointId = 30, SizeId = 10, Value = 0.5f },

                new Grading { Id = 151, MeasurementPointId = 31, SizeId = 11, Value = -2f },  //for Style 1, Measurument 3
                new Grading { Id = 152, MeasurementPointId = 31, SizeId = 12, Value = -2f },
                new Grading { Id = 153, MeasurementPointId = 31, SizeId = 13, Value = 33f },
                new Grading { Id = 154, MeasurementPointId = 31, SizeId = 14, Value = 2f },
                new Grading { Id = 155, MeasurementPointId = 31, SizeId = 15, Value = 2f },
                new Grading { Id = 156, MeasurementPointId = 32, SizeId = 11, Value = -2f },  //waist
                new Grading { Id = 157, MeasurementPointId = 32, SizeId = 12, Value = -2f },
                new Grading { Id = 158, MeasurementPointId = 32, SizeId = 13, Value = 30f },
                new Grading { Id = 159, MeasurementPointId = 32, SizeId = 14, Value = 2f },
                new Grading { Id = 160, MeasurementPointId = 32, SizeId = 15, Value = 2f },
                new Grading { Id = 161, MeasurementPointId = 33, SizeId = 11, Value = -2f },  //hip EDIT
                new Grading { Id = 162, MeasurementPointId = 33, SizeId = 12, Value = -2f },
                new Grading { Id = 163, MeasurementPointId = 33, SizeId = 13, Value = 31f },
                new Grading { Id = 164, MeasurementPointId = 33, SizeId = 14, Value = 2f },
                new Grading { Id = 165, MeasurementPointId = 33, SizeId = 15, Value = 2f },
                new Grading { Id = 166, MeasurementPointId = 34, SizeId = 11, Value = -0.5f },  //Front length from HPS EDIT
                new Grading { Id = 167, MeasurementPointId = 34, SizeId = 12, Value = -0.5f },
                new Grading { Id = 168, MeasurementPointId = 34, SizeId = 13, Value = 60f },
                new Grading { Id = 169, MeasurementPointId = 34, SizeId = 14, Value = 1f },
                new Grading { Id = 170, MeasurementPointId = 34, SizeId = 15, Value = 1f },
                new Grading { Id = 171, MeasurementPointId = 35, SizeId = 11, Value = -0.5f },  //Neck width
                new Grading { Id = 172, MeasurementPointId = 35, SizeId = 12, Value = -0.5f },
                new Grading { Id = 173, MeasurementPointId = 35, SizeId = 13, Value = 15f },
                new Grading { Id = 174, MeasurementPointId = 35, SizeId = 14, Value = 0.5f },
                new Grading { Id = 175, MeasurementPointId = 35, SizeId = 15, Value = 0.5f },
                new Grading { Id = 176, MeasurementPointId = 36, SizeId = 11, Value = -0.5f },  //Neck drop front
                new Grading { Id = 177, MeasurementPointId = 36, SizeId = 12, Value = -0.5f },
                new Grading { Id = 178, MeasurementPointId = 36, SizeId = 13, Value = 12.5f },
                new Grading { Id = 179, MeasurementPointId = 36, SizeId = 14, Value = 0.5f },
                new Grading { Id = 180, MeasurementPointId = 36, SizeId = 15, Value = 0.5f },
                new Grading { Id = 181, MeasurementPointId = 37, SizeId = 11, Value = -0.5f },  //Neck drop back
                new Grading { Id = 182, MeasurementPointId = 37, SizeId = 12, Value = -0.5f },
                new Grading { Id = 183, MeasurementPointId = 37, SizeId = 13, Value = 12f },
                new Grading { Id = 184, MeasurementPointId = 37, SizeId = 14, Value = 0.5f },
                new Grading { Id = 185, MeasurementPointId = 37, SizeId = 15, Value = 0.5f },
                new Grading { Id = 186, MeasurementPointId = 38, SizeId = 11, Value = -1f },  //Across shoulder
                new Grading { Id = 187, MeasurementPointId = 38, SizeId = 12, Value = -1f },
                new Grading { Id = 188, MeasurementPointId = 38, SizeId = 13, Value = 33f },
                new Grading { Id = 189, MeasurementPointId = 38, SizeId = 14, Value = 2f },
                new Grading { Id = 190, MeasurementPointId = 38, SizeId = 15, Value = 2f },
                new Grading { Id = 191, MeasurementPointId = 39, SizeId = 11, Value = -1f },  //Sleeve length fr CB
                new Grading { Id = 192, MeasurementPointId = 39, SizeId = 12, Value = -1f },
                new Grading { Id = 193, MeasurementPointId = 39, SizeId = 13, Value = 27f },
                new Grading { Id = 194, MeasurementPointId = 39, SizeId = 14, Value = 1.5f },
                new Grading { Id = 195, MeasurementPointId = 39, SizeId = 15, Value = 1.5f },
                new Grading { Id = 196, MeasurementPointId = 40, SizeId = 11, Value = -0.5f },  //½ upper sleeve with
                new Grading { Id = 197, MeasurementPointId = 40, SizeId = 12, Value = -0.5f },
                new Grading { Id = 198, MeasurementPointId = 40, SizeId = 13, Value = 16f },
                new Grading { Id = 199, MeasurementPointId = 40, SizeId = 14, Value = 1f },
                new Grading { Id = 200, MeasurementPointId = 40, SizeId = 15, Value = 1f },
                new Grading { Id = 201, MeasurementPointId = 41, SizeId = 11, Value = -0.5f },  //½ sleeve opening
                new Grading { Id = 202, MeasurementPointId = 41, SizeId = 12, Value = -0.5f },
                new Grading { Id = 203, MeasurementPointId = 41, SizeId = 13, Value = 14f },
                new Grading { Id = 204, MeasurementPointId = 41, SizeId = 14, Value = 0.5f },
                new Grading { Id = 205, MeasurementPointId = 41, SizeId = 15, Value = 0.5f },
                new Grading { Id = 206, MeasurementPointId = 42, SizeId = 11, Value = 0f },  //neck rib height
                new Grading { Id = 207, MeasurementPointId = 42, SizeId = 12, Value = 0f },
                new Grading { Id = 208, MeasurementPointId = 42, SizeId = 13, Value = 1.8f },
                new Grading { Id = 209, MeasurementPointId = 42, SizeId = 14, Value = 0f },
                new Grading { Id = 210, MeasurementPointId = 42, SizeId = 15, Value = 0f },
                new Grading { Id = 211, MeasurementPointId = 43, SizeId = 11, Value = 0f },  //pocket width
                new Grading { Id = 212, MeasurementPointId = 43, SizeId = 12, Value = 0f },
                new Grading { Id = 213, MeasurementPointId = 43, SizeId = 13, Value = 11f },
                new Grading { Id = 214, MeasurementPointId = 43, SizeId = 14, Value = 0.5f },
                new Grading { Id = 215, MeasurementPointId = 43, SizeId = 15, Value = 0f },
                new Grading { Id = 216, MeasurementPointId = 44, SizeId = 11, Value = 0f },  //pocket height
                new Grading { Id = 217, MeasurementPointId = 44, SizeId = 12, Value = 0f },
                new Grading { Id = 218, MeasurementPointId = 44, SizeId = 13, Value = 11f },
                new Grading { Id = 219, MeasurementPointId = 44, SizeId = 14, Value = 1f },
                new Grading { Id = 220, MeasurementPointId = 44, SizeId = 15, Value = 0f },
                new Grading { Id = 221, MeasurementPointId = 45, SizeId = 11, Value = -0.5f },  //Pocket placement from HPS
                new Grading { Id = 222, MeasurementPointId = 45, SizeId = 12, Value = -0.5f },
                new Grading { Id = 223, MeasurementPointId = 45, SizeId = 13, Value = 16.5f },
                new Grading { Id = 224, MeasurementPointId = 45, SizeId = 14, Value = 0.5f },
                new Grading { Id = 225, MeasurementPointId = 45, SizeId = 15, Value = 0.5f },
                new Grading { Id = 226, MeasurementPointId = 83, SizeId = 11, Value = -0.2f },  //Shoulderslope EDIT/ADDED
                new Grading { Id = 227, MeasurementPointId = 83, SizeId = 12, Value = -0.2f },
                new Grading { Id = 228, MeasurementPointId = 83, SizeId = 13, Value = 4.5f },
                new Grading { Id = 229, MeasurementPointId = 83, SizeId = 14, Value = 0.3f },
                new Grading { Id = 230, MeasurementPointId = 83, SizeId = 15, Value = 0.3f },

                // Style 2
                new Grading { Id = 231, MeasurementPointId = 46, SizeId = 16, Value = -2f },  //for Style 1, Measurument 3
                new Grading { Id = 232, MeasurementPointId = 46, SizeId = 17, Value = -2f },
                new Grading { Id = 233, MeasurementPointId = 46, SizeId = 18, Value = 33f },
                new Grading { Id = 234, MeasurementPointId = 46, SizeId = 19, Value = 2f },
                new Grading { Id = 235, MeasurementPointId = 46, SizeId = 20, Value = 2f },
                new Grading { Id = 236, MeasurementPointId = 47, SizeId = 16, Value = -2f },  //waist
                new Grading { Id = 237, MeasurementPointId = 47, SizeId = 17, Value = -2f },
                new Grading { Id = 238, MeasurementPointId = 47, SizeId = 18, Value = 30f },
                new Grading { Id = 239, MeasurementPointId = 47, SizeId = 19, Value = 2f },
                new Grading { Id = 240, MeasurementPointId = 47, SizeId = 20, Value = 2f },
                new Grading { Id = 241, MeasurementPointId = 48, SizeId = 16, Value = -2f },  //hip EDIT
                new Grading { Id = 242, MeasurementPointId = 48, SizeId = 17, Value = -2f },
                new Grading { Id = 243, MeasurementPointId = 48, SizeId = 18, Value = 31f },
                new Grading { Id = 244, MeasurementPointId = 48, SizeId = 19, Value = 2f },
                new Grading { Id = 245, MeasurementPointId = 48, SizeId = 20, Value = 2f },
                new Grading { Id = 246, MeasurementPointId = 49, SizeId = 16, Value = -0.5f },  //Front length from HPS EDIT
                new Grading { Id = 247, MeasurementPointId = 49, SizeId = 17, Value = -0.5f },
                new Grading { Id = 248, MeasurementPointId = 49, SizeId = 18, Value = 60f },
                new Grading { Id = 249, MeasurementPointId = 49, SizeId = 19, Value = 1f },
                new Grading { Id = 250, MeasurementPointId = 49, SizeId = 20, Value = 1f },
                new Grading { Id = 251, MeasurementPointId = 50, SizeId = 16, Value = -0.5f },  //Neck width
                new Grading { Id = 252, MeasurementPointId = 50, SizeId = 17, Value = -0.5f },
                new Grading { Id = 253, MeasurementPointId = 50, SizeId = 18, Value = 15f },
                new Grading { Id = 254, MeasurementPointId = 50, SizeId = 19, Value = 0.5f },
                new Grading { Id = 255, MeasurementPointId = 50, SizeId = 20, Value = 0.5f },
                new Grading { Id = 256, MeasurementPointId = 51, SizeId = 16, Value = -0.5f },  //Neck drop front
                new Grading { Id = 257, MeasurementPointId = 51, SizeId = 17, Value = -0.5f },
                new Grading { Id = 258, MeasurementPointId = 51, SizeId = 18, Value = 12.5f },
                new Grading { Id = 259, MeasurementPointId = 51, SizeId = 19, Value = 0.5f },
                new Grading { Id = 260, MeasurementPointId = 51, SizeId = 20, Value = 0.5f },
                new Grading { Id = 261, MeasurementPointId = 52, SizeId = 16, Value = -0.5f },  //Neck drop back
                new Grading { Id = 262, MeasurementPointId = 52, SizeId = 17, Value = -0.5f },
                new Grading { Id = 263, MeasurementPointId = 52, SizeId = 18, Value = 12f },
                new Grading { Id = 264, MeasurementPointId = 52, SizeId = 19, Value = 0.5f },
                new Grading { Id = 265, MeasurementPointId = 52, SizeId = 20, Value = 0.5f },
                new Grading { Id = 266, MeasurementPointId = 53, SizeId = 16, Value = -1f },  //Across shoulder
                new Grading { Id = 267, MeasurementPointId = 53, SizeId = 17, Value = -1f },
                new Grading { Id = 268, MeasurementPointId = 53, SizeId = 18, Value = 33f },
                new Grading { Id = 269, MeasurementPointId = 53, SizeId = 19, Value = 2f },
                new Grading { Id = 270, MeasurementPointId = 53, SizeId = 20, Value = 2f },
                new Grading { Id = 271, MeasurementPointId = 54, SizeId = 16, Value = -1f },  //Sleeve length fr CB
                new Grading { Id = 272, MeasurementPointId = 54, SizeId = 17, Value = -1f },
                new Grading { Id = 273, MeasurementPointId = 54, SizeId = 18, Value = 42f },
                new Grading { Id = 274, MeasurementPointId = 54, SizeId = 19, Value = 1.5f },
                new Grading { Id = 275, MeasurementPointId = 54, SizeId = 20, Value = 1.5f },
                new Grading { Id = 276, MeasurementPointId = 55, SizeId = 16, Value = -0.5f },  //½ upper sleeve with
                new Grading { Id = 277, MeasurementPointId = 55, SizeId = 17, Value = -0.5f },
                new Grading { Id = 278, MeasurementPointId = 55, SizeId = 18, Value = 15f },
                new Grading { Id = 279, MeasurementPointId = 55, SizeId = 19, Value = 1f },
                new Grading { Id = 280, MeasurementPointId = 55, SizeId = 20, Value = 1f },
                new Grading { Id = 281, MeasurementPointId = 56, SizeId = 16, Value = -0.25f },  //½ sleeve opening
                new Grading { Id = 282, MeasurementPointId = 56, SizeId = 17, Value = -0.25f },
                new Grading { Id = 283, MeasurementPointId = 56, SizeId = 18, Value = 11f },
                new Grading { Id = 284, MeasurementPointId = 56, SizeId = 19, Value = 0.5f },
                new Grading { Id = 285, MeasurementPointId = 56, SizeId = 20, Value = 0.5f },
                new Grading { Id = 286, MeasurementPointId = 57, SizeId = 16, Value = 0f },  //neck rib height
                new Grading { Id = 287, MeasurementPointId = 57, SizeId = 17, Value = 0f },
                new Grading { Id = 288, MeasurementPointId = 57, SizeId = 18, Value = 1.8f },
                new Grading { Id = 289, MeasurementPointId = 57, SizeId = 19, Value = 0f },
                new Grading { Id = 290, MeasurementPointId = 57, SizeId = 20, Value = 0f },
                new Grading { Id = 291, MeasurementPointId = 58, SizeId = 16, Value = 0f },  //print width
                new Grading { Id = 292, MeasurementPointId = 58, SizeId = 17, Value = 0f },
                new Grading { Id = 293, MeasurementPointId = 58, SizeId = 18, Value = 8f },
                new Grading { Id = 294, MeasurementPointId = 58, SizeId = 19, Value = 0.5f },
                new Grading { Id = 295, MeasurementPointId = 58, SizeId = 20, Value = 0f },
                new Grading { Id = 296, MeasurementPointId = 59, SizeId = 16, Value = 0f },  //print height
                new Grading { Id = 297, MeasurementPointId = 59, SizeId = 17, Value = 0f },
                new Grading { Id = 298, MeasurementPointId = 59, SizeId = 18, Value = 1.8f },
                new Grading { Id = 299, MeasurementPointId = 59, SizeId = 19, Value = 1f },
                new Grading { Id = 300, MeasurementPointId = 59, SizeId = 20, Value = 0f },
                new Grading { Id = 301, MeasurementPointId = 60, SizeId = 16, Value = -0.5f },  //print placement from HPS
                new Grading { Id = 302, MeasurementPointId = 60, SizeId = 17, Value = -0.5f },
                new Grading { Id = 303, MeasurementPointId = 60, SizeId = 18, Value = 16.5f },
                new Grading { Id = 304, MeasurementPointId = 60, SizeId = 19, Value = 0.5f },
                new Grading { Id = 305, MeasurementPointId = 60, SizeId = 20, Value = 0.5f },
                new Grading { Id = 306, MeasurementPointId = 84, SizeId = 16, Value = -0.2f },  //Shoulderslope EDIT/ADDED
                new Grading { Id = 307, MeasurementPointId = 84, SizeId = 17, Value = -0.2f },
                new Grading { Id = 308, MeasurementPointId = 84, SizeId = 18, Value = 4.5f },
                new Grading { Id = 309, MeasurementPointId = 84, SizeId = 19, Value = 0.3f },
                new Grading { Id = 310, MeasurementPointId = 84, SizeId = 20, Value = 0.3f },


                // Style 3
                new Grading { Id = 311, MeasurementPointId = 61, SizeId = 21, Value = -1.5f }, // Style 3, Measurement 1
                new Grading { Id = 312, MeasurementPointId = 61, SizeId = 22, Value = 27.5f },
                new Grading { Id = 313, MeasurementPointId = 61, SizeId = 23, Value = 1.5f },
                new Grading { Id = 314, MeasurementPointId = 61, SizeId = 24, Value = 1.5f },
                new Grading { Id = 315, MeasurementPointId = 61, SizeId = 25, Value = 2f },
                new Grading { Id = 316, MeasurementPointId = 61, SizeId = 26, Value = 2f },
                new Grading { Id = 317, MeasurementPointId = 62, SizeId = 21, Value = -1.5f }, // ½ waist, extended
                new Grading { Id = 318, MeasurementPointId = 62, SizeId = 22, Value = 32.5f },
                new Grading { Id = 319, MeasurementPointId = 62, SizeId = 23, Value = 1.5f },
                new Grading { Id = 320, MeasurementPointId = 62, SizeId = 24, Value = 1.5f },
                new Grading { Id = 321, MeasurementPointId = 62, SizeId = 25, Value = 2f },
                new Grading { Id = 322, MeasurementPointId = 62, SizeId = 26, Value = 2f },
                new Grading { Id = 323, MeasurementPointId = 63, SizeId = 21, Value = -1.5f }, // ½ waist, extended
                new Grading { Id = 324, MeasurementPointId = 63, SizeId = 22, Value = 29f },
                new Grading { Id = 325, MeasurementPointId = 63, SizeId = 23, Value = 1.5f },
                new Grading { Id = 326, MeasurementPointId = 63, SizeId = 24, Value = 1.5f },
                new Grading { Id = 327, MeasurementPointId = 63, SizeId = 25, Value = 2f },
                new Grading { Id = 328, MeasurementPointId = 63, SizeId = 26, Value = 2f },
                new Grading { Id = 329, MeasurementPointId = 64, SizeId = 21, Value = 0f }, // String length at waist
                new Grading { Id = 330, MeasurementPointId = 64, SizeId = 22, Value = 18f },
                new Grading { Id = 331, MeasurementPointId = 64, SizeId = 23, Value = 0f },
                new Grading { Id = 332, MeasurementPointId = 64, SizeId = 24, Value = 0f },
                new Grading { Id = 333, MeasurementPointId = 64, SizeId = 25, Value = 0f },
                new Grading { Id = 334, MeasurementPointId = 64, SizeId = 26, Value = 0f },
                new Grading { Id = 468, MeasurementPointId = 88, SizeId = 21, Value = 0f }, // Waist band hight
                new Grading { Id = 469, MeasurementPointId = 88, SizeId = 22, Value = 11f },
                new Grading { Id = 470, MeasurementPointId = 88, SizeId = 23, Value = 0f },
                new Grading { Id = 471, MeasurementPointId = 88, SizeId = 24, Value = 0f },
                new Grading { Id = 472, MeasurementPointId = 88, SizeId = 25, Value = 0f },
                new Grading { Id = 473, MeasurementPointId = 88, SizeId = 26, Value = 0f },
                new Grading { Id = 335, MeasurementPointId = 65, SizeId = 21, Value = -1.5f }, // ½ hip, 8cm from waist seam at CF
                new Grading { Id = 336, MeasurementPointId = 65, SizeId = 22, Value = 33.5f },
                new Grading { Id = 337, MeasurementPointId = 65, SizeId = 23, Value = 1.5f },
                new Grading { Id = 338, MeasurementPointId = 65, SizeId = 24, Value = 1.5f },
                new Grading { Id = 339, MeasurementPointId = 65, SizeId = 25, Value = 2f },
                new Grading { Id = 340, MeasurementPointId = 65, SizeId = 26, Value = 2f },
                new Grading { Id = 341, MeasurementPointId = 66, SizeId = 21, Value = -1.25f }, //½ thigh
                new Grading { Id = 342, MeasurementPointId = 66, SizeId = 22, Value = 18.75f },
                new Grading { Id = 343, MeasurementPointId = 66, SizeId = 23, Value = 1.25f },
                new Grading { Id = 344, MeasurementPointId = 66, SizeId = 24, Value = 1.5f },
                new Grading { Id = 345, MeasurementPointId = 66, SizeId = 25, Value = 1.5f },
                new Grading { Id = 346, MeasurementPointId = 66, SizeId = 26, Value = 1.75f },
                new Grading { Id = 347, MeasurementPointId = 66, SizeId = 21, Value = -1.25f }, //½ thigh
                new Grading { Id = 348, MeasurementPointId = 66, SizeId = 22, Value = -17.75f },
                new Grading { Id = 349, MeasurementPointId = 66, SizeId = 23, Value = 1.25f },
                new Grading { Id = 350, MeasurementPointId = 66, SizeId = 24, Value = 1.5f },
                new Grading { Id = 351, MeasurementPointId = 66, SizeId = 25, Value = 1.5f },
                new Grading { Id = 352, MeasurementPointId = 66, SizeId = 26, Value = 1.75f },
                new Grading { Id = 353, MeasurementPointId = 85, SizeId = 21, Value = -0.75f }, //½ knee
                new Grading { Id = 354, MeasurementPointId = 85, SizeId = 22, Value = 12.75f },
                new Grading { Id = 355, MeasurementPointId = 85, SizeId = 23, Value = 0.75f },
                new Grading { Id = 356, MeasurementPointId = 85, SizeId = 24, Value = 0.75f },
                new Grading { Id = 357, MeasurementPointId = 85, SizeId = 25, Value = 0.75f },
                new Grading { Id = 358, MeasurementPointId = 85, SizeId = 26, Value = 1f },
                new Grading { Id = 359, MeasurementPointId = 86, SizeId = 21, Value = -0.5f }, //½ leg opening,5cm above seam
                new Grading { Id = 360, MeasurementPointId = 86, SizeId = 22, Value = 14.5f },
                new Grading { Id = 361, MeasurementPointId = 86, SizeId = 23, Value = 0.5f },
                new Grading { Id = 362, MeasurementPointId = 86, SizeId = 24, Value = 0.5f },
                new Grading { Id = 363, MeasurementPointId = 86, SizeId = 25, Value = 0.5f },
                new Grading { Id = 364, MeasurementPointId = 86, SizeId = 26, Value = 0.75f },
                new Grading { Id = 365, MeasurementPointId = 87, SizeId = 21, Value = -0.5f }, //½ leg opening
                new Grading { Id = 366, MeasurementPointId = 87, SizeId = 22, Value = 14.5f },
                new Grading { Id = 367, MeasurementPointId = 87, SizeId = 23, Value = 0.5f },
                new Grading { Id = 368, MeasurementPointId = 87, SizeId = 24, Value = 0.5f },
                new Grading { Id = 369, MeasurementPointId = 87, SizeId = 25, Value = 0.5f },
                new Grading { Id = 370, MeasurementPointId = 87, SizeId = 26, Value = 0.75f },
                new Grading { Id = 371, MeasurementPointId = 67, SizeId = 21, Value = 0f }, //mudd height
                new Grading { Id = 372, MeasurementPointId = 67, SizeId = 22, Value = 6f },
                new Grading { Id = 373, MeasurementPointId = 67, SizeId = 23, Value = 0f },
                new Grading { Id = 374, MeasurementPointId = 67, SizeId = 24, Value = 0f },
                new Grading { Id = 375, MeasurementPointId = 67, SizeId = 25, Value = 0f },
                new Grading { Id = 376, MeasurementPointId = 67, SizeId = 26, Value = 0f },
                new Grading { Id = 377, MeasurementPointId = 68, SizeId = 21, Value = -0.75f }, //CF length
                new Grading { Id = 378, MeasurementPointId = 68, SizeId = 22, Value = 17.75f },
                new Grading { Id = 379, MeasurementPointId = 68, SizeId = 23, Value = 0.75f },
                new Grading { Id = 380, MeasurementPointId = 68, SizeId = 24, Value = 0.75f },
                new Grading { Id = 381, MeasurementPointId = 68, SizeId = 25, Value = 0.75f },
                new Grading { Id = 382, MeasurementPointId = 68, SizeId = 26, Value = 1f },
                new Grading { Id = 384, MeasurementPointId = 69, SizeId = 21, Value = -1.25f }, //CB length
                new Grading { Id = 385, MeasurementPointId = 69, SizeId = 22, Value = 24.75f },
                new Grading { Id = 386, MeasurementPointId = 69, SizeId = 23, Value = 1.25f },
                new Grading { Id = 387, MeasurementPointId = 69, SizeId = 24, Value = 1.5f },
                new Grading { Id = 388, MeasurementPointId = 69, SizeId = 25, Value = 1.5f },
                new Grading { Id = 389, MeasurementPointId = 69, SizeId = 26, Value = 1.75f },
                new Grading { Id = 390, MeasurementPointId = 70, SizeId = 21, Value = 0f }, //Inseam
                new Grading { Id = 391, MeasurementPointId = 70, SizeId = 22, Value = 67f },
                new Grading { Id = 392, MeasurementPointId = 70, SizeId = 23, Value = 1f },
                new Grading { Id = 393, MeasurementPointId = 70, SizeId = 24, Value = 0f },
                new Grading { Id = 394, MeasurementPointId = 70, SizeId = 25, Value = 1.5f },
                new Grading { Id = 395, MeasurementPointId = 70, SizeId = 26, Value = 0f },

                // Style 4, Measurement 1 (bikini top) 
                new Grading { Id = 396, MeasurementPointId = 71, SizeId = 27, Value = -0.75f }, //Cup height
                new Grading { Id = 397, MeasurementPointId = 71, SizeId = 28, Value = -0.75f },
                new Grading { Id = 398, MeasurementPointId = 71, SizeId = 29, Value = 16.5f },
                new Grading { Id = 399, MeasurementPointId = 71, SizeId = 30, Value = 0.75f },
                new Grading { Id = 400, MeasurementPointId = 71, SizeId = 31, Value = 0.75f },
                new Grading { Id = 401, MeasurementPointId = 71, SizeId = 32, Value = 0.75f },
                new Grading { Id = 402, MeasurementPointId = 72, SizeId = 27, Value = -0.5f }, //Cup width, at bottom
                new Grading { Id = 403, MeasurementPointId = 72, SizeId = 28, Value = -0.5f },
                new Grading { Id = 404, MeasurementPointId = 72, SizeId = 29, Value = 15f },
                new Grading { Id = 405, MeasurementPointId = 72, SizeId = 30, Value = 0.5f },
                new Grading { Id = 406, MeasurementPointId = 72, SizeId = 31, Value = 0.5f },
                new Grading { Id = 407, MeasurementPointId = 72, SizeId = 32, Value = 0.75f },
                new Grading { Id = 408, MeasurementPointId = 73, SizeId = 27, Value = -0.5f }, //Cup width, at ½ height
                new Grading { Id = 409, MeasurementPointId = 73, SizeId = 28, Value = -0.5f },
                new Grading { Id = 410, MeasurementPointId = 73, SizeId = 29, Value = 12.5f },
                new Grading { Id = 411, MeasurementPointId = 73, SizeId = 30, Value = 0.5f },
                new Grading { Id = 412, MeasurementPointId = 73, SizeId = 31, Value = 0.5f },
                new Grading { Id = 413, MeasurementPointId = 73, SizeId = 32, Value = 0.75f },
                new Grading { Id = 414, MeasurementPointId = 74, SizeId = 27, Value = 0f }, //String length, at nec
                new Grading { Id = 415, MeasurementPointId = 74, SizeId = 28, Value = -2f },
                new Grading { Id = 416, MeasurementPointId = 74, SizeId = 29, Value = 28f },
                new Grading { Id = 417, MeasurementPointId = 74, SizeId = 30, Value = 0f },
                new Grading { Id = 418, MeasurementPointId = 74, SizeId = 31, Value = 2f },
                new Grading { Id = 419, MeasurementPointId = 74, SizeId = 32, Value = 0f },
                new Grading { Id = 420, MeasurementPointId = 75, SizeId = 27, Value = -5f }, //String length, at waist
                new Grading { Id = 421, MeasurementPointId = 75, SizeId = 28, Value = -5f },
                new Grading { Id = 422, MeasurementPointId = 75, SizeId = 29, Value = 105f },
                new Grading { Id = 423, MeasurementPointId = 75, SizeId = 30, Value = 5f },
                new Grading { Id = 424, MeasurementPointId = 75, SizeId = 31, Value = 5f },
                new Grading { Id = 425, MeasurementPointId = 75, SizeId = 32, Value = 5f },

                new Grading { Id = 426, MeasurementPointId = 76, SizeId = 33, Value = -0.75f }, // Style 4, measurement 2 - Cup height
                new Grading { Id = 427, MeasurementPointId = 76, SizeId = 34, Value = -0.75f },
                new Grading { Id = 428, MeasurementPointId = 76, SizeId = 35, Value = 16.5f },
                new Grading { Id = 429, MeasurementPointId = 76, SizeId = 36, Value = 0.75f },
                new Grading { Id = 430, MeasurementPointId = 76, SizeId = 37, Value = 0.75f },
                new Grading { Id = 431, MeasurementPointId = 76, SizeId = 38, Value = 0.75f },
                new Grading { Id = 432, MeasurementPointId = 77, SizeId = 33, Value = -0.5f }, //Cup width, at bottom EDIT
                new Grading { Id = 433, MeasurementPointId = 77, SizeId = 34, Value = -0.5f },
                new Grading { Id = 434, MeasurementPointId = 77, SizeId = 35, Value = 14f },
                new Grading { Id = 435, MeasurementPointId = 77, SizeId = 36, Value = 0.5f },
                new Grading { Id = 436, MeasurementPointId = 77, SizeId = 37, Value = 0.5f },
                new Grading { Id = 437, MeasurementPointId = 77, SizeId = 38, Value = 0.75f },
                new Grading { Id = 438, MeasurementPointId = 78, SizeId = 33, Value = -0.5f }, //Cup width, at ½ height
                new Grading { Id = 439, MeasurementPointId = 78, SizeId = 34, Value = -0.5f },
                new Grading { Id = 440, MeasurementPointId = 78, SizeId = 35, Value = 12.5f },
                new Grading { Id = 441, MeasurementPointId = 78, SizeId = 36, Value = 0.5f },
                new Grading { Id = 442, MeasurementPointId = 78, SizeId = 37, Value = 0.5f },
                new Grading { Id = 443, MeasurementPointId = 78, SizeId = 38, Value = 0.75f },
                new Grading { Id = 444, MeasurementPointId = 79, SizeId = 33, Value = 0f }, //String length, at nec
                new Grading { Id = 445, MeasurementPointId = 79, SizeId = 34, Value = -2f },
                new Grading { Id = 446, MeasurementPointId = 79, SizeId = 35, Value = 28f },
                new Grading { Id = 447, MeasurementPointId = 79, SizeId = 36, Value = 0f },
                new Grading { Id = 448, MeasurementPointId = 79, SizeId = 37, Value = 2f },
                new Grading { Id = 449, MeasurementPointId = 79, SizeId = 38, Value = 0f },
                new Grading { Id = 450, MeasurementPointId = 80, SizeId = 33, Value = -5f }, //String length, at waist
                new Grading { Id = 451, MeasurementPointId = 80, SizeId = 34, Value = -5f },
                new Grading { Id = 452, MeasurementPointId = 80, SizeId = 35, Value = 105f },
                new Grading { Id = 453, MeasurementPointId = 80, SizeId = 36, Value = 5f },
                new Grading { Id = 454, MeasurementPointId = 80, SizeId = 37, Value = 5f },
                new Grading { Id = 455, MeasurementPointId = 80, SizeId = 38, Value = 5f },
                new Grading { Id = 456, MeasurementPointId = 81, SizeId = 33, Value = 0f }, //Print width ADDED
                new Grading { Id = 457, MeasurementPointId = 81, SizeId = 34, Value = 0f },
                new Grading { Id = 458, MeasurementPointId = 81, SizeId = 35, Value = 6f },
                new Grading { Id = 459, MeasurementPointId = 81, SizeId = 36, Value = 0f },
                new Grading { Id = 460, MeasurementPointId = 81, SizeId = 37, Value = 0f },
                new Grading { Id = 461, MeasurementPointId = 81, SizeId = 38, Value = 0f },
                new Grading { Id = 462, MeasurementPointId = 82, SizeId = 33, Value = 0f }, //Print placement ADDED
                new Grading { Id = 463, MeasurementPointId = 82, SizeId = 34, Value = 0f },
                new Grading { Id = 464, MeasurementPointId = 82, SizeId = 35, Value = 2f },
                new Grading { Id = 465, MeasurementPointId = 82, SizeId = 36, Value = 0f },
                new Grading { Id = 466, MeasurementPointId = 82, SizeId = 37, Value = 0f },
                new Grading { Id = 467, MeasurementPointId = 82, SizeId = 38, Value = 0f }
                // NOTE: Seed Id 468 to 473 is used
            );
        }
    }
}
