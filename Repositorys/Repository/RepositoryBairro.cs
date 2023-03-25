using MsBairro.MsContext;
using MsBairro.Repositorys.Entidades;
using MsBairro.Repositorys.Interfaces;
using System.Data.Entity;

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

        public async Task<bool> DeleteBairro(Bairro bairro)
        {
            try
            {
                _dbContext.Set<Bairro>().Remove(bairro);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<Bairro>> GetAll()
        {
            var bairros = new List<Bairro>();
            try
            {
                bairros = await _dbContext.Bairro.AsNoTracking().ToListAsync();
            }
            catch (Exception)
            {
                bairros = null;
            }

            return bairros;
        }

        public async Task<Bairro> GetById(int id)
        {
            var bairro = new Bairro();

            try
            {
                bairro = await _dbContext.Bairro.FirstOrDefaultAsync(bairro => bairro.Id == id);
            }
            catch (Exception)
            {
                bairro = null;
            }

            return bairro;
        }

        public async Task<bool> UpdateBairro(Bairro bairro)
        {
            try
            {
                _dbContext.Bairro.Update(bairro);
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
