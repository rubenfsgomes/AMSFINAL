using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementação_AMS
{
    class Consulta : IEquatable<Consulta>
    {
        #region atributos
        DateTime dataHoraConsulta;
        Psicólogo psicólogo;
        Cliente cliente;
        int id;
        #endregion

        #region construtores
        public Consulta(DateTime dataHoraConsulta, Psicólogo psicólogo, Cliente cliente, int id)
        {
            this.id = id;
            this.dataHoraConsulta = dataHoraConsulta;
            this.psicólogo = psicólogo ?? throw new ArgumentNullException(nameof(psicólogo));
            this.cliente = cliente ?? throw new ArgumentNullException(nameof(cliente));
        }
        #endregion

        #region propriedades
        public DateTime DataConsulta
        {
            get
            {
                return dataHoraConsulta;
            }
            set
            {
                dataHoraConsulta = value;
            }
        }
        public int ID
        {
            get
            {
                return id;
            }
        }
        #endregion

        #region metodos
        #endregion

        #region overrides
        public override bool Equals(object obj)
        {
            return Equals(obj as Consulta);
        }

        public bool Equals(Consulta other)
        {
            return other != null &&
                   dataHoraConsulta == other.dataHoraConsulta;
        }

        public override int GetHashCode()
        {
            int hashCode = -1161400505;
            hashCode = hashCode * -1521134295 + dataHoraConsulta.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Psicólogo>.Default.GetHashCode(psicólogo);
            hashCode = hashCode * -1521134295 + EqualityComparer<Cliente>.Default.GetHashCode(cliente);
            hashCode = hashCode * -1521134295 + id.GetHashCode();
            hashCode = hashCode * -1521134295 + DataConsulta.GetHashCode();
            hashCode = hashCode * -1521134295 + ID.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(Consulta left, Consulta right)
        {
            return EqualityComparer<Consulta>.Default.Equals(left, right);
        }

        public static bool operator !=(Consulta left, Consulta right)
        {
            return !(left == right);
        }
        #endregion

    }
}
