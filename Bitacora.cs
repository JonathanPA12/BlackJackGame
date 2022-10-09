using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace BlackJackGame
{
     class Bitacora

    {
        int jugador = 0;
        int dealer = 0;
      public void RegistroDejuego(cartaController inicio)
        {
            TextWriter registro = new StreamWriter("Registro.txt",true);
            if (inicio.CheckPerdidas(Globals.MyHand) == true)
            {
                registro.WriteLine("Jugador ha Perdido " + dealer++);


            }
            else
            {
                registro.WriteLine("Jugador ha ganado " + jugador++);
              
            }
            registro.Close();

        }
    
    }
}
