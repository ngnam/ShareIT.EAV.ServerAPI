using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShareIT.EAV.DomainModel.Migrations
{
    /// <inheritdoc />
    public partial class InitialDbContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "EAV");

            migrationBuilder.CreateTable(
                name: "AttributeTypes",
                schema: "EAV",
                columns: table => new
                {
                    AttributeTypeId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttributeTypes", x => x.AttributeTypeId);
                });

            migrationBuilder.CreateTable(
                name: "ProductDefinitions",
                schema: "EAV",
                columns: table => new
                {
                    ProductDefinitionId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDefinitions", x => x.ProductDefinitionId);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                schema: "EAV",
                columns: table => new
                {
                    ItemId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductDefinitionId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemId);
                    table.ForeignKey(
                        name: "FK_Items_ProductDefinitions_ProductDefinitionId",
                        column: x => x.ProductDefinitionId,
                        principalSchema: "EAV",
                        principalTable: "ProductDefinitions",
                        principalColumn: "ProductDefinitionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductAttributes",
                schema: "EAV",
                columns: table => new
                {
                    ProductAttributeId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AttributeTypeId = table.Column<long>(type: "bigint", nullable: false),
                    ProductDefinitionId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAttributes", x => x.ProductAttributeId);
                    table.ForeignKey(
                        name: "FK_ProductAttributes_AttributeTypes_AttributeTypeId",
                        column: x => x.AttributeTypeId,
                        principalSchema: "EAV",
                        principalTable: "AttributeTypes",
                        principalColumn: "AttributeTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductAttributes_ProductDefinitions_ProductDefinitionId",
                        column: x => x.ProductDefinitionId,
                        principalSchema: "EAV",
                        principalTable: "ProductDefinitions",
                        principalColumn: "ProductDefinitionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemBoolValues",
                schema: "EAV",
                columns: table => new
                {
                    ItemBoolValueId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductDefinitionId = table.Column<long>(type: "bigint", nullable: false),
                    ItemId = table.Column<long>(type: "bigint", nullable: false),
                    ProductAttributeId = table.Column<long>(type: "bigint", nullable: false),
                    Value = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemBoolValues", x => x.ItemBoolValueId);
                    table.ForeignKey(
                        name: "FK_ItemBoolValues_Items_ItemId",
                        column: x => x.ItemId,
                        principalSchema: "EAV",
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemBoolValues_ProductAttributes_ProductAttributeId",
                        column: x => x.ProductAttributeId,
                        principalSchema: "EAV",
                        principalTable: "ProductAttributes",
                        principalColumn: "ProductAttributeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemBoolValues_ProductDefinitions_ProductDefinitionId",
                        column: x => x.ProductDefinitionId,
                        principalSchema: "EAV",
                        principalTable: "ProductDefinitions",
                        principalColumn: "ProductDefinitionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemDateTimeValues",
                schema: "EAV",
                columns: table => new
                {
                    ItemDateTimeValueId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductDefinitionId = table.Column<long>(type: "bigint", nullable: false),
                    ItemId = table.Column<long>(type: "bigint", nullable: false),
                    ProductAttributeId = table.Column<long>(type: "bigint", nullable: false),
                    Value = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemDateTimeValues", x => x.ItemDateTimeValueId);
                    table.ForeignKey(
                        name: "FK_ItemDateTimeValues_Items_ItemId",
                        column: x => x.ItemId,
                        principalSchema: "EAV",
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemDateTimeValues_ProductAttributes_ProductAttributeId",
                        column: x => x.ProductAttributeId,
                        principalSchema: "EAV",
                        principalTable: "ProductAttributes",
                        principalColumn: "ProductAttributeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemDateTimeValues_ProductDefinitions_ProductDefinitionId",
                        column: x => x.ProductDefinitionId,
                        principalSchema: "EAV",
                        principalTable: "ProductDefinitions",
                        principalColumn: "ProductDefinitionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemDecimalValues",
                schema: "EAV",
                columns: table => new
                {
                    ItemDecimalValueId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductDefinitionId = table.Column<long>(type: "bigint", nullable: false),
                    ItemId = table.Column<long>(type: "bigint", nullable: false),
                    ProductAttributeId = table.Column<long>(type: "bigint", nullable: false),
                    Value = table.Column<decimal>(type: "decimal(18,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemDecimalValues", x => x.ItemDecimalValueId);
                    table.ForeignKey(
                        name: "FK_ItemDecimalValues_Items_ItemId",
                        column: x => x.ItemId,
                        principalSchema: "EAV",
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemDecimalValues_ProductAttributes_ProductAttributeId",
                        column: x => x.ProductAttributeId,
                        principalSchema: "EAV",
                        principalTable: "ProductAttributes",
                        principalColumn: "ProductAttributeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemDecimalValues_ProductDefinitions_ProductDefinitionId",
                        column: x => x.ProductDefinitionId,
                        principalSchema: "EAV",
                        principalTable: "ProductDefinitions",
                        principalColumn: "ProductDefinitionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemIntValues",
                schema: "EAV",
                columns: table => new
                {
                    ItemIntValueId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductDefinitionId = table.Column<long>(type: "bigint", nullable: false),
                    ItemId = table.Column<long>(type: "bigint", nullable: false),
                    ProductAttributeId = table.Column<long>(type: "bigint", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemIntValues", x => x.ItemIntValueId);
                    table.ForeignKey(
                        name: "FK_ItemIntValues_Items_ItemId",
                        column: x => x.ItemId,
                        principalSchema: "EAV",
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemIntValues_ProductAttributes_ProductAttributeId",
                        column: x => x.ProductAttributeId,
                        principalSchema: "EAV",
                        principalTable: "ProductAttributes",
                        principalColumn: "ProductAttributeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemIntValues_ProductDefinitions_ProductDefinitionId",
                        column: x => x.ProductDefinitionId,
                        principalSchema: "EAV",
                        principalTable: "ProductDefinitions",
                        principalColumn: "ProductDefinitionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemStringValues",
                schema: "EAV",
                columns: table => new
                {
                    ItemStringValueId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductDefinitionId = table.Column<long>(type: "bigint", nullable: false),
                    ItemId = table.Column<long>(type: "bigint", nullable: false),
                    ProductAttributeId = table.Column<long>(type: "bigint", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemStringValues", x => x.ItemStringValueId);
                    table.ForeignKey(
                        name: "FK_ItemStringValues_Items_ItemId",
                        column: x => x.ItemId,
                        principalSchema: "EAV",
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemStringValues_ProductAttributes_ProductAttributeId",
                        column: x => x.ProductAttributeId,
                        principalSchema: "EAV",
                        principalTable: "ProductAttributes",
                        principalColumn: "ProductAttributeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemStringValues_ProductDefinitions_ProductDefinitionId",
                        column: x => x.ProductDefinitionId,
                        principalSchema: "EAV",
                        principalTable: "ProductDefinitions",
                        principalColumn: "ProductDefinitionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemBoolValues_ItemId",
                schema: "EAV",
                table: "ItemBoolValues",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemBoolValues_ProductAttributeId",
                schema: "EAV",
                table: "ItemBoolValues",
                column: "ProductAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemBoolValues_ProductDefinitionId",
                schema: "EAV",
                table: "ItemBoolValues",
                column: "ProductDefinitionId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemDateTimeValues_ItemId",
                schema: "EAV",
                table: "ItemDateTimeValues",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemDateTimeValues_ProductAttributeId",
                schema: "EAV",
                table: "ItemDateTimeValues",
                column: "ProductAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemDateTimeValues_ProductDefinitionId",
                schema: "EAV",
                table: "ItemDateTimeValues",
                column: "ProductDefinitionId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemDecimalValues_ItemId",
                schema: "EAV",
                table: "ItemDecimalValues",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemDecimalValues_ProductAttributeId",
                schema: "EAV",
                table: "ItemDecimalValues",
                column: "ProductAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemDecimalValues_ProductDefinitionId",
                schema: "EAV",
                table: "ItemDecimalValues",
                column: "ProductDefinitionId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemIntValues_ItemId",
                schema: "EAV",
                table: "ItemIntValues",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemIntValues_ProductAttributeId",
                schema: "EAV",
                table: "ItemIntValues",
                column: "ProductAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemIntValues_ProductDefinitionId",
                schema: "EAV",
                table: "ItemIntValues",
                column: "ProductDefinitionId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ProductDefinitionId",
                schema: "EAV",
                table: "Items",
                column: "ProductDefinitionId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemStringValues_ItemId",
                schema: "EAV",
                table: "ItemStringValues",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemStringValues_ProductAttributeId",
                schema: "EAV",
                table: "ItemStringValues",
                column: "ProductAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemStringValues_ProductDefinitionId",
                schema: "EAV",
                table: "ItemStringValues",
                column: "ProductDefinitionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAttributes_AttributeTypeId",
                schema: "EAV",
                table: "ProductAttributes",
                column: "AttributeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAttributes_ProductDefinitionId",
                schema: "EAV",
                table: "ProductAttributes",
                column: "ProductDefinitionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemBoolValues",
                schema: "EAV");

            migrationBuilder.DropTable(
                name: "ItemDateTimeValues",
                schema: "EAV");

            migrationBuilder.DropTable(
                name: "ItemDecimalValues",
                schema: "EAV");

            migrationBuilder.DropTable(
                name: "ItemIntValues",
                schema: "EAV");

            migrationBuilder.DropTable(
                name: "ItemStringValues",
                schema: "EAV");

            migrationBuilder.DropTable(
                name: "Items",
                schema: "EAV");

            migrationBuilder.DropTable(
                name: "ProductAttributes",
                schema: "EAV");

            migrationBuilder.DropTable(
                name: "AttributeTypes",
                schema: "EAV");

            migrationBuilder.DropTable(
                name: "ProductDefinitions",
                schema: "EAV");
        }
    }
}
