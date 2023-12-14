namespace GUIAPP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BarraTitulo = new Panel();
            BtnMinimizar = new PictureBox();
            BtnRestaurar = new PictureBox();
            BtnMaximizar = new PictureBox();
            BtnCerrar = new PictureBox();
            MenuVertical = new Panel();
            panel5 = new Panel();
            button4 = new Button();
            panel4 = new Panel();
            button3 = new Button();
            panel3 = new Panel();
            button2 = new Button();
            panel2 = new Panel();
            button1 = new Button();
            panel1 = new Panel();
            BtnPanel1 = new Button();
            pictureBox1 = new PictureBox();
            panelContenedor = new Panel();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnCerrar).BeginInit();
            MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.CornflowerBlue;
            BarraTitulo.Controls.Add(BtnMinimizar);
            BarraTitulo.Controls.Add(BtnRestaurar);
            BarraTitulo.Controls.Add(BtnMaximizar);
            BarraTitulo.Controls.Add(BtnCerrar);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(0, 0);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(1300, 35);
            BarraTitulo.TabIndex = 0;
            BarraTitulo.Paint += BarraTitulo_Paint;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // BtnMinimizar
            // 
            BtnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnMinimizar.Cursor = Cursors.Hand;
            BtnMinimizar.Image = (Image)resources.GetObject("BtnMinimizar.Image");
            BtnMinimizar.Location = new Point(1183, 3);
            BtnMinimizar.Name = "BtnMinimizar";
            BtnMinimizar.Size = new Size(31, 29);
            BtnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            BtnMinimizar.TabIndex = 2;
            BtnMinimizar.TabStop = false;
            BtnMinimizar.Click += BtnMinimizar_Click;
            // 
            // BtnRestaurar
            // 
            BtnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnRestaurar.Cursor = Cursors.Hand;
            BtnRestaurar.Image = (Image)resources.GetObject("BtnRestaurar.Image");
            BtnRestaurar.Location = new Point(1220, 3);
            BtnRestaurar.Name = "BtnRestaurar";
            BtnRestaurar.Size = new Size(31, 29);
            BtnRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            BtnRestaurar.TabIndex = 1;
            BtnRestaurar.TabStop = false;
            BtnRestaurar.Visible = false;
            BtnRestaurar.Click += BtnRestaurar_Click;
            // 
            // BtnMaximizar
            // 
            BtnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnMaximizar.Cursor = Cursors.Hand;
            BtnMaximizar.Image = (Image)resources.GetObject("BtnMaximizar.Image");
            BtnMaximizar.Location = new Point(1220, 3);
            BtnMaximizar.Name = "BtnMaximizar";
            BtnMaximizar.Size = new Size(31, 29);
            BtnMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            BtnMaximizar.TabIndex = 1;
            BtnMaximizar.TabStop = false;
            BtnMaximizar.Click += BtnMaximizar_Click;
            // 
            // BtnCerrar
            // 
            BtnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnCerrar.Cursor = Cursors.Hand;
            BtnCerrar.Image = (Image)resources.GetObject("BtnCerrar.Image");
            BtnCerrar.Location = new Point(1257, 3);
            BtnCerrar.Name = "BtnCerrar";
            BtnCerrar.Size = new Size(31, 29);
            BtnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            BtnCerrar.TabIndex = 0;
            BtnCerrar.TabStop = false;
            BtnCerrar.Click += BtnCerrar_Click;
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.SlateGray;
            MenuVertical.Controls.Add(panel5);
            MenuVertical.Controls.Add(button4);
            MenuVertical.Controls.Add(panel4);
            MenuVertical.Controls.Add(button3);
            MenuVertical.Controls.Add(panel3);
            MenuVertical.Controls.Add(button2);
            MenuVertical.Controls.Add(panel2);
            MenuVertical.Controls.Add(button1);
            MenuVertical.Controls.Add(panel1);
            MenuVertical.Controls.Add(BtnPanel1);
            MenuVertical.Controls.Add(pictureBox1);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 35);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(220, 615);
            MenuVertical.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.CornflowerBlue;
            panel5.Location = new Point(0, 353);
            panel5.Name = "panel5";
            panel5.Size = new Size(10, 42);
            panel5.TabIndex = 10;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(12, 353);
            button4.Name = "button4";
            button4.Size = new Size(208, 42);
            button4.TabIndex = 9;
            button4.Text = "Panel 5";
            button4.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.CornflowerBlue;
            panel4.Location = new Point(0, 291);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 42);
            panel4.TabIndex = 8;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(12, 291);
            button3.Name = "button3";
            button3.Size = new Size(208, 42);
            button3.TabIndex = 7;
            button3.Text = "Panel 4";
            button3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.CornflowerBlue;
            panel3.Location = new Point(0, 230);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 42);
            panel3.TabIndex = 6;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(12, 230);
            button2.Name = "button2";
            button2.Size = new Size(208, 42);
            button2.TabIndex = 5;
            button2.Text = "Panel 3";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.CornflowerBlue;
            panel2.Location = new Point(0, 166);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 42);
            panel2.TabIndex = 4;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(12, 166);
            button1.Name = "button1";
            button1.Size = new Size(208, 42);
            button1.TabIndex = 3;
            button1.Text = "Panel 2";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Location = new Point(0, 109);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 42);
            panel1.TabIndex = 2;
            // 
            // BtnPanel1
            // 
            BtnPanel1.FlatAppearance.BorderSize = 0;
            BtnPanel1.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            BtnPanel1.FlatStyle = FlatStyle.Flat;
            BtnPanel1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnPanel1.Location = new Point(12, 109);
            BtnPanel1.Name = "BtnPanel1";
            BtnPanel1.Size = new Size(208, 42);
            BtnPanel1.TabIndex = 1;
            BtnPanel1.Text = "Panel 1";
            BtnPanel1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(75, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.DarkGray;
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(220, 35);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1080, 615);
            panelContenedor.TabIndex = 2;
            panelContenedor.Paint += panelContenedor_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 650);
            Controls.Add(panelContenedor);
            Controls.Add(MenuVertical);
            Controls.Add(BarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BtnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnCerrar).EndInit();
            MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }



        #endregion

        private Panel BarraTitulo;
        private PictureBox BtnCerrar;
        private Panel MenuVertical;
        private Panel panelContenedor;
        private PictureBox BtnRestaurar;
        private PictureBox BtnMaximizar;
        private PictureBox BtnMinimizar;
        private Button BtnPanel1;
        private PictureBox pictureBox1;
        private Panel panel5;
        private Button button4;
        private Panel panel4;
        private Button button3;
        private Panel panel3;
        private Button button2;
        private Panel panel2;
        private Button button1;
        private Panel panel1;
    }
}