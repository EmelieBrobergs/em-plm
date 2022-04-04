using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Persistence.Migrations
{
    public partial class _1st : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Styles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StyleNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssignedToUserId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductGroup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tags = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Styles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Styles_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fittings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StyleId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fittings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fittings_Styles_StyleId",
                        column: x => x.StyleId,
                        principalTable: "Styles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Measurements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentMeasurementId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UnitOfMeasure = table.Column<int>(type: "int", nullable: false),
                    StyleId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Measurements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Measurements_Measurements_ParentMeasurementId",
                        column: x => x.ParentMeasurementId,
                        principalTable: "Measurements",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Measurements_Styles_StyleId",
                        column: x => x.StyleId,
                        principalTable: "Styles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MeasurementPoints",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShortName = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Tolerance = table.Column<float>(type: "real", nullable: true),
                    MeasurementId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeasurementPoints", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MeasurementPoints_Measurements_MeasurementId",
                        column: x => x.MeasurementId,
                        principalTable: "Measurements",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SizeRanges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BaseSizeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MeasurementId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SizeRanges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SizeRanges_Measurements_MeasurementId",
                        column: x => x.MeasurementId,
                        principalTable: "Measurements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderdIndex = table.Column<int>(type: "int", nullable: false),
                    SizeRangeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sizes_SizeRanges_SizeRangeId",
                        column: x => x.SizeRangeId,
                        principalTable: "SizeRanges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Gradings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SizeId = table.Column<int>(type: "int", nullable: false),
                    MeasurementPointId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gradings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gradings_MeasurementPoints_MeasurementPointId",
                        column: x => x.MeasurementPointId,
                        principalTable: "MeasurementPoints",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Gradings_Sizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Sizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Bruw Brey" },
                    { 2, "Allissons CO" },
                    { 3, "Bellaroom" },
                    { 4, "Dreeble" },
                    { 5, "Emelie style" },
                    { 6, "Jesus Bak & Slakt AB" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CompanyId", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, 1, "2fe43c9e-d0c6-4f67-baa4-c99a299961b4", "em@mail.com", true, "Emssi", "House", false, null, "EM@MAIL.COM", "EMHOUSE", "AQAAAAEAACcQAAAAELRE2U++Gy5tpt14HJwPYhq9ajSivlhSG5GcswQBL8VJYksLvlAQ+usbRS0U9/ro8Q==", null, false, null, false, "emhouse" },
                    { 2, 0, 3, "1b915ffa-abad-4634-adaa-2846ffbeb45c", "bella@mail.com", false, "Bella", "House", false, null, "BELLA@MAIL.COM", "BELLA@MAIL.COM", "AQAAAAEAACcQAAAAEC+YnvFVuxAmKqAGR/LKegAk6oTQxT/FNmFLcnl/rajMs3nsKMMIP6SwyF+iQ4RzqA==", null, false, null, false, "bella@mail.com" },
                    { 3, 0, 1, "13e37366-853b-4c5c-b2e0-863749e17c10", "b@mail.com", false, "Basic", "House", false, null, "B@MAIL.COM", "B@MAIL.COM", "AQAAAAEAACcQAAAAEJpzhO5NAlfyi/JvDdn1Pob6nRD1Z7bgx9s98Zreq6kQHG6D2/2tABfAovtIxd/cRw==", null, false, null, false, "b@mail.com" },
                    { 4, 0, 1, "deb770e8-9965-421e-adb7-e27663716c5b", "emma@mail.com", true, "Emma", "House", false, null, "EMMA@MAIL.COM", "EMMAH", null, null, false, null, false, "emmah" }
                });

            migrationBuilder.InsertData(
                table: "Styles",
                columns: new[] { "Id", "AssignedToUserId", "CompanyId", "Description", "Name", "OrderNumber", "ProductGroup", "ProductType", "StyleNumber", "Tags" },
                values: new object[,]
                {
                    { 1, 4, 1, "Classic trouser with low wist and staight leg.", "Tshirt Smile", "lkj76aa4-12", "Women top", "Tricot", "a0", "t-shirt,chestpocket,off-shoulder" },
                    { 2, 4, 1, "Lose fitted long sleeve shirt with tilored fitt at waist. Print at center front chest.", "Lounge shirt", "aaqs21", "High fashion", "Tricot", "a1", "chestprint,figure,long-sleeve" },
                    { 3, 4, 1, "Seamless yoga pants in elastic organic cotton mixed with elastane. High waist and pocket on left thigh.", "Yoga tights", "123abc", "Women Sport", "Training", "a2", "compress,lycra" },
                    { 4, 1, 1, "Lorem ipsum hapsum di ab sa nog live av list mos dent italid flori data min gonsedl moli.", "Vivvi", "AW22-981", "Underwear", "Bikini top", "a3", "mockfabric,brazilian" },
                    { 5, 1, 1, "Lorem ipsum hapsum di ab sa nog live av list mos dent italid flori data min gonsedl moli.", "Annz", "AW22-982", "Underwear", "Bikini top", "a4", "mockfabric,triangle,fashion" },
                    { 6, 1, 1, "Lorem ipsum hapsum di ab sa nog live av list mos dent italid flori data min gonsedl moli.", "Vivvi", "AW22-983", "Underwear", "Bikini bottom", "a5", "highwaist,wideside,compression" },
                    { 7, 1, 1, "Lorem ipsum hapsum di ab sa nog live av list mos dent italid flori data min gonsedl moli.", "Annz", "AW22-984", "Underwear", "Bikini bottom", "a6", "regularFitt,noseams" },
                    { 8, 4, 1, "Lorem ipsum hapsum di ab sa nog live av list mos dent italid flori data min gonsedl moli.", "Elsa swim", "AW22-985", "Underwear", "Swimsuit child", "a7", "skirt,crossback" },
                    { 9, 4, 1, "Lorem ipsum hapsum di ab sa nog live av list mos dent italid flori data min gonsedl moli.", "Elva yos", "AW22-986", "Sport", "Yoga pants", "a8", "looseleg,wideleg,highwaist,foldedwaistband" },
                    { 10, 4, 1, "Lorem ipsum hapsum di ab sa nog live av list mos dent italid flori data min gonsedl moli.", "Elva pas", "AW22-987", "Sport", "Yoga pants", "a9", "straightleg,highwaist,7/8-length" },
                    { 11, 4, 1, "Lorem ipsum hapsum di ab sa nog live av list mos dent italid flori data min gonsedl moli.", "Pas esma", "AW22-988", "Sport", "Yoga top", "b1", "loosefitt,tshirt,openback" },
                    { 12, 4, 1, "Lorem ipsum hapsum di ab sa nog live av list mos dent italid flori data min gonsedl moli.", "Seamless Ribb Tights", "AW22-989", "Sport", "Tights", "b2", "compression,legpocket,7/8-length" },
                    { 13, 4, 1, "Lorem ipsum hapsum di ab sa nog live av list mos dent italid flori data min gonsedl moli.", "Fancyann Tights", "AW22-921", "Sport", "Tights", "b3", "thinfabric,waistpocket,full-length" },
                    { 14, 3, 1, "Lorem ipsum hapsum di ab sa nog live av list mos dent italid flori data min gonsedl moli.", "Seamless Anna Top", "AW22-922", "Sport", "Bra", "b4", "crossback,keypocket,padding" },
                    { 15, 4, 1, "Lorem ipsum hapsum di ab sa nog live av list mos dent italid flori data min gonsedl moli.", "Lova Top", "AW22-923", "Sport", "Bra", "b5", "compression,nopadding,v-ring" },
                    { 16, 3, 1, "Lose fitted bluse in shire vowen satin with voulumos sleev with elastic mudd.", "Lovalia", "AW22-924", "Tricot", "Long dress", "b6", "volumeskirt,strassfeeling,summerdress" },
                    { 17, 4, 1, "Lorem ipsum hapsum di ab sa nog live av list mos dent italid flori data min gonsedl moli.", "Jhonna printed dress", "AW22-925", "Tricot", "Short dress", "b7", "classic,tailoredfitt,elastic" },
                    { 18, 4, 1, "Lorem ipsum hapsum di ab sa nog live av list mos dent italid flori data min gonsedl moli.", "Alva ", "AW22-926", "Tricot", "Pants", "b8", "classic,tailoredfitt,elastic" },
                    { 19, 3, 1, "Lorem ipsum hapsum di ab sa nog live av list mos dent italid flori data min gonsedl moli.", "Alva ankle length", "AW22-927", "Tricot", "Pants", "b9", "7/8-length,elasticwaist,nice" },
                    { 20, 4, 1, "Lorem ipsum hapsum di ab sa nog live av list mos dent italid flori data min gonsedl moli.", "Flica Basic T-shirt", "AW22-928", "Tricot", "T-shirt", "c1", "highfashion,spring32,londonCollection,colab-joss" },
                    { 21, null, 1, "Lorem ipsum hapsum di ab sa nog live av list mos dent italid flori data min gonsedl moli.", "Flica Basic Blouse", "AW22-929", "Light vowen", "Blouse", "c2", "colab-joss,premium,classic" },
                    { 22, null, 1, "Lorem ipsum hapsum di ab sa nog live av list mos dent italid flori data min gonsedl moli.", "Nna Shirt", "AW22-871", "Light vowen", "Shirt", "c3", "colab-elsa,premium,classic" },
                    { 23, 2, 3, "Denna tillhör företag 3 och ska endast synas på dennes användares inlogg! :).", "Yoga", "AW22-872", "Light vowen", "Blouse", "c4", "colab-elsa,premium,classic" },
                    { 24, null, 3, "Lorem lipsum comapny 3 here", "Yoga no.3", "AW22-873", "Yoga", "Pants women", "c5", "colab-elsa,premium,classic" }
                });

            migrationBuilder.InsertData(
                table: "Measurements",
                columns: new[] { "Id", "Name", "ParentMeasurementId", "StyleId", "UnitOfMeasure" },
                values: new object[,]
                {
                    { 1, "1st", null, 1, 0 },
                    { 2, "2nd", null, 1, 0 },
                    { 3, "3d", null, 1, 0 },
                    { 5, "1st", null, 3, 0 },
                    { 6, "1st", null, 4, 0 },
                    { 7, "2nd", null, 4, 0 }
                });

            migrationBuilder.InsertData(
                table: "MeasurementPoints",
                columns: new[] { "Id", "Description", "MeasurementId", "ShortName", "Tolerance" },
                values: new object[,]
                {
                    { 1, "½ chest", 1, "A", 0.5f },
                    { 2, "½ waist", 1, "B", 0.5f },
                    { 3, "½ hip", 1, "C", 0.5f },
                    { 4, "Front length from HPS", 1, "D", 1f },
                    { 5, "Neck width", 1, "E", 0.5f },
                    { 6, "Neck drop front", 1, "F", 0.25f },
                    { 7, "Neck drop back", 1, "G", 0.25f },
                    { 8, "Across shoulder", 1, "H", 0.5f },
                    { 9, "Sleeve length from CB", 1, "I", 0.5f },
                    { 10, "½ upper sleeve with", 1, "J", 0.5f },
                    { 11, "½ sleeve opening", 1, "K", 0.5f },
                    { 12, "Neck rib height", 1, "L", 0.3f },
                    { 13, "Pocket width", 1, "M1", 0.3f },
                    { 14, "Pocket height", 1, "M2", 0.3f },
                    { 15, "Pocket from CF neck", 1, "M3", 0.5f },
                    { 16, "½ chest", 2, "A", 0.5f },
                    { 17, "½ waist", 2, "B", 0.5f },
                    { 18, "½ hip", 2, "C", 0.5f },
                    { 19, "Front length from HPS", 2, "D", 1f },
                    { 20, "Neck width", 2, "E", 0.5f },
                    { 21, "Neck drop front", 2, "F", 0.25f },
                    { 22, "Neck drop back", 2, "G", 0.25f },
                    { 23, "Across shoulder", 2, "H", 0.5f },
                    { 24, "Sleeve length from CB", 2, "I", 0.5f },
                    { 25, "½ upper sleeve with", 2, "J", 0.5f },
                    { 26, "½ sleeve opening", 2, "K", 0.5f },
                    { 27, "Neck rib height", 2, "L", 0.3f },
                    { 28, "Pocket width", 2, "M1", 0.3f },
                    { 29, "Pocket height", 2, "M2", 0.3f },
                    { 30, "Pocket placement from HPS", 2, "M3", 0.5f },
                    { 31, "½ chest", 3, "A", 0.5f },
                    { 32, "½ waist", 3, "B", 0.5f },
                    { 33, "½ hip", 3, "C", 0.5f },
                    { 34, "Front length from HPS", 3, "D", 1f },
                    { 35, "Neck width", 3, "E", 0.5f },
                    { 36, "Neck drop front", 3, "F", 0.25f },
                    { 37, "Neck drop back", 3, "G", 0.25f },
                    { 38, "Across shoulder", 3, "H", 0.5f },
                    { 39, "Sleeve length from CB", 3, "I", 0.5f },
                    { 40, "½ upper sleeve with", 3, "J", 0.5f },
                    { 41, "½ sleeve opening", 3, "K", 0.5f },
                    { 42, "Neck rib height", 3, "L", 0.3f }
                });

            migrationBuilder.InsertData(
                table: "MeasurementPoints",
                columns: new[] { "Id", "Description", "MeasurementId", "ShortName", "Tolerance" },
                values: new object[,]
                {
                    { 43, "Pocket width", 3, "M1", 0.3f },
                    { 44, "Pocket height", 3, "M2", 0.3f },
                    { 45, "Pocket placement from HPS", 3, "M3", 0.5f },
                    { 61, "½ waist, relaxed", 5, "A1", 0.5f },
                    { 62, "½ waist, extended", 5, "A2", null },
                    { 63, "½ waist, at seam", 5, "A3", 0.5f },
                    { 64, "Waistband height", 5, "A4", 0.3f },
                    { 65, "½ hip, 8cm from waist seam at CF", 5, "B", 0.5f },
                    { 66, "½ thigh", 5, "C", 0.5f },
                    { 67, "mudd height", 5, "D3", 0.3f },
                    { 68, "CF length", 5, "E", 0.5f },
                    { 69, "Cb length", 5, "F", 0.5f },
                    { 70, "Inseam length", 5, "G", 0.5f },
                    { 71, "Cup height", 6, "A", 0.5f },
                    { 72, "Cup width, at bottom", 6, "B1", 0.5f },
                    { 73, "Cup width, at ½ height", 6, "B2", 0.5f },
                    { 74, "String length, at neck", 6, "C", 0.5f },
                    { 75, "String length, at waist", 6, "D", 0.5f },
                    { 76, "Cup height", 6, "A", 0.5f },
                    { 77, "Cup width, at bottom", 6, "B1", 0.5f },
                    { 78, "Cup width, at ½ height", 6, "B2", 0.5f },
                    { 79, "String length, at neck", 6, "C", 0.5f },
                    { 80, "String length, at waist", 6, "D", 2f },
                    { 81, "Print width", 6, "1", 0.3f },
                    { 82, "Print placement from seam", 6, "2", 0.3f },
                    { 83, "Shoulderslope", 3, "1", 0.2f },
                    { 85, "½ knee, at ½ inseam", 5, "C", 0.5f },
                    { 86, "½ leg opening,5cm above seam", 5, "D1", 0.5f },
                    { 87, "½ leg opening", 5, "D2", 0.3f },
                    { 88, "String length at waist", 5, "A5", 0.5f }
                });

            migrationBuilder.InsertData(
                table: "Measurements",
                columns: new[] { "Id", "Name", "ParentMeasurementId", "StyleId", "UnitOfMeasure" },
                values: new object[] { 4, "1st", 3, 2, 0 });

            migrationBuilder.InsertData(
                table: "SizeRanges",
                columns: new[] { "Id", "BaseSizeName", "MeasurementId" },
                values: new object[,]
                {
                    { 1, "M", 1 },
                    { 2, "M", 2 },
                    { 3, "M", 3 },
                    { 5, "36", 5 },
                    { 6, "38", 6 },
                    { 7, "38", 7 }
                });

            migrationBuilder.InsertData(
                table: "MeasurementPoints",
                columns: new[] { "Id", "Description", "MeasurementId", "ShortName", "Tolerance" },
                values: new object[,]
                {
                    { 46, "½ chest", 4, "A", 0.5f },
                    { 47, "½ waist", 4, "B", 0.5f },
                    { 48, "½ hip", 4, "C", 0.5f },
                    { 49, "Front length from HPS", 4, "D", 1f },
                    { 50, "Neck width", 4, "E", 0.5f },
                    { 51, "Neck drop front", 4, "F", 0.25f },
                    { 52, "Neck drop back", 4, "G", 0.25f },
                    { 53, "Shoulder width", 4, "H", 0.5f },
                    { 54, "Sleeve length from CB", 4, "I", 0.5f },
                    { 55, "½ upper sleeve with", 4, "J", 0.5f },
                    { 56, "½ sleeve opening", 4, "K", 0.5f },
                    { 57, "Neck rib height", 4, "L", 0.3f },
                    { 58, "Print width", 4, "M1", 0.3f },
                    { 59, "Print height", 4, "M2", 0.3f },
                    { 60, "Print placement from HPS", 4, "M3", 0.5f },
                    { 84, "Shoulderslope", 4, "1", 0.2f }
                });

            migrationBuilder.InsertData(
                table: "SizeRanges",
                columns: new[] { "Id", "BaseSizeName", "MeasurementId" },
                values: new object[] { 4, "M", 4 });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "Name", "OrderdIndex", "SizeRangeId" },
                values: new object[,]
                {
                    { 1, "XS", 1, 1 },
                    { 2, "S", 2, 1 },
                    { 3, "M", 3, 1 },
                    { 4, "L", 4, 1 },
                    { 5, "XL", 5, 1 },
                    { 6, "XS", 1, 2 },
                    { 7, "S", 2, 2 },
                    { 8, "M", 3, 2 },
                    { 9, "L", 4, 2 },
                    { 10, "XL", 5, 2 },
                    { 11, "XS", 1, 3 },
                    { 12, "S", 2, 3 },
                    { 13, "M", 3, 3 },
                    { 14, "L", 4, 3 },
                    { 15, "XL", 5, 3 },
                    { 16, "XS", 1, 3 },
                    { 17, "S", 2, 3 },
                    { 18, "M", 3, 3 },
                    { 19, "L", 4, 3 },
                    { 20, "XL", 5, 3 },
                    { 21, "34", 1, 3 },
                    { 22, "36", 2, 3 },
                    { 23, "38", 3, 3 },
                    { 24, "40", 4, 3 },
                    { 25, "42", 5, 3 }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "Name", "OrderdIndex", "SizeRangeId" },
                values: new object[,]
                {
                    { 26, "44", 6, 3 },
                    { 27, "34", 1, 3 },
                    { 28, "36", 2, 3 },
                    { 29, "38", 3, 3 },
                    { 30, "40", 4, 3 },
                    { 31, "42", 5, 3 },
                    { 32, "44", 6, 3 },
                    { 33, "34", 1, 3 },
                    { 34, "36", 2, 3 },
                    { 35, "38", 3, 3 },
                    { 36, "40", 4, 3 },
                    { 37, "42", 5, 3 },
                    { 38, "44", 6, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CompanyId",
                table: "AspNetUsers",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Email",
                table: "AspNetUsers",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_Name",
                table: "Companies",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Fittings_StyleId",
                table: "Fittings",
                column: "StyleId");

            migrationBuilder.CreateIndex(
                name: "IX_Gradings_MeasurementPointId",
                table: "Gradings",
                column: "MeasurementPointId");

            migrationBuilder.CreateIndex(
                name: "IX_Gradings_SizeId",
                table: "Gradings",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_MeasurementPoints_MeasurementId",
                table: "MeasurementPoints",
                column: "MeasurementId");

            migrationBuilder.CreateIndex(
                name: "IX_Measurements_ParentMeasurementId",
                table: "Measurements",
                column: "ParentMeasurementId");

            migrationBuilder.CreateIndex(
                name: "IX_Measurements_StyleId",
                table: "Measurements",
                column: "StyleId");

            migrationBuilder.CreateIndex(
                name: "IX_SizeRanges_MeasurementId",
                table: "SizeRanges",
                column: "MeasurementId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sizes_SizeRangeId",
                table: "Sizes",
                column: "SizeRangeId");

            migrationBuilder.CreateIndex(
                name: "IX_Styles_CompanyId",
                table: "Styles",
                column: "CompanyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Fittings");

            migrationBuilder.DropTable(
                name: "Gradings");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "MeasurementPoints");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "SizeRanges");

            migrationBuilder.DropTable(
                name: "Measurements");

            migrationBuilder.DropTable(
                name: "Styles");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
