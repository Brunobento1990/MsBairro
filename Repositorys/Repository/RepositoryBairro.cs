using MsBairro.MsContext;
using MsBairro.Repositorys.Entidades;
using MsBairro.Repositorys.Interfaces;

namespace MsBairro.Repositorys.Repository
{
    public class RepositoryBairro : IRepositoryBairro
    {
        protected MsBairroContext _dbContext;
        public RepositoryBairro(MsBairroContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<bool> AddBairro(Bairro bairro)
        {
            try
            {
                _dbContext.Set<Bairro>().Add(bairro);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
