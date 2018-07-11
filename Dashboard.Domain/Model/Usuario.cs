using System;
using System.Collections.Generic;
using System.Text;

namespace Dashboard.Domain.Model
{
    public class Usuario 
    {


        public virtual string Login { get; set; }
        public virtual string Senha { get; set; }
        public virtual PerfilAcesso PerfilAcesso { get; set; }
        public virtual DateTime? DataUltimoAcesso { get; set; }
        public virtual DateTime? DataUltimaSenha { get; set; }
        public virtual string Senha1 { get; set; }
        public virtual string Senha2 { get; set; }
        public virtual string Senha3 { get; set; }
        public virtual string Foto { get; set; }
        public virtual string Extensao { get; set; }
        public virtual DateTime? DataHoraFoto { get; set; }
        public virtual string Arquivo { get; set; }


    }
}
