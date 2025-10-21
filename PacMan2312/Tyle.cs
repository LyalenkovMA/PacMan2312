namespace PacMan2312
{
    public class Tyle : IGameObject
    {
        private IGameObject _gameObject;

        public Tyle(Vectore position, int kye, char symbol = ' ')
        {
            Position = position;
            _gameObject = null;
            Symbol = symbol;

            if (kye == 0)
                IsWoll = false;
            else
                IsWoll = true;
        }

        public Vectore Position { get; private set; }

        public bool IsOpen => _gameObject == null;
        
        public bool IsWoll { get; private set; }

        public char Symbol { get; private set; }

        public void AddGameObject(IGameObject[] gameObjects)
        {
            foreach (IGameObject @object in gameObjects)
            {
                if (@object.Position == Position)
                {
                    _gameObject = @object;
                    break;
                }
                else 
                {
                    _gameObject = null;
                }
            }
        }
    }
}
