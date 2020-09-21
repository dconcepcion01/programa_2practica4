using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_2practica4
{
    public class Estudiante
    {
        private int matricula;
        private string nombre;
        private string apellido;
        public  double nota1 =0;
        public  double  nota2 =0;
        public double nota3 =0;
        private double promedio =0;


        public void resultado()
        {

            Console.SetCursorPosition(5, 7);
            Console.WriteLine("ESTE PROGRAMA TE CALCULA EL PROMEDIO DEL ESTUDIANTE");

            Console.SetCursorPosition(5, 8);
            Console.WriteLine("Digite la nota 1__  " + nota1);
            nota1 = Double.Parse  (Console.ReadLine());

            Console.SetCursorPosition(5, 9);
            Console.WriteLine("Digite la nota 2__  " + nota2);
            nota2 = Double.Parse(Console.ReadLine());

            Console.SetCursorPosition(5, 10);
            Console.WriteLine("digite la nota 3___ " + nota3);
            nota3 = Double.Parse(Console.ReadLine());

            promedio = (nota1 + nota2 + nota3) / 3;

            Console.SetCursorPosition(5, 12);
            Console.WriteLine("El promedio del estudiante es: " + promedio);

            if (promedio > 100)
            {
                Console.SetCursorPosition(5, 15);
                Console.WriteLine("Promedio Invalido la Nota maxima es 100");
            }
             else 
            {
                Console.SetCursorPosition(5, 13);
                Console.WriteLine("FELICIDADES PROMEDIO APROBADO");
            }


            Console.ReadLine();

        }

    }
    
    
}
