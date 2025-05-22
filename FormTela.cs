using System;
using System.Reflection;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using Patos;
using System.Drawing.Drawing2D;

namespace POO_activities
{
    public partial class FormTela : Form
    {
        private Menu menu;

        public FormTela()
        {
            InitializeComponent();
            menu = new Menu();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rect = this.ClientRectangle;

            using (LinearGradientBrush brush = new LinearGradientBrush(
                rect,
                Color.LightGreen,
                Color.DarkGreen,
                LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, rect);
            }

            base.OnPaint(e);
        }

        private void FormTela_Load(object sender, EventArgs e)
        {
            foreach (var duck in menu.GetDucks())
            {
                comboBoxPatos.Items.Add(duck.Name);
            }
        }

        private void comboBoxPatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxPatos.SelectedIndex;
            var duck = menu.GetDuck(index);
            listBoxMetodos.Items.Clear();

            var tipo = duck.GetType();
            var metodos = tipo.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);

            foreach (var metodo in metodos)
            {
                listBoxMetodos.Items.Add(metodo.Name);
            }
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            int duckIndex = comboBoxPatos.SelectedIndex;
            string metodoNome = listBoxMetodos.SelectedItem?.ToString();

            if (duckIndex >= 0 && !string.IsNullOrEmpty(metodoNome))
            {
                var duck = menu.GetDuck(duckIndex);

                string tipoPato = duck.GetType().Name;
                string caminhoImagem = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Imagens", tipoPato + ".png");

                if (File.Exists(caminhoImagem))
                {
                    pictureBoxPato.Image = Image.FromFile(caminhoImagem);
                }
                else
                {
                    pictureBoxPato.Image = null;
                }

                var metodo = duck.GetType().GetMethod(metodoNome);
                if (metodo != null)
                {
                    var resultado = metodo.Invoke(duck, null);
                    lblResultado.Text = resultado?.ToString() ?? "Executado!";
                }
            }
        }

        private void pictureBoxPato_Click(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
