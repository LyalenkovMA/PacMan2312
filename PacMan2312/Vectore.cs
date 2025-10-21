using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan2312
{
    public struct Vectore
    {
        public Vectore(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; private set; }
        
        public int Y { get; private set; }

        public static Vectore operator + (Vectore one , Vectore two)=> new Vectore(one.X + two.X, one.Y + two.Y);
       
        public static Vectore operator - (Vectore one , Vectore two)=> new Vectore(one.X - two.X, one.Y - two.Y);
        
        public static bool operator == (Vectore one , Vectore two)=> one.X == two.X && one.Y == two.Y;
        
        public static bool operator != (Vectore one , Vectore two)=> one.X != two.X && one.Y != two.Y;
    }
}
