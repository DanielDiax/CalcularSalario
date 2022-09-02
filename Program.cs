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
                float deducciones = 0;
                float exedente_horas = 0;
                float totalValorExtras = 0;
                bool extras = false;

                Console.Write("*****Calculadora de Salarios*****\n");
                Console.Write("**------------------------**\n");

                Console.WriteLine("Ingrese nombre del empleado: ");
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingrese apellido del empleado: ");
                string apellido = Console.ReadLine();

                Console.WriteLine("Ingrese documento del empleado: ");
                string documento = Console.ReadLine();

                Console.WriteLine("Ingrese el valor de la hora laborada por el empleado: \n");
                float valor_hora = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese horas trabajadas del empleado: \n");
                float horas_trabajadas = Convert.ToInt32(Console.ReadLine());

                if (horas_trabajadas > 40)
                {
                    Console.WriteLine("Ingrese el porcentaje del valor adicional que tiene la hora trabajada por el empleado: \n");
                    float porcentaje_hora_extra = Convert.ToInt32(Console.ReadLine());
                    exedente_horas = horas_trabajadas - 40;

                    float hora_adicional = (porcentaje_hora_extra /100) * valor_hora;
                    valor_extras = valor_hora + hora_adicional;
                    totalValorExtras = valor_extras * exedente_horas;
                    extras = true;
                }
                Console.WriteLine("¿El empleado tiene deducciónes? Presione S para si N para no \n");
                string validador_deducciones = Console.ReadLine();
                if (validador_deducciones == "S" || validador_deducciones == "s")
                {
                    Console.WriteLine("Ingrese las deducciónes del empleado del empleado: \n");
                    deducciones = Convert.ToInt32(Console.ReadLine());
                }

                if (extras == true) salario_base = valor_hora + totalValorExtras * horas_trabajadas;
                else salario_base = valor_hora * horas_trabajadas;

                if (deducciones > 0)
                {
                    salario_total = salario_base - deducciones;
                    Console.WriteLine("El empleado " + nombre + " " + apellido + " " + " identificado con documento:  " + documento + " tiene un salario básico de: \n"
                        + salario_base + " " + "un total de " + exedente_horas + " " +
                        "horas extras trabajadas, que representan un adicional de: " + 
                        totalValorExtras + " " + "unas deducciónes por valor de: "+ deducciones + " " + "Dando un salario total de: " + salario_total);
                }
                else
                {
                    salario_total = salario_base;
                    Console.WriteLine("El empleado " + nombre + " " + apellido + " " + " identificado con documento:  " + documento + " tiene un salario básico de:" + salario_base + " " + "un total de " + exedente_horas + " " +
                        "horas extras trabajadas, que representan un adicional de: " + totalValorExtras + " " + "Dando un salario total de: " + salario_total);
                }
                    





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
