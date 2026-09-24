using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerDiseno3D_ExaIndi
{
    internal class EnemyMelee : Enemy
    {
        private bool estaVivo;
        private bool yaImprimiMuerte;
        private int vecesQueRecibioDaño;

        public EnemyMelee(int vida, int daño) : base(vida, daño)
        {
            this.vida = vida;
            this.daño = daño;
            this.estaVivo = true;
            this.yaImprimiMuerte = false;
            this.vecesQueRecibioDaño = 0;

            Console.WriteLine("Se creo un enemigo melee con " + vida + " de vida y " + daño + " de daño");
        }

        public override void RecibirDaño(int cantidad)
        {
            this.vecesQueRecibioDaño = this.vecesQueRecibioDaño + 1;

            if (cantidad < 0)
            {
                Console.WriteLine("ERROR: no se puede recibir daño negativo");
                return;
            }

            int vidaAntes = this.vida;
            this.vida = this.vida - cantidad;

            Console.WriteLine("El enemigo melee recibio " + cantidad + " de daño");
            Console.WriteLine("Vida antes: " + vidaAntes);
            Console.WriteLine("Vida ahora: " + this.vida);

            if (this.vida <= 0)
            {
                this.vida = 0;
                this.estaVivo = false;

                if (this.yaImprimiMuerte == false)
                {
                    Console.WriteLine("*** El enemigo melee ha muerto ***");
                    this.yaImprimiMuerte = true;
                }
                else
                {
                    Console.WriteLine("El enemigo ya estaba muerto, no hace falta pegarle mas");
                }
            }
            else
            {
                Console.WriteLine("Al enemigo melee le quedan " + this.vida + " puntos de vida");
            }

            Console.WriteLine("----------------------------------------");
        }

        public int GetDaño()
        {
            int dañoQueVoyARetornar = this.daño;
            return dañoQueVoyARetornar;
        }

        public bool EstaVivo()
        {
            if (this.vida > 0)
            {
                return true;
            }
            else if (this.vida == 0)
            {
                return false;
            }
            else
            {
                return false;
            }
        }

        public void MostrarEstado()
        {
            Console.WriteLine("===== ESTADO DEL ENEMIGO MELEE =====");
            Console.WriteLine("Vida: " + this.vida);
            Console.WriteLine("Daño: " + this.daño);

            if (this.estaVivo == true)
            {
                Console.WriteLine("Estado: VIVO");
            }
            else
            {
                Console.WriteLine("Estado: MUERTO");
            }

            Console.WriteLine("Veces que recibio daño: " + this.vecesQueRecibioDaño);
            Console.WriteLine("=====================================");
        }
    }
}
