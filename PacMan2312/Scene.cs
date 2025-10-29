using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace PacMan2312
{
    public class Scene
    {
        private Tyle[,] _map;
        private string[] _textFile;
        private GameObject[] _gameObject;

        public Scene(string path, GameObject[] gameObjects) 
        {
            _textFile = GetTextFile(path);
            _map = GetMap(_textFile);
            _gameObject = gameObjects;
        }

        public void Update()
        {
            foreach (GameObject gameObject in _gameObject)
                gameObject.Update(this);
        }

        public void PrintMap()
        {
            for (int x = 0; x < _map.GetLength(0); x++)
            {
                for (int y = 0; y < _map.GetLength(1); y++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write(_map[x,y].Symbol);
                }
            }
        }
        
        private string[] GetTextFile(string path)
        {
            return File.ReadAllLines(path);
        }

        private Tyle[,] GetMap(string[] textFile)
        {
            const char SymboleWoll = '#';
            const char SymboleEmptyCell = ' ';
            const int KyeWoll = 1;
            const int KyeEmptyCell = 0;

            Tyle[,] tyles = new Tyle[textFile.Length, GetMaxOfLine(textFile)];

            for(int x = 0; x < textFile.Length; x++)
            {
                for(int y = 0; y < textFile[x].Length; y++)
                {
                    switch (Convert.ToInt32(textFile[x][y]))
                    {
                        case KyeWoll:
                            tyles[x,y] = new Tyle(new Vectore(x,y),Convert.ToInt32(textFile[x][y]), SymboleWoll);
                            break;
                        case KyeEmptyCell:
                            tyles[x, y] = new Tyle(new Vectore(x, y),Convert.ToInt32(textFile[x][y]),SymboleEmptyCell);
                            break;
                    }
                }
            }

            return tyles;
        }

        private int GetMaxOfLine(string[] strings)
        {
            int maxLength = 0;

            foreach (string line in strings)
                if(line.Length > maxLength)
                    maxLength = line.Length;

            return maxLength;
        }
    }
}
