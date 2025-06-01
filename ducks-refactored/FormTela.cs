using System;
using System.Drawing;
using System.Windows.Forms;
using Ducks.Behaviors;

namespace Ducks
{
    public class FormTela : Form
    {
        private Button btnMallard;
        private Button btnPapao;
        private Button btnPoke;
        private Button btnTrocarVoo;

        public FormTela()
        {
            Text = "Simulador de Patos";
            Size = new Size(400, 300);

            btnMallard = new Button() { Text = "Criar Mallard Duck", Location = new Point(50, 30), Size = new Size(150, 30) };
            btnPapao = new Button() { Text = "Criar Pato Papão", Location = new Point(50, 80), Size = new Size(150, 30) };
            btnPoke = new Button() { Text = "Criar PokePato", Location = new Point(50, 130), Size = new Size(150, 30) };
            btnTrocarVoo = new Button() { Text = "Trocar Voo Mallard", Location = new Point(50, 180), Size = new Size(150, 30) };

            btnMallard.Click += btnCriarMallard_Click;
            btnPapao.Click += btnCriarPapao_Click;
            btnPoke.Click += btnCriarPoke_Click;
            btnTrocarVoo.Click += btnTrocarVooMallard_Click;

            Controls.Add(btnMallard);
            Controls.Add(btnPapao);
            Controls.Add(btnPoke);
            Controls.Add(btnTrocarVoo);
        }

        private void btnCriarMallard_Click(object sender, EventArgs e)
        {
            Duck pato = new MallardDuck();
            pato.Display();
            pato.PerformFly();
            pato.PerformQuack();
        }

        private void btnCriarPapao_Click(object sender, EventArgs e)
        {
            Duck pato = new PapaoDuck();
            pato.Display();
            pato.PerformFly();
            pato.PerformQuack();
        }

        private void btnCriarPoke_Click(object sender, EventArgs e)
        {
            Duck pato = new Pokepato();
            pato.Display();
            pato.PerformFly();
            pato.PerformQuack();
        }

        private void btnTrocarVooMallard_Click(object sender, EventArgs e)
        {
            MallardDuck mallard = new MallardDuck();
            mallard.Display();
            mallard.PerformFly();
            mallard.SetFlyBehavior(new GlideBehavior());
            mallard.PerformFly();
        }
    }
}
