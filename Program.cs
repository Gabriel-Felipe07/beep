namespace beep;

class Program
{
    static void Main(string[] args)
    {
        int contador = 0;
        Random random = new Random();
        int numeroBeeps;
        List<int> jaFoi = new List<int>();
        string jogarNovamente = "s";
        int rodadasParaVencer = 5;


        while(jogarNovamente != "n" || rodadasParaVencer != 0){
            int[] listaNumeros = {1, 2, 3, 4, 5};
            Console.WriteLine("Preste atenção no som!!");
        
            int indiceAleatorio = random.Next(listaNumeros.Length);
            int numeroAleatorio = listaNumeros[indiceAleatorio];
            jaFoi.Add(numeroAleatorio);
            Console.WriteLine(numeroAleatorio);

            while(contador < numeroAleatorio){
                Console.Beep(3000,600);
                Thread.Sleep(250);
                contador++;
            }
            Console.WriteLine("DIGITE QUANTOS BEEPS OUVIU: ");
        
            numeroBeeps = Convert.ToInt32(Console.ReadLine());
            if(numeroBeeps == numeroAleatorio){
                Console.WriteLine("PARABÉNS, VOCÊ ACERTOU!!!\n\r");
            }else {
                Console.WriteLine("PERDEU, VOCÊ ERROU!!!\n\r");
            }

            rodadasParaVencer--;

            if(rodadasParaVencer == 0){
                Console.WriteLine("Deseja Jogar novamente? (s/n)");
                Console.WriteLine(string.Join(",", jaFoi));
                jogarNovamente = Console.ReadLine()!;
            }
        }
        
        
    }
}
