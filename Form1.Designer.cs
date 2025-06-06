namespace Academia2025
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            pictureBox1 = new PictureBox();
            imageList1 = new ImageList(components);
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(btn3);
            panel1.Controls.Add(btn2);
            panel1.Controls.Add(btn1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 20, 0, 0);
            panel1.Size = new Size(228, 797);
            panel1.TabIndex = 0;
            // 
            // btn3
            // 
            btn3.Anchor = AnchorStyles.None;
            btn3.BackColor = Color.FromArgb(36, 47, 59);
            btn3.BackgroundImage = (Image)resources.GetObject("btn3.BackgroundImage");
            btn3.BackgroundImageLayout = ImageLayout.Zoom;
            btn3.FlatAppearance.BorderColor = Color.White;
            btn3.FlatAppearance.BorderSize = 3;
            btn3.FlatAppearance.MouseDownBackColor = Color.White;
            btn3.FlatAppearance.MouseOverBackColor = Color.Red;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Poppins Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.ForeColor = Color.White;
            btn3.ImageAlign = ContentAlignment.MiddleLeft;
            btn3.Location = new Point(0, 561);
            btn3.Margin = new Padding(3, 4, 3, 4);
            btn3.Name = "btn3";
            btn3.Padding = new Padding(6, 0, 2, 0);
            btn3.Size = new Size(225, 185);
            btn3.TabIndex = 3;
            btn3.TextAlign = ContentAlignment.MiddleRight;
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btn2.BackColor = Color.FromArgb(36, 47, 59);
            btn2.BackgroundImage = (Image)resources.GetObject("btn2.BackgroundImage");
            btn2.BackgroundImageLayout = ImageLayout.Zoom;
            btn2.FlatAppearance.BorderColor = Color.White;
            btn2.FlatAppearance.BorderSize = 2;
            btn2.FlatAppearance.MouseDownBackColor = Color.White;
            btn2.FlatAppearance.MouseOverBackColor = Color.Red;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Poppins Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.ImageAlign = ContentAlignment.MiddleLeft;
            btn2.Location = new Point(0, 376);
            btn2.Margin = new Padding(3, 4, 3, 4);
            btn2.Name = "btn2";
            btn2.Padding = new Padding(6, 0, 2, 0);
            btn2.Size = new Size(225, 185);
            btn2.TabIndex = 2;
            btn2.TextAlign = ContentAlignment.MiddleRight;
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btn1.BackColor = Color.FromArgb(36, 47, 59);
            btn1.BackgroundImage = (Image)resources.GetObject("btn1.BackgroundImage");
            btn1.BackgroundImageLayout = ImageLayout.Zoom;
            btn1.FlatAppearance.BorderColor = Color.White;
            btn1.FlatAppearance.MouseDownBackColor = Color.White;
            btn1.FlatAppearance.MouseOverBackColor = Color.Red;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Poppins Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.ForeColor = Color.White;
            btn1.ImageAlign = ContentAlignment.MiddleLeft;
            btn1.Location = new Point(0, 191);
            btn1.Margin = new Padding(3, 4, 3, 4);
            btn1.Name = "btn1";
            btn1.Padding = new Padding(6, 0, 2, 0);
            btn1.Size = new Size(225, 185);
            btn1.TabIndex = 1;
            btn1.TextAlign = ContentAlignment.MiddleRight;
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(0, 20);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(228, 162);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "func2_2.png");
            imageList1.Images.SetKeyName(1, "func1_2.png");
            imageList1.Images.SetKeyName(2, "cli1.png");
            imageList1.Images.SetKeyName(3, "func1.png");
            imageList1.Images.SetKeyName(4, "Atualizar_icone.png");
            imageList1.Images.SetKeyName(5, "Atualizar_Icone_semFundo.png");
            imageList1.Images.SetKeyName(6, "delete_icone.png");
            imageList1.Images.SetKeyName(7, "delete_Icone_semFundo.png");
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(228, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1026, 797);
            panel2.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1254, 797);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Academia2025 - A3 - Prof. Wanfranklin ";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btn1;
        private ImageList imageList1;
        private Button btn2;
        private Panel panel2;
        private Button btn3;
    }
}
