using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerDiseno3D_ExaIndi
{
    internal class Entity
    {
        protected int vida;
        protected int daño;

        public Entity(int vida, int daño)
        {
            this.vida = Clamp(vida, 0, 100);
            this.daño = Clamp(daño, 0, 100);
        }

        private static int Clamp(int value, int min, int max)
        {
            return Math.Min(Math.Max(value, min), max);
        }

        public virtual int ObtenerDaño()
        {
            return daño;
        }

        public virtual void RecibirDaño(int daño)
        {
            // ...
        }
    }
}
