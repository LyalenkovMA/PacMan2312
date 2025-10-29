using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan2312
{
    public abstract class Anemi : GameObject, IGameObject
    {
        private Player _player;

        public Anemi(Vectore position, Player player) : base()
        {
            Position = position;
            Symbol = 'S';
            _player = player;
        }

        public Vectore Position { get; private set; }

        public char Symbol { get; private set; }

        public override void Print()
        {
            PrintAnemi();
        }

        protected virtual void PrintAnemi() 
        {
            Console.SetCursorPosition(Position.X, Position.Y);
            Console.Write(Symbol);
        }

        public override void Update(Scene scene)=> GameIntelligence(scene, _player);
        
        protected abstract void GameIntelligence(Scene scene, Player player);
    }
}
