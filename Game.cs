using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerDiseno3D_ExaIndi
{
    internal class Game
    {
        int vidaPlayer;
        private Enemy[] enemigos;
        public void Iniciar()
        {
            Console.WriteLine("Creando enemigos...");
            enemigos = new Enemy[1];
            enemigos[0] = new EnemyMelee(5, 10);
            Console.WriteLine("Creando jugador...");
            Player player = new Player(100, 15);
            Console.WriteLine("Enemigos creados, Jugador creado. Iniciando el juego...");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Te encuentras en una habitación oscura.");
            Console.WriteLine("logras ver una puerta a tu delante, pero hay un guardia protegiéndola.");
            Console.WriteLine("Que deseas hacer?");
            Console.WriteLine("1. Atacar al guardia.");
            Console.WriteLine("2. Intentar pasar sigilosamente.");
            Console.WriteLine("3. Huir.");
            int option = int.Parse(Console.ReadLine());
            bool continueFlag = true;
            switch (option)
            {
                case 1:
                    Console.WriteLine("Atacando al guardia...");
                    enemigos[0].RecibirDaño(player.GetDaño());
                    
                    if (!player.EstaVivo())
                    {
                        Console.WriteLine("Has muerto. Fin del juego.");
                    }
                    else
                    {
                        Console.WriteLine("Has derrotado al guardia. Puedes pasar.");
                        Cuarto2();
                    }
                    break;
                case 2:
                    Console.WriteLine("Intentando pasar sigilosamente...");
                    Random rand = new Random();
                    int chance = rand.Next(0, 100);
                    if (chance >= 50)
                    {
                        Console.WriteLine("Has logrado pasar sigilosamente.");
                        Cuarto2();
                    }
                    else
                    {
                        Console.WriteLine("El guardia te ha visto y te ha atacado.");
                        player.RecibirDaño(enemigos[0].GetDaño());
                        if (!player.EstaVivo())
                        {
                            Console.WriteLine("Has muerto. Fin del juego.");
                            Environment.Exit(0);
                        }
                    }
                    break;
                case 3:
                    Console.WriteLine("Huyendo...");
                    Console.WriteLine("Sigues atrapado en el calabozo.");
                    Console.WriteLine("Fin del juego.");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
            vidaPlayer = player.GetVida();
        }
        public void Cuarto2()
        {
            Player player = new Player(vidaPlayer, 15);
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Lograste pasar a la sala principal.");
            Console.WriteLine("Esta es la última sala del calabozo.");
            Console.WriteLine("logras ver una puerta a tu delante, pero hay un guardia protegiéndola.");
            Console.WriteLine("Que deseas hacer?");
            Console.WriteLine("1. Atacar al guardia.");
            Console.WriteLine("2. Intentar pasar sigilosamente.");
            Console.WriteLine("3. Huir.");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Atacando al guardia...");
                    enemigos[0].RecibirDaño(player.GetDaño());
                    if (!player.EstaVivo())
                    {
                        Console.WriteLine("Has muerto. Fin del juego.");
                    }
                    else
                    {
                        Console.WriteLine("Has derrotado al guardia.");
                        Console.WriteLine("¡Felicidades! Has logrado escapar del calabozo.");
                    }
                    break;
                case 2:
                    Console.WriteLine("Intentando pasar sigilosamente...");
                    Random rand = new Random();
                    int chance = rand.Next(0, 100);
                    if (chance >= 50)
                    {
                        Console.WriteLine("Has logrado pasar sigilosamente.");
                        Console.WriteLine("¡Felicidades! Has logrado escapar del calabozo.");
                    }
                    else
                    {
                        Console.WriteLine("El guardia te ha visto y te ha atacado.");
                        player.RecibirDaño(enemigos[0].GetDaño());
                        if (!player.EstaVivo())
                        {
                            Console.WriteLine("Has muerto. Fin del juego.");
                            Environment.Exit(0);
                        }
                    }
                    break;
                case 3:
                    Console.WriteLine("Huyendo...");
                    Console.WriteLine("Regresas a la sala anterior.");
                    Console.WriteLine("Fin del juego.");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }
    }
}
