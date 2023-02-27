using AutoMapper;
using Lab.Measurement.Entities;
using Lab.Measurement.Samples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Measurement.Profiles
{
	internal class AutomapperProfile : Profile
	{
		public AutomapperProfile() 
		{
			CreateMap<Sample, SampleDto>();
		}
	}
}
