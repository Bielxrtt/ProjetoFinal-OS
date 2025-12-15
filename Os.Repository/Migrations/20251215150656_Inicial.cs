using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace Os.Repository.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Quantity = table.Column<float>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
                    Description = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    FinishDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserSystem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    Login = table.Column<string>(type: "longtext", nullable: false),
                    Password = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    AcessLevel = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    IdStatus = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSystem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSystem_Status_IdStatus",
                        column: x => x.IdStatus,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserSystem_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Id_Client = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
                    Phone = table.Column<string>(type: "varchar(12)", maxLength: 12, nullable: false),
                    Email = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    Adress = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Register_Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IdDevice = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Device",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    IdDevice = table.Column<int>(type: "int", nullable: false),
                    Id_Client = table.Column<int>(type: "int", nullable: false),
                    TypeBrand = table.Column<int>(type: "int", nullable: false),
                    Model = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    Type = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    IMEI = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Device", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Device_Client_Id_Client",
                        column: x => x.Id_Client,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    TypeService = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
                    Start_Date = table.Column<DateTime>(type: "datetime", nullable: false),
                    Finish_Date = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: true),
                    DeviceId = table.Column<int>(type: "int", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Service_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Service_Device_DeviceId",
                        column: x => x.DeviceId,
                        principalTable: "Device",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Service_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Service_UserSystem_UserId",
                        column: x => x.UserId,
                        principalTable: "UserSystem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ServiceOrder",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    Note = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    IdStatus = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    IdClient = table.Column<int>(type: "int", nullable: false),
                    IdDevice = table.Column<int>(type: "int", nullable: false),
                    UserSystemId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceOrder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceOrder_Client_IdClient",
                        column: x => x.IdClient,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceOrder_Device_IdDevice",
                        column: x => x.IdDevice,
                        principalTable: "Device",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceOrder_Status_IdStatus",
                        column: x => x.IdStatus,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceOrder_UserSystem_UserId",
                        column: x => x.UserId,
                        principalTable: "UserSystem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceOrder_UserSystem_UserSystemId",
                        column: x => x.UserSystemId,
                        principalTable: "UserSystem",
                        principalColumn: "Id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Products_has_ServiceOrder",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ServiceOrder_Id_Service_Order = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    Quantity = table.Column<float>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products_has_ServiceOrder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_has_ServiceOrder_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_has_ServiceOrder_ServiceOrder_ServiceOrder_Id_Servi~",
                        column: x => x.ServiceOrder_Id_Service_Order,
                        principalTable: "ServiceOrder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ServiceOrder_has_Service",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ServiceOrderId = table.Column<int>(type: "int", nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceOrder_has_Service", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceOrder_has_Service_ServiceOrder_ServiceOrderId",
                        column: x => x.ServiceOrderId,
                        principalTable: "ServiceOrder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceOrder_has_Service_Service_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Service",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Client_IdDevice",
                table: "Client",
                column: "IdDevice");

            migrationBuilder.CreateIndex(
                name: "IX_Device_Id_Client",
                table: "Device",
                column: "Id_Client");

            migrationBuilder.CreateIndex(
                name: "IX_Products_has_ServiceOrder_ProductId",
                table: "Products_has_ServiceOrder",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_has_ServiceOrder_ServiceOrder_Id_Service_Order",
                table: "Products_has_ServiceOrder",
                column: "ServiceOrder_Id_Service_Order");

            migrationBuilder.CreateIndex(
                name: "IX_Service_ClientId",
                table: "Service",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Service_DeviceId",
                table: "Service",
                column: "DeviceId");

            migrationBuilder.CreateIndex(
                name: "IX_Service_StatusId",
                table: "Service",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Service_UserId",
                table: "Service",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceOrder_IdClient",
                table: "ServiceOrder",
                column: "IdClient");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceOrder_IdDevice",
                table: "ServiceOrder",
                column: "IdDevice");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceOrder_IdStatus",
                table: "ServiceOrder",
                column: "IdStatus");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceOrder_UserId",
                table: "ServiceOrder",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceOrder_UserSystemId",
                table: "ServiceOrder",
                column: "UserSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceOrder_has_Service_ServiceId",
                table: "ServiceOrder_has_Service",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceOrder_has_Service_ServiceOrderId",
                table: "ServiceOrder_has_Service",
                column: "ServiceOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSystem_IdStatus",
                table: "UserSystem",
                column: "IdStatus");

            migrationBuilder.CreateIndex(
                name: "IX_UserSystem_StatusId",
                table: "UserSystem",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Client_Device_IdDevice",
                table: "Client",
                column: "IdDevice",
                principalTable: "Device",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Client_Device_IdDevice",
                table: "Client");

            migrationBuilder.DropTable(
                name: "Products_has_ServiceOrder");

            migrationBuilder.DropTable(
                name: "ServiceOrder_has_Service");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "ServiceOrder");

            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DropTable(
                name: "UserSystem");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "Device");

            migrationBuilder.DropTable(
                name: "Client");
        }
    }
}
