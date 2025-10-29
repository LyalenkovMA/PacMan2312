namespace PacMan2312
{
    public class Tyle : IGameObject
    {
        private Tyle _up;
        private Tyle _down;
        private Tyle _left;
        private Tyle _right;

        public Tyle(Vectore position, int kye, char symbol = ' ')
        {
            Position = position;
            Symbol = symbol;
            Kye = kye;

            _up = null;
            _down = null;
            _left = null;
            _right = null;

            if (kye == 0)
                IsWoll = false;
            else
                IsWoll = true;
        }

        public Vectore Position { get; private set; }

        public int Kye { get; private set; }

        public bool IsWoll { get; private set; }

        public char Symbol { get; private set; }

        public Vectore GetRouteFinushTyle(Vectore vectore)=> Position - vectore;

        public static bool operator ==(Tyle tyle, Vectore vectore) => tyle.Position.X == vectore.X && tyle.Position.Y == vectore.Y;
        
        public static bool operator ==(Tyle one, Tyle two) => one.Position == two.Position;
        
        public static bool operator !=(Tyle tyle, Vectore vectore) => tyle.Position.X != vectore.X && tyle.Position.Y != vectore.Y;

        public static bool operator !=(Tyle one, Tyle two) => one.Position != two.Position;

        public void SetLinck(Tyle tyle)
        {
            if(tyle.Position.X == Position.X || tyle.Position.Y == Position.Y)
            {
                if(tyle.Position.X > Position.X)
                    _left = tyle;
                else if(tyle.Position.Y > Position.Y)
                    _down = tyle;
                else if (tyle.Position.X < Position.X)
                    _right = tyle;
                else
                    _up = tyle;
            }
        }
    }
}
