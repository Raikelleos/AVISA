using AVISA.Core.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace AVISA.Core.Context
{
    public static class PopulaContext
    {
        public static void IncluiDados(IApplicationBuilder app)
        {
            IncluiDados(app.ApplicationServices.GetRequiredService<MedicamentoContext>());
        }

        public static void IncluiDados(MedicamentoContext context)
        {
            context.Database.Migrate();

            if (!context.Medicamentos.Any())
            {
                context.Medicamentos.AddRange(
                    new Medicamento(1, "Annita", 25, null),
                    new Medicamento(2, "Bactrim", 5, null),
                    new Medicamento(3, "Cataflam D", 2, null),
                    new Medicamento(4, "Dramin B6", 10, null),
                    new Medicamento(5, "Eranz", 0, null),
                    new Medicamento(6, "Fentanil", 11, null),
                    new Medicamento(7, "Geodon", 6, null)
                );
                context.SaveChanges();
            }
        }
    }
}
