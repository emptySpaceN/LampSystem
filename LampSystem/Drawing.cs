using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LampSystem
{
    public class Drawing : Shapes
    {
        // Classes
        private Lamps lampsMenu = null;

        private List<Point[]> shapeHolder = null;
        private Bitmap finalCanvas = null;


        public Drawing(Lamps _passedLamps)
        {
            // Asign the main menu to have a reference
            lampsMenu = _passedLamps;

            shapeHolder = new List<Point[]>();
            finalCanvas = new Bitmap(lampsMenu.LampsCanvas.Width, lampsMenu.Height);
            
            CreateLamps();
        }

        public void CreateLamps()
        {
            InitializeShapes(lampsMenu.LampWidth, lampsMenu.LampWidth);

            finalCanvas = new Bitmap(lampsMenu.LampsCanvas.Width, lampsMenu.Height);

            GenerateShapes();
        }

        private void GenerateShapes()
        {
            shapeHolder.Clear();

            for (int i = 0; i < lampsMenu.LampsCounter; i++)
            {
                shapeHolder.Add(GetRandomShape());
            }
        }

        public void DrawLamps(PaintEventArgs _passedPaintEvent)
        {
            finalCanvas = new Bitmap(lampsMenu.LampsCanvas.Width, lampsMenu.Height);

            using (Graphics graphicsObject = Graphics.FromImage(finalCanvas))
            {
                for (int i = 0; i < lampsMenu.LampsCounter; i++)
                {
                    graphicsObject.FillPolygon(new SolidBrush(Color.CornflowerBlue), GetRandomShape());
                }
            }

            _passedPaintEvent.Graphics.DrawImage(finalCanvas, 0, 0);
        }
    }
}
