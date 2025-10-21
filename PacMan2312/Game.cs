using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan2312
{
    public class Game
    {
        private GameObject[] _gameObjects;
        private Scene _scene;

        public Game()
        {

        }

        public void Start()
        {
            bool isOpen = true;

            while (isOpen) 
            {
                Update();
                Print();
            }
        }

        private void Update() 
        { 
        }

        private void Print()
        {

        }
    }
}
