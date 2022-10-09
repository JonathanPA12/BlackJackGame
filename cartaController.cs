using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJackGame
{
    public class cartaController
    {
        public int CompararValores(Mazo jugador, Mazo dealer)
        {
            if (jugador.sumar() > dealer.sumar()) // Si el jugador gana 
            {
                return 1;
            }
            else if (jugador.sumar() < dealer.sumar()) // si el dealer gana
            {
                return 2;
            }
            else //si hay empate
            {
                return 3;
            }
                 

        }
        public bool CompararAses(Mazo jugador, Mazo dealer)
        {
            if (jugador.sumar() == 21 && dealer.sumar() == 21) // Si el jugador y el dealer tienen 21
            {
                return true;
            }
            else if (jugador.sumar() == 21) // Si el jugador tiene 21
            {
                return true;
            }
            else if (dealer.sumar() == 21) // Si el dealer tiene 21
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckPerdidas(Mazo jugador)
        {
            if (jugador.sumar() > 21)
            {
                jugador.Aset1();
                if (jugador.sumar() > 21)
                {
                    jugador.Aset1();
                    if (jugador.sumar() > 21)
                    {
                        jugador.Aset1();
                        if (jugador.sumar() > 21)
                        {
                            jugador.Aset1();
                            if (jugador.sumar() > 21)
                            {
                                return true;
                            }
                            else return false;
                        }
                        else return false;
                    }
                    else return false;
                }
                else return false;
            }

            return false;
        }
        
        public bool PlantarseDealer17(Mazo dealer)
        {
            if (dealer.sumar() < 17)
            {
                dealer.Aset1();
                if (dealer.sumar() < 17)
                {
                    dealer.Aset1();
                    if (dealer.sumar() < 17)
                    {
                        dealer.Aset1();
                        if (dealer.sumar() < 17)
                        {
                            dealer.Aset1();
                            if (dealer.sumar() < 17)
                            {
                                return true;
                            }
                            else return false;
                        }
                        else return false;
                    }
                    else return false;
                }
                else return false;
            }

            return false;
          
        }
        public bool Verificar21(Mazo jugador)
        {
            if (jugador.sumar() == 21) return true;
            return false;
        }
           

        public string VerificarGanador(Mazo jugador, Mazo dealer)
        {
            if (jugador.sumar() > 21) return "Casa gana!";
            if (dealer.sumar() > 21) return "Ganaste, el dealer se pasó!";

            if (jugador.sumar() < dealer.sumar()) // Si el jugador gana 
            {
                return "Felicidades Ganaste!, Dealer pierde";
            }
            else if (jugador.sumar() > dealer.sumar()) // si el dealer gana
            {
                return "Perdiste, Casa gana";
            }
            else //si hay empate
            {
                return "Empate";
            }
        }
        public Carta AgarrarMazo(Mazo mazo, ListView v)
        {

            Carta aux = mazo.AgarrarCartaTop();
            ListViewItem item = new ListViewItem(aux.getCara());
            item.SubItems.Add(aux.getPalo());
            item.SubItems.Add(aux.getValor().ToString());
            v.Items.Add(item);
            return aux;
        }
        public void VaciarMano(ListView vaciar)
        {
            vaciar.Items.Clear();
        }
        public Mazo CrearMazo()
        {
            Mazo buff = new Mazo();
            return buff;
        }

        public void AgregarCarta(Mazo mazo, Carta carta)
        {
            mazo.AgregarCarta(carta);
        }

        public void Agregar52(Mazo mazo)
        {
            string palo = "Picas";
            Carta carta;
            carta = new Carta(palo, "As", 11);
            mazo.AgregarCarta(carta);
            carta = new Carta(palo, "Dos", 2);
            mazo.AgregarCarta(carta);
            carta = new Carta(palo, "Tres", 3);
            mazo.AgregarCarta(carta);
            carta = new Carta(palo, "Cuatro", 4);
            mazo.AgregarCarta(carta);
            carta = new Carta(palo, "Cinco", 5);
            mazo.AgregarCarta(carta);
            carta = new Carta(palo, "Seis", 6);
            mazo.AgregarCarta(carta);
            carta = new Carta(palo, "Siete", 7);
            mazo.AgregarCarta(carta);
            carta = new Carta(palo, "Ocho", 8);
            mazo.AgregarCarta(carta);
            carta = new Carta(palo, "Nueve", 9);
            mazo.AgregarCarta(carta);
            carta = new Carta(palo, "Diez", 10);
            mazo.AgregarCarta(carta);
            carta = new Carta(palo, "Reyna", 10);
            mazo.AgregarCarta(carta);
            carta = new Carta(palo, "Rey", 10);
            mazo.AgregarCarta(carta);
            carta = new Carta(palo, "Jota", 10);
            mazo.AgregarCarta(carta);

            palo = "Diamante";
            carta = new Carta(palo, "As", 11);
            mazo.AgregarCarta(carta);
            carta = new Carta(palo, "Dos", 2);
            mazo.AgregarCarta(carta);
            carta = new Carta(palo, "Tres", 3);
            mazo.AgregarCarta(carta);
            carta = new Carta(palo, "Cuatro", 4);
            mazo.AgregarCarta(carta);
            carta = new Carta(palo, "Cinco", 5);
            mazo.AgregarCarta(carta);
            carta = new Carta(palo, "Seis", 6);
            mazo.AgregarCarta(carta);
            carta = new Carta(palo, "Siete", 7);
            mazo.AgregarCarta(carta);
            carta = new Carta(palo, "Ocho", 8);
            mazo.AgregarCarta(carta);
            carta = new Carta(palo, "Nueve", 9);
            mazo.AgregarCarta(carta);
            carta = new Carta(palo, "Diez", 10);
            mazo.AgregarCarta(carta);
            carta = new Carta(palo, "Reyna", 10);
            mazo.AgregarCarta(carta);
            carta = new Carta(palo, "Rey", 10);
            mazo.AgregarCarta(carta);
            carta = new Carta(palo, "Jota", 10);
            mazo.AgregarCarta(carta);

            palo = "Trebol";
            carta = new Carta(palo, "As", 11);
            mazo.AgregarCarta(carta);
            carta = new Carta(palo, "Dos", 2);
            mazo.AgregarCarta(carta);
            carta = new Carta(palo, "Tres", 3);
            mazo.AgregarCarta(carta);
            carta = new Carta(palo, "Cuatro", 4);
            mazo.AgregarCarta(carta);
            carta = new Carta(palo, "Cinco", 5);
            mazo.AgregarCarta(carta);
            carta = new Carta(palo, "Seis", 6);
            mazo.AgregarCarta(carta);
            carta = new Carta(palo, "Siete", 7);
            mazo.AgregarCarta(carta);
            carta = new Carta(palo, "Ocho", 8);
            mazo.AgregarCarta(carta);
            carta = new Carta(palo, "Nueve", 9);
            mazo.AgregarCarta(carta);
            carta = new Carta(palo, "Diez", 10);
            mazo.AgregarCarta(carta);
            carta = new Carta(palo, "Reyna", 10);
            mazo.AgregarCarta(carta);
            carta = new Carta(palo, "Rey", 10);
            mazo.AgregarCarta(carta);
            carta = new Carta(palo, "Jota", 10);
            mazo.AgregarCarta(carta);

            palo = "Corazon";
            carta = new Carta(palo, "As", 11);
            mazo.AgregarCarta(carta);
            carta = new Carta(palo, "Dos", 2);
            mazo.AgregarCarta(carta);
            carta = new Carta(palo, "Tres", 3);
            mazo.AgregarCarta(carta);
            carta = new Carta(palo, "Cuatro", 4);
            mazo.AgregarCarta(carta);
            carta = new Carta(palo, "Cinco", 5);
            mazo.AgregarCarta(carta);
            carta = new Carta(palo, "Seis", 6);
            mazo.AgregarCarta(carta);
            carta = new Carta(palo, "Siete", 7);
            mazo.AgregarCarta(carta);
            carta = new Carta(palo, "Ocho", 8);
            mazo.AgregarCarta(carta);
            carta = new Carta(palo, "Nueve", 9);
            mazo.AgregarCarta(carta);
            carta = new Carta(palo, "Diez", 10);
            mazo.AgregarCarta(carta);
            carta = new Carta(palo, "Reyna", 10);
            mazo.AgregarCarta(carta);
            carta = new Carta(palo, "Rey", 10);
            mazo.AgregarCarta(carta);
            carta = new Carta(palo, "Jota", 10);
            mazo.AgregarCarta(carta);

        }




    }
}
