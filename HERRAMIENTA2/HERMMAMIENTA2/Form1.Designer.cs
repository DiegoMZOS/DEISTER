namespace HERMMAMIENTA2
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
            folderBrowserDialog1 = new FolderBrowserDialog();
            ArchivosListBox = new CheckedListBox();
            SeleccionarCarpetaButton = new Button();
            textBox1 = new TextBox();
            ModificarNombres = new Button();
            SuspendLayout();
            // 
            // ArchivosListBox
            // 
            ArchivosListBox.FormattingEnabled = true;
            ArchivosListBox.Location = new Point(39, 85);
            ArchivosListBox.Name = "ArchivosListBox";
            ArchivosListBox.Size = new Size(393, 112);
            ArchivosListBox.TabIndex = 0;
            ArchivosListBox.SelectedIndexChanged += ArchivosListBox_SelectedIndexChanged;
            // 
            // SeleccionarCarpetaButton
            // 
            SeleccionarCarpetaButton.Location = new Point(39, 32);
            SeleccionarCarpetaButton.Name = "SeleccionarCarpetaButton";
            SeleccionarCarpetaButton.Size = new Size(75, 23);
            SeleccionarCarpetaButton.TabIndex = 1;
            SeleccionarCarpetaButton.Text = "Seleccionar carpeta";
            SeleccionarCarpetaButton.UseVisualStyleBackColor = true;
            SeleccionarCarpetaButton.Click += SeleccionarCarpetaButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(213, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(219, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // ModificarNombres
            // 
            ModificarNombres.Location = new Point(477, 29);
            ModificarNombres.Name = "ModificarNombres";
            ModificarNombres.Size = new Size(75, 23);
            ModificarNombres.TabIndex = 3;
            ModificarNombres.Text = "Modificar";
            ModificarNombres.UseVisualStyleBackColor = true;
            ModificarNombres.Click += ModificarNombres_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 342);
            Controls.Add(ModificarNombres);
            Controls.Add(textBox1);
            Controls.Add(SeleccionarCarpetaButton);
            Controls.Add(ArchivosListBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FolderBrowserDialog folderBrowserDialog1;
        private CheckedListBox ArchivosListBox;
        private Button SeleccionarCarpetaButton;
        private TextBox textBox1;
        private Button ModificarNombres;
    }
}