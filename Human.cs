/*
    Exercício proposto pela plataforma CodeWars
    De acordo com os mitos de criação das religiões abraâmicas, Adão e Eva foram os primeiros 
    humanos a vagar pela Terra.

    Você tem que fazer o trabalho de Deus. O método de criação deve retornar um array de comprimento 
    2 contendo objetos (representando Adão e Eva). O primeiro objeto do array deve ser uma instância 
    da classe Man. O segundo deve ser uma instância da classe Woman. Ambos os objetos devem ser
    subclasses de Human. Seu trabalho é implementar as classes Human, Man and Woman.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsExercises
{
    public class Human
    {

        public string Name { get; set; }
        public int Idade { get; set; }

        public Human[] Create()
        {
            Woman Eva = new Woman();
            Man Adao = new Man();

            Human[] result = new Human[] { Adao, Eva };

            // for (int i = 0; i < result.Length; i++)
            // {
            //    Console.WriteLine(result[i].Name);
            // }

            return result;
        }
    }

    public class Woman : Human
    {
        public Woman() 
        {
            this.Name = "Eva";
        }
    }

    public class Man : Human
    {
        public Man()
        {
            this.Name = "Adão";
        }
    }
}
