using System;
namespace Bislerium_v7.Data
{
	public class Orders
	{
		public List<Coffees> coffeeList;
		public List<AddIns> addInsList;
		public int totalAmount;
		public int discount;
		public string customerPhone;
		public DateTime orderDate;
		public int grandTotal;
	}
}

