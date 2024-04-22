namespace Juegos
{
    public class PPT
    {
        int victoriasJ = 0;
        int victoriasCPU = 0;

        public int ganador(int movJ, int movCPU)
        {
            int ganador = 0;

            if ((movJ == 1 && movCPU == 3) || (movJ == 2 && movCPU == 1) || (movJ == 3 && movCPU == 2))
            {
                Console.WriteLine("¡¡Vence el Jugador!!");
                victoriasJ++;
            }
            else if ((movCPU == 1 && movJ == 3) || (movCPU == 2 && movJ == 1) || (movCPU == 3 && movJ == 2))
            {
                Console.WriteLine("¡¡Vence la CPU!!");
                victoriasCPU++;
            }
            else
            {
                Console.WriteLine("Empate");
            }

            Console.WriteLine("\nMarcador:");
            Console.WriteLine(" - J: " + victoriasJ + "\n - CPU: " + victoriasCPU + "\n");

            if (victoriasJ == 3)
            {
                ganador = 1;
            }
            else if (victoriasCPU == 3)
            {
                ganador = 2;
            }

            if (ganador == 1)
            {
                Console.WriteLine("FIN: JUGADOR GANA!!\n");
                Thread.Sleep(2000);
                Console.Clear();
            }
            else if (ganador == 2)
            {
                Console.WriteLine("FIN: CPU GANA!!\n");
                Thread.Sleep(2000);
                Console.Clear();
            }

            return ganador;
        }

        public void ronda(int movJ, int movCPU)
        {
            string movimientoJ = "";
            string movimientoCPU = "";


            switch (movJ)
            {
                case 1:
                    movimientoJ = "Piedra";
                    break;
                case 2:
                    movimientoJ = "Papel";
                    break;
                case 3:
                    movimientoJ = "Tijera";
                    break;
            }

            switch (movCPU)
            {
                case 1:
                    movimientoCPU = "Piedra";
                    break;
                case 2:
                    movimientoCPU = "Papel";
                    break;
                case 3:
                    movimientoCPU = "Tijera";
                    break;
            }

            Console.WriteLine("J: " + movimientoJ + "\nCPU: " + movimientoCPU);
        }

        public int turnoJugador()
        {
            int movJ;
            Console.WriteLine("1. Piedra\n2. Papel\n3. Tijera");
            Console.Write("Elige: ");
            movJ = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Clear();
            return movJ;
        }

        public int turnoCPU()
        {
            int movCPU;
            Random numAleatorio = new Random();
            movCPU = numAleatorio.Next(3) + 1;
            return movCPU;
        }

        static void Main()
        {
            PPT game = new PPT();
            int movJ;
            int movCPU;
            int seguir = 1;

            Console.WriteLine("Bienvenido al Piedra Papel Tijera!!");
            Console.WriteLine("Preisona 'enter' para comenzar\n");
            Console.ReadKey();

            do
            {
                Console.Clear();
                game.victoriasJ = 0;
                game.victoriasCPU = 0;
                do
                {
                    movJ = game.turnoJugador();
                    movCPU = game.turnoCPU();
                    game.ronda(movJ, movCPU);
                } while (game.ganador(movJ, movCPU) == 0);
                Console.Write("¿Deseas jugar de nuevo?\n1. SI\n2. NO\nElige: ");
                seguir = int.Parse(Console.ReadLine());
            } while (seguir == 1);
            Console.WriteLine("¡Vuelve pronto!");
        }

    }
}