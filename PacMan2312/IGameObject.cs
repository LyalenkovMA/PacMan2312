using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan2312
{
    public interface IGameObject
    {
        Vectore Position { get; }

        char Symbol { get; }
    }
}
