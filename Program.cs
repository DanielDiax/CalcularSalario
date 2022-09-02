using System;

namespace CalcularSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                float salario_base = 0;
                float salario_total = 0;
                float valor_extras = 0;
                bool extras = false;

                //Console.WriteLine("Ingrese nombre del empleado: ");
                //string nombre = Console.ReadLine();

                //Console.WriteLine("Ingrese apellido del empleado: ");
                //string apellido = Console.ReadLine();

                //Console.WriteLine("Ingrese documento del empleado: ");
                //string documento = Console.ReadLine();

                Console.WriteLine("Ingrese edad del empleado: ");
                int edad = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el valor de la hora laborada por el empleado: ");
                float valor_hora = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese horas trabajadas del empleado del empleado: ");
                float horas_trabajadas = Convert.ToInt32(Console.ReadLine());

                if (horas_trabajadas > 40)
                {
                    Console.WriteLine("Ingrese el porcentaje del valor adicional que tiene la hora trabajada por el empleado: ");
                    float porcentaje_hora_extra = Convert.ToInt32(Console.ReadLine());
                    float exedente_horas = horas_trabajadas - 40;

                    float hora_adicional = (porcentaje_hora_extra /100) * valor_hora;
                    valor_extras = valor_hora + hora_adicional;
                    extras = true;
                }
                Console.WriteLine("Ingrese las deducciónes del empleado del empleado si las tiene: ");
                int deducciones = Convert.ToInt32(Console.ReadLine());

                if (extras == true) 
                {
                    salario_base = valor_hora + valor_extras * horas_trabajadas;
                } 

                else salario_base = valor_hora * horas_trabajadas;







                Console.Write("\tPresione cualquier tecla para cerrar la consola...");
                Console.ReadKey();
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
