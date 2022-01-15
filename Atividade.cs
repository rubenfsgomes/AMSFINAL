using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementação_AMS
{
    class Atividade
    {
        #region Atributos
        int id;
        DateTime dataHoraAtividade;
        Psicólogo responsável;
        List<Cliente> Clientes;
        string tipoAtividade;
        string descAtividade;

        #endregion

        #region construtores
        public Atividade(DateTime dataHoraAtividade, Psicólogo responsável, string tipoAtividade, int id)
        {
            this.id = id;
            this.dataHoraAtividade = dataHoraAtividade;
            this.responsável = responsável ?? throw new ArgumentNullException(nameof(responsável));
            Clientes = new List<Cliente>();
            this.tipoAtividade = tipoAtividade ?? throw new ArgumentNullException(nameof(tipoAtividade));
            this.descAtividade = descAtividade ?? throw new ArgumentNullException(nameof(descAtividade));
        }
        #endregion

        #region propriedades
        public DateTime DataHoraAtividade
        {
            get
            {
                return dataHoraAtividade;
            }
            set
            {
                dataHoraAtividade = value;
            }
        }

        public int ID
        {
            get
            {
                return id;
            }
        }
        public string DescAtividade
        {
            get
            {
                return descAtividade;
            }
            set
            {
                descAtividade = value;
            }
        }
        #endregion
    }
}
