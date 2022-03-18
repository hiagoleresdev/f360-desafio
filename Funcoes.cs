using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioF360
{
    public class Funcoes
    {

        public int verbos, verbosPrimeiraPessoa = 0;
        char[] alfabeto = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y' };
        char[] alfabetoKlingon = { 'k', 'b', 'w', 'r', 'q', 'd', 'n', 'f', 'x', 'j', 'm', 'l', 'v', 'h', 't', 'c', 'g', 'z', 'p', 's' };

        
        //MÉTODO PARA ACHAR PREPOSIÇÕES
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

        //MÉTODO PARA ACHAR OS VERBOS
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

        //MÉTODO PARA RETIRAR PALAVRAS REPETIDAS
        public string[] textoFinal()
        {
            var textoFinal = new StringBuilder("");
            using (StreamReader sr = new StreamReader(@"C:\Users\hiago.leres\source\repos\DesafioF360\textoB.txt"))
            {
                while (sr.Peek() >= 0)
                {

                    string line = sr.ReadLine();
                    string[] words = line.Split();

                    foreach (string word in words)
                    {
                        if (!textoFinal.ToString().Contains($" {word} "))
                        {
                            if (textoFinal.Length == 0)
                            {
                                textoFinal.Append(word);
                            }
                            else
                            {
                                textoFinal.Append(" ");
                                textoFinal.Append(word);
                            }
                        }
                    }

                }
              
                return textoFinal.ToString().Split(" ");
            }

            
        }

        //MÉTODO PARA ORDENAR NA ORDEM DO ALFABETO KLINDON

        /*
        public string TextoOrdenado()
        {
           
            var vocabulario = new Dictionary<string, string>();
            var textoOrdenado = new StringBuilder("");
            var ordemLetras = new StringBuilder("");


            using (StreamReader sr = new StreamReader(@"C:\Users\hiago.leres\source\repos\DesafioF360\textoB.txt"))
            {
                while (sr.Peek() >= 0)
                {

                    string line = sr.ReadLine();
                    string[] words = line.Split();
                    foreach (string word in words)
                    {

                        ordemLetras.Clear();
                        foreach (var letter in word)
                        {
                            ordemLetras.Append(alfabeto[Array.IndexOf(alfabetoKlingon, letter)]);
                        }
                        vocabulario.Add(word, ordemLetras.ToString());


                        var vocabularioOrdenado = vocabulario.OrderBy(x => x.Value);
                        foreach (var item in vocabularioOrdenado)
                        {
                            textoOrdenado.Append(item.Key + " ");
                        }
                        textoOrdenado.Remove(textoOrdenado.Length - 1, 1);
                    }
                    
                }
                return textoOrdenado.ToString();
            }


        }*/

        //Métodos para achar os números bonitos
        public int Numeros()
        {
            int qtdeNumeros = 0;
            using (StreamReader sr = new StreamReader(@"C:\Users\hiago.leres\source\repos\DesafioF360\textoB.txt"))
            {
                while (sr.Peek() >= 0)
                {
                    string line = sr.ReadLine();
                    string[] words = line.Split();

                    foreach (string word in words)
                    {
                        long numero = 0;
                        long peso = 1;
                        foreach (var letter in word)
                        {
                            numero += Array.IndexOf(alfabetoKlingon, letter) * peso;
                            peso *= 20;
                        }

                        if (numero >= 440566 && numero % 3 == 0)
                        {
                            qtdeNumeros++;
                        }
                    }

                }
                return qtdeNumeros;
            }
        }
    }
}
