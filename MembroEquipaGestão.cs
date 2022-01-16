using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementação_AMS
{
    class MembroEquipaGestão : IEquatable<MembroEquipaGestão>
    {
        #region Atributos
        string nome;
        int numEmp;
        List<Atividade> atividades;
        #endregion

        #region construtores
        public MembroEquipaGestão(string nome, int numEmp)
        {
            this.nome = nome ?? throw new ArgumentNullException(nameof(nome));
            this.numEmp = numEmp;
            this.atividades = new List<Atividade>();
        }
        #endregion

        #region propriedades
        public string Nome
        {
            get
            {
                return nome;
            }
        }
        public List<Atividade> Atividades
        {
            get
            {
                return atividades;
            }
            set
            {
                atividades = value;
            }
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as MembroEquipaGestão);
        }

        public bool Equals(MembroEquipaGestão other)
        {
            return other != null &&
                   nome == other.nome &&
                   numEmp == other.numEmp;
        }

        public override int GetHashCode()
        {
            int hashCode = -158158361;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nome);
            hashCode = hashCode * -1521134295 + numEmp.GetHashCode();
            return hashCode;
        }
        #endregion

        #region Metodos
        public bool ProporAtividade(DateTime dataHora, Psicólogo psicólogo, string desc, int id)
        {
            Atividade atividade = new Atividade(dataHora, psicólogo, desc, id);
            if(psicólogo.CalendarioLivre(dataHora))
            {
                atividades.Add(atividade);
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        #region overrides
        public static bool operator ==(MembroEquipaGestão left, MembroEquipaGestão right)
        {
            return EqualityComparer<MembroEquipaGestão>.Default.Equals(left, right);
        }

        public static bool operator !=(MembroEquipaGestão left, MembroEquipaGestão right)
        {
            return !(left == right);
        }
        #endregion

    }
}
