using System;

namespace AVISA.Core.Models
{
    public class Medicamento
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public int Quantidade { get; set; }

        public DateTime? Horario { get; set; }

        public Medicamento()
        {

        }

        public Medicamento(int id, string nome, int quantidade, DateTime? horario)
        {
            this.Id = id;
            this.Nome = nome;
            this.Quantidade = quantidade;
            this.Horario = horario;
        }
    }
}
