using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Persistence.Migrations
{
    public partial class _2nd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3a4034fe-8efd-47c8-9176-8e50106493df", "AQAAAAEAACcQAAAAEMWm+Gk4LhJTV48ytD3INWqQ57kjs5kVdeoY2rkZNObbQvdqgH36EZ6hMF4b4Wft9w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e38e814f-3554-4c7b-b200-9d9b77dd4ce1", "AQAAAAEAACcQAAAAEHk3tm6PzhHX3itHTxSNU3k0oUhQhEY2RBEswBqAemTJO7y3uqog5CTENEj5vqEUfw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "44dbd80f-b8d3-4ed0-9a74-2390702de2d9", "AQAAAAEAACcQAAAAEG0ZGOmd2jUOX50GkFY1HhJV7p2nmJ2x6hD53+6HNBr2N3coo8c6B9u7jMkLux3Z8w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "c29fd212-ce4e-46dc-ad0d-12a2c4d9dbcc");

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
                    { 38, 8, 3, 34f }
                });

            migrationBuilder.InsertData(
                table: "Gradings",
                columns: new[] { "Id", "MeasurementPointId", "SizeId", "Value" },
                values: new object[,]
                {
                    { 39, 8, 4, 2f },
                    { 40, 8, 5, 2f },
                    { 41, 9, 1, -1f },
                    { 42, 9, 2, -1f },
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
                    { 80, 16, 10, 2f }
                });

            migrationBuilder.InsertData(
                table: "Gradings",
                columns: new[] { "Id", "MeasurementPointId", "SizeId", "Value" },
                values: new object[,]
                {
                    { 81, 17, 6, -2f },
                    { 82, 17, 7, -2f },
                    { 83, 17, 8, 30f },
                    { 84, 17, 9, 2f },
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
                    { 122, 25, 7, -0.5f }
                });

            migrationBuilder.InsertData(
                table: "Gradings",
                columns: new[] { "Id", "MeasurementPointId", "SizeId", "Value" },
                values: new object[,]
                {
                    { 123, 25, 8, 16f },
                    { 124, 25, 9, 1f },
                    { 125, 25, 10, 1f },
                    { 126, 26, 6, -0.5f },
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
                    { 164, 33, 14, 2f }
                });

            migrationBuilder.InsertData(
                table: "Gradings",
                columns: new[] { "Id", "MeasurementPointId", "SizeId", "Value" },
                values: new object[,]
                {
                    { 165, 33, 15, 2f },
                    { 166, 34, 11, -0.5f },
                    { 167, 34, 12, -0.5f },
                    { 168, 34, 13, 60f },
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
                    { 206, 42, 11, 0f }
                });

            migrationBuilder.InsertData(
                table: "Gradings",
                columns: new[] { "Id", "MeasurementPointId", "SizeId", "Value" },
                values: new object[,]
                {
                    { 207, 42, 12, 0f },
                    { 208, 42, 13, 1.8f },
                    { 209, 42, 14, 0f },
                    { 210, 42, 15, 0f },
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
                    { 248, 49, 18, 60f }
                });

            migrationBuilder.InsertData(
                table: "Gradings",
                columns: new[] { "Id", "MeasurementPointId", "SizeId", "Value" },
                values: new object[,]
                {
                    { 249, 49, 19, 1f },
                    { 250, 49, 20, 1f },
                    { 251, 50, 16, -0.5f },
                    { 252, 50, 17, -0.5f },
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
                    { 290, 57, 20, 0f }
                });

            migrationBuilder.InsertData(
                table: "Gradings",
                columns: new[] { "Id", "MeasurementPointId", "SizeId", "Value" },
                values: new object[,]
                {
                    { 291, 58, 16, 0f },
                    { 292, 58, 17, 0f },
                    { 293, 58, 18, 8f },
                    { 294, 58, 19, 0.5f },
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
                    { 332, 64, 24, 0f }
                });

            migrationBuilder.InsertData(
                table: "Gradings",
                columns: new[] { "Id", "MeasurementPointId", "SizeId", "Value" },
                values: new object[,]
                {
                    { 333, 64, 25, 0f },
                    { 334, 64, 26, 0f },
                    { 335, 65, 21, -1.5f },
                    { 336, 65, 22, 33.5f },
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
                    { 374, 67, 24, 0f }
                });

            migrationBuilder.InsertData(
                table: "Gradings",
                columns: new[] { "Id", "MeasurementPointId", "SizeId", "Value" },
                values: new object[,]
                {
                    { 375, 67, 25, 0f },
                    { 376, 67, 26, 0f },
                    { 377, 68, 21, -0.75f },
                    { 378, 68, 22, 17.75f },
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
                    { 417, 74, 30, 0f }
                });

            migrationBuilder.InsertData(
                table: "Gradings",
                columns: new[] { "Id", "MeasurementPointId", "SizeId", "Value" },
                values: new object[,]
                {
                    { 418, 74, 31, 2f },
                    { 419, 74, 32, 0f },
                    { 420, 75, 27, -5f },
                    { 421, 75, 28, -5f },
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
                    { 459, 81, 36, 0f }
                });

            migrationBuilder.InsertData(
                table: "Gradings",
                columns: new[] { "Id", "MeasurementPointId", "SizeId", "Value" },
                values: new object[,]
                {
                    { 460, 81, 37, 0f },
                    { 461, 81, 38, 0f },
                    { 462, 82, 33, 0f },
                    { 463, 82, 34, 0f },
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Gradings",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2fe43c9e-d0c6-4f67-baa4-c99a299961b4", "AQAAAAEAACcQAAAAELRE2U++Gy5tpt14HJwPYhq9ajSivlhSG5GcswQBL8VJYksLvlAQ+usbRS0U9/ro8Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1b915ffa-abad-4634-adaa-2846ffbeb45c", "AQAAAAEAACcQAAAAEC+YnvFVuxAmKqAGR/LKegAk6oTQxT/FNmFLcnl/rajMs3nsKMMIP6SwyF+iQ4RzqA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "13e37366-853b-4c5c-b2e0-863749e17c10", "AQAAAAEAACcQAAAAEJpzhO5NAlfyi/JvDdn1Pob6nRD1Z7bgx9s98Zreq6kQHG6D2/2tABfAovtIxd/cRw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "deb770e8-9965-421e-adb7-e27663716c5b");
        }
    }
}
