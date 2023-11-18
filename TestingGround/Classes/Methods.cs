using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingGround.Classes
{
	public class Methods
	{
		public static string seatingString = "";
		public static string placeList = ",";		
		
		public static string? Age { get; set; }		
				
		public static void Confirmation(int price, decimal tax, int ticketNumber, int numberOfTickets, decimal salesAmount)
		{
            Console.WriteLine("Here is your booked ticket\n");
            Console.WriteLine($"Ticket Number: \t{ticketNumber}");
			Console.WriteLine($"Ticket Price: \t{price:C}");
			Console.WriteLine($"Tax: \t{tax:C}");
            Console.WriteLine($"Number of tickets: \t{numberOfTickets}");
			Console.WriteLine($"Total sales amount: \t{salesAmount}");
        }		
		
		public static string AddPlace(int ticketNumber)
		{
			string temp = placeList.Insert(placeList.Length, $"{ticketNumber},").ToString();
			placeList = temp;

            Console.WriteLine($"This is whats in the list: {placeList}\n");

			return placeList;
        }

		public static string RemovePlace(int ticketNumber)
		{
			string deleteNumber = Convert.ToString(ticketNumber);
            Console.WriteLine($"deleteNumber is: {deleteNumber.Length}");
            string temp = placeList.Remove(placeList.Length-(deleteNumber.Length+1)).ToString();
			placeList = temp;

			Console.WriteLine($"This is whats in the list: {placeList}\n");
			return placeList;
		}

		public static int GetCustomerAge()
		{
			bool check = false;
			
			while ( !check ) 
			{
                Console.WriteLine("Please enter your age: ");
				Age = Console.ReadLine();
				if (Age.Length <= 3)
				{
					for (int i = 0; i < Age.Length; i++)
					{
						if (Age[i] >= '0' && Age[i] <= '9')
						{
							check = true;
						}
					}
				}
				else
					continue;
            }

            Console.WriteLine(check);
            Console.WriteLine(Age);

			int ageEntered = Convert.ToInt32(Age);

			return ageEntered;
        }

		public static EnumClass GetCustomerPlacePreference()
		{
			string temp;
			do
			{
                Console.WriteLine("Please enter if you want seated or standing placing: ");
				temp = Console.ReadLine();
				seatingString = $"{temp[0].ToString().ToUpper()}" +
								$"{temp.ToString().ToLower().Substring(1)}";

            }while (seatingString != "Seated" && seatingString != "Standing");

            Console.WriteLine(seatingString);

			Console.ReadKey();

			if (seatingString == "Seated")
				return (EnumClass)0;
			else
				return (EnumClass)1;
        }
	}
}
