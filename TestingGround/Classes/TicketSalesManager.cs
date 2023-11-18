using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TestingGround.Classes
{
	public class TicketSalesManager
	{
		public  int SumTotalSales { get; set; }
		public int TotalSales { get; set; }		
		public int TicketPrice { get; set; }
		public int TicketCount { get; set; }
		public static List<Ticket> tickets = new List<Ticket>();		

		public static int NextTicketNumber()
		{
			Random random = new Random();
			int ticketNumber = random.Next(1, 8000);
						
			return ticketNumber;
		}
				
		public Ticket AddTicket(Ticket ticket)
		{
			tickets.Add(ticket);
			return ticket;
		}
		
		public bool RemoveTicket(Ticket ticket)
		{	
			bool listed = false;
			if (tickets.Contains(ticket))
			{
				listed = true;
                Console.WriteLine(listed);
                tickets.Remove(ticket);
				listed = false;
			}
            Console.WriteLine(listed);
			SalesTotal();
			AmountOfTickets();

            return listed;
		}
		
		public decimal SalesTotal()
		{			
			foreach (var item in tickets)
			{
				TotalSales += item.Price;				
            }
			return TotalSales;
		}

		public int AmountOfTickets()
		{
			return tickets.Count;
		}
	}
}