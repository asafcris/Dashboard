using System;
using System.Collections.Generic;
using System.Text;

namespace Dashboard.Domain.Model
{
    public class PerfilAcesso 
    {
        public PerfilAcesso()
        {
            Funcionalidades = new List<Funcionalidade>();
        }
        public virtual string Nome { get; set; }
        public virtual string Descricao { get; set; }
        public virtual IList<Funcionalidade> Funcionalidades { get; set; }
        public virtual DateTime DataHoraCadastro { get; set; }
        public virtual Usuario UsuarioCadastro { get; set; }
    }
}
