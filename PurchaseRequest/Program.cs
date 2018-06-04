using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseRequest {
	class Program {
		static void Main(string[] args) {



			Vendor Target = new Vendor("TAR", "Target");
			Vendor Walmart = new Vendor("WAL", "Walmart");
			Vendor MicroCenter = new Vendor("MIC", "MicroCenter");

			Product Xbox = new Product("Xbox", 399.99);
			Xbox.VendorsSelling.Add(Target);
			Xbox.VendorsSelling.Add(Walmart);
			Xbox.VendorsSelling.Add(MicroCenter);
			Target.Products.Add(Xbox);
			Walmart.Products.Add(Xbox);
			MicroCenter.Products.Add(Xbox);

			Product Playstation = new Product("Playstation", 399.99);
			Playstation.VendorsSelling.Add(Target);
			Playstation.VendorsSelling.Add(Walmart);
			Playstation.VendorsSelling.Add(MicroCenter);
			Target.Products.Add(Playstation);
			Walmart.Products.Add(Playstation);
			MicroCenter.Products.Add(Playstation);

			Product Desktop = new Product("Desktop", 999.99);
			Desktop.VendorsSelling.Add(Target);
			Desktop.VendorsSelling.Add(Walmart);
			Desktop.VendorsSelling.Add(MicroCenter);
			Target.Products.Add(Desktop);
			Walmart.Products.Add(Desktop);
			MicroCenter.Products.Add(Desktop);



		}
		
	}
}
