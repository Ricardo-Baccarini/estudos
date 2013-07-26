using System;

namespace ObjetoTransferencia
{
    public class Cliente
    {
        // Variaveis
        public int idCliente { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public Boolean Sexo { get; set; }
        public decimal LimiteCompra { get; set; }
    }
}
