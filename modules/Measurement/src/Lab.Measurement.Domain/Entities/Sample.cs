using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace Lab.Measurement.Entities
{
	public class Sample : Entity<Guid>
	{
		public int Number { get; set; }

		public int Value { get; set; }

		public string Measurement { get; set; } 
	}
}
