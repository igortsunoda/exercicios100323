namespace Exercicio3
{
    public class Exercicio3
    {
        public static void Main()
        {
            //Criando Lista
            List<string> listaFrutas = new List<string>();
            string entrada;
            Console.WriteLine("Entre com a lista conforme manual");

            //Exemplo entrada: "banana; maça; laranja"
            entrada = Console.ReadLine();

            //Pega Array de palavras separados por ";"
            string[] strArray = entrada.Split(';');

            //Para cada palavra no array
            foreach (string str in strArray)
            {
                //Faz uma copia da string em Lower Case
                string fruta = str.ToLower();

                //Copia a primeira letra da strinf em UpperCase
                string primeiraLetra = fruta.Substring(0, 1).ToUpper();

                //fruta recebe PrimeiraLetra maiuscula e restante minuscula
                fruta = primeiraLetra + fruta.Substring(1, fruta.Length - 1);

                //se a fruta ainda não existir na lista, adiciona
                if (!listaFrutas.Contains(str))
                    listaFrutas.Add(str);

            }
            Console.WriteLine("Resposta: " + Environment.NewLine);
            //Exibir lista de frutas
            foreach (string fruta in listaFrutas)
                Console.WriteLine(fruta);
        }

    }
}