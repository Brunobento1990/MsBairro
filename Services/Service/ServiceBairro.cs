using MsBairro.Dtos;
using MsBairro.Repositorys.Entidades;
using MsBairro.Repositorys.Interfaces;
using MsBairro.Services.Interfaces;

namespace MsBairro.Services.Service
{
    public class ServiceBairro : IServiceBairro
    {
        private readonly IRepositoryBairro _repositoryBairro;
        public ServiceBairro(IRepositoryBairro repositoryBairro)
        {
            _repositoryBairro = repositoryBairro;
        }
        public async Task<bool> AddBairro(BairroDto bairroDto)
        {
            try
            {
                if (bairroDto == null) throw new Exception("Dados do bairro enviados nulos.");
                if (string.IsNullOrEmpty(bairroDto.Nome.Trim())) throw new Exception("Nome do bairro é obrigatório.");

                var bairro = new Bairro()
                {
                    Id = 0,
                    Nome = bairroDto.Nome
                };

                await this._repositoryBairro.AddBairro(bairro);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
