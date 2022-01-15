using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementação_AMS
{
    class MembroEquipaGestão
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

    }
}
