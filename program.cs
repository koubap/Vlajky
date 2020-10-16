/*
 * Created by SharpDevelop.
 * User: petrkou
 * Date: 14.10.2020
 * Time: 16:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace vlajky
{
	class Program
	{
		private void czechFlag() {
			Console.WriteLine("\u2591\u2591\u2591\u2591");
			Console.WriteLine("\u2588\u2588\u2588\u2588");
			Console.WriteLine("\u2588\u2588\u2588\u2588");
		}

		private void germanFlag() {
			Console.WriteLine();	
			Console.WriteLine("\u2588\u2588\u2588\u2588");
			Console.WriteLine("\u2588\u2588\u2588\u2588");			
			Console.WriteLine("\u2592\u2592\u2592\u2592");
			Console.WriteLine("\u2592\u2592\u2592\u2592");
			Console.WriteLine("\u2591\u2591\u2591\u2591");
			Console.WriteLine("\u2591\u2591\u2591\u2591");
		}

		private void usFlag() {
			Console.WriteLine("******\u2591\u2591\u2591\u2591");
			Console.WriteLine("******\u2591\u2591\u2591\u2591");
			Console.WriteLine("\u2591\u2591\u2591\u2591\u2591\u2591\u2591\u2591\u2591\u2591\u2591\u2591\u2591\u2591\u2591\u2591");
		}

		public void run() {
			Console.WriteLine(">>>VLAJKY<<<");			
			Console.WriteLine("1 - CZ");
			Console.WriteLine("2 - DE");
			Console.WriteLine("3 - US");			                  								
			Console.Write("Volba:");
			ConsoleKeyInfo cki = Console.ReadKey(true);
			switch (cki.Key) {
				case ConsoleKey.D1:	
					czechFlag();				
					break;
				case ConsoleKey.D2:
					germanFlag();
					break;
				case ConsoleKey.D3:	
					usFlag();	
					break;
				default:
					Console.WriteLine("Volba " + cki.Key + " neni podporovana!");
					break;
			}
		}

		public static void Main(string[] args) {		
			new Program().run();
			
			
		}
	}
}
