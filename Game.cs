using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerDiseno3D_ExaIndi
{
    internal class Game
    {
        private Enemy[] enemigos;
        public void Iniciar()
        {
            Console.WriteLine("Creando enemigos...");
            enemigos = new Enemy[2];
            enemigos[0] = new EnemyMelee(50, 10);
            enemigos[1] = new EnemyMelee(50, 10);
            Console.WriteLine("Creando jugador...");
            Player player = new Player(100, 15);
            Console.WriteLine("Enemigos creados, Jugador creado. Iniciando el juego...");
        }
    }
}
