namespace POO_activities
{
    partial class FormTela
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
            comboBoxPatos = new ComboBox();
            listBoxMetodos = new ListBox();
            btnExecutar = new Button();
            lblResultado = new Label();
            pictureBoxPato = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPato).BeginInit();
            SuspendLayout();
            // 
            // comboBoxPatos
            // 
            comboBoxPatos.FormattingEnabled = true;
            comboBoxPatos.Location = new Point(47, 125);
            comboBoxPatos.Name = "comboBoxPatos";
            comboBoxPatos.Size = new Size(121, 23);
            comboBoxPatos.TabIndex = 0;
            comboBoxPatos.SelectedIndexChanged += comboBoxPatos_SelectedIndexChanged;
            // 
            // listBoxMetodos
            // 
            listBoxMetodos.FormattingEnabled = true;
            listBoxMetodos.ItemHeight = 15;
            listBoxMetodos.Location = new Point(251, 104);
            listBoxMetodos.Name = "listBoxMetodos";
            listBoxMetodos.Size = new Size(120, 94);
            listBoxMetodos.TabIndex = 1;
            // 
            // btnExecutar
            // 
            btnExecutar.Location = new Point(70, 154);
            btnExecutar.Name = "btnExecutar";
            btnExecutar.Size = new Size(75, 23);
            btnExecutar.TabIndex = 2;
            btnExecutar.Text = "Executar";
            btnExecutar.UseVisualStyleBackColor = true;
            btnExecutar.Click += btnExecutar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(47, 311);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(62, 15);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "Resultado:";
            // 
            // pictureBoxPato
            // 
            pictureBoxPato.Location = new Point(516, 58);
            pictureBoxPato.Name = "pictureBoxPato";
            pictureBoxPato.Size = new Size(251, 268);
            pictureBoxPato.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPato.TabIndex = 4;
            pictureBoxPato.TabStop = false;
            // 
            // FormTela
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBoxPato);
            Controls.Add(lblResultado);
            Controls.Add(btnExecutar);
            Controls.Add(listBoxMetodos);
            Controls.Add(comboBoxPatos);
            Name = "FormTela";
            Text = "FormTela";
            Load += FormTela_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxPato).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxPatos;
        private ListBox listBoxMetodos;
        private Button btnExecutar;
        private Label lblResultado;
        private PictureBox pictureBoxPato;
    }
}