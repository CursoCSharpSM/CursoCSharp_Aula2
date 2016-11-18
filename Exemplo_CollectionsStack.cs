using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Exemplo_CollectionsStack
{
    static void ImprimirQueue(Stack<int> collectionS)
    {
        Console.WriteLine();
        //Para imprimir o conteúdo de um Stack
        foreach (int item in collectionS)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        //Forma de implementação de uma pilha ==> "LIFO"
        //Declaração e instanciação de um objeto Stack que poderá conter inteiros
        Stack<int> collectionStack = new Stack<int>();

        //Adição de itens na coleção
        collectionStack.Push(1);
        collectionStack.Push(2);
        collectionStack.Push(3);
        collectionStack.Push(4);
        collectionStack.Push(5);
        collectionStack.Push(6);

        //Para verificar a quantidade de itens do Collection
        Console.WriteLine("O Stack possui " + collectionStack.Count + " itens");

        Console.WriteLine();

        //Chamando a função para imprimir o Stack
        Console.WriteLine("Stack original");
        ImprimirQueue(collectionStack);

        //Como obter o item no topo da lista
        int strTopoDaPilha = collectionStack.Peek();
        Console.WriteLine("O último item da pilha: " + strTopoDaPilha);

        //Para remover o elemento do topo do Stack
        collectionStack.Pop();

        Console.WriteLine();

        //Chamando a função para imprimir o Stack
        Console.WriteLine("Stack com '" + strTopoDaPilha + "' removido");
        ImprimirQueue(collectionStack);

        //Como remover todos os items do Stack
        collectionStack.Clear();

        Console.WriteLine();
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
    }
}