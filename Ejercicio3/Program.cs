using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3 
{
    class Password
    {

        int longitud;
        public int LONGITUD { get { return longitud; } set { this.longitud = value; } }
        string contraseña;
        public string CONTRASEÑA { get { return contraseña; } set { this.contraseña = value; } }

        public Password(int LONGITUD) 
        {
            var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

            var random = new Random();

            var arrayChar = new char[longitud];
            for (int i = 0; i < longitud; i++)
            {
                arrayChar[i] = characters[random.Next(characters.Length)];


            }
            var resultString = new String(arrayChar);
            this.CONTRASEÑA = resultString;
            Console.WriteLine(CONTRASEÑA);
        }

        public void Contra() 
        {
            var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

            var random = new Random();

            var arrayChar = new char[longitud];
            for (int i = 0; i < longitud; i++)
            {
                arrayChar[i] = characters[random.Next(characters.Length)];


            }
            var resultString = new String(arrayChar);
            this.CONTRASEÑA = resultString;
            Console.WriteLine("La contraseña es: " + this.CONTRASEÑA);

        }


        public void esFuerte()
        {
            int cuentanumeros = 0;
            int cuentaminusculas = 0;
            int cuentamayusculas = 0;
            
            for (int i = 0; i < this.CONTRASEÑA.Length; i++)
            {
                if (contraseña[i] >= 97 && contraseña[i] <= 122)
                {
                    cuentaminusculas += 1;
                }
                else
                {
                    if (contraseña[i] >= 65 && contraseña[i] <= 90)
                    {
                        cuentamayusculas += 1;
                    }
                    else
                    {
                        cuentanumeros += 1;
                    }
                }
            }
            
            if (cuentanumeros >= 5 && cuentaminusculas >= 1 && cuentamayusculas >= 2)
            {

                Console.WriteLine("es fuerte");
            }
            else
            {

                Console.WriteLine("es debil");
            }
        }


        public Password()
        {

        }


        internal class Program
        {
            static void Main(string[] args)
            {

                Password password = new Password();
                Console.Write("Introduce longitud: ");
                password.LONGITUD = (int.Parse(Console.ReadLine()));

                password.Contra();
                password.esFuerte();

                // password.esFuerte();



                Console.ReadKey();

            }
        }
    }
}

