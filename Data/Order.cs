//Patrick Kliesner
//For CIS 400 by Nathan Bean
//2/26/2020
//Order Class

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
	public class Order :INotifyPropertyChanged
	{
		private static uint lastOrderNumber;

		private List<IOrderItem> items = new List<IOrderItem>();

		public List<IOrderItem> Items { get; set; }

		public double Subtotal { get; }

		public uint OrderNumber { get; }

		public event PropertyChangedEventHandler PropertyChanged;


		/// <summary>
        /// Adds the IOrderItem to the list of items
        /// </summary>
		public void Add(IOrderItem item)
        {
			items.Add(item);
        }

		/// <summary>
        /// Removes the IOrderItem from the list of items
        /// </summary>
		public void Remove(IOrderItem item)
        {
			items.Remove(item);
        }
	}
}

