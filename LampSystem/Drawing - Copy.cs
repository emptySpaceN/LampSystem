using System.Drawing;
using System.Windows.Forms;

namespace LampSystem
{
    public class ADrawing : Shapes
    {
        // Classes
        private Lamps LampsMenu = null;

        public ADrawing(Lamps _passedLamps)
        {
            // Asign the main menu to have a reference
            LampsMenu = _passedLamps;
        }

        public void DrawLamps(PaintEventArgs _passedPaintEvent)
        {
            if (LampsMenu.PaintLamps)
            {
                Pen lampColour = new Pen(new SolidBrush(Color.FromArgb(0, 255, 0)));    // Border of the lamp
                lampColour.Width = 2;   // Thickness of the lamp

                if (!LampsMenu.MouseButtonDown)
                {
                    if (LampsMenu.LampsCounter > 0)
                    {
                        // Reset the screen by drawing all white
                        _passedPaintEvent.Graphics.FillRectangle(new SolidBrush(Color.White), LampsMenu.LampsCanvas.ClientRectangle);

                        for (int i = 0; i < LampsMenu.LampsCounter; i++)
                        {
                            // Draw the lamp
                            _passedPaintEvent.Graphics.DrawEllipse(lampColour, LampsMenu.LampsHolder[i]);
                        }
                    }
                }
                else
                {
                    // Canvas position on the for - is used to add the width and height to the current lamp below
                    Point lampsCanvasPosition = LampsMenu.LampsCanvas.FindForm().PointToClient(LampsMenu.LampsCanvas.Parent.PointToScreen(LampsMenu.LampsCanvas.Location));
                    Point relativeMousePoint = LampsMenu.PointToClient(Cursor.Position);        // Current mouse position of the form
                    Rectangle bufferLamp;   // Is used to not change the original lamp's position

                    for (int i = 0; i < LampsMenu.LampsCounter; i++)
                    {
                        bufferLamp = new Rectangle(LampsMenu.LampsHolder[i].Location, LampsMenu.LampsHolder[i].Size);

                        // Add the canvas position to the X and Y position to have the position on the form
                        bufferLamp.X += lampsCanvasPosition.X;
                        bufferLamp.Y += lampsCanvasPosition.Y;

                        if (bufferLamp.Contains(relativeMousePoint))
                        {
                            if (!LampsMenu.LampsHit[i])
                            {
                                // Set the push state of the lamp to be true
                                LampsMenu.LampsHit[i] = true;

                                // Fill the Lamp by colour
                                _passedPaintEvent.Graphics.FillEllipse(new SolidBrush(Color.FromArgb(0, 255, 0)), LampsMenu.LampsHolder[i]);
                            }
                            else
                            {
                                // Set the push state of the lamp to be false
                                LampsMenu.LampsHit[i] = false;

                                // Draw the border of the lamp
                                //_passedPaintEvent.Graphics.DrawEllipse(lampColour, LampsMenu.LampsHolderPublic[i]);
                                _passedPaintEvent.Graphics.FillPolygon(new SolidBrush(Color.CornflowerBlue), GetRandomShape());
                            }
                        }
                        else
                        {
                            if (!LampsMenu.LampsHit[i])
                            {
                                // Draw the border of the lamp
                                //_passedPaintEvent.Graphics.draw
                                _passedPaintEvent.Graphics.DrawEllipse(lampColour, LampsMenu.LampsHolder[i]);
                            }
                            else
                            {
                                // Fill the Lamp by colour
                                _passedPaintEvent.Graphics.FillEllipse(new SolidBrush(Color.FromArgb(0, 255, 0)), LampsMenu.LampsHolder[i]);
                            }
                        }
                    }

                    LampsMenu.MouseButtonDown = false;

                    // Clear up at the end
                    lampColour.Dispose();
                }
            }
        }

        private void CreateNewLamps(PaintEventArgs _passedPaintEvent, Pen _passedPen)
        {

        }
    }
}
