using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementação_AMS
{
    class Cliente
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
        #endregion
    }
}
