using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Implementação_AMS
{
    class Program
    {
        static void Main(string[] args)
        {
            #region variáveis declarações
            Empresa e = new Empresa(1);
            Cliente c1 = new Cliente("Rúben Gomes", 2543);
            e.AdicionaCliente(c1);
            Psicólogo p1 = new Psicólogo("Carla Costa", 3322);
            e.AdicionaPsicologo(p1);
            Psicólogo p2 = new Psicólogo("Joana Ribeiro", 6352);
            e.AdicionaPsicologo(p2);
            MembroEquipaGestão g1 = new MembroEquipaGestão("Jorge Cunha", 1432);
            string targetDateFormat = "dd/MM/yyyy", tipoAtividade, descAtividade;
            DateTime dt;
            int choice, id, idConsulta, idPsicólogo, idAtividade, idGestor;
            Random rd = new Random();
            #endregion

            #region Menu
            do
            {
                Console.WriteLine("Menu: ");
                Console.WriteLine("Escolha o seu cargo;");
                Console.WriteLine("1-Cliente;");
                Console.WriteLine("2-Psicólogo;");
                Console.WriteLine("3-Equipa de Gestão;");
                Console.WriteLine("0-Sair.");
                Console.WriteLine("Escolha: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("1-Marcar Consulta;");
                        Console.WriteLine("Escolha: ");
                        choice = Convert.ToInt32(Console.ReadLine());
                        if (choice == 1)
                        {
                            Console.WriteLine("Introduza data (day/month/year): ");
                            string enteredDateString = Console.ReadLine();

                            dt = DateTime.ParseExact(enteredDateString, targetDateFormat, CultureInfo.InvariantCulture);

                            Console.WriteLine("Introduza nº de psicólogo: ");
                            id = Convert.ToInt32(Console.ReadLine());

                            idConsulta = rd.Next(1000, 9999);

                            c1.MarcarConsulta(dt, c1, e.EncontraPsicologo(id), idConsulta);

                            Console.WriteLine("Consulta nº: " + idConsulta);

                        }
                        else
                        {
                            Console.WriteLine("Escolha Inválida!");
                        }
                        break;
                    case 2:
                        Console.WriteLine("1-Propor outra data;");
                        Console.WriteLine("2-Designar atividade.");
                        Console.WriteLine("Escolha: ");
                        choice = Convert.ToInt32(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Introduza data (day/month/year): ");
                                string enteredDateString = Console.ReadLine();

                                dt = DateTime.ParseExact(enteredDateString, targetDateFormat, CultureInfo.InvariantCulture);

                                Console.WriteLine("Introduza id da Consulta: ");
                                idConsulta = Convert.ToInt32(Console.ReadLine());

                                p1.ProporOutraData(dt, idConsulta);

                                break;
                            case 2:
                                Console.WriteLine("Introduza o ID do gestor responsável: ");
                                idGestor = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Introduza o ID da atividade a definir: ");
                                idAtividade = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Descreva a Atividade: ");
                                descAtividade = Console.ReadLine();
                                p1.DesignaAtividade(e.EncontraGestor(idGestor), idAtividade, descAtividade);

                                break;
                        }

                        break;
                    case 3:
                        Console.WriteLine("1-Propor atividade.");
                        choice = Convert.ToInt32(Console.ReadLine());
                        if (choice == 1)
                        {
                            Console.WriteLine("Introduza data (day/month/year): ");
                            string enteredDateString = Console.ReadLine();

                            dt = DateTime.ParseExact(enteredDateString, targetDateFormat, CultureInfo.InvariantCulture);

                            Console.WriteLine("Introduz o ID do psicólogo designado: ");
                            idPsicólogo = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Tipo de Atividade: ");
                            tipoAtividade = Console.ReadLine();

                            idAtividade = rd.Next(1000, 9999);

                            g1.ProporAtividade(dt, e.EncontraPsicologo(idPsicólogo), tipoAtividade, idAtividade);
                            Console.WriteLine("Atividade nº: " + idAtividade);
                        }
                        else
                        {
                            Console.WriteLine("Escolha Inválida!");
                        }
                        break;
                }
            } while (choice != 0);
            #endregion

            Console.ReadKey();

        }
    }
}
