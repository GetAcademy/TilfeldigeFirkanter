using System;
using System.Linq;

namespace TilfeldigeFirkanter
{
    public class ScreenRow
    {
        private ScreenCell[] _cells;
        private int _width;
        private int _startX;

        public ScreenRow(int width, int startX)
        {
            _startX = startX;
            _width = width;
            _cells = new ScreenCell[width];
            for (int i = 0; i < width; i++)
            {
                _cells[i] = new ScreenCell();
            }
        }

        public void AddBoxTopRow(int boxX, int boxWidth)
        {
            _cells[boxX].AddUpperLeftCorner();
            for (var i = 1; i < boxWidth - 1; i++)
            {
                _cells[boxX + i].AddHorizontal();
            }
            _cells[boxX + boxWidth - 1].AddUpperRightCorner();
        }

        public void AddBoxBottomRow(int boxX, int boxWidth)
        {
            _cells[boxX].AddLowerLeftCorner();
            for (var i = 1; i < boxWidth - 1; i++)
            {
                _cells[boxX + i].AddHorizontal();
            }
            _cells[boxX + boxWidth - 1].AddLowerRightCorner();

        }

        public void AddBoxMiddleRow(int boxX, int boxWidth)
        {
            _cells[boxX].AddVertical();
            _cells[boxX + boxWidth - 1].AddVertical();
        }

        public void Show()
        {
            Console.CursorLeft = _startX;
            var chars = _cells.Select(cell => cell.GetCharacter()).ToArray();
            Console.WriteLine(chars);
        }
    }
}
