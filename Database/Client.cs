using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
	public class Client
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string RequiredString { get; set; }
		public string NullableString { get; set; }
	}
}
