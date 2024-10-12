

namespace LABB2.LevelElement
{
    public abstract class LevelElement
    {
        public int X { get; set; }

        public int Y { get; set; }

        public char Symbol { get; set; }

        public ConsoleColor Color { get; set; }


        public void Move(int deltaX, int deltaY, LevelData levelData)
        {
            int newX = X + deltaX;
            int newY = Y + deltaY;

            if (!levelData.IsWall(newX, newY) && !levelData.IsOccupiedByElement(newX, newY))
            {
                X = newX;
                Y = newY;
            }
        }


        public void Draw()
        {
            Console.SetCursorPosition(X, Y+4);
            Console.ForegroundColor = Color;
            Console.Write(Symbol);
            Console.ResetColor();
        } 
    }
}
