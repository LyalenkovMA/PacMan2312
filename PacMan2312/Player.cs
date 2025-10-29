using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan2312
{
    public class Player : GameObject, IGameObject
    {
        public Player(Vectore position): base(3) 
        {
            Position = position;
            Symbol = '@';
        } 

        public Vectore Position { get; private set; }

        public char Symbol { get; private set; }

        public override void Print()
        {
            Console.SetCursorPosition(Position.X,Position.Y);
            Console.Write(Symbol);
        }

        public override void Update(Scene scene)
        {
            throw new NotImplementedException();
        }
    }
}
