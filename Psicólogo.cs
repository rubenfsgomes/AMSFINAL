using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementação_AMS
{
    class Psicólogo : IEquatable<Psicólogo>
    {
        #region atributos
        string nomePsicologo;
        int numEmp;
        List<Consulta> consultas; //Lista de Consultas
        #endregion

        #region construtores
        /// <summary>
        /// Construtor da classe psicologo
        /// </summary>
        /// <param name="nomePsicologo"></param>
        /// <param name="numEmp"></param>
        public Psicólogo(string nomePsicologo, int numEmp)
        {
            this.nomePsicologo = nomePsicologo ?? throw new ArgumentNullException(nameof(nomePsicologo));
            this.numEmp = numEmp;
            this.consultas = new List<Consulta>();
        }
        #endregion

        #region propriedades
        /// <summary>
        /// Propriedade para devolver o nome do psicólgo
        /// </summary>
        public string NomePsicologo
        {
            get
            {
                return nomePsicologo;
            }
        }
        /// <summary>
        /// Propriedade para devolver o numero do empregado
        /// </summary>
        public int NumEmp
        {
            get
            {
                return numEmp;
            }
        }

        public List<Consulta> Consultas 
        {
            get
            {
                return consultas;
            }
            set
            {
                consultas = value;
            }
        }
        #endregion

        #region métodos
        public bool CalendarioLivre(DateTime dataHora)
        {

            foreach (Consulta obj in consultas)
            {
                if (obj.DataConsulta == dataHora)
                {
                    return false;
                }
            }
            return true;
        }

        public bool ProporOutraData(DateTime dataHora, int id)
        {
            foreach(Consulta obj in consultas)
            {
                if(obj.ID == id)
                {
                    obj.DataConsulta = dataHora;
                    return true;
                }
            }
            return false;
        }
        public bool DesignaAtividade(MembroEquipaGestão m ,int id, string desc)
        {
            foreach(Atividade obj in m.Atividades)
            {
                if(obj.ID == id)
                {
                    obj.DescAtividade = desc;
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region overrides
        public override bool Equals(object obj)
        {
            return Equals(obj as Psicólogo);
        }

        public bool Equals(Psicólogo other)
        {
            return other != null &&
                   nomePsicologo == other.nomePsicologo &&
                   numEmp == other.numEmp;
        }

        public override int GetHashCode()
        {
            int hashCode = -1466580540;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nomePsicologo);
            hashCode = hashCode * -1521134295 + numEmp.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(Psicólogo left, Psicólogo right)
        {
            return EqualityComparer<Psicólogo>.Default.Equals(left, right);
        }

        public static bool operator !=(Psicólogo left, Psicólogo right)
        {
            return !(left == right);
        }
        #endregion
    }
}
