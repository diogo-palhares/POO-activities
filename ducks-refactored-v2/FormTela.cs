using System;
using System.Windows.Forms;

namespace Ducks
{
    public class FormTela : Form
    {
        private ComboBox comboDucks;
        private Button btnSelectDuck;
        private Button btnDisplay;
        private Button btnFly;
        private Button btnQuack;
        private Label lblSelect;
        private Duck selectedDuck;

        public FormTela()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Simulador de Patos";
            this.Width = 400;
            this.Height = 200;

            lblSelect = new Label();
            lblSelect.Text = "Escolha um tipo de pato:";
            lblSelect.Top = 20;
            lblSelect.Left = 20;
            lblSelect.Width = 200;

            comboDucks = new ComboBox();
            comboDucks.Items.AddRange(new string[] { "Mallard", "Papao", "Poke" });
            comboDucks.Top = 50;
            comboDucks.Left = 20;
            comboDucks.Width = 120;
            comboDucks.DropDownStyle = ComboBoxStyle.DropDownList;

            btnSelectDuck = new Button();
            btnSelectDuck.Text = "Selecionar Pato";
            btnSelectDuck.Top = 50;
            btnSelectDuck.Left = 160;
            btnSelectDuck.Click += BtnSelectDuck_Click;

            btnDisplay = new Button();
            btnDisplay.Text = "Exibir Pato";
            btnDisplay.Top = 90;
            btnDisplay.Left = 20;
            btnDisplay.Enabled = false;
            btnDisplay.Click += BtnDisplay_Click;

            btnFly = new Button();
            btnFly.Text = "Voar";
            btnFly.Top = 90;
            btnFly.Left = 120;
            btnFly.Enabled = false;
            btnFly.Click += BtnFly_Click;

            btnQuack = new Button();
            btnQuack.Text = "Grasnar";
            btnQuack.Top = 90;
            btnQuack.Left = 200;
            btnQuack.Enabled = false;
            btnQuack.Click += BtnQuack_Click;

            this.Controls.Add(lblSelect);
            this.Controls.Add(comboDucks);
            this.Controls.Add(btnSelectDuck);
            this.Controls.Add(btnDisplay);
            this.Controls.Add(btnFly);
            this.Controls.Add(btnQuack);
        }

        private void BtnSelectDuck_Click(object sender, EventArgs e)
        {
            string choice = comboDucks.SelectedItem as string;
            if (string.IsNullOrEmpty(choice))
            {
                MessageBox.Show("Por favor, selecione um tipo de pato.");
                return;
            }

            // Instanciar o pato de acordo com a escolha
            switch (choice)
            {
                case "Mallard":
                    selectedDuck = new MallardDuck();
                    break;
                case "Papao":
                    selectedDuck = new PapaoDuck();
                    break;
                case "Poke":
                    selectedDuck = new Pokepato();
                    break;
                default:
                    selectedDuck = null;
                    break;
            }

            if (selectedDuck != null)
            {
                MessageBox.Show($"Pato {selectedDuck.Name} selecionado.");
                // Habilitar botões de ação
                btnDisplay.Enabled = true;
                btnFly.Enabled = true;
                btnQuack.Enabled = true;
            }
        }

        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            selectedDuck?.Display();
        }

        private void BtnFly_Click(object sender, EventArgs e)
        {
            selectedDuck?.PerformFly();
        }

        private void BtnQuack_Click(object sender, EventArgs e)
        {
            selectedDuck?.PerformQuack();
        }
    }
}
