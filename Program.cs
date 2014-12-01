using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    class Program
    {
        static void Main(string[] args)
        {
            int choixOrinateur = 0;
            string choixOrinateurString;
            bool conv;

            int choixOffre = 0;
            string choixOffreString;
            bool convOffre;

            int choixOffre2 = 0;
            string choixOffreString2;
            bool convOffre2;

            string continuer = "c";
            while (continuer.Equals("c"))
            {
                Console.Clear(); 
                Console.WriteLine("*****************************************************");
                Console.WriteLine("************* NOS Ordinateurs ***********************");
                Console.WriteLine("***Asus =============> 1                     ********");
                Console.WriteLine("***Mac  =============> 2                     ********");
                Console.WriteLine("*****************************************************");
                choixOrinateurString = Console.ReadLine();
                conv = int.TryParse(choixOrinateurString, out choixOrinateur);
                switch (choixOrinateur)
                {
                    case 1:
                        
                            Ordinateur asus = new Asus();
                            Console.WriteLine("************* NOS Offres ***********************************");
                            Console.WriteLine("*** Imprimante =============> 1                     ********");
                            Console.WriteLine("*** Tablette   =============> 2                     ********");
                            Console.WriteLine("*** CLE 3G     =============> 3                     ********");
                            Console.WriteLine("*** Tablette & CLE 3G ======> 4                     ********");
                            Console.WriteLine("*** Aucun      =============> 0                     ********");
                            Console.WriteLine("************************************************************");
                            choixOffreString = Console.ReadLine();
                            convOffre = int.TryParse(choixOffreString, out choixOffre);
                            switch (choixOffre)
                            {
                                case 1: asus = new OrdinateurAvecImprimante(asus); Console.WriteLine(" Prix Asus Avec Offre Imprimante " + asus.prix); break;
                                case 2: asus = new OrdinateurAvecTablette(asus); Console.WriteLine(" Prix Asus Avec Offre Tablette " + asus.prix); break;
                                case 3: asus = new OrdinateurAvecCle(asus); Console.WriteLine(" Prix Asus Avec Offre CLE 3G " + asus.prix); break;
                                case 4: asus = new OrdinateurAvecCle(asus); asus = new OrdinateurAvecTablette(asus); Console.WriteLine(" Prix Asus Avec Offre CLE 3G & Tablette " + asus.prix); break;
                                case 0: Console.WriteLine(" Prix Asus Aucun Offre " + asus.prix); break;
                                default:
                                    Console.WriteLine(" On considere que vous n'avez pas choisi aucun offre ");
                                    Console.WriteLine(" Prix Asus Aucun Offre " + asus.prix);
                                    break;        
                            }

                            break; 
                        
                    case 2:
                        Ordinateur mac = new Mac();
                        Console.WriteLine("************* NOS Offres ***********************************");
                        Console.WriteLine("*** Imprimante =============> 1                     ********");
                        Console.WriteLine("*** Tablette   =============> 2                     ********");
                        Console.WriteLine("*** CLE 3G     =============> 3                     ********");
                        Console.WriteLine("*** Tablette & CLE 3G ======> 4                     ********");
                        Console.WriteLine("*** Aucun      =============> 0                     ********");
                        Console.WriteLine("************************************************************");
                        choixOffreString2 = Console.ReadLine();
                        convOffre2 = int.TryParse(choixOffreString2, out choixOffre2);
                        switch (choixOffre2)
                        {
                            case 1: mac = new OrdinateurAvecImprimante(mac); Console.WriteLine(" Prix mac Avec Offre Imprimante " + mac.prix); break;
                            case 2: mac = new OrdinateurAvecTablette(mac); Console.WriteLine(" Prix mac Avec Offre Tablette " + mac.prix); break;
                            case 3: mac = new OrdinateurAvecCle(mac); Console.WriteLine(" Prix mac Avec Offre CLE 3G " + mac.prix); break;
                            case 4: mac = new OrdinateurAvecCle(mac); mac = new OrdinateurAvecTablette(mac); Console.WriteLine(" Prix mac Avec Offre CLE 3G & Tablette " + mac.prix); break;
                            case 0: Console.WriteLine(" Prix mac Aucun Offre " + mac.prix); break;
                            default:
                                Console.WriteLine(" On considere que vous n'avez pas choisi aucun offre ");
                                Console.WriteLine(" Prix mac Aucun Offre " + mac.prix); break;


                        }
                        break; 
                    default:
                        Console.WriteLine("vous n'avez pas choisi aucun ordinateur ");
                      break;
                        
                }
                Console.WriteLine("**********************************************************************");
                Console.WriteLine(" Si vous voulez continuer appuyez sur c ");
                continuer = Console.ReadLine();
            }

        }
    }
}
