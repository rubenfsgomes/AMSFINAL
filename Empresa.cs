using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementação_AMS
{
    class Empresa
    {
        #region atributos
        int idEmpresa;
        List<Psicólogo> psicólogos;
        List<Cliente> clientes;
        List<MembroEquipaGestão> gestores;
        #endregion

        #region construtores
        public Empresa(int id)
        {
            idEmpresa = id;
            psicólogos = new List<Psicólogo>();
            clientes = new List<Cliente>();
            gestores = new List<MembroEquipaGestão>();
        }
        #endregion

        #region propriedades
        public List<Psicólogo> Psicólogos
        {
            get
            {
                return psicólogos;
            }    
            set
            {
                psicólogos = value;
            }
        }
        public List<Cliente> Clientes
        {
            get
            {
                return clientes;
            }
            set
            {
                clientes = value;
            }
        }
        public List<MembroEquipaGestão> Gestores
        {
            get
            {
                return gestores;
            }
            set
            {
                gestores = value;
            }
        }
        #endregion

        #region metodos
        public Psicólogo EncontraPsicologo(int id)
        {
            foreach(Psicólogo obj in psicólogos)
            {
                if(obj.NumEmp==id)
                {
                    return obj;
                }
            }
            return null;
        }
        public MembroEquipaGestão EncontraGestor(int id)
        {
            foreach (MembroEquipaGestão obj in gestores)
            {
                if (obj.NumEmp == id)
                {
                    return obj;
                }
            }
            return null;
        }
        public void AdicionaCliente(Cliente c)
        {
            clientes.Add(c);
        }
        public void AdicionaPsicologo(Psicólogo p)
        {
            psicólogos.Add(p);
        }
        public void AdicionaGestor(MembroEquipaGestão g)
        {
            gestores.Add(g);
        }
        #endregion
    }
}
