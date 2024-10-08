using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerProgramacion.Tiendavideojuegos
{
    public class InventarioVideojuegos
    {
        public static Videojuego[] videojuegos = new Videojuego[10];
        public static int pos = 0;

        public static void AgregarVideojuego()
        {
            videojuegos[0] = new Videojuego(1, "The Legend of Zelda: Ocarina of Time", "Shigeru Miyamoto", false);
            videojuegos[1] = new Videojuego(2, "Super Mario Galaxy", " Yoshiaki Koizumi ", true);
            videojuegos[2] = new Videojuego(3, "The Legend of Zelda: Breath of the Wild", "Hidemaro Fujibayashi", true);
            videojuegos[3] = new Videojuego(4, "Halo 2", "Bungie Studios",false);
            pos = 4;
        }
        public static bool vacio()
        {
            if (pos == 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public static bool lleno()
        {
            if (pos == 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string agregarVideojuego(Videojuego objv)
        {
            if (!lleno())
            {
               videojuegos[pos] = objv;
                pos++;
                return "Producto agregado correctamente";
            }
            else
            {
                return "No hay espacio para mas productos";
            }

        }

        public static Videojuego Mostrar(int cod)
        {
            for (int i = 0; i < pos; i++)
            {
                if (cod == videojuegos[i].Codigo)
                {
                    return videojuegos[i];
                }
            }

            return null;

        }

        public static Videojuego[] MostrarInventario()
        {
            return videojuegos;
        }

        public static int Cantidad()
        {
            return pos;
        }
    }
}
