using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGame
{
    public static class Globals
    {
        public static Mazo _cartas;
        public static Mazo MyHand;
        public static Mazo DealerHand;
        public static Random _random = new Random();
    }
   public class Mazo
    {
       private List<Carta> _cartas;
        

        public Mazo()
        {
            this._cartas = new List<Carta>();

        }

       /* public Carta SacarCarta() // Se saca una carta del mazo
        {
            int index = _random.Next(_cartas.Count);
            Carta carta = _cartas[index];
            _cartas.RemoveAt(index);
            return carta;
        }*/
       /*
        public void Barajar() // Se baraja el mazo
        {
            _cartas = _cartas.OrderBy(x => _random.Next()).ToList();
        }*/

        public int sumar() // Se suman los valores de las cartas
        {
            int suma = 0;
            foreach (Carta carta in _cartas)
            {
                suma += carta.getValor();
            }
            return suma;
        }
        
        public void Aset1() 
        {
            int i = 0, j = 0;
            while (i < _cartas.Count)
            {
                    j=_cartas[i].setA();
                i++;
            }
            
        }
        public void AgregarCarta(Carta carta) // Se agrega una carta al mazo
        {
            _cartas.Add(carta);
        }

        public Carta AgarrarCartaTop() // Se agarran las cartas del mazo de arriba
        {

            int r = Globals._random.Next(_cartas.Count);
            Carta buff = _cartas[r];
            _cartas.Remove(buff);
            return buff;


            //Carta carta = _cartas[0]; // Se agarran las cartas del mazo de arriba
            //_cartas.RemoveAt(0); // se remueve la primera carta
            //return carta; //regresa la carta removida

        }

    }
}
