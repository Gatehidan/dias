namespace ejercicio
{
    public class Program
    {
        public static void Main()
        {
            int dia = 0;
            int mes = 0;
            int anyo = 0;

            Console.WriteLine("ingrese el año");
            anyo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el mes");
            mes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el dia");
            dia = Convert.ToInt32(Console.ReadLine());

            if (anyo % 4 != 0)
            {
                if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
                {
                    if (dia > 31)
                    {
                        Console.WriteLine("el dia es incorrecto");
                    }
                }
                else if (mes == 2)
                {
                    if (dia >= 28)
                    {
                        Console.WriteLine("dia incorecto");

                    }

                }
                else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
                {
                    if (dia > 30)
                    {
                        Console.WriteLine("dia incorrecto");
                    }
                }






                else
                if (mes == 2)
                {
                    if (dia >= 29)
                    {
                        Console.WriteLine("dia incorrecto");

                    }
                    else if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
                    {
                        if (dia > 31)
                        {
                            Console.WriteLine("dia incorrecto ");
                        }
                    }
                    else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
                    {
                        if (dia > 30)
                        {
                            Console.WriteLine("dia incorrecto");
                        }
                    }
                }
            }
            DateTime mifecha = new DateTime(anyo, mes, dia);
            mifecha = mifecha.AddDays(1);
            Console.WriteLine(mifecha);

        }
    }
}
