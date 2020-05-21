using AVISA.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace AVISA.Core.Context
{
    public class MedicamentoContext : DbContext
    {
        public DbSet<Medicamento> Medicamentos { get; set; }

        public MedicamentoContext(DbContextOptions<MedicamentoContext> options) : base(options)
        {

        }
    }
}
