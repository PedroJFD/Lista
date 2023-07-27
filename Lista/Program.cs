using System;

class Lista
{
    static void Main(string[] args)
    {
        List<string> lista1 = new List<string>();
        lista1.Add("a"); //add coisa lista
        lista1.Add("b");
        lista1.Add("c");

        Console.WriteLine(lista1[2]); //imprime

        Console.WriteLine(lista1.Count); //conta tamanho lista

        foreach(string s in lista1) //percorre lsita
        {
            Console.WriteLine(s);
        }
    }
}