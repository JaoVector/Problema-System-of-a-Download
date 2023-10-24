class Program
{
    static void Main(string[] args) { 

        var songs = new Dictionary<int, string>
        {
           {0, "PROXYCITY"}, {1, "P.Y.N.G."}, {2, "DNSUEY!"}, {3, "SERVERS"}, {4, "HOST!"},
           {5, "CRIPTONIZE"}, {6, "OFFLINE DAY"}, {7, "SALT"}, {8, "ANSWER!"}, {9, "RAR?"},
           {10, "WIFI ANTENNAS"}
        };

        Console.Write("Quantidade de Casos: ");
        int C = Convert.ToInt32(Console.ReadLine());
        
        string[,] testes = new string[C,2];
        int[] sum = new int[C];

        for(int i = 0; i < C; i++)
        {
            for(int j = 0; j < 2; j++)
            {
                if(j == 0)
                {
                    Console.Write("X: ");
                    var x = Console.ReadLine();
                    testes[i,j] = x;
                } else 
                {
                    Console.Write("Y: ");
                    var y = Console.ReadLine();
                    testes[i,j] = y;
                }
            }
            
        }

        Console.WriteLine("====================");

        for(int i = 0; i < C; i++)
        {   
            int soma = 0;
            for(int j = 0; j < 2; j++)
            {
               if(testes[i,j] == "")
                  testes[i,j] = "0";
               soma += Convert.ToInt32(testes[i,j]);
               sum[i] = soma;
            }
        }
        
        for(int i = 0; i < C; i++)
        {
            Console.WriteLine($"Musica: {songs[sum[i]]}");
        }
    }

}