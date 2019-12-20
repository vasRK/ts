using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Http.Results;
using System.Net;
using PRAngular.Models;
using PRAngular.Controllers;
using PRAngular.Tests.Context;

namespace PRAngular.Tests
{

	[TestClass]
	public class TestPatientController
	{
		[TestMethod]
		public void GetAllPatients_ShouldRetunAllPatients()
		{
			var controller = new PatientApiController(new TestPatientAppContext());
			var item = GetDemoProduct();
			var result = controller.GetAllPatients().GetAwaiter().GetResult(); //<Models.Patient>;

			Assert.IsNotNull(result);
			//Assert.AreEqual(result.RouteName, "DefaultApi");
			//Assert.AreEqual(result.RouteValues["id"], result.Content.Id);
			//Assert.AreEqual(result.Content.Name, item.Name);
		}

		[TestMethod]
		public void PutProduct_ShouldReturnStatusCode()
		{
			var controller = new PatientApiController(new TestPatientAppContext());

			var item = GetDemoProduct();

			//var result = controller.PutProduct(item.Id, item) as StatusCodeResult;
			//Assert.IsNotNull(result);
			//Assert.IsInstanceOfType(result, typeof(StatusCodeResult));
			//Assert.AreEqual(HttpStatusCode.NoContent, result.StatusCode);
		}

		[TestMethod]
		public void PutProduct_ShouldFail_WhenDifferentID()
		{
			var controller = new PatientApiController(new TestPatientAppContext());

			//var badresult = controller.PutProduct(999, GetDemoProduct());
			//Assert.IsInstanceOfType(badresult, typeof(BadRequestResult));
		}

		[TestMethod]
		public void GetProduct_ShouldReturnProductWithSameID()
		{
			var context = new TestPatientAppContext();
			//context.Products.Add(GetDemoProduct());

			//var controller = new PatientApiController(context);
			//var result = controller.GetProduct(3) as OkNegotiatedContentResult<Models.Patient>;

			//Assert.IsNotNull(result);
			//Assert.AreEqual(3, result.Content.Id);
		}

		[TestMethod]
		public void GetProducts_ShouldReturnAllProducts()
		{
			var context = new TestPatientAppContext();
			//context.Products.Add(new Product { Id = 1, Name = "Demo1", Price = 20 });
			//context.Products.Add(new Product { Id = 2, Name = "Demo2", Price = 30 });
			//context.Products.Add(new Product { Id = 3, Name = "Demo3", Price = 40 });

			//var controller = new PatientApiController(context);
			//var result = controller.GetProducts() as TestProductDbSet;

			//Assert.IsNotNull(result);
			//Assert.AreEqual(3, result.Local.Count);
		}

		[TestMethod]
		public void DeleteProduct_ShouldReturnOK()
		{
			var context = new TestPatientAppContext();
			var item = GetDemoProduct();
			//context.Products.Add(item);

			//var controller = new PatientApiController(context);
			//var result = controller.DeleteProduct(3) as OkNegotiatedContentResult<Product>;

			//Assert.IsNotNull(result);
			//Assert.AreEqual(item.Id, result.Content.Id);
		}

		Models.Patient GetDemoProduct()
		{
			return null;

			//new Patient() { Id = 3, Name = "Demo name", Price = 5 };
		}
	}
}
