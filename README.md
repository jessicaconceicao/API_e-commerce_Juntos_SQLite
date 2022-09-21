# API_Juntos
API para gerenciamento de pedidos, cadastro de produtos e clientes de uma plataforma de e-commerce.
Projeto de conclusão de curso do programa Construdelas (Bootcamp promovido pela WoMakersCode em parceria com a empresa Juntos Somos Mais). 

- BD:SQLite
- Ao rodar a aplicação as migrações de criação das tabelas e inserção de dados teste serão executadas.
- Endpoints: 
           Clientes: POST, DELETE, LISTAR POR ID, LISTAR TODOS
           Produtos: POST, DELETE, LISTAR POR ID, LISTAR TODOS
           Pedidos: POST, DELETE, LISTAR POR ID, LISTAR TODOS


Comando utilizado para gerar as Migrations(executados na pasta raiz do projeto):

Tabelas: dotnet ef --startup-project ./API_e-commerce_Juntos/API_e-commerce_Juntos.csproj  migrations add Tabelas -p ./API_Juntos.Infra/API_Juntos.Infra.csproj
Inserções: dotnet ef --startup-project ./API_e-commerce_Juntos/API_e-commerce_Juntos.csproj  migrations add Inserts -p ./API_Juntos.Infra/API_Juntos.Infra.csproj
Update: dotnet ef database update --project ./API_e-commerce_Juntos 