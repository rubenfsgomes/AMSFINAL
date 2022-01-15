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
