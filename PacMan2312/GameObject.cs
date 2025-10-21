using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan2312
{
    public abstract class GameObject
    {
        public abstract void Update(Scene scene);

        public abstract void Print();
    }
}
