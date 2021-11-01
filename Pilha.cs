using System;
using System.Collections.Generic;

namespace pilhaq1
{
    class Pilha
    {
        List<int> id = new List<int>();
        Stack<int> p1 = new Stack<int>();
        Stack<int> p2 = new Stack<int>();
        Stack<int> p3 = new Stack<int>();
        Stack<int> p4 = new Stack<int>();
        bool pilhaVazia(Stack<int> p)
        {
            if (p.Peek() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        bool pilhaCheia(Stack<int> p)
        {
            if (p.Count > 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string ChecarQualEstaDisponivel(Stack<int> p1, Stack<int> p2, Stack<int> p3, Stack<int> p4)
        {
            int tam1 = p1.Count;
            int tam2 = p2.Count;
            int tam3 = p3.Count;
            int tam4 = p4.Count;


            if (tam1 < tam2)
            {
                if (tam1 < tam3)
                {
                    if (tam1 < tam4)
                    {
                        return "pilha1";
                    }
                    return "Pilha 4";
                }
                else if (tam2 < tam3)
                {
                    if (tam2 < tam4)
                    {
                        return "Pilha 2";
                    }
                    return "pilha 4";
                }
                else if (tam3 < tam4)
                {
                    return "pilha 3";
                }
                else
                {
                    return "pilha 4";
                }
            }
            else
            {
                return "pilha 2";
            }
        }

        public void InserirContainer()
        {
            Console.WriteLine("Inserir o código do container: ");
            int idContainer = Convert.ToInt16(Console.ReadLine());

            if (id.Contains(idContainer))
            {
                Console.WriteLine("Código Inválido");
            }
            else
            {
                id.Add(idContainer);
                Console.WriteLine("Código válido");
            }

            Console.WriteLine("Inserir container na pilha: ");
            Console.WriteLine(ChecarQualEstaDisponivel(p1, p2, p3, p4));

        }


    }
}