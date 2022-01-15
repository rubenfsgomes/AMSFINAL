using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementação_AMS
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente("Rúben Gomes", 2543);
            Psicólogo p1 = new Psicólogo("Carla Costa", 3322);
            MembroEquipaGestão g1 = new MembroEquipaGestão("Jorge Cunha", 1432);
            DateTime dataConsulta = new DateTime(2022, 12, 12, 15, 30, 0);
            DateTime dataConsultaNova = new DateTime(2022, 12, 10, 16, 30, 0);
            DateTime dataAtiviade = new DateTime(2022, 6, 2, 13, 30, 0);

            c1.MarcarConsulta(dataConsulta, c1, p1, 44);

            p1.ProporOutraData(dataConsultaNova, 44);

            g1.ProporAtividade(dataAtiviade, p1, "Desporto", 15);

            p1.DesignaAtividade(g1, 15, "Torneio das Olimpíadas");

        }
    }
}
