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

        private void hitButton_Click(object sender, EventArgs e)
        {
            cartaController carta = new cartaController();
            carta.AgregarCarta(Globals.MyHand, carta.AgarrarMazo(Globals._cartas, Jugador));

            if (carta.CheckPerdidas(Globals.MyHand) == true)
            {
                statusLabel.Text = "Jugador Pierde";
            }
        }
        private void resetButton_Click(object sender, EventArgs e)
        {
            cartaController c = new cartaController();
            Globals.MyHand = c.CrearMazo();
            Globals.DealerHand = c.CrearMazo();
            Globals._cartas = c.CrearMazo();
            c.VaciarMano(Jugador);
            c.VaciarMano(Dealer);
            statusLabel.Text = "Jugando...";
            c.Agregar52(Globals._cartas);
            c.AgregarCarta(Globals.MyHand, c.AgarrarMazo(Globals._cartas, Jugador));
            c.AgregarCarta(Globals.DealerHand, c.AgarrarMazo(Globals._cartas, Dealer));
            c.AgregarCarta(Globals.MyHand, c.AgarrarMazo(Globals._cartas, Jugador));
        }
        private void stopButton_Click(object sender, EventArgs e)
        {
            cartaController c = new cartaController();
            c.AgregarCarta(Globals.DealerHand, c.AgarrarMazo(Globals._cartas, Dealer));

            //verificar la jugada inicail del dealer
            if (c.Verificar21(Globals.DealerHand)){
                statusLabel.Text = "Dealer Gana";
            }
            else
            {
                statusLabel.Text = "Jugador Gana";
            }

            if (c.PlantarseDealer17(Globals.DealerHand)) // si el dealer tiene 17 se debe de plantar 
            {
                if (c.CompararValores(Globals.DealerHand, Globals.MyHand) == 3)
                {
                    statusLabel.Text = "Dealer Gana";
                }
                if (c.CompararValores(Globals.DealerHand, Globals.MyHand) == 2)
                {
                    statusLabel.Text = "Dealer Gana";
                }
                if (c.CompararValores(Globals.DealerHand, Globals.MyHand) == 1)
                {
                    statusLabel.Text = "Dealer Gana";
                }

            }
            else c.AgregarCarta(Globals.DealerHand, c.AgarrarMazo(Globals._cartas, Dealer));

            if (c.CheckPerdidas(Globals.DealerHand) == true)
            {
                statusLabel.Text = "Jugador gana";

            }

            //de ser necesario agregar mas cartas al dealer y volver a verificar si gana o pierde (segundo robo)
            if (c.PlantarseDealer17(Globals.DealerHand))
            {
                if (c.CompararValores(Globals.DealerHand, Globals.MyHand) == 3)
                {
                    statusLabel.Text = "Dealer gana";
                }
                if (c.CompararValores(Globals.DealerHand, Globals.MyHand) == 2)
                {
                    statusLabel.Text = "Dealer gana";
                }
                if (c.CompararValores(Globals.DealerHand, Globals.MyHand) == 1)
                {
                    statusLabel.Text = "Jugador Gana";
                }
            }
            else c.AgregarCarta(Globals.DealerHand, c.AgarrarMazo(Globals._cartas, Dealer));

            if (c.CheckPerdidas(Globals.DealerHand) == true)
            {
                statusLabel.Text = "Jugador gana";

            }

            // si el dealer tiene 17 se debe de plantar en el caso de que no tenga 17 se debe de seguir pidiendo cartas (tercer robo)
            if (c.PlantarseDealer17(Globals.DealerHand))
            {
                if (c.CompararValores(Globals.DealerHand, Globals.MyHand) == 3)
                {
                    statusLabel.Text = "Dealer gana";
                }
                if (c.CompararValores(Globals.DealerHand, Globals.MyHand) == 2)
                {
                    statusLabel.Text = "Dealer gan";
                }
                if (c.CompararValores(Globals.DealerHand, Globals.MyHand) == 1)
                {
                    statusLabel.Text = "Jugador gana";
                }
            }
            else c.AgregarCarta(Globals.DealerHand, c.AgarrarMazo(Globals._cartas, Dealer));

            if (c.CheckPerdidas(Globals.DealerHand) == true)
            {
                statusLabel.Text = "Jugador gana";

            }

            //cuarto pase 
            if (c.PlantarseDealer17(Globals.DealerHand))
            {
                if (c.CompararValores(Globals.DealerHand, Globals.MyHand) == 3)
                {
                    statusLabel.Text = "Dealer gana";
                }
                if (c.CompararValores(Globals.DealerHand, Globals.MyHand) == 2)
                {
                    statusLabel.Text = "Dealer gana";
                }
                if (c.CompararValores(Globals.DealerHand, Globals.MyHand) == 1)
                {
                    statusLabel.Text = "Jugador gana";
                }
            }
            else c.AgregarCarta(Globals.DealerHand, c.AgarrarMazo(Globals._cartas, Dealer));
            if (c.CheckPerdidas(Globals.DealerHand) == true)
            {
                statusLabel.Text = "Jugador gana";

            }



        }

        private void Jugador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void statusLabel_Click(object sender, EventArgs e)
        {

        }

        private void Dealer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
