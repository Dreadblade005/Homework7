using System;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
				Console.Out.WriteLine("Celsius to Fahrenheit: (CTF) ");
				//each object is processed slightly differntly to test different methods
				Temperature CTFObj1 = new Temperature();
				CTFObj1.setTemperature(0.00);
				CTFObj1.setScale('C');
				Console.Out.WriteLine(CTFObj1.toString());


				Temperature CTFObj2 = new Temperature('C');
				CTFObj2.setTemperature(-40);
				Console.Out.WriteLine(CTFObj2.toString());

			
				Temperature CTFObj3 = new Temperature(100.00, 'C');
				Console.Out.WriteLine(CTFObj3.toString());

				Console.Out.WriteLine("\nFahrenheit to Celsius: (FTC)");
				Temperature FTCO = new Temperature(0);
				FTCO.setTemperatureScale(56.00, 'F');
				Console.Out.WriteLine(FTCO.toString());

			//checking if comparisson turns true 
				Temperature CTFTEST = new Temperature();
				CTFObj1.setTemperature(0.00);
				CTFObj1.setScale('C');

			Temperature CTFTEST2 = new Temperature();
			CTFObj1.setTemperature(32.00);
			CTFObj1.setScale('f');

			// Display Comparision.
			if (CTFObj1.equals(CTFObj3))
				{
					Console.WriteLine("The two objects are the same");
				}
				else
				{
					Console.WriteLine("The two objects are not the same");
				}

			if (CTFTEST.equals(CTFTEST2))
			{
				Console.WriteLine("The two objects are the same");
			}
			else
			{
				Console.WriteLine("The two objects are not the same");
			}


		}
		}
	}
