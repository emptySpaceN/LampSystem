using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LampSystem
{
    public class Shapes
    {
        // Dimensions and counters
        private int lampWidth = 0;
        private int lampHeight = 0;
        //private int lampsCount = 0;
        //private int bufferLampCount = 1;
        //private int bufferXPosition = 10;
        //private int bufferYPosition = 10;

        // Available shapes
        private Point[] triangleEmptyTopDown = null;
        private Point[] triangleEmptyTopUp = null;
        private Point[] square = null;

        // 
        private List<Point[]> shapeHolder = new List<Point[]>();

        private Random shapePicker = new Random();

        public void InitializeShapes(int _passedWidth, int _passedHeight)
        {
            // Asign shape dimensions and counter
            lampWidth = _passedWidth;
            lampHeight = _passedHeight;
            //lampsCount = _passedLampsCount;

            // Reset buffer counter and buffer positions
            //bufferLampCount = 1;
            //bufferXPosition = 10;
            //bufferYPosition = 10;

            // Local declaration and initialisation
            Point[] bufferTriangleEmptyTopDown = { new Point(0, 0), new Point(lampWidth, 0), new Point(lampWidth / 2, lampHeight) };
            Point[] bufferTriangleEmptyTopUp = { new Point(0, lampHeight), new Point(lampWidth, lampHeight), new Point(lampWidth / 2, 0) };
            Point[] bufferSquare = { new Point(0, 0), new Point(lampWidth, 0), new Point(lampWidth, lampHeight), new Point(0, lampHeight) };

            // Asign the local to glocal variables
            triangleEmptyTopDown = bufferTriangleEmptyTopDown;
            triangleEmptyTopUp = bufferTriangleEmptyTopUp;
            square = bufferSquare;

            // Clear and fill the shape holder
            shapeHolder.Clear();
            shapeHolder.Add(triangleEmptyTopDown);
            shapeHolder.Add(triangleEmptyTopUp);
            shapeHolder.Add(square);
        }

        public Point[] GetRandomShape()
        {
            int shapeIndex = shapePicker.Next(0, shapeHolder.Count);    // Generates a random number for picking a different shape every time
            //int factorX = (bufferLampCount < 10 ? bufferLampCount - 1 : ((bufferLampCount % 10) == 0 ? 9 : ((bufferLampCount % 10) - 1)));
            //int factorY = ((bufferLampCount % 10) == 0 ? (bufferLampCount / 10) - 1 : bufferLampCount / 10);

            ////Point[] bufferPoint = new Point[shapeHolder[shapeIndex].Length];
            //Point[] bufferPoint = new Point[square.Length];
            //square.CopyTo(bufferPoint, 0);
            ////shapeHolder[shapeIndex].CopyTo(bufferPoint, 0);

            //// If the loop of the drawing class has reached the end, set the buffer to 1
            //if (bufferLampCount == lampsCount)
            //{
            //    bufferLampCount = 1;
            //    bufferXPosition = 10;
            //    bufferYPosition =  10;
            //}
            //else
            //{
            //    bufferLampCount++;
            //}

            //// Set the position of the shape regarding the current shape in the drawing loop
            //for (int i = 0; i < bufferPoint.Length; i++)
            //{
            //    if (bufferLampCount == 1)
            //    {
            //        bufferPoint[i].X += bufferXPosition;
            //        bufferPoint[i].Y += bufferYPosition;
            //    }
            //    else
            //    {
            //        bufferPoint[i].X += bufferXPosition + lampWidth + 10;
            //        bufferPoint[i].Y += bufferYPosition + lampHeight + 10;
            //    }
            //}

            //// Asign the value after the position has been set
            //bufferXPosition += lampWidth + 10;
            //bufferYPosition += lampHeight + 10;

            return shapeHolder[shapeIndex]; 
        }
    }
}
