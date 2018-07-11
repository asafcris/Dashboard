using System;
using System.Collections.Generic;
using System.Text;

namespace Dashboard.Domain.Model
{
    public class Funcionalidade :  IEquatable<Funcionalidade>
    {

        public virtual long Id { get; set; }
        public virtual Funcionalidade Categoria { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Descricao { get; set; }
        public virtual string CodigoAcesso { get; set; }

        public Funcionalidade()
        {
        }

        public Funcionalidade(long id, string nome)
        {
            this.Id = id;
            this.Nome = nome;
        }

        /// <summary>
        /// Determina ou define se esta é uma funcionalidade fixa, ou seja,
        /// associada a um elemento do código fonte do sistema.
        /// Funcionalidades não fixas, são dinâmicas.
        /// </summary>
        public virtual bool Fixo { get; set; }

        bool IEquatable<Funcionalidade>.Equals(Funcionalidade other)
        {
            if (other == null) return false;
            return this.Id == other.Id;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", this.Id, this.Nome);
        }

    }
}
