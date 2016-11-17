using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Exemplo_ExcecaoPropagacao
{
    static void Main(string[] args)
    {
        try
        {
            ExemploDivisao1(1, 0);
        }
        catch (Exception e)
        {
            Console.WriteLine("Exceção encontrada: " + e.GetType());
            throw;
        }

    }

    static double ExemploDivisao1(int vlr1, int vlr2)
    {
        return  vlr1 / vlr2;
    }
}
