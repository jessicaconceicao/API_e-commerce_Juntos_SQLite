using API_Juntos.Application.Mappings;
using API_Juntos.Application.Models.Cliente.ExcluirCliente;
using API_Juntos.Application.Models.Cliente.InserirCliente;
using API_Juntos.Application.Models.Cliente.ListarClientePorId;
using API_Juntos.Application.Models.Cliente.ListarClientes;
using API_Juntos.Application.Models.Pedidos.ExcluirPedidos;
using API_Juntos.Application.Models.Pedidos.InserirPedido;
using API_Juntos.Application.Models.Pedidos.ListarPedidoPorId;
using API_Juntos.Application.Models.Pedidos.ListarPedidos;
using API_Juntos.Application.Models.Produtos.ExcluirProduto;
using API_Juntos.Application.Models.Produtos.InserirProduto;
using API_Juntos.Application.Models.Produtos.ListarProdutoPorId;
using API_Juntos.Application.Models.Produtos.ListarProdutos;
using API_Juntos.Application.UseCases;
using API_Juntos.Application.UseCases.Clientes;
using API_Juntos.Application.UseCases.Pedidos;
using API_Juntos.Application.UseCases.Produtos;
using API_Juntos.Core.Repositorios;
using API_Juntos.Infra.Database;
using API_Juntos.Infra.Repositorios;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace API_e_commerce_Juntos
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddTransient<IClienteRepository, ClienteRepository>();
            services.AddTransient<IProdutoRepository, ProdutoRepository>();
            services.AddTransient<IPedidoRepository, PedidoRepository>();
            services.AddTransient<IProdutosDoPedidoRepository, ProdutosDoPedidoRepository>();

            services.AddTransient<IUseCaseAsync<InserirClienteRequest, InserirClienteResponse>, InserirClienteUseCase>();
            //services.AddTransient<IUseCaseAsync<AtualizarClienteRequest, AtualizarClienteResponse>, AtualizarClienteUseCase>();
            services.AddTransient<IUseCaseAsync<ExcluirClienteRequest, ExcluirClienteResponse>, ExcluirClienteUseCase>();
            services.AddTransient<IUseCaseAsync<int, ListarClientePorIdResponse>, ListarClientePorIdUseCase>();
            services.AddTransient<IUseCaseAsync<ListarClientesRequest, List<ListarClientesResponse>>, ListarClientesUseCase>();

            services.AddTransient<IUseCaseAsync<InserirProdutoRequest, InserirProdutoResponse>, InserirProdutoUseCase>();
            //services.AddTransient<IUseCaseAsync<AtualizarProdutoRequest, AtualizarProdutoResponse>, AtualizarProdutoUseCase>();
            services.AddTransient<IUseCaseAsync<ExcluirProdutoRequest, ExcluirProdutoResponse>, ExcluirProdutoUseCase>();
            services.AddTransient<IUseCaseAsync<int, ListarProdutoPorIdResponse>, ListarProdutoPorIdUseCase>();
            services.AddTransient<IUseCaseAsync<ListarProdutosRequest, List<ListarProdutosResponse>>, ListarProdutosUseCase>();

            services.AddTransient<IUseCaseAsync<InserirPedidoRequest, InserirPedidoResponse>, InserirPedidoUseCase>();
            //// services.AddTransient<IUseCaseAsync<AtualizarPedidoRequest, AtualizarPedidoResponse>, AtualizarPedidoUseCase>();
            services.AddTransient<IUseCaseAsync<ExcluirPedidoRequest, ExcluirPedidoResponse>, ExcluirPedidoUseCase>();
            services.AddTransient<IUseCaseAsync<int, ListarPedidoPorIdResponse>, ListarPedidoPorIdUseCase>();
            services.AddTransient<IUseCaseAsync<ListarPedidosRequest, List<ListarPedidosResponse>>, ListarPedidosUseCase>();

            services.AddAutoMapper(typeof(MappingProfile));

            //services.AddDbContext<ApplicationContext>(options =>
            //    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
            //    .UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()))
            // );
            services.AddDbContext<ApplicationContext>(options =>
               options.UseSqlite(Configuration.GetConnectionString("DefaultConnection"))
               .UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()))
            );

            services.AddControllers();
            //services.AddControllers().AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve);//APAGAR
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "API_e_commerce_Juntos", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ApplicationContext context)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "API_e_commerce_Juntos v1"));
            }

            context.Database.Migrate();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
