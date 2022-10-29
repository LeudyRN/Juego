    //Leudy Randy Nolasco
    //Proyecto Propio
    
    class juego
    {
        
        public static void Main(){
         
         Random rnd = new Random();

         int maquina = rnd.Next(1, 3);
         int jugador = 0;
         int computador = 0;

         Console.WriteLine(" *** Bienvenido ***");
         Console.WriteLine(" **** Al juego Legendario de Piedras, Papel y Tijeras ***");

         Console.WriteLine(@"
         
           *** Seleccione su habilidad con cual atacara a la maquina ***
         
            1. Piedra.
            2. Papel.
            3. Tijeras.

         ");

         Console.WriteLine("Ingrese su Habilidad de ataque: ");
         int ataque = Int32.Parse(Console.ReadLine());

         Console.WriteLine("La maquina Ataco! " + maquina);

         switch (ataque){

            case 1:
            if (ataque == maquina){
                jugador = jugador + 0;
                computador = computador + 0;
                Console.WriteLine("No puedo creer que he quedado empate con un ser inferior ");

            }
            else if (ataque > maquina){
                jugador = jugador + 1;
                Console.WriteLine("COMO!!!!! Como pude perder con un humano");
                Console.WriteLine("Con movimientos tan predecibles!!");
                Console.WriteLine("Los dioses te protejen!");

            }
            else{
                computador = computador + 1;
                Console.WriteLine("Perdiste humano, no entiendo porque te esfuerzas ");
                Console.WriteLine("Tu perdida era clara ");
          
              }

              Console.ReadKey();

            break;

            case 2:
                if(ataque==maquina)
					{
						jugador=jugador + 0;
						computador= computador+ 0 ;
						Console.WriteLine("No puedo creer que he quedado empate con un ser inferior");
					}
				   else if (ataque>maquina)			
					{
						jugador= jugador + 1;
                        Console.WriteLine("COMO!!!!! Como pude perder con un humano");
                        Console.WriteLine("Con movimientos tan predecibles!!");
                        Console.WriteLine("Los dioses te protejen!");
					}
					else 
					{
						computador= computador+ 1;
                        Console.WriteLine("Perdiste humano, no entiendo porque te esfuerzas ");
                        Console.WriteLine("Tu perdida era clara ");
					}

					Console.ReadKey();

				break;
				   case 3: 
					if(ataque==maquina)
					{
						jugador=jugador + 0;
						computador= computador+ 0 ;
						Console.WriteLine("No puedo creer que he quedado empate con un ser inferior");
					}else if (ataque>maquina)
					{
						jugador= jugador + 1;
                        Console.WriteLine("COMO!!!!! Como pude perder con un humano");
                        Console.WriteLine("Con movimientos tan predecibles!!");
                        Console.WriteLine("Los dioses te protejen!");
					}
					else 
					{
						computador= computador+ 1;
                        Console.WriteLine("Perdiste humano, no entiendo porque te esfuerzas ");
                        Console.WriteLine("Tu perdida era clara ");
					}

					Console.ReadKey();
                    
				break;
			
         }
        }
    }