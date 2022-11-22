using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance_system.Model.ViewModel
{
	/// <summary>
	/// 供ProductForm使用
	/// </summary>
	public class ProductindexVM
	{
		public int Id { get; set; }
		public int type_ID { get; set; }
		public int company_ID { get; set; }
		public string ProductName { get; set; }
		public int Price { get; set; }
		public string CompanyName { get; set; }
		public string Name { get; set; }
	}
	/// <summary>
	/// 供CreateProductForm,EditProductForm使用
	/// </summary>
	public class ProductVM
	{
		public int Id { get; set; }
		public int type_ID { get; set; }
		public int company_ID { get; set; }
		[Required(ErrorMessage = "商品名稱必填")]
		public string ProductName { get; set; }
		[Required(ErrorMessage = "保費必填")]
		public int? Price { get; set; }
		
		public string CompanyName { get; set; }
		
		public string Name { get; set; }
	}
}
