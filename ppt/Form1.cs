using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ppt
{
    public partial class Form1 : Form
    {

        int enemy = 0;
        int ponto = 0;
        int eponto = 0;

        public Form1()
        {
            InitializeComponent();
        }



        public void rand()
        {
            Random random = new Random();
            enemy = random.Next(3);
            if (enemy == 0)
            {
                panel2.Location = new Point(30, 30);
                ipedra.Location = new Point(350, 173);
            }
            if (enemy == 1)
            {
                panel2.Location = new Point(190, 30);
                ipapel.Location = new Point(350, 173);
            }
            if (enemy == 2)
            {
                panel2.Location = new Point(350, 30);
                itesoura.Location = new Point(350, 173);
            }
        }



        private void pedra_Click(object sender, EventArgs e)
        {
            if (pedra.Location == new Point(30, 315)
               && (papel.Location == new Point(190, 315))
               && tesoura.Location == new Point(350, 315))
            {
                pedra.BorderStyle = BorderStyle.FixedSingle;
                panel1.Location = new Point(30, 315);
                pedra.Location = new Point(30, 173);

                rand();
                epedra();
            }

            else
            {
                return;
            }

        }


        private void papel_Click(object sender, EventArgs e)
        {
            if (pedra.Location == new Point(30, 315)
            && (papel.Location == new Point(190, 315))
            && tesoura.Location == new Point(350, 315))
            {
                papel.BorderStyle = BorderStyle.FixedSingle;
                panel1.Location = new Point(190, 315);
                papel.Location = new Point(30, 173);

                rand();
                epapel();
            }

            else
            {
                return;
            }
        }

        private void tesoura_Click(object sender, EventArgs e)
        {
            if (pedra.Location == new Point(30, 315)
             && (papel.Location == new Point(190, 315))
              && tesoura.Location == new Point(350, 315))
            {
                tesoura.BorderStyle = BorderStyle.FixedSingle;
                panel1.Location = new Point(350, 315);
                tesoura.Location = new Point(30, 173);

                rand();
                etesoura();
            }

            else
            {
                return;
            }
        }

        public void epedra()
        {
            switch (enemy)
            {
                case 0:
                    MessageBox.Show("Empatou");
                    break;

                case 1:
                    MessageBox.Show("Perdeu!");
                    eponto++;
                    plac2.Text = Convert.ToString(eponto);
                    break;

                case 2:
                    MessageBox.Show("Ganhou!");
                    ponto++;
                    plac.Text = Convert.ToString(ponto);
                    break;
            }
        }

        public void epapel()
        {
            switch (enemy)
            {
                case 0:
                    MessageBox.Show("Ganhou!");
                    ponto++;
                    plac.Text = Convert.ToString(ponto);
                    break;

                case 1:
                    MessageBox.Show("Empatou");
                    break;

                case 2:
                    MessageBox.Show("Perdeu!");
                    eponto++;
                    plac2.Text = Convert.ToString(eponto);
                    break;
            }
        }

        public void etesoura()
        {
            switch (enemy)
            {
                case 0:
                    MessageBox.Show("Perdeu!");
                    eponto++;
                    plac2.Text = Convert.ToString(eponto);
                    break;

                case 1:
                    MessageBox.Show("Ganhou!");
                    ponto++;
                    plac.Text = Convert.ToString(ponto);
                    break;

                case 2:
                    MessageBox.Show("Empatou");
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reorganiza();
        }

        private void reorganiza()
        {
            ipedra.Location = new Point(30, 30);
            ipapel.Location = new Point(190, 30);
            itesoura.Location = new Point(350, 30);
            panel1.Location = new Point(30, 173);
            panel2.Location = new Point(350, 173);
            pedra.Location = new Point(30, 315);
            papel.Location = new Point(190, 315);
            tesoura.Location = new Point(350, 315);
            pedra.BorderStyle = BorderStyle.None;
            papel.BorderStyle = BorderStyle.None;
            tesoura.BorderStyle = BorderStyle.None;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reorganiza();
            ponto = 0;
            eponto = 0;
            plac.Text = Convert.ToString(ponto);
            plac2.Text = Convert.ToString(eponto);
        }

    }
}
