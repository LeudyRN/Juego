class BattleShip
{
    static void Main(string[] args)
    {
        // Crea un tablero de 10x10
        char[,] board = new char[10, 10];

        // Llena el tablero con agua ('~')
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                board[i, j] = '~';
            }
        }

        // Coloca un barco en una posición aleatoria en el tablero
        Random rand = new Random();
        int x = rand.Next(0, 10);
        int y = rand.Next(0, 10);
        board[x, y] = 'B';

        // Juega el juego
while (true)
{
    // Muestra el tablero
    for (int i = 0; i < 10; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            Console.Write(board[i, j] + " ");
        }
        Console.WriteLine();
    }

    // Pide al usuario una posición para lanzar una bomba
    Console.WriteLine("Ingresa la posición para lanzar la bomba (ejemplo: A 5):");
    try
    {
        string input = Console.ReadLine();
        int bombX = input[0] - 'A';
        int bombY = int.Parse(input.Substring(2)) - 1;

        // Revisa si el usuario acertó el barco
        if (board[bombX, bombY] == 'B'){
            Console.WriteLine("¡Hundiste mi barco!");
            break;
        }else{
            Console.WriteLine("Agua...");
        }
         
    }catch (Exception e){
        Console.WriteLine("Entrada inválida. Por favor, ingresa una entrada válida");
    }
    
    }

  }

}