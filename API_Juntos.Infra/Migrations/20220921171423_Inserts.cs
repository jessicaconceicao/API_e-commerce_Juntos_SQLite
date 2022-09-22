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
            migrationBuilder.Sql("INSERT INTO clientes values (5,'Mayara Campos', '98764524318', 'may.sarr@yahoo.com.br', '71987653425', 'Rua Telonio, n. 16, Salvador / BA');");
            migrationBuilder.Sql("INSERT INTO clientes values (6,'Elizabeth Cosimi', '01124538789', 'elictes@hotmail.com', '51984264218', 'Rua Castro Alves n. 256, Porto Alegre / RS');");
            migrationBuilder.Sql("INSERT INTO clientes values (7,'Tamara Caceres', '93324031957', 'tamaracaceres@gmail.com', '21982341225', 'Rua Xavier da Silveira n. 13, Rio de Janeiro / RJ');");
            migrationBuilder.Sql("INSERT INTO clientes values (8,'Claudia Aparecida Manero Madeira', '87756312593', 'clau_madeira@live.com', '4430196060', 'Rua Ipiranga n. 420, Cianorte / PR');");
            migrationBuilder.Sql("INSERT INTO clientes values (9,'Mirtes Wolf', '95217896617', 'mirteswolf@gmail.com', '51999746744', 'Rua Ceres-Norte n. 385 Porto Alegre / RS');");
            migrationBuilder.Sql("INSERT INTO clientes values (10,'Vivaldino Hass', '02342135041', 'vi_hass@gmail.com', '51996458254', 'Rua Santa Catarina n. 11, Guaiba / RS');");
            migrationBuilder.Sql("INSERT INTO clientes values (11,'Fernanda Pieczarka', '96687245321', 'ferpieczarka@yahoo.com.br', '4799644-9775', 'Rua Eugenio Sidorak n. 815, Papanduva / SC');");
            migrationBuilder.Sql("INSERT INTO clientes values (12,'Maria Alice Casela', '85234059863', 'maria_casela@gmail.com', '4430163807', 'Rua São Paulo n. 741, Campo Mourão / PR');");
            migrationBuilder.Sql("INSERT INTO clientes values (13,'Ana Elisa B. Barros', '05836287751', 'anaelisabarros@gmail.com', '4430163807', 'Rua Leopoldo Bier n. 311, Rio Branco / Acre');");
            migrationBuilder.Sql("INSERT INTO clientes values (14,'Maria da Silva', '05836287751', 'mdasilva@outlook.com', '5132281587', 'Rua Demetrio Ribeiro n. 1164, Porto Alegre / RS');");
            migrationBuilder.Sql("INSERT INTO clientes values (15,'Gil Vanei', '88855599856', 'gil-vanei@gmail.com', '7533315897', 'Rua Inocencio Monteiro de Souza n. 261, Itaete / BA');");
            migrationBuilder.Sql("INSERT INTO clientes values (16,'Carlos Alves Silvestre', '95217432159', 'calvessilvestre@gmail.com', '2126207475', 'Rua Jornalista Alberto Francisco Torres n. 99, Niteroi / RJ');");
            migrationBuilder.Sql("INSERT INTO clientes values (17,'Michele Ventura Costa', '02134552899', 'mivencosta@hotmail.com', '51995986888', 'Rua Adolfo Moog n. 71, Porto Alegre / RS');");
            migrationBuilder.Sql("INSERT INTO clientes values (18,'Luciene Martins De Farias', '91652831752', 'lufarias@outlook.com', '11999364303', 'Rua Ernesto de Oliveira n. 130, São Paulo / SP');");
            migrationBuilder.Sql("INSERT INTO clientes values (19,'Sandra Coelloni', '03522145662', 'sandra-coelloni@gmail.com', '51995593015', 'Rua Regente n. 246, Porto Alegre / RS');");
            migrationBuilder.Sql("INSERT INTO clientes values (20,'Catia Patricia da Silveira', '99562530115', 'catita_silveira@yahoo.com.br', '51981463575', 'Rua Mauá n. 2950, São Leopoldo / RS');");
            migrationBuilder.Sql("INSERT INTO clientes values (21,'Stefania Fracasso', '84126032157', 'stefaniaf@yahoo.com.br', '49999149064', 'Rua Marciano Leite de Almeida n. 25, Xanxerê / SC');");
            migrationBuilder.Sql("INSERT INTO clientes values (22,'Andre Bellandi', '02543162581', 'andre-bellandi@outlook.com', '6536456029', 'Rua Das Mangabas n. 14, Cuiabá / MT');");
            migrationBuilder.Sql("INSERT INTO clientes values (23,'Daniela Barreto de Souza', '95225478963', 'danielabsouza@gmail.com', '8587401754', 'Rua Cleyton Pimenta n. 630, Fortaleza / CE');");
            migrationBuilder.Sql("INSERT INTO clientes values (24,'Rubilar Martins de Souza', '01232158269', 'rubilar-martins@live.com', '5596032445', 'Rua Venancio Aires n. 615, Cruz Alta / RS');");

            migrationBuilder.Sql("INSERT INTO produtos values (1,'Argamassa ACII', '675GH', '36 meses', 20.00, 'kg', 29.80, 35);");
            migrationBuilder.Sql("INSERT INTO produtos values (2,'Argamassa', '875HH', '48 meses', 30.00, 'kg', 49.85, 40);");
            migrationBuilder.Sql("INSERT INTO produtos values (3,'Cimento', '333JJ', '60 meses', 15.00, 'kg', 63.11, 54);");
            migrationBuilder.Sql("INSERT INTO produtos values (4,'Argamassa ACII', '675GH', '36 meses', 20.00, 'kg', 29.80, 35);");
            migrationBuilder.Sql("INSERT INTO produtos values (5,'Argamassa ACIII', '675GH', '36 meses', 20.00, 'kg', 29.80, 35);");
            migrationBuilder.Sql("INSERT INTO produtos values (6,'Selante PU40 multiuso', 'L/1248', '15 meses', 360, 'g', 20.00, 50);");
            migrationBuilder.Sql("INSERT INTO produtos values (7,'Reboco Impermeável', '21JR086', '8 meses', 20.00, 'kg', 35.50, 20);");
            migrationBuilder.Sql("INSERT INTO produtos values (8,'Manta Líquida Preta', 'K12345630', '24 meses', 18.00, 'kg', 47.90, 30);");
            migrationBuilder.Sql("INSERT INTO produtos values (9,'Manta Líquida Branca', 'K17645630', '24 meses', 18.00, 'kg', 47.90, 30);");
            migrationBuilder.Sql("INSERT INTO produtos values (10,'Manta Líquida Ocre', 'K12348730', '24 meses', 18.00, 'kg', 47.90, 30);");
            migrationBuilder.Sql("INSERT INTO produtos values (11,'Manta Líquida Telha', 'K12345990', '24 meses', 18.00, 'kg', 47.90, 30);");
            migrationBuilder.Sql("INSERT INTO produtos values (12,'Revestimento Base de Fachadas', '15005552', '3 meses', 30.00, 'kg', 65.90, 20);");
            migrationBuilder.Sql("INSERT INTO produtos values (13,'Massa de Preparação', 'PB3201', '12 meses', 10.00, 'kg', 47.90, 15);");
            migrationBuilder.Sql("INSERT INTO produtos values (14,'Tinta Acrílica Standard', '35MR54', '6 meses', 18.00, 'L', 65.00, 20);");
            migrationBuilder.Sql("INSERT INTO produtos values (15,'Tinta PVA Standard', '35MR54', '6 meses', 18.00, 'L', 45.00, 20);");
            migrationBuilder.Sql("INSERT INTO produtos values (16,'Tinta esmalte Standard', '35MR54', '6 meses', 3.60, 'L', 45.00, 20);");
            migrationBuilder.Sql("INSERT INTO produtos values (17,'Weber.Guard Proteção Antipichação', '2157RA', '12 meses', 3.6, 'L', 48.90, 15);");
            migrationBuilder.Sql("INSERT INTO produtos values (18,'Adesivo Colamúlti', '35BA45', '24 meses', 2.8, 'kg', 20.00, 200);");
            migrationBuilder.Sql("INSERT INTO produtos values (18,'Adesivo Colamúlti', '35BA45', '24 meses', 1.4, 'kg', 10.00, 10);");
            
            
            migrationBuilder.Sql("INSERT INTO PEDIDOS VALUES(1,200,'2022-08-31',1);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS VALUES(2,300,'2022-09-15',2);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS VALUES(3,400,'2022-08-10',3);");

            migrationBuilder.Sql("INSERT INTO PRODUTOSDOSPEDIDOS VALUES(1,50,0,1,1);");
            migrationBuilder.Sql("INSERT INTO PRODUTOSDOSPEDIDOS VALUES(2,25,0,1,3);");
            migrationBuilder.Sql("INSERT INTO PRODUTOSDOSPEDIDOS VALUES(3,33,0,2,3);");
            migrationBuilder.Sql("INSERT INTO PRODUTOSDOSPEDIDOS VALUES(4,11,0,2,2);");
            migrationBuilder.Sql("INSERT INTO PRODUTOSDOSPEDIDOS VALUES(5,3,0,3,1);");

            
            migrationBuilder.Sql("INSERT INTO PEDIDOS VALUES(1,30,'2022-10-10',11);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS VALUES(2,30,'2022-05-10',12);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS VALUES(3,30,'2021-08-10',13);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS VALUES(4,30,'2022-04-10',14);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS VALUES(5,30,'2022-03-09',15);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS VALUES(6,30,'2022-08-10',1);"); 
            migrationBuilder.Sql("INSERT INTO PEDIDOS VALUES(7,30,'2022-09-10',2);"); 
            migrationBuilder.Sql("INSERT INTO PEDIDOS VALUES(8,30,'2021-08-12',3);"); 
            migrationBuilder.Sql("INSERT INTO PEDIDOS VALUES(9,30,'2022-04-10',4);"); 
            migrationBuilder.Sql("INSERT INTO PEDIDOS VALUES(10,30,'2022-06-11',5);"); 
            migrationBuilder.Sql("INSERT INTO PEDIDOS VALUES(11,30,'2022-08-10',6);"); 
            migrationBuilder.Sql("INSERT INTO PEDIDOS VALUES(12,30,'2022-06-10',7);"); 
            migrationBuilder.Sql("INSERT INTO PEDIDOS VALUES(13,30,'2020-08-10',8);"); 
            migrationBuilder.Sql("INSERT INTO PEDIDOS VALUES(14,30,'2021-08-11',9);"); 
            migrationBuilder.Sql("INSERT INTO PEDIDOS VALUES(15,30,'2022-08-11',10);"); 
            migrationBuilder.Sql("INSERT INTO PEDIDOS VALUES(16,30,'2022-10-10',11);"); 
            migrationBuilder.Sql("INSERT INTO PEDIDOS VALUES(17,30,'2022-05-10',12);"); 
            migrationBuilder.Sql("INSERT INTO PEDIDOS VALUES(18,30,'2021-08-10',13);"); 
            migrationBuilder.Sql("INSERT INTO PEDIDOS VALUES(19,30,'2022-04-10',14);"); 
            migrationBuilder.Sql("INSERT INTO PEDIDOS VALUES(20,30,'2022-03-09',15);"); 
            migrationBuilder.Sql("INSERT INTO PEDIDOS VALUES(21,30,'2021-03-10',16);"); 
            migrationBuilder.Sql("INSERT INTO PEDIDOS VALUES(22,30,'2022-05-12',17);"); 
            migrationBuilder.Sql("INSERT INTO PEDIDOS VALUES(23,30,'2021-03-11',18);"); 

            migrationBuilder.Sql("INSERT INTO PRODUTOSDOSPEDIDOS VALUES(6,3,30,1,18);");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
