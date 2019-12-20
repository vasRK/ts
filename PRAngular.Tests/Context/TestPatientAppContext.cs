using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRAngular.Models;

namespace PRAngular.Tests.Context
{
	public class TestPatientAppContext : IPatientAppContext
	{
		public TestPatientAppContext()
		{
			this.Patients = new TestProductDbSet();
		}

		public DbSet<Models.Patient> Patients { get; set; }

		public int SaveChanges()
		{
			return 0;
		}

		public void MarkAsModified(Models.Patient item)
		{

		}
		public void Dispose()
		{

		}
	}
}
