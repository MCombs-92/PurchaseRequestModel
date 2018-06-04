using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseRequest {
	class Product {

		public static int Counter { get; set; } = 0;
		public int Id { get; set; }

		public String ProductName { get; set; }
		public double ProductPrice { get; set; }
		public List<Vendor> VendorsSelling = new List<Vendor>();

		private void InitCounter() {
			Id = ++Counter;
		}

		public Product(string productname, double productprice) {
			InitCounter();
			ProductName = productname;
			ProductPrice = productprice;
		}

	}
}
