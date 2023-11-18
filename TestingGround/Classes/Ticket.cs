using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingGround.Classes
{
	public class Ticket
	{		
		public decimal Tax {  get; set; }		
		public int Price {  get; set; }
		public int Age { get; set; }
        public EnumClass Place { get; set; }
        public int Number { get; set; }

        public Ticket(int age, EnumClass place)
		{
			//this.Price = Price;
			this.Age = age;
			this.Place = place;
			this.Number = TicketSalesManager.NextTicketNumber();			
		}

		public int TicketPrice()
		{
			if (Age <= 11)
			{
				switch (Place)
				{
					case EnumClass.Seated: Price = 50; break;
					case EnumClass.Standing: Price = 25; break;
				}
			}

			if (Age >= 12 && Age <= 64)
			{
				switch (Place)
				{
					case EnumClass.Seated: Price = 170; break;
					case EnumClass.Standing: Price = 110; break;
				}
			}

			if (Age >= 65)
			{
				switch (Place)
				{
					case EnumClass.Seated: Price = 100; break;
					case EnumClass.Standing: Price = 60; break;
				}
			}
			
			return Price;
		}

		public decimal TicketTax()
		{
			Tax = (decimal)((1-1/1.06) * TicketPrice());
			return Tax;
		}
	}
}
