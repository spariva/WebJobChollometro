using Microsoft.EntityFrameworkCore;
using MvcNetCoreChollome.Data;
using MvcNetCoreChollome.Models;

namespace MvcNetCoreChollome.Repositories
{
    public class RepositoryChollometro
    {
        private ChollometroContext context;

        public RepositoryChollometro(ChollometroContext context) {
            this.context = context;
        }

        public async Task<List<Chollo>> GetChollosAsync() {
            return await this.context.Chollos.OrderByDescending(x => x.Fecha).ToListAsync();
        }


    }
}
