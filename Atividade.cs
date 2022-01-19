using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementação_AMS
{
    class Atividade : IEquatable<Atividade>
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

        #region overrides
        public override bool Equals(object obj)
        {
            return Equals(obj as Atividade);
        }

        public bool Equals(Atividade other)
        {
            return other != null &&
                   id == other.id;
        }

        public override int GetHashCode()
        {
            return 1877310944 + id.GetHashCode();
        }

        public static bool operator ==(Atividade left, Atividade right)
        {
            return EqualityComparer<Atividade>.Default.Equals(left, right);
        }

        public static bool operator !=(Atividade left, Atividade right)
        {
            return !(left == right);
        }
        #endregion
    }
}
