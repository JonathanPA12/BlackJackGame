using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

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

        public void RegistroDejuego(cartaController inicio)
        {
            int dealer = 0, jugador = 0;
            TextWriter registro = new StreamWriter("Registro.txt", true);
            if (inicio.CheckPerdidas(Globals.MyHand) == true)
            {
                registro.WriteLine("Jugador ha Perdido " + dealer+1);


            }
            else
            {
                registro.WriteLine("Jugador ha ganado " + jugador+1);

            }
            registro.Close();

        }

        private void hitButton_Click(object sender, EventArgs e)
        {
            cartaController carta = new cartaController();
            carta.AgregarCarta(Globals.MyHand, carta.AgarrarMazo(Globals._cartas, Jugador));

            if (carta.CheckPerdidas(Globals.MyHand) == true)
            {
                statusLabel.Text = "Jugador Pierde";
                RegistroDejuego(carta);


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
                RegistroDejuego(c);
            }
            else
            {
                statusLabel.Text = "Jugador Gana";
                RegistroDejuego(c);
            }

            if (c.PlantarseDealer17(Globals.DealerHand)) // si el dealer tiene 17 se debe de plantar 
            {
                if (c.CompararValores(Globals.DealerHand, Globals.MyHand) == 3)
                {
                    statusLabel.Text = "Dealer Gana";
                    RegistroDejuego(c);
                }
                if (c.CompararValores(Globals.DealerHand, Globals.MyHand) == 2)
                {
                    statusLabel.Text = "Dealer Gana";
                    RegistroDejuego(c);
                }
                if (c.CompararValores(Globals.DealerHand, Globals.MyHand) == 1)
                {
                    statusLabel.Text = "Dealer Gana";
                    RegistroDejuego(c);
                }

            }
            else c.AgregarCarta(Globals.DealerHand, c.AgarrarMazo(Globals._cartas, Dealer));

            if (c.CheckPerdidas(Globals.DealerHand) == true)
            {
                statusLabel.Text = "Jugador gana";
                RegistroDejuego(c);

            }

            //de ser necesario agregar mas cartas al dealer y volver a verificar si gana o pierde (segundo robo)
            if (c.PlantarseDealer17(Globals.DealerHand))
            {
                if (c.CompararValores(Globals.DealerHand, Globals.MyHand) == 3)
                {
                    statusLabel.Text = "Dealer gana";
                    RegistroDejuego(c);
                }
                if (c.CompararValores(Globals.DealerHand, Globals.MyHand) == 2)
                {
                    statusLabel.Text = "Dealer gana";
                    RegistroDejuego(c);
                }
                if (c.CompararValores(Globals.DealerHand, Globals.MyHand) == 1)
                {
                    statusLabel.Text = "Jugador Gana";
                    RegistroDejuego(c);
                }
            }
            else c.AgregarCarta(Globals.DealerHand, c.AgarrarMazo(Globals._cartas, Dealer));

            if (c.CheckPerdidas(Globals.DealerHand) == true)
            {
                statusLabel.Text = "Jugador gana";
                RegistroDejuego(c);

            }

            // si el dealer tiene 17 se debe de plantar en el caso de que no tenga 17 se debe de seguir pidiendo cartas (tercer robo)
            if (c.PlantarseDealer17(Globals.DealerHand))
            {
                if (c.CompararValores(Globals.DealerHand, Globals.MyHand) == 3)
                {
                    statusLabel.Text = "Dealer gana";
                    RegistroDejuego(c);
                }
                if (c.CompararValores(Globals.DealerHand, Globals.MyHand) == 2)
                {
                    statusLabel.Text = "Dealer gana";
                    RegistroDejuego(c);
                }
                if (c.CompararValores(Globals.DealerHand, Globals.MyHand) == 1)
                {
                    statusLabel.Text = "Jugador gana";
                    RegistroDejuego(c);
                }
            }
            else c.AgregarCarta(Globals.DealerHand, c.AgarrarMazo(Globals._cartas, Dealer));

            if (c.CheckPerdidas(Globals.DealerHand) == true)
            {
                statusLabel.Text = "Jugador gana";
                RegistroDejuego(c);

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
                    RegistroDejuego(c);
                }
                if (c.CompararValores(Globals.DealerHand, Globals.MyHand) == 1)
                {
                    statusLabel.Text = "Jugador gana";
                    RegistroDejuego(c);
                }
            }
            else c.AgregarCarta(Globals.DealerHand, c.AgarrarMazo(Globals._cartas, Dealer));
            if (c.CheckPerdidas(Globals.DealerHand) == true)
            {
                statusLabel.Text = "Jugador gana";
                RegistroDejuego(c);

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
