using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseRequest {
	class Vendor {

		static int Counter { get; set; } = 0;

		public int Id { get; set; }
		public string Code { get; set; }
		public string Name { get; set; }
		public List<Product> Products = new List<Product>();

		//public Product CreateProduct(int Id, string VendorCode, string ProductName, double ProductPrice) {
		//	Product PR = new Product();
		//	PR.Id = Id;
		//	PR.VendorCode = VendorCode;
		//	PR.ProductName = ProductName;
		//	PR.ProductPrice = ProductPrice;
		//	return PR;

		//}

		private void InitCounter() {
			Id = ++Counter;
		}

		// Creat New Vendor
		public Vendor(string code, string name) {
			InitCounter();
			Code = code;
			Name = name;
		}

	}
}
