using TestingGround.Classes;

while (true)
{
	Console.Clear();

    Console.WriteLine("Welcome to the Ticket Office!");

	var objecta = Methods.GetCustomerAge();
	var objectb = Methods.GetCustomerPlacePreference();	

	Ticket ticket = new Ticket(objecta, objectb);
	TicketSalesManager ticketSalesManager = new TicketSalesManager();
	
	var objectc = ticket.Price();
	var objectd = ticket.Tax();
	var objecte = ticket.Number;

	ticketSalesManager.AddTicket(ticket);
	//ticketSalesManager.RemoveTicket(ticket);
	var objectf = ticketSalesManager.AmountOfTickets();
	var objectg = ticketSalesManager.SalesTotal();			
	
	// Keeping the 3 lines directly below so I can see something when I testrun
	Methods.Confirmation(objectc, objectd, objecte, objectf, objectg);
	Methods.AddPlace(objecte);
	
	Console.WriteLine("Do you want to keep booking tickets: \nYes = Enter, Quit = Z");

	if (Console.ReadKey().Key == ConsoleKey.Z)
	{
		break;
	}
}

Console.WriteLine($"This is the totals: \n");






Console.ReadKey();