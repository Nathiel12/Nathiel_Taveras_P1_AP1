using Microsoft.EntityFrameworkCore;
using Nathiel_Taveras_P1_AP1.DAL;
using Nathiel_Taveras_P1_AP1.Models;

namespace Nathiel_Taveras_P1_AP1.Services
{
    public class ModeloService(IDbContextFactory<Contexto> DbFactory)
    {
        public async Task<bool> Guardar(Modelo modelo)
        {
            
        }
        public async Task<bool> Existe(int modelo)
        {

        }
        private async Task<bool> Insertar(Modelo modelo)
        {

        }
        private async Task<bool> Modificar(Modelo modelo)
        {

        }
        public async Task<Modelo?> Buscar(int modeloId)
        {

        }
        public async Task<bool> Eliminar(int modeloId)
        {

        }
        public async Task<List<Modelo>> Listar(Expression<Func<Modelo, bool>> criterio)
        {

        }
    }
}
