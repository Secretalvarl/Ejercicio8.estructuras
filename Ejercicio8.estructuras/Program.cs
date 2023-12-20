namespace Ejercicio8.estructuras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] palabras = { "Hola", "Adiós", "Nuevo", "Viejo", "Vamos"};

            int control = Array.IndexOf(palabras, "Adiós");

            if (control != -1)
            {
                Console.WriteLine("La palabra Adiós esta situada en: " + control);
            }


            int[] numeros = { 1, 5, 7, 8, 4, 3, 9 };

            var seleccion = numeros.Where(mayor => mayor > 3);

            Console.WriteLine("Numeros mayores que 3:");

            foreach (int numeroSuperiores in seleccion) 
            {
                Console.WriteLine(numeroSuperiores);
            }
        }
    }
}