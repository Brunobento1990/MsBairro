using MsBairro.Dtos;

namespace MsBairro.Services.Interfaces
{
    public interface IServiceBairro
    {
        Task<bool> AddBairro(BairroDto bairroDto);
    }
}
