

namespace LABB2.LevelElement
{
    public class Wall : LevelElement
    {
        public bool IsDiscovered { get; set; }
        public Wall(int x, int y)
        {
            Symbol = '#';

            Color = ConsoleColor.Gray;

            X = x;
            Y = y;
            IsDiscovered = false;
        }
    }
}
