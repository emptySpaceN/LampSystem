namespace LampSystem
{
    partial class Lamps
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ChooseLamps = new System.Windows.Forms.ComboBox();
            this.ChooseLampsTitle = new System.Windows.Forms.Label();
            this.AddLamps = new System.Windows.Forms.Button();
            this.RemoveLamps = new System.Windows.Forms.Button();
            this.MarkAllLamps = new System.Windows.Forms.Button();
            this.DeselectAllLamps = new System.Windows.Forms.Button();
            this.SetLampWidth = new System.Windows.Forms.TextBox();
            this.SetLampHeight = new System.Windows.Forms.TextBox();
            this.SetLampWidthTitle = new System.Windows.Forms.Label();
            this.SetLampHeightTitle = new System.Windows.Forms.Label();
            this.LampsCanvas = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChooseLamps
            // 
            this.ChooseLamps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChooseLamps.FormattingEnabled = true;
            this.ChooseLamps.Location = new System.Drawing.Point(12, 28);
            this.ChooseLamps.Name = "ChooseLamps";
            this.ChooseLamps.Size = new System.Drawing.Size(121, 21);
            this.ChooseLamps.TabIndex = 0;
            // 
            // ChooseLampsTitle
            // 
            this.ChooseLampsTitle.AutoSize = true;
            this.ChooseLampsTitle.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.ChooseLampsTitle.ForeColor = System.Drawing.Color.White;
            this.ChooseLampsTitle.Location = new System.Drawing.Point(12, 9);
            this.ChooseLampsTitle.Name = "ChooseLampsTitle";
            this.ChooseLampsTitle.Size = new System.Drawing.Size(88, 16);
            this.ChooseLampsTitle.TabIndex = 1;
            this.ChooseLampsTitle.Text = "Choose lamps";
            // 
            // AddLamps
            // 
            this.AddLamps.Location = new System.Drawing.Point(139, 26);
            this.AddLamps.Name = "AddLamps";
            this.AddLamps.Size = new System.Drawing.Size(114, 23);
            this.AddLamps.TabIndex = 3;
            this.AddLamps.Text = "Create lamps";
            this.AddLamps.UseVisualStyleBackColor = true;
            this.AddLamps.Click += new System.EventHandler(this.AddLamps_Click);
            // 
            // RemoveLamps
            // 
            this.RemoveLamps.Location = new System.Drawing.Point(139, 55);
            this.RemoveLamps.Name = "RemoveLamps";
            this.RemoveLamps.Size = new System.Drawing.Size(114, 23);
            this.RemoveLamps.TabIndex = 4;
            this.RemoveLamps.Text = "Remove lamps";
            this.RemoveLamps.UseVisualStyleBackColor = true;
            this.RemoveLamps.Click += new System.EventHandler(this.RemoveLamps_Click);
            // 
            // MarkAllLamps
            // 
            this.MarkAllLamps.Enabled = false;
            this.MarkAllLamps.Location = new System.Drawing.Point(307, 26);
            this.MarkAllLamps.Name = "MarkAllLamps";
            this.MarkAllLamps.Size = new System.Drawing.Size(126, 23);
            this.MarkAllLamps.TabIndex = 5;
            this.MarkAllLamps.Text = "Select all lamps";
            this.MarkAllLamps.UseVisualStyleBackColor = true;
            this.MarkAllLamps.Visible = false;
            this.MarkAllLamps.Click += new System.EventHandler(this.MarkAllLamps_Click);
            // 
            // DeselectAllLamps
            // 
            this.DeselectAllLamps.Enabled = false;
            this.DeselectAllLamps.Location = new System.Drawing.Point(307, 55);
            this.DeselectAllLamps.Name = "DeselectAllLamps";
            this.DeselectAllLamps.Size = new System.Drawing.Size(126, 23);
            this.DeselectAllLamps.TabIndex = 6;
            this.DeselectAllLamps.Text = "Deselect everything";
            this.DeselectAllLamps.UseVisualStyleBackColor = true;
            this.DeselectAllLamps.Visible = false;
            this.DeselectAllLamps.Click += new System.EventHandler(this.DeselectAllLamps_Click);
            // 
            // SetLampWidth
            // 
            this.SetLampWidth.Enabled = false;
            this.SetLampWidth.Location = new System.Drawing.Point(772, 28);
            this.SetLampWidth.Name = "SetLampWidth";
            this.SetLampWidth.Size = new System.Drawing.Size(100, 20);
            this.SetLampWidth.TabIndex = 7;
            this.SetLampWidth.Visible = false;
            this.SetLampWidth.TextChanged += new System.EventHandler(this.SetLampWidth_TextChanged);
            // 
            // SetLampHeight
            // 
            this.SetLampHeight.Enabled = false;
            this.SetLampHeight.Location = new System.Drawing.Point(772, 57);
            this.SetLampHeight.Name = "SetLampHeight";
            this.SetLampHeight.Size = new System.Drawing.Size(100, 20);
            this.SetLampHeight.TabIndex = 8;
            this.SetLampHeight.Visible = false;
            this.SetLampHeight.TextChanged += new System.EventHandler(this.SetLampHeight_TextChanged);
            // 
            // SetLampWidthTitle
            // 
            this.SetLampWidthTitle.AutoSize = true;
            this.SetLampWidthTitle.Enabled = false;
            this.SetLampWidthTitle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetLampWidthTitle.ForeColor = System.Drawing.Color.White;
            this.SetLampWidthTitle.Location = new System.Drawing.Point(683, 29);
            this.SetLampWidthTitle.Name = "SetLampWidthTitle";
            this.SetLampWidthTitle.Size = new System.Drawing.Size(79, 16);
            this.SetLampWidthTitle.TabIndex = 9;
            this.SetLampWidthTitle.Text = "Lamp width:";
            this.SetLampWidthTitle.Visible = false;
            // 
            // SetLampHeightTitle
            // 
            this.SetLampHeightTitle.AutoSize = true;
            this.SetLampHeightTitle.Enabled = false;
            this.SetLampHeightTitle.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.SetLampHeightTitle.ForeColor = System.Drawing.Color.White;
            this.SetLampHeightTitle.Location = new System.Drawing.Point(683, 58);
            this.SetLampHeightTitle.Name = "SetLampHeightTitle";
            this.SetLampHeightTitle.Size = new System.Drawing.Size(83, 16);
            this.SetLampHeightTitle.TabIndex = 10;
            this.SetLampHeightTitle.Text = "Lamp height:";
            this.SetLampHeightTitle.Visible = false;
            // 
            // LampsCanvas
            // 
            this.LampsCanvas.AutoScroll = true;
            this.LampsCanvas.BackColor = System.Drawing.Color.White;
            this.LampsCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LampsCanvas.Location = new System.Drawing.Point(3, 3);
            this.LampsCanvas.Name = "LampsCanvas";
            this.LampsCanvas.Size = new System.Drawing.Size(854, 348);
            this.LampsCanvas.TabIndex = 2;
            this.LampsCanvas.Click += new System.EventHandler(this.LampsCanvas_Click);
            this.LampsCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.LampsCanvas_Paint);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.LampsCanvas);
            this.panel1.Location = new System.Drawing.Point(12, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 354);
            this.panel1.TabIndex = 11;
            // 
            // Lamps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SetLampHeightTitle);
            this.Controls.Add(this.SetLampWidthTitle);
            this.Controls.Add(this.SetLampHeight);
            this.Controls.Add(this.SetLampWidth);
            this.Controls.Add(this.DeselectAllLamps);
            this.Controls.Add(this.MarkAllLamps);
            this.Controls.Add(this.RemoveLamps);
            this.Controls.Add(this.AddLamps);
            this.Controls.Add(this.ChooseLampsTitle);
            this.Controls.Add(this.ChooseLamps);
            this.Name = "Lamps";
            this.Text = "Lamps";
            this.Load += new System.EventHandler(this.Lamps_Load);
            this.Resize += new System.EventHandler(this.Lamps_Resize);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ChooseLamps;
        private System.Windows.Forms.Label ChooseLampsTitle;
        private System.Windows.Forms.Button AddLamps;
        private System.Windows.Forms.Button RemoveLamps;
        private System.Windows.Forms.Button MarkAllLamps;
        private System.Windows.Forms.Button DeselectAllLamps;
        private System.Windows.Forms.TextBox SetLampWidth;
        private System.Windows.Forms.TextBox SetLampHeight;
        private System.Windows.Forms.Label SetLampWidthTitle;
        private System.Windows.Forms.Label SetLampHeightTitle;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel LampsCanvas;
    }
}

