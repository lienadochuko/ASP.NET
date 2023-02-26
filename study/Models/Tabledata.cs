using System.ComponentModel.DataAnnotations;

namespace study.Models
{
	public class Tabledata
	{
		[Key]
		public int Id {get; set;}
		[Required]
		public string Name {get; set;}
		public string Department {get; set;}
		public int DisplayOrder { get; set; }
		public DateTime CreatedDateTime { get; set; } = DateTime.Now;

		public static void Main1()
		{
			Tabledata tabledatalist = new Tabledata();
			tabledatalist.Name = "Name";
			tabledatalist.Department = "ccd";
			tabledatalist.Id = 1;

		}
	}
}
