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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPato).BeginInit();
            SuspendLayout();
            // 
            // comboBoxPatos
            // 
            comboBoxPatos.BackColor = Color.LightGreen;
            comboBoxPatos.FlatStyle = FlatStyle.Flat;
            comboBoxPatos.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxPatos.ForeColor = SystemColors.ActiveCaptionText;
            comboBoxPatos.ImeMode = ImeMode.Disable;
            comboBoxPatos.Location = new Point(12, 98);
            comboBoxPatos.Margin = new Padding(3, 4, 3, 4);
            comboBoxPatos.Name = "comboBoxPatos";
            comboBoxPatos.Size = new Size(494, 25);
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
            listBoxMetodos.Location = new Point(12, 178);
            listBoxMetodos.Margin = new Padding(3, 4, 3, 4);
            listBoxMetodos.Name = "listBoxMetodos";
            listBoxMetodos.Size = new Size(494, 85);
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
            btnExecutar.Location = new Point(41, 282);
            btnExecutar.Margin = new Padding(3, 4, 3, 4);
            btnExecutar.Name = "btnExecutar";
            btnExecutar.RightToLeft = RightToLeft.No;
            btnExecutar.Size = new Size(416, 47);
            btnExecutar.TabIndex = 2;
            btnExecutar.Text = "JOGAR";
            btnExecutar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnExecutar.UseVisualStyleBackColor = false;
            btnExecutar.Click += btnExecutar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.BackColor = Color.Transparent;
            lblResultado.Font = new Font("Comic Sans MS", 20F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(41, 370);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 38);
            lblResultado.TabIndex = 3;
            lblResultado.Click += lblResultado_Click;
            // 
            // pictureBoxPato
            // 
            pictureBoxPato.BackColor = Color.Transparent;
            pictureBoxPato.BackgroundImageLayout = ImageLayout.Center;
            pictureBoxPato.Location = new Point(560, 98);
            pictureBoxPato.Margin = new Padding(3, 4, 3, 4);
            pictureBoxPato.Name = "pictureBoxPato";
            pictureBoxPato.Size = new Size(345, 301);
            pictureBoxPato.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPato.TabIndex = 4;
            pictureBoxPato.TabStop = false;
            pictureBoxPato.Click += pictureBoxPato_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Comic Sans MS", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 45);
            label1.Name = "label1";
            label1.Size = new Size(231, 38);
            label1.TabIndex = 5;
            label1.Text = "Escolha seu pato!";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Comic Sans MS", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 127);
            label2.Name = "label2";
            label2.Size = new Size(375, 38);
            label2.TabIndex = 6;
            label2.Text = "O que seu patinho vai fazer?";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(370, 572);
            label3.Name = "label3";
            label3.Size = new Size(207, 19);
            label3.TabIndex = 7;
            label3.Text = "Copyright all rights reserved©";
            label3.Click += label3_Click;
            // 
            // FormTela
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(944, 600);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBoxPato);
            Controls.Add(lblResultado);
            Controls.Add(btnExecutar);
            Controls.Add(listBoxMetodos);
            Controls.Add(comboBoxPatos);
            Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
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
        private Label label1;
        private Label label2;
        private Label label3;
    }
}