using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dibujarlineas
{
    public partial class Form1 : Form
    {
        Graphics papel;
        public Form1()
        {
            InitializeComponent();
            
            papel = pictureBox1.CreateGraphics();
        }

        private void btndibujarlineas_Click(object sender, EventArgs e)
        {
            Pen lapiz = new Pen(Color.Black);
            switch (cbocolores.SelectedIndex)
            {
                case 0:
                    lapiz = new Pen(Color.Yellow);
                    break;
                case 1:
                    lapiz = new Pen(Color.Red);
                    break;
                case 2:
                    lapiz = new Pen(Color.Blue);
                    break;
                case 3:
                    lapiz = new Pen(Color.Black);
                    break;
            }
            int iteraciones = int.Parse(txtcantidad.Text);// cantidad de lineas a dibujar
            int espacio = int.Parse(txtespaciado.Text);//Espacio en pixeles
            papel.Clear(Color.White);
            int puntoinicio = 50;
            for (int i = 0; i < iteraciones; i++)
            {
                papel.DrawLine(lapiz, 20, puntoinicio + (espacio * i), 290, puntoinicio + (espacio * i));
            }
        }
    }
}
