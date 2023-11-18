using TestingGround.Classes;

while (true)
{
	Console.Clear();

    Console.WriteLine("Welcome to the Ticket Office!");

	var objecta = Methods.GetCustomerAge();
	var objectb = Methods.GetCustomerPlacePreference();	

	Ticket ticket = new Ticket(objecta, objectb);
	TicketSalesManager ticketSalesManager = new TicketSalesManager();
	
	var objectc = ticket.TicketPrice();
	var objectd = ticket.TicketTax();
	var objecte = ticket.Number;

	ticketSalesManager.AddTicket(ticket);
	
	var objectf = ticketSalesManager.AmountOfTickets();
	var objectg = ticketSalesManager.SalesTotal();			
	
	Methods.AddPlace(objecte);
	
    Console.WriteLine("Do you want to change a booking: \n Yes = Y, No = N");
	if(Console.ReadKey().Key == ConsoleKey.Y)
	{
		ticketSalesManager.RemoveTicket(ticket);
		Methods.RemovePlace(objecte);
	}

	Console.WriteLine($"This is the totals:");
	Methods.Confirmation(objectc, objectd, objecte, objectf, objectg);

	Console.WriteLine("Do you want to keep booking tickets: \nYes = Enter, Quit = Q");

	if (Console.ReadKey().Key == ConsoleKey.Q)
	{
		break;
	}
}

Console.ReadKey();