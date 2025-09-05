using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Set_Dictionary
{
    internal class PrintService
    {
        private int[] _values = new int[10]; // Vetor de inteiros com tamanho 10
        private int _count = 0; // conta quantos elementos foram adicionados

        public void AddValue(int value)
        {
            if (_count == 10) // Verifica se o vetor está cheio
            {
                throw new InvalidOperationException("PrintService is full");
            }

            _values[_count] = value; // Adiciona o valor no vetor
            _count++; // Incrementa o contador
        }

        public int First()
        {
            if (_count == 0) // Verifica se o vetor está cheio
            {
                throw new InvalidOperationException("PrintService is empty");
            }

            return _values[0];
        }

        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < _count; i++) // Imprime até a penultima posição do vetor
            {
                Console.Write(_values[i] + ", " );
            }
            if (_count > 0)
            {
                Console.Write(_values[_count - 1]); // Imprime o último elemento sem a vírgula
            }
            Console.WriteLine("]");
        }
    }
}
