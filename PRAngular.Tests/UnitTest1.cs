﻿//using System;
//using System.Collections.Generic;
//using System.Threading.Tasks;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using PRAngular.Controllers;

//namespace PRAngular.Tests
//{
//	[TestClass]
//	public class TestPatientController
//	{
//		[TestMethod]
//		public void GetAllPatients_ShouldReturnAllPatients()
//		{
//			var controller = new PatientApiController();

//			var result = controller.GetAllPatients().GetAwaiter().GetResult();

//			Assert.IsTrue(result.Count > 0);
//		}

//		[TestMethod]
//		public void SavePatient_ShouldReturnSuccessMessage()
//		{
//			var controller = new PatientApiController();

//			var result = controller.SavePatient(new Models.Patient() { City = "Pune" }).GetAwaiter().GetResult();

//			Assert.AreEqual(result, "Saved patient");
//		}

//		//[TestMethod]
//		//public async Task GetAllProductsAsync_ShouldReturnAllProducts()
//		//{
//		//	var testProducts = GetTestProducts();
//		//	var controller = new SimpleProductController(testProducts);

//		//	var result = await controller.GetAllProductsAsync() as List<Product>;
//		//	Assert.AreEqual(testProducts.Count, result.Count);
//		//}

//		//[TestMethod]
//		//public void GetProduct_ShouldReturnCorrectProduct()
//		//{
//		//	var testProducts = GetTestProducts();
//		//	var controller = new SimpleProductController(testProducts);

//		//	var result = controller.GetProduct(4) as OkNegotiatedContentResult<Product>;
//		//	Assert.IsNotNull(result);
//		//	Assert.AreEqual(testProducts[3].Name, result.Content.Name);
//		//}

//		//[TestMethod]
//		//public async Task GetProductAsync_ShouldReturnCorrectProduct()
//		//{
//		//	var testProducts = GetTestProducts();
//		//	var controller = new SimpleProductController(testProducts);

//		//	var result = await controller.GetProductAsync(4) as OkNegotiatedContentResult<Product>;
//		//	Assert.IsNotNull(result);
//		//	Assert.AreEqual(testProducts[3].Name, result.Content.Name);
//		//}

//		//[TestMethod]
//		//public void GetProduct_ShouldNotFindProduct()
//		//{
//		//	var controller = new SimpleProductController(GetTestProducts());

//		//	var result = controller.GetProduct(999);
//		//	Assert.IsInstanceOfType(result, typeof(NotFoundResult));
//		//}

//		//private List<Product> GetTestProducts()
//		//{
//		//	var testProducts = new List<Product>();
//		//	testProducts.Add(new Product { Id = 1, Name = "Demo1", Price = 1 });
//		//	testProducts.Add(new Product { Id = 2, Name = "Demo2", Price = 3.75M });
//		//	testProducts.Add(new Product { Id = 3, Name = "Demo3", Price = 16.99M });
//		//	testProducts.Add(new Product { Id = 4, Name = "Demo4", Price = 11.00M });

//		//	return testProducts;
//		//}
//	}
//}
