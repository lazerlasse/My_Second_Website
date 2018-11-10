using System.ComponentModel.DataAnnotations;

namespace My_Second_Website
{
	public class Customer
	{
		public int Id { get; set; }
		[Required, StringLength(5)]
		public string Name { get; set; }
		public string LastName { get; set; }
		public string Mail { get; set; }
	}
}