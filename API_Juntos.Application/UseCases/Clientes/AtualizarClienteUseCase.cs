//using API_Juntos.Application.Models.Cliente.AtualizarCliente;
//using API_Juntos.Application.Validations;
//using API_Juntos.Core.Entidades;
//using API_Juntos.Core.Repositorios;
//using AutoMapper;
//using FluentValidation;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace API_Juntos.Application.UseCases.Clientes
//{
//    public class AtualizarClienteUseCase : IUseCaseAsync<AtualizarClienteRequest, AtualizarClienteResponse>
//    {
//        private readonly IClienteRepository _repository;
//        private readonly IMapper _mapper;

//        public AtualizarClienteUseCase(IClienteRepository repository, IMapper mapper)
//        {
//            _repository = repository;
//            _mapper = mapper;
//        }

//        public async Task<AtualizarClienteResponse> ExecuteAsync(AtualizarClienteRequest request)
//        {
//            if (request == null)
//                return null;


//            var cliente = await _repository.ListarPorId(request.IdCliente); //acessa o repositório para chamar o método listar por id para identificar os dados do usuário atualizar
//                                                                            //é realmente necessário criar outro método? não poderia apenas listar por id para acessar qual vai modificar?

//            //como ficaria o mapeamento??? cliente = _mapper.Map<AtualizarClienteResponse, Cliente>(request);
//            //cliente.Nome = request.Nome;
//            //cliente.Email = request.Email;
//            //cliente.Telefone = request.Telefone;
//            //cliente.CPF = request.CPF;
//            //cliente.Endereco = request.Endereco;

//            await _repository.Atualizar(cliente);

//            var mensagemAtualizacao = new AtualizarClienteResponse();
//            mensagemAtualizacao.Mensagem = "Atualização feita com sucesso!";
//            return mensagemAtualizacao;

//        }

//    }
//}
