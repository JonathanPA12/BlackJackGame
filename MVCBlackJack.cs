using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJackGame
{
    public partial class MVCBlackJack : Form
    {
        public MVCBlackJack()
        {
            InitializeComponent();
        }

        private void MVCBlackJack_Load(object sender, EventArgs e)
        {

        }

        private void listMyHand_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void hitButton_Click(object sender, EventArgs e)
        {
            cartaController carta = new cartaController();
            carta.AgregarCarta(Globals.MyHand, carta.AgarrarMazo(Globals._cartas, Jugador));

            if (carta.CheckPerdidas(Globals.MyHand) == true)
            {
                statusLabel.Text = "Jugador Pierde";
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
