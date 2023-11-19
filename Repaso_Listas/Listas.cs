using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_Listas
{
    public class Listas
    {
        Nodo primero;
        Nodo ultimo;

        public bool ListaVacia()
        {
            if (primero == null)
            {
                return true;
            }
            return false;

        }
       public int LongitudLista()
        {
            int contador = 0;
            if(primero == null)
            {
                return contador;
            }
            else
            {
                if(primero != null && primero.getSiguiente != null)
                {
                    return (contador + 1);
                }
                else
                {

                }
            }
        }
     }
}
