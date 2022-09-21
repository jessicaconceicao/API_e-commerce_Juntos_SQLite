using Microsoft.EntityFrameworkCore.Migrations;

namespace API_Juntos.Infra.Migrations
{
    public partial class Inserts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO clientes values (1,'Mayara Campos', '98764524318', 'may.sarr@yahoo.com.br', '71987653425', 'Rua Telonio, n. 16, Salvador');");
            migrationBuilder.Sql("INSERT INTO clientes values (2,'Jamile Duarte', '00045789631', 'jamile@gmail.com', '71996331847', 'Rua do Codigo, n. 5, Cachoeira');");
            migrationBuilder.Sql("INSERT INTO clientes values (3,'Rodrigo Neves', '99965845215', 'rodrigo@gmail.com', '71995152365', 'Rua da Gota, n. 10, Rio de Janeiro');");
            migrationBuilder.Sql("INSERT INTO clientes values (4,'Jessica Caetano', '04788865421', 'jessica@gmail.com', '71988483425', 'Rua das Arvores, n. 15, Feira de Santana');");

            migrationBuilder.Sql("INSERT INTO produtos values (1,'Argamassa ACII', '675GH', '36 meses', 20.00, 'kg', 29.80, 35);");
            migrationBuilder.Sql("INSERT INTO produtos values (2,'Argamassa', '875HH', '48 meses', 30.00, 'kg', 49.85, 40);");
            migrationBuilder.Sql("INSERT INTO produtos values (3,'Cimento', '333JJ', '60 meses', 15.00, 'kg', 63.11, 54);");

            migrationBuilder.Sql("INSERT INTO PEDIDOS VALUES(1,200,'2022-08-31',1);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS VALUES(2,300,'2022-09-15',2);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS VALUES(3,400,'2022-08-10',3);");

            migrationBuilder.Sql("INSERT INTO PRODUTOSDOSPEDIDOS VALUES(1,50,0,1,1);");
            migrationBuilder.Sql("INSERT INTO PRODUTOSDOSPEDIDOS VALUES(2,25,0,1,3);");
            migrationBuilder.Sql("INSERT INTO PRODUTOSDOSPEDIDOS VALUES(3,33,0,2,3);");
            migrationBuilder.Sql("INSERT INTO PRODUTOSDOSPEDIDOS VALUES(4,11,0,2,2);");
            migrationBuilder.Sql("INSERT INTO PRODUTOSDOSPEDIDOS VALUES(5,3,0,3,1);");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
