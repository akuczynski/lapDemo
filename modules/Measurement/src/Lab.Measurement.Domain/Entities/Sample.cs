using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace Lab.Measurement.Entities
{
	public class Sample : Entity<Guid>
	{
		public string LaborantName { get; set; } 

		public DateTime DataOfMeasurement { get; set; }
	}
}
