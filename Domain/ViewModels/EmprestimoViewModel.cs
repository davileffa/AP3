using System;

namespace AP3.Domain.ViewModels
{
    public class EmprestimoViewModel
    {
        public int UsuarioId { get; set; }
        public int LivroId { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucao { get; set; }
    }
}
