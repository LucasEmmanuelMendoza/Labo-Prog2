using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace POOEJ05
{
    internal class Rectangulo
    {
        private float area;
        private float perimetro;

        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public Rectangulo (Punto vertice1, Punto vertice3)
        {
            vertice2 = new Punto(vertice3.GetX(), vertice1.GetY()); 
            vertice4 = new Punto(vertice1.GetX(), vertice3.GetY()); 
        }
        public float Area()
        {
            float retorno;
            double lado1;
            double lado2;
            double aux1;
            double aux2;
            double aux3;
            double aux4;

            aux1 = Math.Pow(vertice1.GetX() - vertice2.GetX(), 2);
            aux2 = Math.Pow(vertice1.GetY() - vertice2.GetY(), 2);
            lado1 = Math.Sqrt(aux1 + aux2);

            aux3 = Math.Pow(vertice1.GetX() - vertice4.GetX(), 2);
            aux4 = Math.Pow(vertice1.GetX() - vertice4.GetX(), 2);
            lado2 = Math.Sqrt(aux2 + aux4);
            //ToSingle(Object, IFormatProvider)
            //Convert.ToSingle();
            retorno = Convert.ToSingle(lado1 * lado2);

            return retorno;
        }
        public float Perimetro()
        {
            float retorno;
            double suma;
            double lado1;
            double lado2;
            double lado3;
            double lado4;
            double aux1;
            double aux2;
            double aux3;
            double aux4;
            double aux5;
            double aux6;
            double aux7;
            double aux8;

            aux1 = Math.Pow(vertice1.GetX() - vertice2.GetX(), 2);
            aux2 = Math.Pow(vertice1.GetY() - vertice2.GetY(), 2);
            lado1 = Math.Sqrt(aux1 + aux2);

            aux3 = Math.Pow(vertice1.GetX() - vertice4.GetX(), 2);
            aux4 = Math.Pow(vertice1.GetX() - vertice4.GetX(), 2);
            lado2 = Math.Sqrt(aux2 + aux4);

            //2y3

            aux5 = Math.Pow(vertice2.GetX()-vertice3.GetX(), 2);
            aux6 = Math.Pow(vertice2.GetY()-vertice3.GetY(), 2);
            lado3 = Math.Sqrt(aux5 + aux6);

            //3y4

            aux7 = Math.Pow(vertice3.GetX() - vertice4.GetX(), 2);
            aux8 = Math.Pow(vertice3.GetY() - vertice4.GetY(), 2);
            lado4 = Math.Sqrt(aux7 + aux8);

            suma = lado1 + lado2 + lado3 + lado4;

            retorno = Convert.ToSingle(suma);

            return retorno;
        }
    }
}
