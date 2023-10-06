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
		//public int numberOfTickets = 0;
		
		public List<Ticket> tickets { get; set; } = new List<Ticket>();		

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
			bool listed = true;
			tickets.Remove(ticket);
			if (tickets.Contains(ticket))
			{
				listed = false;
			}
			
			return listed;
		}
		
		public decimal SalesTotal()
		{
			decimal totalSales = 0.0m;
			foreach (Ticket t in tickets)
			{
				
                //Console.WriteLine(t); ;
			}

			return totalSales;
		}

		public int AmountOfTickets()
		{
			
			foreach (Ticket t in tickets)
			{
				return tickets.Count;
			}
			return tickets.Count;
		}
	}
}
