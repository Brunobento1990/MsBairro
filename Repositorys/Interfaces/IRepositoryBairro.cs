using MsBairro.Repositorys.Entidades;

namespace MsBairro.Repositorys.Interfaces
{
    public interface IRepositoryBairro
    {
        Task<bool> AddBairro(Bairro bairro);
    }
}
