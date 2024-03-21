/*
    Exercício proposto pela plataforma CodeWars
    Descrição: Jack gosta muito do seu número cinco: o truque aqui é que você tem que multiplicar
    cada número por 5 elevado ao número de dígitos de cada número, então, por exemplo:

      3 -->    15  (  3 * 5¹)
     10 -->   250  ( 10 * 5²)
    200 --> 25000  (200 * 5³)
      0 -->     0  (  0 * 5¹)
     -3 -->   -15  ( -3 * 5¹)
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsExercises
{
    public class MultiplyNumber
    {
        public static int Multiply(int number)
        {
            int digitos = number.ToString().Length;

            if (number < 0)
            {
                digitos = --digitos;
            }

            double pow = Math.Pow(5, digitos);

            double result = number * pow;

            Console.WriteLine(pow);

            return Convert.ToInt32(result);
        }

    }
}
