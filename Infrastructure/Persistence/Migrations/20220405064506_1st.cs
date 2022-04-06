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
                    StyleNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    { 1, 0, 1, "3bc6f3bb-447d-4e5e-b93c-9a1f8e625b45", "em@mail.com", true, "Emssi", "House", false, null, "EM@MAIL.COM", "EMHOUSE", "AQAAAAEAACcQAAAAELSyxmhcuw22ywBPlYjNtUsu1UdydA9ls5EJxXvNdPv+l36tjqTx+Y9DKFbnO83EkQ==", null, false, null, false, "emhouse" },
                    { 2, 0, 3, "2a86854f-d9f4-43ad-b621-102c74a04829", "bella@mail.com", false, "Bella", "House", false, null, "BELLA@MAIL.COM", "BELLA@MAIL.COM", "AQAAAAEAACcQAAAAEKHmANPEsqPLttMVo/DNFC4Q870J+5g1juPzhXg8KZA0u7ttafuDCk3Aus1xw4NCHQ==", null, false, null, false, "bella@mail.com" },
                    { 3, 0, 1, "6a645d57-c935-44ef-ac6e-a1a26e0e2a31", "b@mail.com", false, "Basic", "House", false, null, "B@MAIL.COM", "B@MAIL.COM", "AQAAAAEAACcQAAAAEMrq7ldGvaelTVPuAegir8IatP+yDAN6p4/WEkkfQHBCdjCRtilLZPBEWbRTGBLqjQ==", null, false, null, false, "b@mail.com" },
                    { 4, 0, 1, "008bf76a-b23c-4d5d-8e7b-b7e76cf6161a", "emma@mail.com", true, "Emma", "House", false, null, "EMMA@MAIL.COM", "EMMAH", "AQAAAAEAACcQAAAAECQW1KMTteqIfqpna/Kx1IY8MdFUMl8X2ORxAs6rbDJi797dYh63u0+GBut6VJMHtQ==", null, false, null, false, "emmah" }
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
                    { 67, "mudd height", 5, "1", 0.3f },
                    { 68, "CF length", 5, "F1", 0.5f },
                    { 69, "Cb length", 5, "F2", 0.5f },
                    { 70, "Inseam length", 5, "G", 0.5f },
                    { 71, "Cup height", 6, "A", 0.5f },
                    { 72, "Cup width, at bottom", 6, "B1", 0.5f },
                    { 73, "Cup width, at ½ height", 6, "B2", 0.5f },
                    { 74, "String length, at neck", 6, "C", 0.5f },
                    { 75, "String length, at waist", 6, "D", 0.5f },
                    { 76, "Cup height", 7, "A", 0.5f },
                    { 77, "Cup width, at bottom", 7, "B1", 0.5f },
                    { 78, "Cup width, at ½ height", 7, "B2", 0.5f },
                    { 79, "String length, at neck", 7, "C", 0.5f },
                    { 80, "String length, at waist", 7, "D", 2f },
                    { 81, "Print width", 7, "1", 0.3f },
                    { 82, "Print placement from seam", 7, "2", 0.3f },
                    { 83, "Shoulderslope", 3, "1", 0.2f },
                    { 85, "½ knee, at ½ inseam", 5, "D", 0.5f },
                    { 86, "½ leg opening,5cm above seam", 5, "E1", 0.5f },
                    { 87, "½ leg opening", 5, "E2", 0.3f },
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

            migrationBuilder.InsertData(
                table: "Gradings",
                columns: new[] { "Id", "MeasurementPointId", "SizeId", "Value" },
                values: new object[,]
                {
                    { 1, 1, 1, -2f },
                    { 2, 1, 2, -2f },
                    { 3, 1, 3, 33f },
                    { 4, 1, 4, 2f },
                    { 5, 1, 5, 2f },
                    { 6, 2, 1, -2f },
                    { 7, 2, 2, -2f },
                    { 8, 2, 3, 30f },
                    { 9, 2, 4, 2f },
                    { 10, 2, 5, 2f },
                    { 11, 3, 1, -2f },
                    { 12, 3, 2, -2f },
                    { 13, 3, 3, 31.5f },
                    { 14, 3, 4, 2f },
                    { 15, 3, 5, 2f },
                    { 16, 4, 1, -0.5f },
                    { 17, 4, 2, -0.5f },
                    { 18, 4, 3, 61f },
                    { 19, 4, 4, 1f },
                    { 20, 4, 5, 1f },
                    { 21, 5, 1, -0.5f },
                    { 22, 5, 2, -0.5f },
                    { 23, 5, 3, 15f },
                    { 24, 5, 4, 0.5f },
                    { 25, 5, 5, 0.5f },
                    { 26, 6, 1, -0.5f },
                    { 27, 6, 2, -0.5f },
                    { 28, 6, 3, 12f },
                    { 29, 6, 4, 0.5f },
                    { 30, 6, 5, 0.5f },
                    { 31, 7, 1, -0.5f },
                    { 32, 7, 2, -0.5f },
                    { 33, 7, 3, 12f },
                    { 34, 7, 4, 0.5f },
                    { 35, 7, 5, 0.5f },
                    { 36, 8, 1, -1f },
                    { 37, 8, 2, -1f },
                    { 38, 8, 3, 34f },
                    { 39, 8, 4, 2f },
                    { 40, 8, 5, 2f },
                    { 41, 9, 1, -1f },
                    { 42, 9, 2, -1f }
                });

            migrationBuilder.InsertData(
                table: "Gradings",
                columns: new[] { "Id", "MeasurementPointId", "SizeId", "Value" },
                values: new object[,]
                {
                    { 43, 9, 3, 27f },
                    { 44, 9, 4, 1.5f },
                    { 45, 9, 5, 1.5f },
                    { 46, 10, 1, -0.5f },
                    { 47, 10, 2, -0.5f },
                    { 48, 10, 3, 16f },
                    { 49, 10, 4, 1f },
                    { 50, 10, 5, 1f },
                    { 51, 11, 1, -0.25f },
                    { 52, 11, 2, -0.25f },
                    { 53, 11, 3, 16f },
                    { 54, 11, 4, 0.5f },
                    { 55, 11, 5, 0.5f },
                    { 56, 12, 1, 0f },
                    { 57, 12, 2, 0f },
                    { 58, 12, 3, 1.8f },
                    { 59, 12, 4, 0f },
                    { 60, 12, 5, 0f },
                    { 61, 13, 1, 0f },
                    { 62, 13, 2, 0f },
                    { 63, 13, 3, 11f },
                    { 64, 13, 4, 0.5f },
                    { 65, 13, 5, 0f },
                    { 66, 14, 1, 0f },
                    { 67, 14, 2, 0f },
                    { 68, 14, 3, 11f },
                    { 69, 14, 4, 1f },
                    { 70, 14, 5, 0f },
                    { 71, 15, 1, 0f },
                    { 72, 15, 2, 0f },
                    { 73, 15, 3, 4f },
                    { 74, 15, 4, 0f },
                    { 75, 15, 5, 0f },
                    { 76, 16, 6, -2f },
                    { 77, 16, 7, -2f },
                    { 78, 16, 8, 33f },
                    { 79, 16, 9, 2f },
                    { 80, 16, 10, 2f },
                    { 81, 17, 6, -2f },
                    { 82, 17, 7, -2f },
                    { 83, 17, 8, 30f },
                    { 84, 17, 9, 2f }
                });

            migrationBuilder.InsertData(
                table: "Gradings",
                columns: new[] { "Id", "MeasurementPointId", "SizeId", "Value" },
                values: new object[,]
                {
                    { 85, 17, 10, 2f },
                    { 86, 18, 6, -2f },
                    { 87, 18, 7, -2f },
                    { 88, 18, 8, 31.5f },
                    { 89, 18, 9, 2f },
                    { 90, 18, 10, 2f },
                    { 91, 19, 6, -0.5f },
                    { 92, 19, 7, -0.5f },
                    { 93, 19, 8, 61f },
                    { 94, 19, 9, 1f },
                    { 95, 19, 10, 1f },
                    { 96, 20, 6, -0.5f },
                    { 97, 20, 7, -0.5f },
                    { 98, 20, 8, 15f },
                    { 99, 20, 9, 0.5f },
                    { 100, 20, 10, 0.5f },
                    { 101, 21, 6, -0.5f },
                    { 102, 21, 7, -0.5f },
                    { 103, 21, 8, 12.5f },
                    { 104, 21, 9, 0.5f },
                    { 105, 21, 10, 0.5f },
                    { 106, 22, 6, -0.5f },
                    { 107, 22, 7, -0.5f },
                    { 108, 22, 8, 12f },
                    { 109, 22, 9, 0.5f },
                    { 110, 22, 10, 0.5f },
                    { 111, 23, 6, -1f },
                    { 112, 23, 7, -1f },
                    { 113, 23, 8, 33f },
                    { 114, 23, 9, 2f },
                    { 115, 23, 10, 2f },
                    { 116, 24, 6, -1f },
                    { 117, 24, 7, -1f },
                    { 118, 24, 8, 27f },
                    { 119, 24, 9, 1.5f },
                    { 120, 24, 10, 1.5f },
                    { 121, 25, 6, -0.5f },
                    { 122, 25, 7, -0.5f },
                    { 123, 25, 8, 16f },
                    { 124, 25, 9, 1f },
                    { 125, 25, 10, 1f },
                    { 126, 26, 6, -0.5f }
                });

            migrationBuilder.InsertData(
                table: "Gradings",
                columns: new[] { "Id", "MeasurementPointId", "SizeId", "Value" },
                values: new object[,]
                {
                    { 127, 26, 7, -0.5f },
                    { 128, 26, 8, 14f },
                    { 129, 26, 9, 0.5f },
                    { 130, 26, 10, 0.5f },
                    { 131, 27, 6, 0f },
                    { 132, 27, 7, 0f },
                    { 133, 27, 8, 1.8f },
                    { 134, 27, 9, 0f },
                    { 135, 27, 10, 0f },
                    { 136, 28, 6, 0f },
                    { 137, 28, 7, 0f },
                    { 138, 28, 8, 11f },
                    { 139, 28, 9, 0.5f },
                    { 140, 28, 10, 0f },
                    { 141, 29, 6, 0f },
                    { 142, 29, 7, 0f },
                    { 143, 29, 8, 11f },
                    { 144, 29, 9, 1f },
                    { 145, 29, 10, 0f },
                    { 146, 30, 6, -0.5f },
                    { 147, 30, 7, -0.5f },
                    { 148, 30, 8, 16.5f },
                    { 149, 30, 9, 0.5f },
                    { 150, 30, 10, 0.5f },
                    { 151, 31, 11, -2f },
                    { 152, 31, 12, -2f },
                    { 153, 31, 13, 33f },
                    { 154, 31, 14, 2f },
                    { 155, 31, 15, 2f },
                    { 156, 32, 11, -2f },
                    { 157, 32, 12, -2f },
                    { 158, 32, 13, 30f },
                    { 159, 32, 14, 2f },
                    { 160, 32, 15, 2f },
                    { 161, 33, 11, -2f },
                    { 162, 33, 12, -2f },
                    { 163, 33, 13, 31f },
                    { 164, 33, 14, 2f },
                    { 165, 33, 15, 2f },
                    { 166, 34, 11, -0.5f },
                    { 167, 34, 12, -0.5f },
                    { 168, 34, 13, 60f }
                });

            migrationBuilder.InsertData(
                table: "Gradings",
                columns: new[] { "Id", "MeasurementPointId", "SizeId", "Value" },
                values: new object[,]
                {
                    { 169, 34, 14, 1f },
                    { 170, 34, 15, 1f },
                    { 171, 35, 11, -0.5f },
                    { 172, 35, 12, -0.5f },
                    { 173, 35, 13, 15f },
                    { 174, 35, 14, 0.5f },
                    { 175, 35, 15, 0.5f },
                    { 176, 36, 11, -0.5f },
                    { 177, 36, 12, -0.5f },
                    { 178, 36, 13, 12.5f },
                    { 179, 36, 14, 0.5f },
                    { 180, 36, 15, 0.5f },
                    { 181, 37, 11, -0.5f },
                    { 182, 37, 12, -0.5f },
                    { 183, 37, 13, 12f },
                    { 184, 37, 14, 0.5f },
                    { 185, 37, 15, 0.5f },
                    { 186, 38, 11, -1f },
                    { 187, 38, 12, -1f },
                    { 188, 38, 13, 33f },
                    { 189, 38, 14, 2f },
                    { 190, 38, 15, 2f },
                    { 191, 39, 11, -1f },
                    { 192, 39, 12, -1f },
                    { 193, 39, 13, 27f },
                    { 194, 39, 14, 1.5f },
                    { 195, 39, 15, 1.5f },
                    { 196, 40, 11, -0.5f },
                    { 197, 40, 12, -0.5f },
                    { 198, 40, 13, 16f },
                    { 199, 40, 14, 1f },
                    { 200, 40, 15, 1f },
                    { 201, 41, 11, -0.5f },
                    { 202, 41, 12, -0.5f },
                    { 203, 41, 13, 14f },
                    { 204, 41, 14, 0.5f },
                    { 205, 41, 15, 0.5f },
                    { 206, 42, 11, 0f },
                    { 207, 42, 12, 0f },
                    { 208, 42, 13, 1.8f },
                    { 209, 42, 14, 0f },
                    { 210, 42, 15, 0f }
                });

            migrationBuilder.InsertData(
                table: "Gradings",
                columns: new[] { "Id", "MeasurementPointId", "SizeId", "Value" },
                values: new object[,]
                {
                    { 211, 43, 11, 0f },
                    { 212, 43, 12, 0f },
                    { 213, 43, 13, 11f },
                    { 214, 43, 14, 0.5f },
                    { 215, 43, 15, 0f },
                    { 216, 44, 11, 0f },
                    { 217, 44, 12, 0f },
                    { 218, 44, 13, 11f },
                    { 219, 44, 14, 1f },
                    { 220, 44, 15, 0f },
                    { 221, 45, 11, -0.5f },
                    { 222, 45, 12, -0.5f },
                    { 223, 45, 13, 16.5f },
                    { 224, 45, 14, 0.5f },
                    { 225, 45, 15, 0.5f },
                    { 226, 83, 11, -0.2f },
                    { 227, 83, 12, -0.2f },
                    { 228, 83, 13, 4.5f },
                    { 229, 83, 14, 0.3f },
                    { 230, 83, 15, 0.3f },
                    { 231, 46, 16, -2f },
                    { 232, 46, 17, -2f },
                    { 233, 46, 18, 33f },
                    { 234, 46, 19, 2f },
                    { 235, 46, 20, 2f },
                    { 236, 47, 16, -2f },
                    { 237, 47, 17, -2f },
                    { 238, 47, 18, 30f },
                    { 239, 47, 19, 2f },
                    { 240, 47, 20, 2f },
                    { 241, 48, 16, -2f },
                    { 242, 48, 17, -2f },
                    { 243, 48, 18, 31f },
                    { 244, 48, 19, 2f },
                    { 245, 48, 20, 2f },
                    { 246, 49, 16, -0.5f },
                    { 247, 49, 17, -0.5f },
                    { 248, 49, 18, 60f },
                    { 249, 49, 19, 1f },
                    { 250, 49, 20, 1f },
                    { 251, 50, 16, -0.5f },
                    { 252, 50, 17, -0.5f }
                });

            migrationBuilder.InsertData(
                table: "Gradings",
                columns: new[] { "Id", "MeasurementPointId", "SizeId", "Value" },
                values: new object[,]
                {
                    { 253, 50, 18, 15f },
                    { 254, 50, 19, 0.5f },
                    { 255, 50, 20, 0.5f },
                    { 256, 51, 16, -0.5f },
                    { 257, 51, 17, -0.5f },
                    { 258, 51, 18, 12.5f },
                    { 259, 51, 19, 0.5f },
                    { 260, 51, 20, 0.5f },
                    { 261, 52, 16, -0.5f },
                    { 262, 52, 17, -0.5f },
                    { 263, 52, 18, 12f },
                    { 264, 52, 19, 0.5f },
                    { 265, 52, 20, 0.5f },
                    { 266, 53, 16, -1f },
                    { 267, 53, 17, -1f },
                    { 268, 53, 18, 33f },
                    { 269, 53, 19, 2f },
                    { 270, 53, 20, 2f },
                    { 271, 54, 16, -1f },
                    { 272, 54, 17, -1f },
                    { 273, 54, 18, 42f },
                    { 274, 54, 19, 1.5f },
                    { 275, 54, 20, 1.5f },
                    { 276, 55, 16, -0.5f },
                    { 277, 55, 17, -0.5f },
                    { 278, 55, 18, 15f },
                    { 279, 55, 19, 1f },
                    { 280, 55, 20, 1f },
                    { 281, 56, 16, -0.25f },
                    { 282, 56, 17, -0.25f },
                    { 283, 56, 18, 11f },
                    { 284, 56, 19, 0.5f },
                    { 285, 56, 20, 0.5f },
                    { 286, 57, 16, 0f },
                    { 287, 57, 17, 0f },
                    { 288, 57, 18, 1.8f },
                    { 289, 57, 19, 0f },
                    { 290, 57, 20, 0f },
                    { 291, 58, 16, 0f },
                    { 292, 58, 17, 0f },
                    { 293, 58, 18, 8f },
                    { 294, 58, 19, 0.5f }
                });

            migrationBuilder.InsertData(
                table: "Gradings",
                columns: new[] { "Id", "MeasurementPointId", "SizeId", "Value" },
                values: new object[,]
                {
                    { 295, 58, 20, 0f },
                    { 296, 59, 16, 0f },
                    { 297, 59, 17, 0f },
                    { 298, 59, 18, 1.8f },
                    { 299, 59, 19, 1f },
                    { 300, 59, 20, 0f },
                    { 301, 60, 16, -0.5f },
                    { 302, 60, 17, -0.5f },
                    { 303, 60, 18, 16.5f },
                    { 304, 60, 19, 0.5f },
                    { 305, 60, 20, 0.5f },
                    { 306, 84, 16, -0.2f },
                    { 307, 84, 17, -0.2f },
                    { 308, 84, 18, 4.5f },
                    { 309, 84, 19, 0.3f },
                    { 310, 84, 20, 0.3f },
                    { 311, 61, 21, -1.5f },
                    { 312, 61, 22, 27.5f },
                    { 313, 61, 23, 1.5f },
                    { 314, 61, 24, 1.5f },
                    { 315, 61, 25, 2f },
                    { 316, 61, 26, 2f },
                    { 317, 62, 21, -1.5f },
                    { 318, 62, 22, 32.5f },
                    { 319, 62, 23, 1.5f },
                    { 320, 62, 24, 1.5f },
                    { 321, 62, 25, 2f },
                    { 322, 62, 26, 2f },
                    { 323, 63, 21, -1.5f },
                    { 324, 63, 22, 29f },
                    { 325, 63, 23, 1.5f },
                    { 326, 63, 24, 1.5f },
                    { 327, 63, 25, 2f },
                    { 328, 63, 26, 2f },
                    { 329, 64, 21, 0f },
                    { 330, 64, 22, 18f },
                    { 331, 64, 23, 0f },
                    { 332, 64, 24, 0f },
                    { 333, 64, 25, 0f },
                    { 334, 64, 26, 0f },
                    { 335, 65, 21, -1.5f },
                    { 336, 65, 22, 33.5f }
                });

            migrationBuilder.InsertData(
                table: "Gradings",
                columns: new[] { "Id", "MeasurementPointId", "SizeId", "Value" },
                values: new object[,]
                {
                    { 337, 65, 23, 1.5f },
                    { 338, 65, 24, 1.5f },
                    { 339, 65, 25, 2f },
                    { 340, 65, 26, 2f },
                    { 341, 66, 21, -1.25f },
                    { 342, 66, 22, 18.75f },
                    { 343, 66, 23, 1.25f },
                    { 344, 66, 24, 1.5f },
                    { 345, 66, 25, 1.5f },
                    { 346, 66, 26, 1.75f },
                    { 347, 66, 21, -1.25f },
                    { 348, 66, 22, -17.75f },
                    { 349, 66, 23, 1.25f },
                    { 350, 66, 24, 1.5f },
                    { 351, 66, 25, 1.5f },
                    { 352, 66, 26, 1.75f },
                    { 353, 85, 21, -0.75f },
                    { 354, 85, 22, 12.75f },
                    { 355, 85, 23, 0.75f },
                    { 356, 85, 24, 0.75f },
                    { 357, 85, 25, 0.75f },
                    { 358, 85, 26, 1f },
                    { 359, 86, 21, -0.5f },
                    { 360, 86, 22, 14.5f },
                    { 361, 86, 23, 0.5f },
                    { 362, 86, 24, 0.5f },
                    { 363, 86, 25, 0.5f },
                    { 364, 86, 26, 0.75f },
                    { 365, 87, 21, -0.5f },
                    { 366, 87, 22, 14.5f },
                    { 367, 87, 23, 0.5f },
                    { 368, 87, 24, 0.5f },
                    { 369, 87, 25, 0.5f },
                    { 370, 87, 26, 0.75f },
                    { 371, 67, 21, 0f },
                    { 372, 67, 22, 6f },
                    { 373, 67, 23, 0f },
                    { 374, 67, 24, 0f },
                    { 375, 67, 25, 0f },
                    { 376, 67, 26, 0f },
                    { 377, 68, 21, -0.75f },
                    { 378, 68, 22, 17.75f }
                });

            migrationBuilder.InsertData(
                table: "Gradings",
                columns: new[] { "Id", "MeasurementPointId", "SizeId", "Value" },
                values: new object[,]
                {
                    { 379, 68, 23, 0.75f },
                    { 380, 68, 24, 0.75f },
                    { 381, 68, 25, 0.75f },
                    { 382, 68, 26, 1f },
                    { 384, 69, 21, -1.25f },
                    { 385, 69, 22, 24.75f },
                    { 386, 69, 23, 1.25f },
                    { 387, 69, 24, 1.5f },
                    { 388, 69, 25, 1.5f },
                    { 389, 69, 26, 1.75f },
                    { 390, 70, 21, 0f },
                    { 391, 70, 22, 67f },
                    { 392, 70, 23, 1f },
                    { 393, 70, 24, 0f },
                    { 394, 70, 25, 1.5f },
                    { 395, 70, 26, 0f },
                    { 396, 71, 27, -0.75f },
                    { 397, 71, 28, -0.75f },
                    { 398, 71, 29, 16.5f },
                    { 399, 71, 30, 0.75f },
                    { 400, 71, 31, 0.75f },
                    { 401, 71, 32, 0.75f },
                    { 402, 72, 27, -0.5f },
                    { 403, 72, 28, -0.5f },
                    { 404, 72, 29, 15f },
                    { 405, 72, 30, 0.5f },
                    { 406, 72, 31, 0.5f },
                    { 407, 72, 32, 0.75f },
                    { 408, 73, 27, -0.5f },
                    { 409, 73, 28, -0.5f },
                    { 410, 73, 29, 12.5f },
                    { 411, 73, 30, 0.5f },
                    { 412, 73, 31, 0.5f },
                    { 413, 73, 32, 0.75f },
                    { 414, 74, 27, 0f },
                    { 415, 74, 28, -2f },
                    { 416, 74, 29, 28f },
                    { 417, 74, 30, 0f },
                    { 418, 74, 31, 2f },
                    { 419, 74, 32, 0f },
                    { 420, 75, 27, -5f },
                    { 421, 75, 28, -5f }
                });

            migrationBuilder.InsertData(
                table: "Gradings",
                columns: new[] { "Id", "MeasurementPointId", "SizeId", "Value" },
                values: new object[,]
                {
                    { 422, 75, 29, 105f },
                    { 423, 75, 30, 5f },
                    { 424, 75, 31, 5f },
                    { 425, 75, 32, 5f },
                    { 426, 76, 33, -0.75f },
                    { 427, 76, 34, -0.75f },
                    { 428, 76, 35, 16.5f },
                    { 429, 76, 36, 0.75f },
                    { 430, 76, 37, 0.75f },
                    { 431, 76, 38, 0.75f },
                    { 432, 77, 33, -0.5f },
                    { 433, 77, 34, -0.5f },
                    { 434, 77, 35, 14f },
                    { 435, 77, 36, 0.5f },
                    { 436, 77, 37, 0.5f },
                    { 437, 77, 38, 0.75f },
                    { 438, 78, 33, -0.5f },
                    { 439, 78, 34, -0.5f },
                    { 440, 78, 35, 12.5f },
                    { 441, 78, 36, 0.5f },
                    { 442, 78, 37, 0.5f },
                    { 443, 78, 38, 0.75f },
                    { 444, 79, 33, 0f },
                    { 445, 79, 34, -2f },
                    { 446, 79, 35, 28f },
                    { 447, 79, 36, 0f },
                    { 448, 79, 37, 2f },
                    { 449, 79, 38, 0f },
                    { 450, 80, 33, -5f },
                    { 451, 80, 34, -5f },
                    { 452, 80, 35, 105f },
                    { 453, 80, 36, 5f },
                    { 454, 80, 37, 5f },
                    { 455, 80, 38, 5f },
                    { 456, 81, 33, 0f },
                    { 457, 81, 34, 0f },
                    { 458, 81, 35, 6f },
                    { 459, 81, 36, 0f },
                    { 460, 81, 37, 0f },
                    { 461, 81, 38, 0f },
                    { 462, 82, 33, 0f },
                    { 463, 82, 34, 0f }
                });

            migrationBuilder.InsertData(
                table: "Gradings",
                columns: new[] { "Id", "MeasurementPointId", "SizeId", "Value" },
                values: new object[,]
                {
                    { 464, 82, 35, 2f },
                    { 465, 82, 36, 0f },
                    { 466, 82, 37, 0f },
                    { 467, 82, 38, 0f },
                    { 468, 88, 21, 0f },
                    { 469, 88, 22, 11f },
                    { 470, 88, 23, 0f },
                    { 471, 88, 24, 0f },
                    { 472, 88, 25, 0f },
                    { 473, 88, 26, 0f }
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
                name: "IX_MeasurementPoints_ShortName_MeasurementId",
                table: "MeasurementPoints",
                columns: new[] { "ShortName", "MeasurementId" },
                unique: true,
                filter: "[MeasurementId] IS NOT NULL");

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

            migrationBuilder.CreateIndex(
                name: "IX_Styles_StyleNumber_CompanyId",
                table: "Styles",
                columns: new[] { "StyleNumber", "CompanyId" },
                unique: true);
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
