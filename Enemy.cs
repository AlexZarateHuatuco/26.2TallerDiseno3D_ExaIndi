using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerDiseno3D_ExaIndi
{
    internal class Enemy : Entity
    {
        public Enemy(int vida, int daño) : base(vida, daño)
        {
            // ...
        }

        public bool EstáVivo()
        {
            return vida > 0;
        }
    }
}
