using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    public class Pilha
    {
        private Stack<string> stack;

        public Pilha()
        {
            stack = new Stack<string>();
        }
        public void Empilhar(string peca)
        {
            stack.Push(peca);
        }
        public string Desempilhar()
        {
            return stack.Pop();
        }
        public void SubstituirPeca(string velhaPeca, string novaPeca)
        {
            Stack<string> tempStack = new Stack<string>();
            bool temp = false;
            while (stack.Count > 0)
            {
                string pecaAtual = stack.Peek();
                if (pecaAtual.Equals(velhaPeca, StringComparison.OrdinalIgnoreCase))
                {
                    stack.Pop(); 
                    stack.Push(novaPeca); 
                    temp = true;
                    break;
                }
                else
                {
                    tempStack.Push(stack.Pop()); 
                }
            }

            if (!temp)
            {
                Console.WriteLine("Peça não encontrada na pilha.");
            }

            while (tempStack.Count > 0)
            {
                stack.Push(tempStack.Pop());
            }
        }

        public void ImprimirPilha()
        {
            Console.WriteLine("Estado atual da pilha:");
            foreach (string peca in stack)
            {
                Console.WriteLine(peca);
            }
        }
    }


}
