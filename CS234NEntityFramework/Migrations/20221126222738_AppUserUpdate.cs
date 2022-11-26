using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CS234NEntityFramework.Migrations
{
    public partial class AppUserUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "account",
                columns: table => new
                {
                    account_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    address = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    city = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    state = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    zipcode = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    phone = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    contact_name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sales_person_name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_account", x => x.account_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "address",
                columns: table => new
                {
                    address_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    street_line_1 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    street_line_2 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    city = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    state = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    zipcode = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    country = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_address", x => x.address_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "address_type",
                columns: table => new
                {
                    address_type_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_address_type", x => x.address_type_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "adjunct_type",
                columns: table => new
                {
                    adjunct_type_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_adjunct_type", x => x.adjunct_type_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "app_config",
                columns: table => new
                {
                    brewery_id = table.Column<int>(type: "int", nullable: false),
                    default_units = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, defaultValueSql: "'metric'", collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    brewery_name = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    home_page_text = table.Column<string>(type: "varchar(5000)", maxLength: 5000, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    brewery_logo = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    home_page_background_image = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    color_1 = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    color_2 = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    color_3 = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    color_white = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    color_black = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.brewery_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "app_user",
                columns: table => new
                {
                    app_user_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "longtext", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Role = table.Column<string>(type: "longtext", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_app_user", x => x.app_user_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "container_size",
                columns: table => new
                {
                    container_size_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    max_volume = table.Column<double>(type: "double", nullable: true),
                    working_volume = table.Column<double>(type: "double", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_container_size", x => x.container_size_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "container_status",
                columns: table => new
                {
                    container_status_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_container_status", x => x.container_status_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "container_type",
                columns: table => new
                {
                    container_type_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_container_type", x => x.container_type_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "equipment",
                columns: table => new
                {
                    equipment_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    version = table.Column<int>(type: "int", nullable: true),
                    boil_size = table.Column<double>(type: "double", nullable: true),
                    batch_size = table.Column<double>(type: "double", nullable: true),
                    tun_volume = table.Column<double>(type: "double", nullable: true),
                    tun_weight = table.Column<double>(type: "double", nullable: true),
                    tun_specific_heat = table.Column<double>(type: "double", nullable: true),
                    top_up_water = table.Column<double>(type: "double", nullable: true),
                    trub_chiller_loss = table.Column<double>(type: "double", nullable: true),
                    evap_rate = table.Column<double>(type: "double", nullable: true),
                    boil_time = table.Column<double>(type: "double", nullable: true),
                    calc_boil_volume = table.Column<sbyte>(type: "tinyint", nullable: true),
                    lauter_deadspace = table.Column<double>(type: "double", nullable: true),
                    top_up_kettle = table.Column<double>(type: "double", nullable: true),
                    hop_utilization = table.Column<double>(type: "double", nullable: true),
                    cooling_loss_pct = table.Column<double>(type: "double", nullable: true),
                    notes = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_equipment", x => x.equipment_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "fermentable_type",
                columns: table => new
                {
                    fermentable_type_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fermentable_type", x => x.fermentable_type_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "hop_type",
                columns: table => new
                {
                    hop_type_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hop_type", x => x.hop_type_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "ingredient_type",
                columns: table => new
                {
                    ingredient_type_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ingredient_type", x => x.ingredient_type_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "inventory_transaction_type",
                columns: table => new
                {
                    inventory_transaction_type_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inventory_transaction_type", x => x.inventory_transaction_type_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "mash",
                columns: table => new
                {
                    mash_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    version = table.Column<int>(type: "int", nullable: true),
                    grain_temp = table.Column<double>(type: "double", nullable: true),
                    tun_temp = table.Column<double>(type: "double", nullable: true),
                    sparge_temp = table.Column<double>(type: "double", nullable: true),
                    ph = table.Column<double>(type: "double", nullable: true),
                    tun_weight = table.Column<double>(type: "double", nullable: true),
                    tun_specific_heat = table.Column<double>(type: "double", nullable: true),
                    equipment_adjust = table.Column<sbyte>(type: "tinyint", nullable: true),
                    notes = table.Column<string>(type: "varchar(2000)", maxLength: 2000, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mash", x => x.mash_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "product_container_size",
                columns: table => new
                {
                    container_size_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    volume = table.Column<double>(type: "double", nullable: false),
                    item_quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.container_size_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "style",
                columns: table => new
                {
                    style_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    version = table.Column<int>(type: "int", nullable: true),
                    category_name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    category_number = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    category_letter = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    style_guide = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    type = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    og_min = table.Column<double>(type: "double", nullable: true),
                    og_max = table.Column<double>(type: "double", nullable: true),
                    fg_min = table.Column<double>(type: "double", nullable: true),
                    fg_max = table.Column<double>(type: "double", nullable: true),
                    ibu_min = table.Column<double>(type: "double", nullable: true),
                    ibu_max = table.Column<double>(type: "double", nullable: true),
                    color_min = table.Column<double>(type: "double", nullable: true),
                    color_max = table.Column<double>(type: "double", nullable: true),
                    carb_min = table.Column<double>(type: "double", nullable: true),
                    carb_max = table.Column<double>(type: "double", nullable: true),
                    abv_min = table.Column<double>(type: "double", nullable: true),
                    abv_max = table.Column<double>(type: "double", nullable: true),
                    notes = table.Column<string>(type: "varchar(5000)", maxLength: 5000, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    profile = table.Column<string>(type: "varchar(5000)", maxLength: 5000, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ingredients = table.Column<string>(type: "varchar(2000)", maxLength: 2000, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    examples = table.Column<string>(type: "varchar(2000)", maxLength: 2000, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_style", x => x.style_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "supplier",
                columns: table => new
                {
                    supplier_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    phone = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    website = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    contact_first_name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    contact_last_name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    contact_phone = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    contact_email = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    note = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_supplier", x => x.supplier_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "unit_type",
                columns: table => new
                {
                    unit_type_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_unit_type", x => x.unit_type_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "use_during",
                columns: table => new
                {
                    use_during_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_use_during", x => x.use_during_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "brew_container",
                columns: table => new
                {
                    brew_container_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    container_status_id = table.Column<int>(type: "int", nullable: false),
                    container_type_id = table.Column<int>(type: "int", nullable: false),
                    container_size_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_brew_container", x => x.brew_container_id);
                    table.ForeignKey(
                        name: "brew_container_container_size",
                        column: x => x.container_size_id,
                        principalTable: "container_size",
                        principalColumn: "container_size_id");
                    table.ForeignKey(
                        name: "brew_container_container_status_FK",
                        column: x => x.container_status_id,
                        principalTable: "container_status",
                        principalColumn: "container_status_id");
                    table.ForeignKey(
                        name: "brew_container_container_type_FK",
                        column: x => x.container_type_id,
                        principalTable: "container_type",
                        principalColumn: "container_type_id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "mash_step",
                columns: table => new
                {
                    mash_step_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    mash_id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    version = table.Column<int>(type: "int", nullable: true),
                    type = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    infuse_amount = table.Column<double>(type: "double", nullable: true),
                    step_time = table.Column<double>(type: "double", nullable: true),
                    step_temp = table.Column<double>(type: "double", nullable: true),
                    ramp_time = table.Column<double>(type: "double", nullable: true),
                    end_temp = table.Column<double>(type: "double", nullable: true),
                    description = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    water_grain_ratio = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    decoction_amount = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    infuse_temp = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mash_step", x => x.mash_step_id);
                    table.ForeignKey(
                        name: "mast_step_mash_FK",
                        column: x => x.mash_id,
                        principalTable: "mash",
                        principalColumn: "mash_id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "product_container_inventory",
                columns: table => new
                {
                    container_size_id = table.Column<int>(type: "int", nullable: false),
                    quantity_dirty = table.Column<int>(type: "int", nullable: false),
                    quantity_clean = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.container_size_id);
                    table.ForeignKey(
                        name: "product_container_inventory_product_container_FK",
                        column: x => x.container_size_id,
                        principalTable: "product_container_size",
                        principalColumn: "container_size_id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "recipe",
                columns: table => new
                {
                    recipe_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    version = table.Column<int>(type: "int", nullable: true),
                    date = table.Column<DateTime>(type: "datetime", nullable: true),
                    style_id = table.Column<int>(type: "int", nullable: false),
                    volume = table.Column<double>(type: "double", nullable: false),
                    brewer = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    boil_time = table.Column<double>(type: "double", nullable: true, defaultValueSql: "'0'"),
                    boil_volume = table.Column<double>(type: "double", nullable: true, defaultValueSql: "'0'"),
                    efficiency = table.Column<double>(type: "double", nullable: true, defaultValueSql: "'0'"),
                    fermentation_stages = table.Column<int>(type: "int", nullable: true, defaultValueSql: "'1'"),
                    estimated_og = table.Column<double>(type: "double", nullable: true, defaultValueSql: "'0'"),
                    estimated_fg = table.Column<double>(type: "double", nullable: true, defaultValueSql: "'0'"),
                    estimated_color = table.Column<double>(type: "double", nullable: true, defaultValueSql: "'0'"),
                    estimated_abv = table.Column<double>(type: "double", nullable: true, defaultValueSql: "'0'"),
                    actual_efficiency = table.Column<double>(type: "double", nullable: true, defaultValueSql: "'0'"),
                    equipment_id = table.Column<int>(type: "int", nullable: true),
                    carbonation_used = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    forced_carbonation = table.Column<sbyte>(type: "tinyint", nullable: true),
                    keg_priming_factor = table.Column<double>(type: "double", nullable: true),
                    carbonation_temp = table.Column<double>(type: "double", nullable: true),
                    mash_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_recipe", x => x.recipe_id);
                    table.ForeignKey(
                        name: "recipe_equipment_FK",
                        column: x => x.equipment_id,
                        principalTable: "equipment",
                        principalColumn: "equipment_id");
                    table.ForeignKey(
                        name: "recipe_mash_FK",
                        column: x => x.mash_id,
                        principalTable: "mash",
                        principalColumn: "mash_id");
                    table.ForeignKey(
                        name: "recipe_style_FK",
                        column: x => x.style_id,
                        principalTable: "style",
                        principalColumn: "style_id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "supplier_address",
                columns: table => new
                {
                    supplier_id = table.Column<int>(type: "int", nullable: false),
                    address_id = table.Column<int>(type: "int", nullable: false),
                    address_type_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.supplier_id, x.address_id, x.address_type_id })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
                    table.ForeignKey(
                        name: "supplier_address_address_FK",
                        column: x => x.address_id,
                        principalTable: "address",
                        principalColumn: "address_id");
                    table.ForeignKey(
                        name: "supplier_address_address_type_FK",
                        column: x => x.address_type_id,
                        principalTable: "address_type",
                        principalColumn: "address_type_id");
                    table.ForeignKey(
                        name: "supplier_address_supplier_FK",
                        column: x => x.supplier_id,
                        principalTable: "supplier",
                        principalColumn: "supplier_id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "ingredient",
                columns: table => new
                {
                    ingredient_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    version = table.Column<int>(type: "int", nullable: true),
                    ingredient_type_id = table.Column<int>(type: "int", nullable: false),
                    on_hand_quantity = table.Column<double>(type: "double", nullable: false),
                    unit_type_id = table.Column<int>(type: "int", nullable: false),
                    unit_cost = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    reorder_point = table.Column<double>(type: "double", nullable: false),
                    notes = table.Column<string>(type: "varchar(2000)", maxLength: 2000, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ingredient", x => x.ingredient_id);
                    table.ForeignKey(
                        name: "ingredient_ingredient_type_FK",
                        column: x => x.ingredient_type_id,
                        principalTable: "ingredient_type",
                        principalColumn: "ingredient_type_id");
                    table.ForeignKey(
                        name: "ingredient_unit_type_FK",
                        column: x => x.unit_type_id,
                        principalTable: "unit_type",
                        principalColumn: "unit_type_id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "barrel",
                columns: table => new
                {
                    brew_container_id = table.Column<int>(type: "int", nullable: false),
                    treatment = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.brew_container_id);
                    table.ForeignKey(
                        name: "barrel_brew_container_FK",
                        column: x => x.brew_container_id,
                        principalTable: "brew_container",
                        principalColumn: "brew_container_id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "batch",
                columns: table => new
                {
                    batch_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    recipe_id = table.Column<int>(type: "int", nullable: false),
                    equipment_id = table.Column<int>(type: "int", nullable: false),
                    volume = table.Column<double>(type: "double", nullable: false),
                    scheduled_start_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    start_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    estimated_finish_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    finish_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    unit_cost = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: true),
                    notes = table.Column<string>(type: "varchar(2000)", maxLength: 2000, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    taste_notes = table.Column<string>(type: "varchar(2000)", maxLength: 2000, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    taste_rating = table.Column<double>(type: "double", nullable: true),
                    og = table.Column<double>(type: "double", nullable: true),
                    fg = table.Column<double>(type: "double", nullable: true),
                    carbonation = table.Column<double>(type: "double", nullable: true),
                    fermentation_stages = table.Column<int>(type: "int", nullable: true),
                    primary_age = table.Column<double>(type: "double", nullable: true),
                    primary_temp = table.Column<double>(type: "double", nullable: true),
                    secondary_age = table.Column<double>(type: "double", nullable: true),
                    secondary_temp = table.Column<double>(type: "double", nullable: true),
                    tertiary_age = table.Column<double>(type: "double", nullable: true),
                    age = table.Column<double>(type: "double", nullable: true),
                    temp = table.Column<double>(type: "double", nullable: true),
                    ibu = table.Column<double>(type: "double", nullable: true),
                    ibu_method = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    abv = table.Column<double>(type: "double", nullable: true),
                    actual_efficiency = table.Column<double>(type: "double", nullable: true),
                    calories = table.Column<double>(type: "double", nullable: true),
                    carbonation_used = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    forced_carbonation = table.Column<sbyte>(type: "tinyint", nullable: true),
                    keg_priming_factor = table.Column<double>(type: "double", nullable: true),
                    carbonation_temp = table.Column<double>(type: "double", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_batch", x => x.batch_id);
                    table.ForeignKey(
                        name: "batch_equipment_FK",
                        column: x => x.equipment_id,
                        principalTable: "equipment",
                        principalColumn: "equipment_id");
                    table.ForeignKey(
                        name: "batch_recipe_FK",
                        column: x => x.recipe_id,
                        principalTable: "recipe",
                        principalColumn: "recipe_id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "adjunct",
                columns: table => new
                {
                    ingredient_id = table.Column<int>(type: "int", nullable: false),
                    adjunct_type_id = table.Column<int>(type: "int", nullable: false),
                    use_for = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    recommended_quantity = table.Column<double>(type: "double", nullable: true, defaultValueSql: "'0'"),
                    batch_volume = table.Column<double>(type: "double", nullable: true, defaultValueSql: "'0'"),
                    recommended_use_during_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.ingredient_id);
                    table.ForeignKey(
                        name: "adjunct_adjunct_type_FK",
                        column: x => x.adjunct_type_id,
                        principalTable: "adjunct_type",
                        principalColumn: "adjunct_type_id");
                    table.ForeignKey(
                        name: "adjunct_ingredient_FK",
                        column: x => x.ingredient_id,
                        principalTable: "ingredient",
                        principalColumn: "ingredient_id");
                    table.ForeignKey(
                        name: "adjunct_use_during_FK",
                        column: x => x.recommended_use_during_id,
                        principalTable: "use_during",
                        principalColumn: "use_during_id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "fermentable",
                columns: table => new
                {
                    ingredient_id = table.Column<int>(type: "int", nullable: false),
                    fermentable_type_id = table.Column<int>(type: "int", nullable: true),
                    color = table.Column<double>(type: "double", nullable: true),
                    yield = table.Column<double>(type: "double", nullable: true),
                    origin = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    coarse_fine_diff = table.Column<double>(type: "double", nullable: true),
                    moisture = table.Column<double>(type: "double", nullable: true),
                    diastatic_power = table.Column<double>(type: "double", nullable: true),
                    protein = table.Column<double>(type: "double", nullable: true),
                    max_in_batch = table.Column<double>(type: "double", nullable: true),
                    recommend_mash = table.Column<sbyte>(type: "tinyint", nullable: true),
                    add_after_boil = table.Column<sbyte>(type: "tinyint", nullable: true),
                    ibu_gal_per_lb = table.Column<double>(type: "double", nullable: true),
                    potential = table.Column<double>(type: "double", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.ingredient_id);
                    table.ForeignKey(
                        name: "fermentable_fermentable_type_FK",
                        column: x => x.fermentable_type_id,
                        principalTable: "fermentable_type",
                        principalColumn: "fermentable_type_id");
                    table.ForeignKey(
                        name: "fermentable_ingredient_FK",
                        column: x => x.ingredient_id,
                        principalTable: "ingredient",
                        principalColumn: "ingredient_id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "hop",
                columns: table => new
                {
                    ingredient_id = table.Column<int>(type: "int", nullable: false),
                    hop_type_id = table.Column<int>(type: "int", nullable: true),
                    origin = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    alpha = table.Column<double>(type: "double", nullable: true),
                    beta = table.Column<double>(type: "double", nullable: true),
                    hsi = table.Column<double>(type: "double", nullable: true),
                    form = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.ingredient_id);
                    table.ForeignKey(
                        name: "hop_hop_type",
                        column: x => x.hop_type_id,
                        principalTable: "hop_type",
                        principalColumn: "hop_type_id");
                    table.ForeignKey(
                        name: "hop_ingredient_FK",
                        column: x => x.ingredient_id,
                        principalTable: "ingredient",
                        principalColumn: "ingredient_id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "ingredient_inventory_addition",
                columns: table => new
                {
                    ingredient_inventory_addition_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ingredient_id = table.Column<int>(type: "int", nullable: false),
                    order_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    estimated_delivery_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    transaction_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    supplier_id = table.Column<int>(type: "int", nullable: false),
                    quantity = table.Column<double>(type: "double", nullable: false),
                    quantity_remaining = table.Column<double>(type: "double", nullable: true),
                    unit_cost = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ingredient_inventory_addition", x => x.ingredient_inventory_addition_id);
                    table.ForeignKey(
                        name: "ingredient_inventory_addition_ingredient_FK",
                        column: x => x.ingredient_id,
                        principalTable: "ingredient",
                        principalColumn: "ingredient_id");
                    table.ForeignKey(
                        name: "ingredient_invertory_addition_supplier_FK",
                        column: x => x.supplier_id,
                        principalTable: "supplier",
                        principalColumn: "supplier_id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "ingredient_substitute",
                columns: table => new
                {
                    ingredient_id = table.Column<int>(type: "int", nullable: false),
                    substitute_ingredient_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.ingredient_id, x.substitute_ingredient_id })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                    table.ForeignKey(
                        name: "ingredient_substitute_ingredient_FK",
                        column: x => x.ingredient_id,
                        principalTable: "ingredient",
                        principalColumn: "ingredient_id");
                    table.ForeignKey(
                        name: "ingredient_substitute_substitute_ingredient_FK",
                        column: x => x.substitute_ingredient_id,
                        principalTable: "ingredient",
                        principalColumn: "ingredient_id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "ingredient_used_in",
                columns: table => new
                {
                    ingredient_id = table.Column<int>(type: "int", nullable: false),
                    style_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.ingredient_id, x.style_id })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                    table.ForeignKey(
                        name: "used_in_ingredient_FK",
                        column: x => x.ingredient_id,
                        principalTable: "ingredient",
                        principalColumn: "ingredient_id");
                    table.ForeignKey(
                        name: "used_in_style_type_FK",
                        column: x => x.style_id,
                        principalTable: "style",
                        principalColumn: "style_id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "recipe_ingredient",
                columns: table => new
                {
                    recipe_ingredient_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    recipe_id = table.Column<int>(type: "int", nullable: false),
                    ingredient_id = table.Column<int>(type: "int", nullable: false),
                    quantity = table.Column<double>(type: "double", nullable: false),
                    time = table.Column<double>(type: "double", nullable: true, defaultValueSql: "'0'"),
                    use_during_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_recipe_ingredient", x => x.recipe_ingredient_id);
                    table.ForeignKey(
                        name: "recipe_ingredient_ingredient_FK",
                        column: x => x.ingredient_id,
                        principalTable: "ingredient",
                        principalColumn: "ingredient_id");
                    table.ForeignKey(
                        name: "recipe_ingredient_recipe_FK",
                        column: x => x.recipe_id,
                        principalTable: "recipe",
                        principalColumn: "recipe_id");
                    table.ForeignKey(
                        name: "recipe_ingredient_use_during_FK",
                        column: x => x.use_during_id,
                        principalTable: "use_during",
                        principalColumn: "use_during_id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "yeast",
                columns: table => new
                {
                    ingredient_id = table.Column<int>(type: "int", nullable: false),
                    product_id = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    min_temp = table.Column<double>(type: "double", nullable: true),
                    max_temp = table.Column<double>(type: "double", nullable: true),
                    form = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    laboratory = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    flocculation = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    attenuation = table.Column<double>(type: "double", nullable: true),
                    max_reuse = table.Column<int>(type: "int", nullable: true),
                    add_to_secondary = table.Column<sbyte>(type: "tinyint", nullable: true),
                    type = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    best_for = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.ingredient_id);
                    table.ForeignKey(
                        name: "yeast_ingredient_FK",
                        column: x => x.ingredient_id,
                        principalTable: "ingredient",
                        principalColumn: "ingredient_id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "batch_container",
                columns: table => new
                {
                    batch_id = table.Column<int>(type: "int", nullable: false),
                    brew_container_id = table.Column<int>(type: "int", nullable: false),
                    date_in = table.Column<DateTime>(type: "datetime", nullable: false),
                    date_out = table.Column<DateTime>(type: "datetime", nullable: true),
                    volume = table.Column<double>(type: "double", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.batch_id, x.brew_container_id })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                    table.ForeignKey(
                        name: "batch_container_batch_FK",
                        column: x => x.batch_id,
                        principalTable: "batch",
                        principalColumn: "batch_id");
                    table.ForeignKey(
                        name: "batch_container_brew_container_FK",
                        column: x => x.brew_container_id,
                        principalTable: "brew_container",
                        principalColumn: "brew_container_id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "ingredient_inventory_subtraction",
                columns: table => new
                {
                    ingredient_inventory_subtraction_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ingredient_id = table.Column<int>(type: "int", nullable: false),
                    transaction_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    reason = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    batch_id = table.Column<int>(type: "int", nullable: true),
                    quantity = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ingredient_inventory_subtraction", x => x.ingredient_inventory_subtraction_id);
                    table.ForeignKey(
                        name: "ingredient_inventory_subtraction_ingredient_FK",
                        column: x => x.ingredient_id,
                        principalTable: "ingredient",
                        principalColumn: "ingredient_id");
                    table.ForeignKey(
                        name: "ingredient_purchased_batch_FK",
                        column: x => x.batch_id,
                        principalTable: "batch",
                        principalColumn: "batch_id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "inventory_transaction",
                columns: table => new
                {
                    inventory_transaction_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    product_container_size_id = table.Column<int>(type: "int", nullable: false),
                    batch_id = table.Column<int>(type: "int", nullable: false),
                    inventory_transaction_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    inventory_transction_type_id = table.Column<int>(type: "int", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    account_id = table.Column<int>(type: "int", nullable: false),
                    app_user_id = table.Column<int>(type: "int", nullable: false),
                    notes = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inventory_transaction", x => x.inventory_transaction_id);
                    table.ForeignKey(
                        name: "inventory_transaction_account",
                        column: x => x.account_id,
                        principalTable: "account",
                        principalColumn: "account_id");
                    table.ForeignKey(
                        name: "inventory_transaction_app_user_FK",
                        column: x => x.app_user_id,
                        principalTable: "app_user",
                        principalColumn: "app_user_id");
                    table.ForeignKey(
                        name: "inventory_transaction_batch_FK",
                        column: x => x.batch_id,
                        principalTable: "batch",
                        principalColumn: "batch_id");
                    table.ForeignKey(
                        name: "inventory_transaction_product_container_size_FK",
                        column: x => x.product_container_size_id,
                        principalTable: "product_container_size",
                        principalColumn: "container_size_id");
                    table.ForeignKey(
                        name: "inventory_transaction_transaction_type_FK",
                        column: x => x.inventory_transction_type_id,
                        principalTable: "inventory_transaction_type",
                        principalColumn: "inventory_transaction_type_id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "product",
                columns: table => new
                {
                    batch_id = table.Column<int>(type: "int", nullable: false),
                    product_container_size_id = table.Column<int>(type: "int", nullable: false),
                    racked_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    sell_by_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    quantity_racked = table.Column<int>(type: "int", nullable: false),
                    quantity_remaining = table.Column<int>(type: "int", nullable: false),
                    ingredient_cost = table.Column<decimal>(type: "decimal(10,4)", precision: 10, scale: 4, nullable: true),
                    suggested_price = table.Column<decimal>(type: "decimal(10,4)", precision: 10, scale: 4, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.batch_id, x.product_container_size_id })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                    table.ForeignKey(
                        name: "product_batch_FK",
                        column: x => x.batch_id,
                        principalTable: "batch",
                        principalColumn: "batch_id");
                    table.ForeignKey(
                        name: "product_product_container_size_FK",
                        column: x => x.product_container_size_id,
                        principalTable: "product_container_size",
                        principalColumn: "container_size_id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateIndex(
                name: "name_UNIQUE",
                table: "address_type",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "adjunct_adjunct_type_FK_idx",
                table: "adjunct",
                column: "adjunct_type_id");

            migrationBuilder.CreateIndex(
                name: "adjunct_use_during_FK_idx",
                table: "adjunct",
                column: "recommended_use_during_id");

            migrationBuilder.CreateIndex(
                name: "name_UNIQUE1",
                table: "adjunct_type",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "batch_recipe_FK",
                table: "batch",
                column: "recipe_id");

            migrationBuilder.CreateIndex(
                name: "batch_recipe_FK_idx",
                table: "batch",
                column: "equipment_id");

            migrationBuilder.CreateIndex(
                name: "batch_container_brew_container_FK_idx",
                table: "batch_container",
                column: "brew_container_id");

            migrationBuilder.CreateIndex(
                name: "brew_container_container_size_idx",
                table: "brew_container",
                column: "container_size_id");

            migrationBuilder.CreateIndex(
                name: "brew_container_container_status_FK_idx",
                table: "brew_container",
                column: "container_status_id");

            migrationBuilder.CreateIndex(
                name: "brew_container_container_type_FK_idx",
                table: "brew_container",
                column: "container_type_id");

            migrationBuilder.CreateIndex(
                name: "name_UNIQUE2",
                table: "brew_container",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "name_UNIQUE3",
                table: "container_size",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "name_UNIQUE4",
                table: "container_status",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "name_UNIQUE5",
                table: "container_type",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "equipment_name_UNIQUE",
                table: "equipment",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fermentable_fermentable_type_FK_idx",
                table: "fermentable",
                column: "fermentable_type_id");

            migrationBuilder.CreateIndex(
                name: "name_UNIQUE6",
                table: "fermentable_type",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "hop_hop_type_idx",
                table: "hop",
                column: "hop_type_id");

            migrationBuilder.CreateIndex(
                name: "name_UNIQUE7",
                table: "hop_type",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ingredient_ingredient_type_FK_idx",
                table: "ingredient",
                column: "ingredient_type_id");

            migrationBuilder.CreateIndex(
                name: "ingredient_unit_type_FK_idx",
                table: "ingredient",
                column: "unit_type_id");

            migrationBuilder.CreateIndex(
                name: "ingredient_inventory_addition_ingredient_FK_idx",
                table: "ingredient_inventory_addition",
                column: "ingredient_id");

            migrationBuilder.CreateIndex(
                name: "ingredient_invertory_addition_supplier_FK_idx",
                table: "ingredient_inventory_addition",
                column: "supplier_id");

            migrationBuilder.CreateIndex(
                name: "ingredient_inventory_subtraction_ingredient_FK",
                table: "ingredient_inventory_subtraction",
                column: "ingredient_id");

            migrationBuilder.CreateIndex(
                name: "ingredient_purchased_batch_FK",
                table: "ingredient_inventory_subtraction",
                column: "batch_id");

            migrationBuilder.CreateIndex(
                name: "ingredient_substitute_substitute_ingredient_FK_idx",
                table: "ingredient_substitute",
                column: "substitute_ingredient_id");

            migrationBuilder.CreateIndex(
                name: "name_UNIQUE8",
                table: "ingredient_type",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "usedin_style_type_FK_idx",
                table: "ingredient_used_in",
                column: "style_id");

            migrationBuilder.CreateIndex(
                name: "inventory_transaction_account_idx",
                table: "inventory_transaction",
                column: "account_id");

            migrationBuilder.CreateIndex(
                name: "inventory_transaction_app_user_FK_idx",
                table: "inventory_transaction",
                column: "app_user_id");

            migrationBuilder.CreateIndex(
                name: "inventory_transaction_batch_FK_idx",
                table: "inventory_transaction",
                column: "batch_id");

            migrationBuilder.CreateIndex(
                name: "inventory_transaction_product_container_size_FK_idx",
                table: "inventory_transaction",
                column: "product_container_size_id");

            migrationBuilder.CreateIndex(
                name: "inventory_transaction_transaction_type_FK_idx",
                table: "inventory_transaction",
                column: "inventory_transction_type_id");

            migrationBuilder.CreateIndex(
                name: "name_UNIQUE9",
                table: "inventory_transaction_type",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "name_UNIQUE10",
                table: "mash",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "mast_step_mash_FK_idx",
                table: "mash_step",
                column: "mash_id");

            migrationBuilder.CreateIndex(
                name: "keg_batch_FK_idx",
                table: "product",
                column: "batch_id");

            migrationBuilder.CreateIndex(
                name: "product_product_container_size_FK",
                table: "product",
                column: "product_container_size_id");

            migrationBuilder.CreateIndex(
                name: "name_UNIQUE11",
                table: "product_container_size",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "name_UNIQUE12",
                table: "recipe",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "recipe_equipment_FK_idx",
                table: "recipe",
                column: "equipment_id");

            migrationBuilder.CreateIndex(
                name: "recipe_mash_FK_idx",
                table: "recipe",
                column: "mash_id");

            migrationBuilder.CreateIndex(
                name: "recipe_style_type_FK_idx",
                table: "recipe",
                column: "style_id");

            migrationBuilder.CreateIndex(
                name: "recipe_ingredient_ingredient_idx",
                table: "recipe_ingredient",
                column: "ingredient_id");

            migrationBuilder.CreateIndex(
                name: "recipe_ingredient_recipe_FK",
                table: "recipe_ingredient",
                column: "recipe_id");

            migrationBuilder.CreateIndex(
                name: "recipe_ingredient_use_during_FK_idx",
                table: "recipe_ingredient",
                column: "use_during_id");

            migrationBuilder.CreateIndex(
                name: "name_UNIQUE13",
                table: "style",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "name_UNIQUE14",
                table: "supplier",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "supplier_address_address_FK_idx",
                table: "supplier_address",
                column: "address_id");

            migrationBuilder.CreateIndex(
                name: "supplier_address_address_type_FK_idx",
                table: "supplier_address",
                column: "address_type_id");

            migrationBuilder.CreateIndex(
                name: "name_UNIQUE15",
                table: "unit_type",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "name_UNIQUE16",
                table: "use_during",
                column: "name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "adjunct");

            migrationBuilder.DropTable(
                name: "app_config");

            migrationBuilder.DropTable(
                name: "barrel");

            migrationBuilder.DropTable(
                name: "batch_container");

            migrationBuilder.DropTable(
                name: "fermentable");

            migrationBuilder.DropTable(
                name: "hop");

            migrationBuilder.DropTable(
                name: "ingredient_inventory_addition");

            migrationBuilder.DropTable(
                name: "ingredient_inventory_subtraction");

            migrationBuilder.DropTable(
                name: "ingredient_substitute");

            migrationBuilder.DropTable(
                name: "ingredient_used_in");

            migrationBuilder.DropTable(
                name: "inventory_transaction");

            migrationBuilder.DropTable(
                name: "mash_step");

            migrationBuilder.DropTable(
                name: "product");

            migrationBuilder.DropTable(
                name: "product_container_inventory");

            migrationBuilder.DropTable(
                name: "recipe_ingredient");

            migrationBuilder.DropTable(
                name: "supplier_address");

            migrationBuilder.DropTable(
                name: "yeast");

            migrationBuilder.DropTable(
                name: "adjunct_type");

            migrationBuilder.DropTable(
                name: "brew_container");

            migrationBuilder.DropTable(
                name: "fermentable_type");

            migrationBuilder.DropTable(
                name: "hop_type");

            migrationBuilder.DropTable(
                name: "account");

            migrationBuilder.DropTable(
                name: "app_user");

            migrationBuilder.DropTable(
                name: "inventory_transaction_type");

            migrationBuilder.DropTable(
                name: "batch");

            migrationBuilder.DropTable(
                name: "product_container_size");

            migrationBuilder.DropTable(
                name: "use_during");

            migrationBuilder.DropTable(
                name: "address");

            migrationBuilder.DropTable(
                name: "address_type");

            migrationBuilder.DropTable(
                name: "supplier");

            migrationBuilder.DropTable(
                name: "ingredient");

            migrationBuilder.DropTable(
                name: "container_size");

            migrationBuilder.DropTable(
                name: "container_status");

            migrationBuilder.DropTable(
                name: "container_type");

            migrationBuilder.DropTable(
                name: "recipe");

            migrationBuilder.DropTable(
                name: "ingredient_type");

            migrationBuilder.DropTable(
                name: "unit_type");

            migrationBuilder.DropTable(
                name: "equipment");

            migrationBuilder.DropTable(
                name: "mash");

            migrationBuilder.DropTable(
                name: "style");
        }
    }
}
