using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGame
{
    internal class Carta
    {
        private string _palo;
        private string _cara;
        private int _valor;

        public Carta(string palo,  string cara, int valor)
        {
            this._palo = palo;       // Espada, Basto, Oro, Copa
            this._valor = valor;     // As, 2, 3, 4, 5, 6, 7, 10, Jota, Reina, Rey
            this._cara = cara;       // 1, 2, 3, 4, 5, 6, 7, 10, 10, 10, 10
        }
       

        public string Palo
        {
            get { return _palo; }
            set {this._palo = value; }
        }

        public int Valor
        {
            get { return _valor; }
            set {this._valor = value; }
            
        }
        public string Cara
        {
            get { return _cara; }
            set {this._cara = value; }
        }
        public string getCara(){
            return _cara;
        }
        public string getPalo()
        {
            return _palo;
        }
        public int getValor()
        {
            return _valor;
        }
        public int setA() // Si la carta es un As, se le asigna el valor de 1
        {
            if (this._cara == "As")
            {
                this.Cara = "As(1)";
                this._valor = 1;
                return 1;
            }
            return 0;
        }
        public override string ToString()
        {
            return _valor + " de " + _palo;
        }
    }
}
