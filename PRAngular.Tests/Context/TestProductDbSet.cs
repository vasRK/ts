using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRAngular.Tests.Context;

namespace PRAngular.Tests
{
	class TestProductDbSet : TestDbSet<Models.Patient>
	{
		public override Models.Patient Find(params object[] keyValues)
		{
			return this.SingleOrDefault(patient => patient.Id == (int)keyValues.Single());
		}
	}
}
