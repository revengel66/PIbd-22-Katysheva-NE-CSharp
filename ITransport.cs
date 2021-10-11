using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
namespace KatyshevaExcavator
{
    public interface ITransport
    {
        void SetPosition(int x, int y, int width, int height);
        void MoveTransport(Direction direction);
        void DrawTransport(Graphics g);
    }
}

