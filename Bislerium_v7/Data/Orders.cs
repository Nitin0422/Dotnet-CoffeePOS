using System;
namespace Bislerium_v7.Data
{
	public class Orders
	{
		public Orders()
		{
		}
		public List<Coffees> coffeeList;
		public List<AddIns> addInsList;
		public int totalAmount;
		public int discount;
		public Customers customer;
	}
}

