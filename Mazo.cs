using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGame
{
    internal class Mazo
    {
        private List<Carta> _cartas;
        private Random _random;

        public Mazo()
        {
            _cartas = new List<Carta>(); // Lista de cartas
            _random = new Random(); // Generador de numeros aleatorios
            string[] palos = { "Espada", "Basto", "Oro", "Copa" }; // Palos de las cartas
            string[] caras = { "As", "2", "3", "4", "5", "6", "7", "10", "Jota", "Reina", "Rey" };// Caras de las cartas
            int[] valores = { 1, 2, 3, 4, 5, 6, 7, 10, 10, 10, 10 }; // Valores de las cartas
            for (int i = 0; i < palos.Length; i++) // Se crean las cartas
            {
                for (int j = 0; j < caras.Length; j++) 
                {
                    _cartas.Add(new Carta(palos[i],  caras[j], valores[j])); // Se agregan las cartas a la lista
                }
            }
        }

        public Carta SacarCarta() // Se saca una carta del mazo
        {
            int index = _random.Next(_cartas.Count);
            Carta carta = _cartas[index];
            _cartas.RemoveAt(index);
            return carta;
        }

        public void Barajar() // Se baraja el mazo
        {
            _cartas = _cartas.OrderBy(x => _random.Next()).ToList();
        }

        public int sumar() // Se suman los valores de las cartas
        {
            int suma = 0;
            foreach (Carta carta in _cartas)
            {
                suma += carta.Valor;
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
            {
                Carta carta = _cartas[0]; // Se agarran las cartas del mazo de arriba
                _cartas.RemoveAt(0); // se remueve la primera carta
                return carta; //regresa la carta removida
            }
        }

    }
}
