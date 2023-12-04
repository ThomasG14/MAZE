using System;

namespace Maze
{
    internal class Program
    {
        //Les 2 fonctions qui suivent sont utiliser pour le coté haut et bas, d'ou leur nom TopBot...

        //Fonction si le haut ou bas est fermer
        public static void TopBottF()
        {
            for (int x1 = 0; x1 < 33; x1 += 2)
            {
                Console.Write("#");
                if (x1 < 32)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }

        //Fonction si le haut ou bas est ouvert
        public static void TopBottO()
        {
            for (int x1 = 0; x1 < 33; x1 += 2)
            {
                if (x1 > 10 && x1 < 22)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("#");
                }
                if (x1 < 32)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }

        //fonction si le coté gauche et le coté droit sont fermer (LFRF)
        public static void MidLFRF()
        {
            for (int y = 0; y < 12; y++)
            {
                for (int y1 = 0; y1 < 33; y1++)
                {

                    if (y1 == 0 || y1 == 32)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        //fonction si le coté droit et gauche sont ouver (LORO)
        public static void MidLORO()
        {
            for (int y = 0; y < 4; y++)
            {
                for (int y1 = 0; y1 < 33; y1++)
                {
                    if (y1 == 0 || y1 == 32)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            for (int y = 0; y < 4; y++)
            {
                for (int y1 = 0; y1 < 33; y1++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            for (int y = 0; y < 4; y++)
            {
                for (int y1 = 0; y1 < 33; y1++)
                {
                    if (y1 == 0 || y1 == 32)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        //fonction si le coté gauche est fermer (LF) et le coté droit est ouvert (RO)
        public static void MidLFRO()
        {
            int y, y1;
            for (y = 0; y < 12; y++)
            {
                for (y1 = 0; y1 < 33; y1++)
                {

                    if (y1 == 0)
                    {
                        Console.Write("#");
                    }
                    else if (y1 == 32)
                    {
                        if (y > 3 && y < 8)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("#");
                        }
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        //fonction si le coté gauche est ouvert (LO) et le coté droit est fermer (RF)
        public static void MidLORF()
        {
            int y, y1;
            for (y = 0; y < 12; y++)
            {
                for (y1 = 0; y1 < 33; y1++)
                {
                    if (y1 == 32)
                    {
                        Console.Write("#");
                    }
                    else if (y1 == 0)
                    {
                        if (y > 3 && y < 8)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("#");
                        }
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        //cette fonction affiche les murs de la salle celon la configuration
        public static void DisplayHall(string hall)
        {
            //Coté haut
            if (hall[0] == 'F')
            {
                TopBottF();
            }
            else
            {
                TopBottO();
            }

            //Coté droit et gauche
            if (hall[1] == 'F' && hall[3] == 'F')
            {
                MidLFRF();
            }
            else if (hall[1] == 'O' && hall[3] == 'O')
            {
                MidLORO();
            }
            else if (hall[1] == 'O' && hall[3] == 'F')
            {
                MidLFRO();
            }
            else if (hall[1] == 'F' && hall[3] == 'O')
            {
                MidLORF();

            }
            //coté bas
            if (hall[2] == 'F')
            {
                TopBottF();
            }
            else
            {
                TopBottO();
            }
        }



        //Fonction principale
        static void Main(string[] args)
        {
            //on défini le tableau Map qui nous servira d'environnement pour le labyrinthe, chaque index du tableau correspond a la disposition d'une salle
            // exemple avec FFOF,
            // F -> haut fermer,
            // F -> droit fermer
            // O -> bas ouvert
            // F -> gauche fermer

            string[] Map = {    "FFOF", "FFOF", "FOFF", "FFOO", "FOOF", "FOFO", "FOFO", "FFOO", "FFOF", "FFOF",
                                "OFOF", "OOFF", "FFOO", "OFOF", "OFOF", "FFOF", "FFOF", "OFOF", "OFOF", "OFOF",
                                "OOFF", "FFOO", "OFOF", "OFOF", "OFOF", "OOFF", "OOOO", "OFOO", "OOFF", "OFOO",
                                "FOOF", "OOOO", "OOOO", "OOOO", "OFOO", "FOFF", "OFOO", "OOFF", "FOOO", "OFFO",
                                "OFFF", "OFOF", "OFFF", "OOOF", "OFFO", "FOOF", "OOOO", "FOFO", "OOOO", "FFFO",
                                "FOFF", "OOFO", "FFFO", "OOOF", "FOFO", "OOOO", "OFOO", "FOOF", "OOFO", "FFFO",
                                "FOOF", "FOOO", "FFOO", "OOOF", "FFFO", "OOFF", "OFFO", "OOFF", "FOFO", "FFOO",
                                "OOOF", "OOOO", "OOOO", "OFOO", "FFOF", "FOOF", "FFOO", "FOOF", "FOFO", "OFFO",
                                "OOFF", "OOFO", "OFFO", "OOOF", "OOFO", "OFOO", "OOFF", "OFOO", "FOFF", "FFOO",
                                "FOFF", "FOFO", "FOFO", "OOFO", "FFFO", "OOFF", "FFFO", "OOFF", "FOFO", "OFFO"
                            };
            //LA variable moove correspond a l'mplacement de début du jeux
            int moove, i, tour = 1;
            string key = "", MazeHall = "";
            do
            {
                //choix de la configuration de départ 0, 9, 50, 56
                do
                {                  
                    Console.WriteLine("Choisissez une configuration de départ: 0, 9, 50, 56, 90, 96 ou 100 pour choisir une salle aléatoire");
                    moove = int.Parse(Console.ReadLine());
                    Console.Clear();
                } while (moove != 0 && moove != 9 && moove != 50 && moove != 56 && moove != 90 && moove != 100);

                //si le choix est 100 on génere un nombre random (si le nombre tombe sur 88 on regénère un nombre aléatoire)
                if(moove == 100)
                {
                    Random rand = new Random();
                    do
                    {
                        moove = rand.Next(0, 99);
                    } while (moove == 88);
                }
                
                do
                {
                    //affichage des commandes disponibles si un coté est fermer la commande ossicier n'apparait pas et l'action est refuser
                    MazeHall = Map[moove];
                    for (i = 0; i < MazeHall.Length; i++)
                    {
                        switch (i)
                        {
                            case 0:
                                if (MazeHall[i] != 'F')
                                {
                                    Console.WriteLine("Pressez Z pour aller en haut");
                                }
                                break;
                            case 1:
                                if (MazeHall[i] != 'F')
                                {
                                    Console.WriteLine("Pressez D pour aller a droite");
                                }
                                break;
                            case 2:
                                if (MazeHall[i] != 'F')
                                {
                                    Console.WriteLine("Pressez S pour aller en bas");
                                }
                                break;
                            case 3:
                                if (MazeHall[i] != 'F')
                                {
                                    Console.WriteLine("Pressez Q pour aller a gauche");
                                }
                                break;
                            default:
                                break;
                        }

                    }
                    //on affiche la salle dans laquel on se trouve
                    Console.WriteLine();
                    Console.WriteLine();
                    DisplayHall(MazeHall);
                    Console.WriteLine();
                    Console.WriteLine("vous êtes à la salle numéro: " + moove);
                    Console.WriteLine("Objectif: Salle numéro 88");

                    //on écoute les touche presser par l'utilisateur, cela facilite l'utilisation du programme
                    ConsoleKeyInfo keyinfo;
                    keyinfo = Console.ReadKey();

                    //on défini les actions associer au touches [Z , Q, S, D] avec, là aussi, une vérification si le deplacemen est possible de chaque coté
                    switch (keyinfo.Key)
                    {
                        case ConsoleKey.Z:
                            if (MazeHall[0] != 'F')
                            {
                                moove -= 10;

                            }
                            Console.Clear();
                            break;
                        case ConsoleKey.Q:
                            if (MazeHall[3] != 'F')
                            {
                                moove -= 1;
                            }
                            Console.Clear();
                            break;
                        case ConsoleKey.S:
                            if (MazeHall[2] != 'F')
                            {
                                moove += 10;
                            }
                            Console.Clear();
                            break;
                        case ConsoleKey.D:
                            if (MazeHall[1] != 'F')
                            {
                                moove += 1;
                            }
                            Console.Clear();
                            break;
                        default:
                            Console.Clear();
                            break;
                    }

                } while (moove != 88);
                //message de fin quand on arrive dans la salle d'arriver
                if (moove == 88)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Bravo ! vous avez fini le labyrinth MAZE !!");
                    Console.WriteLine();
                    Console.WriteLine();
                    //on reset la position de départ a la salle 56
                    moove = 56;
                }
                //on demande a l'utilisateur s'il veut rejouer
                Console.WriteLine("Rejouer ? 1 = oui 0 = non");
                tour = int.Parse(Console.ReadLine());

                Console.Clear();
            } while (tour == 1);
        }
    }
}
