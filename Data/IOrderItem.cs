//Patrick Kliesner
//For CIS 400 by Nathan Bean
//2/26/2020
//IOrderItem Interface

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
	public interface IOrderItem
	{
		public double Price { get; }

		public List<string> SpecialInstructions { get; }
	}
}


