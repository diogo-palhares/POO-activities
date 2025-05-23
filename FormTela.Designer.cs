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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTela));
            comboBoxPatos = new ComboBox();
            listBoxMetodos = new ListBox();
            btnExecutar = new Button();
            lblResultado = new Label();
            pictureBoxPato = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPato).BeginInit();
            SuspendLayout();
            // 
            // comboBoxPatos
            // 
            comboBoxPatos.BackColor = Color.LightGreen;
            comboBoxPatos.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxPatos.ForeColor = SystemColors.ActiveCaptionText;
            comboBoxPatos.ImeMode = ImeMode.Disable;
            comboBoxPatos.Location = new Point(243, 98);
            comboBoxPatos.Margin = new Padding(3, 4, 3, 4);
            comboBoxPatos.Name = "comboBoxPatos";
            comboBoxPatos.Size = new Size(155, 25);
            comboBoxPatos.TabIndex = 0;
            comboBoxPatos.SelectedIndexChanged += comboBoxPatos_SelectedIndexChanged;
            // 
            // listBoxMetodos
            // 
            listBoxMetodos.BackColor = Color.LightGreen;
            listBoxMetodos.BorderStyle = BorderStyle.None;
            listBoxMetodos.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxMetodos.ForeColor = SystemColors.ActiveCaptionText;
            listBoxMetodos.FormattingEnabled = true;
            listBoxMetodos.ItemHeight = 17;
            listBoxMetodos.Location = new Point(244, 143);
            listBoxMetodos.Margin = new Padding(3, 4, 3, 4);
            listBoxMetodos.Name = "listBoxMetodos";
            listBoxMetodos.Size = new Size(154, 119);
            listBoxMetodos.TabIndex = 1;
            // 
            // btnExecutar
            // 
            btnExecutar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnExecutar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExecutar.BackColor = Color.LimeGreen;
            btnExecutar.BackgroundImageLayout = ImageLayout.Center;
            btnExecutar.FlatStyle = FlatStyle.Popup;
            btnExecutar.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExecutar.Location = new Point(271, 286);
            btnExecutar.Margin = new Padding(3, 4, 3, 4);
            btnExecutar.Name = "btnExecutar";
            btnExecutar.RightToLeft = RightToLeft.No;
            btnExecutar.Size = new Size(97, 31);
            btnExecutar.TabIndex = 2;
            btnExecutar.Text = "Executar";
            btnExecutar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnExecutar.UseVisualStyleBackColor = false;
            btnExecutar.Click += btnExecutar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.BackColor = Color.Transparent;
            lblResultado.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(244, 379);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 17);
            lblResultado.TabIndex = 3;
            lblResultado.Click += lblResultado_Click;
            // 
            // pictureBoxPato
            // 
            pictureBoxPato.BackColor = Color.Transparent;
            pictureBoxPato.BackgroundImageLayout = ImageLayout.Center;
            pictureBoxPato.Location = new Point(512, 98);
            pictureBoxPato.Margin = new Padding(3, 4, 3, 4);
            pictureBoxPato.Name = "pictureBoxPato";
            pictureBoxPato.Size = new Size(345, 301);
            pictureBoxPato.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPato.TabIndex = 4;
            pictureBoxPato.TabStop = false;
            pictureBoxPato.Click += pictureBoxPato_Click;
            // 
            // FormTela
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(944, 600);
            Controls.Add(pictureBoxPato);
            Controls.Add(lblResultado);
            Controls.Add(btnExecutar);
            Controls.Add(listBoxMetodos);
            Controls.Add(comboBoxPatos);
            DoubleBuffered = true;
            Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormTela";
            Text = "Duck Choose";
            TransparencyKey = Color.White;
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}