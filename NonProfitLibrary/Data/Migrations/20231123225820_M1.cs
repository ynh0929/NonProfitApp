using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NonProfitLibrary.Data.Migrations
{
    /// <inheritdoc />
    public partial class M1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContactLists",
                columns: table => new
                {
                    AccountNo = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Street = table.Column<string>(type: "TEXT", nullable: false),
                    City = table.Column<string>(type: "TEXT", nullable: false),
                    PostalCode = table.Column<string>(type: "TEXT", nullable: false),
                    Country = table.Column<string>(type: "TEXT", nullable: false),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Modified = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    ModifiedBy = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactLists", x => x.AccountNo);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethods",
                columns: table => new
                {
                    PaymentMethodId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Modified = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    ModifiedBy = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethods", x => x.PaymentMethodId);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransactionTypes",
                columns: table => new
                {
                    TransactionTypeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Modified = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    ModifiedBy = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionTypes", x => x.TransactionTypeId);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Donations",
                columns: table => new
                {
                    TransId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AccountNo = table.Column<int>(type: "INTEGER", nullable: false),
                    TransactionTypeId = table.Column<int>(type: "INTEGER", nullable: false),
                    Amount = table.Column<float>(type: "REAL", nullable: false),
                    PaymentMethodId = table.Column<int>(type: "INTEGER", nullable: false),
                    Notes = table.Column<string>(type: "TEXT", nullable: false),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Modified = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    ModifiedBy = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donations", x => x.TransId);
                    table.ForeignKey(
                        name: "FK_Donations_ContactLists_AccountNo",
                        column: x => x.AccountNo,
                        principalTable: "ContactLists",
                        principalColumn: "AccountNo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Donations_PaymentMethods_PaymentMethodId",
                        column: x => x.PaymentMethodId,
                        principalTable: "PaymentMethods",
                        principalColumn: "PaymentMethodId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Donations_TransactionTypes_TransactionTypeId",
                        column: x => x.TransactionTypeId,
                        principalTable: "TransactionTypes",
                        principalColumn: "TransactionTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ContactLists",
                columns: new[] { "AccountNo", "City", "Country", "Created", "CreatedBy", "Email", "FirstName", "LastName", "Modified", "ModifiedBy", "PostalCode", "Street" },
                values: new object[,]
                {
                    { 12, "Richmond", "Canada", new DateTime(2023, 11, 23, 22, 58, 20, 91, DateTimeKind.Utc).AddTicks(6877), "System", "sam@fox.com", "Sam", "Fox", new DateTime(2023, 11, 23, 22, 58, 20, 91, DateTimeKind.Utc).AddTicks(6880), "System", "V4F 1M7", "457 Fox Avenue" },
                    { 17, "Delta", "Canada", new DateTime(2023, 11, 23, 22, 58, 20, 91, DateTimeKind.Utc).AddTicks(6927), "System", "ann@day.com", "Ann", "Day", new DateTime(2023, 11, 23, 22, 58, 20, 91, DateTimeKind.Utc).AddTicks(6927), "System", "V6G 1M6", "231 River Road" },
                    { 25, "Vancouver", "Canada", new DateTime(2023, 11, 23, 22, 58, 20, 91, DateTimeKind.Utc).AddTicks(6950), "System", "john@example.com", "John", "Doe", new DateTime(2023, 11, 23, 22, 58, 20, 91, DateTimeKind.Utc).AddTicks(6951), "System", "V5G 1H6", "123 Main Street" },
                    { 29, "Vancouver", "Canada", new DateTime(2023, 11, 23, 22, 58, 20, 91, DateTimeKind.Utc).AddTicks(6965), "System", "jane@ex.com", "Jane", "Smith", new DateTime(2023, 11, 23, 22, 58, 20, 91, DateTimeKind.Utc).AddTicks(6965), "System", "V3G 1K6", "456 Oak Street" }
                });

            migrationBuilder.InsertData(
                table: "PaymentMethods",
                columns: new[] { "PaymentMethodId", "Created", "CreatedBy", "Modified", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 23, 22, 58, 20, 94, DateTimeKind.Utc).AddTicks(198), "System", new DateTime(2023, 11, 23, 22, 58, 20, 94, DateTimeKind.Utc).AddTicks(199), "System", "Direct Deposit" },
                    { 2, new DateTime(2023, 11, 23, 22, 58, 20, 94, DateTimeKind.Utc).AddTicks(247), "System", new DateTime(2023, 11, 23, 22, 58, 20, 94, DateTimeKind.Utc).AddTicks(248), "System", "PayPal" },
                    { 3, new DateTime(2023, 11, 23, 22, 58, 20, 94, DateTimeKind.Utc).AddTicks(260), "System", new DateTime(2023, 11, 23, 22, 58, 20, 94, DateTimeKind.Utc).AddTicks(261), "System", "Check" },
                    { 4, new DateTime(2023, 11, 23, 22, 58, 20, 94, DateTimeKind.Utc).AddTicks(269), "System", new DateTime(2023, 11, 23, 22, 58, 20, 94, DateTimeKind.Utc).AddTicks(269), "System", "Cash" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5411512a-393f-4ac5-a269-2cafe028f269", null, "Finance", "FINANCE" },
                    { "b1b2a3f8-4128-4393-acd6-aefb79111ab6", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "TransactionTypes",
                columns: new[] { "TransactionTypeId", "Created", "CreatedBy", "Description", "Modified", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 23, 22, 58, 20, 92, DateTimeKind.Utc).AddTicks(9061), "System", "Donations made without any special purpose", new DateTime(2023, 11, 23, 22, 58, 20, 92, DateTimeKind.Utc).AddTicks(9062), "System", "General Donation" },
                    { 2, new DateTime(2023, 11, 23, 22, 58, 20, 92, DateTimeKind.Utc).AddTicks(9137), "System", "Donations made for homeless people", new DateTime(2023, 11, 23, 22, 58, 20, 92, DateTimeKind.Utc).AddTicks(9137), "System", "Food for homeless" },
                    { 3, new DateTime(2023, 11, 23, 22, 58, 20, 92, DateTimeKind.Utc).AddTicks(9152), "System", "Donations for the purpose of upgrading the gym", new DateTime(2023, 11, 23, 22, 58, 20, 92, DateTimeKind.Utc).AddTicks(9152), "System", "Repair of Gym" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "b1b2a3f8-4128-4393-acd6-aefb79111ab6", "3a58ee77-88d7-49fd-9bbc-7ad92d0e8fa1" },
                    { "5411512a-393f-4ac5-a269-2cafe028f269", "4aa7fb80-1f2a-415e-807d-da70bc9d9d43" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3a58ee77-88d7-49fd-9bbc-7ad92d0e8fa1", 0, "82b00b2f-e341-4483-a426-bfd703cc859c", "a@a.a", true, false, null, "A@A.A", "A@A.A", "AQAAAAIAAYagAAAAEJB2yf/l6QnAzc7N/+/cQ8r9PG6xLAWV1cnNJsy4e2we3hO3DhtgN/aBkT8JOdD+Ow==", null, false, "a1e3cd67-8296-45a8-8ea7-760d0fd619ad", false, "a@a.a" },
                    { "4aa7fb80-1f2a-415e-807d-da70bc9d9d43", 0, "831b57e7-fb5c-4eca-90b3-bcedf9286e37", "f@f.f", true, false, null, "F@F.F", "F@F.F", "AQAAAAIAAYagAAAAENY6IMQMBZ9MCjGHvYi7Rezf5WM5+M0UfiDqsr+LhdMrTC9/M4chXvutW2Qz2GdO3A==", null, false, "1f70fcce-884f-4b00-a1f7-034402a603fe", false, "f@f.f" }
                });

            migrationBuilder.InsertData(
                table: "Donations",
                columns: new[] { "TransId", "AccountNo", "Amount", "Created", "CreatedBy", "Date", "Modified", "ModifiedBy", "Notes", "PaymentMethodId", "TransactionTypeId" },
                values: new object[,]
                {
                    { 1, 12, 100f, new DateTime(2023, 11, 23, 22, 58, 20, 95, DateTimeKind.Utc).AddTicks(7418), "System", new DateTime(2023, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 23, 22, 58, 20, 95, DateTimeKind.Utc).AddTicks(7420), "System", "Test1", 4, 3 },
                    { 2, 17, 50f, new DateTime(2023, 11, 23, 22, 58, 20, 95, DateTimeKind.Utc).AddTicks(7467), "System", new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 23, 22, 58, 20, 95, DateTimeKind.Utc).AddTicks(7467), "System", "Test2", 3, 2 },
                    { 3, 25, 250f, new DateTime(2023, 11, 23, 22, 58, 20, 95, DateTimeKind.Utc).AddTicks(7486), "System", new DateTime(2023, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 23, 22, 58, 20, 95, DateTimeKind.Utc).AddTicks(7486), "System", "Test3", 2, 1 },
                    { 4, 29, 1000f, new DateTime(2023, 11, 23, 22, 58, 20, 95, DateTimeKind.Utc).AddTicks(7501), "System", new DateTime(2023, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 23, 22, 58, 20, 95, DateTimeKind.Utc).AddTicks(7501), "System", "Test4", 1, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Donations_AccountNo",
                table: "Donations",
                column: "AccountNo");

            migrationBuilder.CreateIndex(
                name: "IX_Donations_PaymentMethodId",
                table: "Donations",
                column: "PaymentMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_Donations_TransactionTypeId",
                table: "Donations",
                column: "TransactionTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Donations");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "ContactLists");

            migrationBuilder.DropTable(
                name: "PaymentMethods");

            migrationBuilder.DropTable(
                name: "TransactionTypes");
        }
    }
}
