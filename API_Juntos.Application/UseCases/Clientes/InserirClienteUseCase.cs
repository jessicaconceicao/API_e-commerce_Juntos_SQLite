using API_Juntos.Application.Models.Cliente.InserirCliente;
using API_Juntos.Application.Validations;
using API_Juntos.Core.Entidades;
using API_Juntos.Core.Repositorios;
using AutoMapper;
using System;
using System.Threading.Tasks;

namespace API_Juntos.Application.UseCases.Clientes
{
    public class InserirClienteUseCase : IUseCaseAsync<InserirClienteRequest, InserirClienteResponse>
    {
        private readonly IClienteRepository _repository;
        private readonly IMapper _mapper;

        public InserirClienteUseCase(IClienteRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<InserirClienteResponse> ExecuteAsync(InserirClienteRequest request)
        {
            var validator = new AtualizarClienteRequestValidator();
            var validatorResults = validator.Validate(request);

            if (!validatorResults.IsValid)
            {
                var validatorErros = string.Empty;
                foreach (var error in validatorResults.Errors)
                    validatorErros += error.ErrorMessage + " | ";

                throw new Exception(validatorErros);
            }

            if (request == null)
            { return null; }

            var cliente = _mapper.Map<Cliente>(request);

            await _repository.Inserir(cliente);

            var clienteResponse = new InserirClienteResponse();
            clienteResponse.Messagem = "Cliente inserido com sucesso!";
            return clienteResponse;

        }
    }
}
