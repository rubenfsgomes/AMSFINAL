using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementação_AMS
{
    class Cliente : IEquatable<Cliente>
    {
        #region atributos
        string nomeCliente;
        int numCliente;
        List<Consulta> consultas; //Lista de Consultas
        #endregion

        #region construtores
        public Cliente(string nomeCliente, int numCliente)
        {
            this.nomeCliente = nomeCliente ?? throw new ArgumentNullException(nameof(nomeCliente));
            this.numCliente = numCliente;
            this.consultas = new List<Consulta>();
        }
        #endregion

        #region metodos
        public bool MarcarConsulta(DateTime dataHora, Cliente c, Psicólogo p, int id)
        {
            Consulta con = new Consulta(dataHora, p, c, id);
            if (p.CalendarioLivre(dataHora))
            {

                p.Consultas.Add(con);
                return true;
            }
            return false;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Cliente);
        }

        public bool Equals(Cliente other)
        {
            return other != null &&
                   nomeCliente == other.nomeCliente &&
                   numCliente == other.numCliente;
        }

        public override int GetHashCode()
        {
            int hashCode = 132735665;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nomeCliente);
            hashCode = hashCode * -1521134295 + numCliente.GetHashCode();
            return hashCode;
        }
        #endregion

        #region propriedades
        public string NomeCliente
        {
            get
            {
                return nomeCliente;
            }
            set
            {
                nomeCliente = value;
            }
        }
        public int NumCliente
        {
            get
            {
                return numCliente;
            }
        }

        #endregion

        #region overrides
        public static bool operator ==(Cliente left, Cliente right)
        {
            return EqualityComparer<Cliente>.Default.Equals(left, right);
        }

        public static bool operator !=(Cliente left, Cliente right)
        {
            return !(left == right);
        }
        #endregion

    }
}
