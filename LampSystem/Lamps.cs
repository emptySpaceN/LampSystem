using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LampSystem
{
    public partial class Lamps : Form
    {
        // Classes
        private Drawing DrawFunction = null;
        private int lampWidth = 75;
        private int lampHeight = 75;

        public int LampWidth
        {
            get { return lampWidth; }
            set { lampWidth = value; }
        }

        public int LampHeight
        {
            get { return lampHeight; }
            set { lampHeight = value; }
        }

        // Accessors
        public int LampsCounter { get; set; } = 1;
        public Rectangle[] LampsHolder { get; set; } = null;
        public bool PaintLamps { get; set; } = false;
        public bool MouseButtonDown { get; set; } = false;
        public bool[] LampsHit { get; set; } = null;

        public Lamps()
        {
            InitializeComponent();
        }

        // Double buffering for all controls on this form
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        private void Lamps_Load(object sender, EventArgs e)
        {
            // Double buffering just for the lamps canvas (put it in the form's load event)
            //typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, LampsCanvas, new object[] { true });

            // Set the size of the form
            this.Width = 900;

            // Initialise the drawing class
            DrawFunction = new Drawing(this);

            // Add n possibilities of drawing lamps to the drop down menu and set the selected inde to one
            for (int i = 1; i <= 120; i++)
            {
                ChooseLamps.Items.Add(i);
            }

            ChooseLamps.SelectedIndex = 0;
        }

        private void AddLamps_Click(object sender, EventArgs e)
        {
            // Get the number of lamps to be created
            LampsCounter = int.Parse(ChooseLamps.Items[ChooseLamps.SelectedIndex].ToString());
            PaintLamps = true;
            
            // Enable the selection buttons
            MarkAllLamps.Enabled = true;
            DeselectAllLamps.Enabled = true;
            MarkAllLamps.Visible = true;
            DeselectAllLamps.Visible = true;

            // Update the lamps
            DrawFunction.CreateLamps();
            
            // Invalidate the canvas to be able to draw
            LampsCanvas.Invalidate();
        }

        private void LampsCanvas_Paint(object sender, PaintEventArgs e)
        {
            // Calls the draw function to draw or clear the canvas
            if (PaintLamps)
            {
                DrawFunction.DrawLamps(e);
            }        
        }

        private void RemoveLamps_Click(object sender, EventArgs e)
        {
            // Remove all lamps from the canvas
            foreach (Control lamp in LampsCanvas.Controls)
            {
                LampsCanvas.Controls.Remove(lamp);
            }

            PaintLamps = false;

            // Disable the selection buttons
            MarkAllLamps.Enabled = false;
            DeselectAllLamps.Enabled = false;
            MarkAllLamps.Visible = false;
            DeselectAllLamps.Visible = false;

            // Invalidate the canvas to be able to draw
            LampsCanvas.Invalidate();
        }

        private void LampsCanvas_Click(object sender, EventArgs e)
        {
            // The mouse has been clicked on the lamps canvas
            MouseButtonDown = true;

            if (LampsHolder == null)
            {
                //CreateNewLamps();
            }

            LampsCanvas.Invalidate();            
        }

        private void MarkAllLamps_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < LampsCounter; i++)
            {
                LampsHit[i] = true;
            }

            // The mouse has been clicked on the lamps canvas
            MouseButtonDown = true;

            // Invalidate the canvas to be able to draw
            LampsCanvas.Invalidate();
        }

        private void DeselectAllLamps_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < LampsCounter; i++)
            {
                LampsHit[i] = false;
            }

            // The mouse has been clicked on the lamps canvas
            MouseButtonDown = true;

            // Invalidate the canvas to be able to draw
            LampsCanvas.Invalidate();
        }

        private void SetLampWidth_TextChanged(object sender, EventArgs e)
        {
            // Have a buffer value to reset the width if its to high
            int bufferWidth = lampWidth;

            // Try to parse the textbox's text to the lamp's width
            if (!int.TryParse(SetLampWidth.Text, out lampWidth))
            {
                if (SetLampWidth.Text != "")
                {
                    MessageBox.Show("The entered value is not an integer, please only enter integers", "Values error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Set the maximum for the width
                if (lampWidth > 300)
                {
                    lampWidth = bufferWidth;
                    SetLampWidth.Text = lampWidth.ToString();

                    MessageBox.Show("The entered value is to high", "Values to high", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            // If the textbox is empty reset the height to the original value
            if (lampWidth== 0)
            {
                lampWidth = 75;
            }
        }

        private void SetLampHeight_TextChanged(object sender, EventArgs e)
        {
            // Have a buffer value to reset the height if its to high
            int bufferHeight = lampHeight;

            // Try to parse the textbox's text to the lamp's height
            if (!int.TryParse(SetLampHeight.Text, out lampHeight))
            {
                if (SetLampHeight.Text != "")
                {
                    MessageBox.Show("The entered value is not an integer, please only enter integers", "Values error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Set the maximum for the height
                if (lampHeight > 300)
                {
                    lampHeight = bufferHeight;
                    SetLampHeight.Text = lampHeight.ToString();

                    MessageBox.Show("The entered value is to high", "Values to high", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            // If the textbox is empty reset the height to the original value
            if (lampHeight == 0)
            {
                lampHeight = 75;
            }
        }

        private void Lamps_Resize(object sender, EventArgs e)
        {
            LampsCanvas.Width = this.ClientSize.Width - 20;
            LampsCanvas.Height = this.ClientSize.Height - LampsCanvas.Height - 10;
        }

        #region // Procedures & functions
        //private void CreateNewLamps()
        //{
        //    // Initialise new lamps and hit values
        //    LampsHolder = new Rectangle[LampsCounter];
        //    LampsHit = new bool[LampsCounter];

        //    for (int i = 0; i < LampsCounter; i++)
        //    {
        //        // Set the dimensions of the current lamp
        //        LampsHolder[i].Width = lampWidth;
        //        LampsHolder[i].Height = lampHeight;

        //        // Set the position of the current lamp
        //        LampsHolder[i].X = (i % 10) == 0 ? 10 : LampsHolder[i - 1].X + lampWidth + 10;
        //        LampsHolder[i].Y = (i / 10) == 0 ? 10 : LampsHolder[i - 10].Y + lampHeight + 10;
        //    }
        //}
        #endregion
    }
}
