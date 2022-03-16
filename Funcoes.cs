using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioF360
{
    public class Funcoes
    {

        string[] letrasFoo = { "s","l","f","w","k"};
        string[] letrasBar = { "a","b","c","e","g","h","i","j","m","n","o","p","q","r","t","u","v","x","y","z"};

       
        char[] ordemAlfabetica = {'k','b','w','r','q','d','n','f','x','j','m','l','v','h','t','c','g','z','p','s'};

        
        public int verbos, verbosPrimeiraPessoa=0;


        public int acharPreposicao()
        {
            int palavras = 0;
            using (StreamReader sr = new StreamReader(@"C:\Users\hiago.leres\source\repos\DesafioF360\textoB.txt"))
            {
                while (sr.Peek() >= 0)
                {
                  
                    string line = sr.ReadLine();
                    string[] words = line.Split();
                    foreach (string word in words)
                    {
                       if(word.Length == 3)
                        {
                           if( word[2] != 's' && word[2] != 'l' && word[2] != 'f' &&
                               word[2] != 'w' && word[2] != 'k' &&  word[0] != 'd' && word[1] != 'd' && word[2] != 'd')
                            {
                                palavras++;
                            }
                        }
                       
                    }
                   
                }
                return palavras;
            }
        }

        public int acharVerbos()
        {

            using (StreamReader sr = new StreamReader(@"C:\Users\hiago.leres\source\repos\DesafioF360\textoB.txt"))
            {
                while (sr.Peek() >= 0)
                {

                    string line = sr.ReadLine();
                    string[] words = line.Split();
                    foreach (string word in words)
                    {
                        if (word.Length >= 8)
                        {
                            //Verifica verbos
                            if (word[7].Equals('s') || word[7].Equals('l') || word[7].Equals('f') || word[7].Equals('w') || word[7].Equals('k'))
                            {
                                //Console.WriteLine(word);
                                this.verbos++;

                            }
                            //Verifica verbos maiusculos
                            if (word.Length >= 8 && word[0] != 's' && word[0] != 'l' && word[0] != 'f' && word[0] != 'w' && word[0] != 'k' && (
                                word[7].Equals('s') || word[7].Equals('l') || word[7].Equals('f') || word[7].Equals('w') || word[7].Equals('k')))
                            {

                                this.verbosPrimeiraPessoa++;
                            }
                        }

                    }

                }
                return 0;
            }
           
        }

    }
}
