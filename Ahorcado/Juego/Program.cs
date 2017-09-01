using System;
using System.Collections;

namespace Juego
{
	class Program
	{
		public static void NuevaPalabra(ArrayList ListaPal, int posFinal)
		{
			string nueva= Console.ReadLine();
			ListaPal.Add(nueva);
			posFinal+=1;		
		}
		
		
		public static void Jugar(int posFinal, ArrayList ListaPal, bool fin, int vida)
			{
				Random rdm= new Random();
				while(fin != true | vida != 0)
				{
					//bool termino= false;
					int posicion= rdm.Next(0,posFinal);
					string palabra= Convert.ToString(ListaPal[posicion]);
					int longitud= palabra.Length;
					string[] mostrar = new string[longitud];
					
					for(int i=0; i< longitud; i++)
					{
						mostrar[i]= "_";
						Console.Write(mostrar[i] + " ");
					}
					int acierto=0;
					Console.WriteLine("\nIngrese la letra: ");
					string letra= Console.ReadLine();
					while(vida!=0 | acierto != longitud)
					{
						Console.WriteLine("Paso por el for y entra devuelta\n");
					for(int i=0; i!= longitud; i++)
					{
								
						if(Convert.ToChar(letra) == palabra[i])
						{
							mostrar[i]=letra.ToUpper();
							Console.Write(mostrar[i] + " ");
							acierto= acierto + 1;
									
						}
						else
						{
							Console.Write(mostrar[i] + " ");
							vida -= 1;
									
						}
						
					}
					letra= Console.ReadLine();
					}
					
					ListaPal.RemoveAt(posicion);
					
				}
			}
		public static void Main(string[] args)
		{
			
			ArrayList ListaPal= new ArrayList();
			ListaPal.Add("electroencefalografista");
			ListaPal.Add("pajaro");
			ListaPal.Add("elefante");
			ListaPal.Add("bicicleta");
			ListaPal.Add("lagarto");
			ListaPal.Add("poligono");
			ListaPal.Add("pentagrama");
			ListaPal.Add("computadora");
			ListaPal.Add("python");
			ListaPal.Add("galicia");
			ListaPal.Add("electroestatica");
			ListaPal.Add("silla");
			ListaPal.Add("caja");
			ListaPal.Add("salero");
			ListaPal.Add("monitor");
			
			
			int posFinal= 14;
			bool fin= false;
			int vida= 6;
			
			int opcion;
			Console.WriteLine("*****************************************");
			Console.WriteLine("           BIENVENIDO AL JUEGO           ");
			Console.WriteLine("               AHORCADO                  ");
			Console.WriteLine("*****************************************");
			Console.WriteLine("");
			Console.WriteLine("1) Jugar ");
			Console.WriteLine("2) Ingresar nueva palabra ");
			Console.WriteLine("3) Salir");
			Console.WriteLine("A continuación ingrese la opcion que desee realizar: ");
			opcion= Convert.ToInt32(Console.ReadLine());
				
			switch (opcion)
			{
				case 1:
					Jugar(posFinal, ListaPal, fin, vida);
					break;
					
				case 2:
					NuevaPalabra(ListaPal, posFinal);
					break;
				
				case 3:
					break;
					
				default:
					Console.WriteLine("Ingrese nuevamente la opción: ");
					opcion = Convert.ToInt32(Console.ReadLine());
					break;
					
			//Ya tenemos la lista y el random, falta armar la logica
			
			
			
			
			//Console.ReadKey(true);
		}
	}
	}}