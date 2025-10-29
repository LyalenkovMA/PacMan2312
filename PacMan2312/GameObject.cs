using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan2312
{
    public abstract class GameObject
    {
        private int _countLive;

        public GameObject(int countLive = 0) 
        {
            _countLive = countLive;
        }

        public bool IsLive => _countLive > 0;

        public int GetCountLive => _countLive;

        public abstract void Update(Scene scene);

        public abstract void Print();

        protected virtual void SetDamege()
        {
            if(_countLive != 0)
            {
                if(_countLive > 0)
                    _countLive--;
            }    
        }
    }
}
