using Laboratorium3_Product.Controllers;
using Laboratorium3_Product.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Xunit;

namespace Laboratorium3_Product_UnitTests
{
    public class ProductControllerTest
    {
        private ProductController _controller;
        private IProductService _service;

        public ProductControllerTest()
        {
            _service = new MemoryProductService();
            _service.Add(new Product() { Id = 1 });
            _service.Add(new Product() { Id = 2 });
            _controller = new ProductController(_service);
        }

        [Fact]
        public void IndexTest()
        {
            var result = _controller.Index();
            Assert.IsType<ViewResult>(result);
            var view = result as ViewResult;
        }

        [Fact]
        public void IndexTestCount()
        {
            var result = _controller.Index();
            Assert.IsType<ViewResult>(result);
            var view = result as ViewResult;
            var model = view.Model as List<Product>;
            Assert.Equal(2, model.Count);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void DetailsTestForExistingProducts(int value)
        {
            var result = _controller.Details(value);
            Assert.IsType<ViewResult>(result);
            var view = result as ViewResult;
            var model = view.Model as Product;
            Assert.Equal(value, model.Id);
        }

        [Fact]
        public void DetailsTestForNotExistingProducts()
        {
            var result = _controller.Details(3);
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public void CreateGetTest()
        {
            var productService = new MemoryProductService();
            var controller = new ProductController(productService);
            var result = controller.Create() as ViewResult;
            Assert.NotNull(result);
            Assert.IsType<Product>(result.Model);
            var model = result.Model as Product;
            Assert.NotNull(model);
            Assert.NotNull(model.ProducentList);
            Assert.NotEmpty(model.ProducentList);
        }

        [Fact]
        public void CreatePostValidTest()
        {
            var product = new Product { Id = 3, ProductName = "TestProduct", Price = 10.0M };
            var result = _controller.Create(product) as RedirectToActionResult;
            Assert.NotNull(result);
            Assert.Equal("Index", result.ActionName);
        }

        [Fact]
        public void PagedIndexTest()
        {
            var productService = new MemoryProductService();
            var controller = new ProductController(productService);
            var result = controller.PagedIndex() as ViewResult;
            Assert.NotNull(result);
            Assert.IsType<PagingList<Product>>(result.Model);
        }

        [Fact]
        public void UpdateGetTest()
        {
            var result = _controller.Update(1);
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void UpdatePostValidTest()
        {
            var product = new Product { Id = 1, ProductName = "UpdatedProduct", Price = 15.0M };
            var result = _controller.Update(product) as RedirectToActionResult;
            Assert.NotNull(result);
            Assert.Equal("Index", result.ActionName);
        }
        
        [Fact]
        public void UpdatePostInvalidTest()
        {
            _controller.ModelState.AddModelError("ProductName", "Product Name is required");
            var product = new Product { Id = 1, Price = 15.0M, ProductName = null };
            var result = _controller.Update(product) as ViewResult;
            Assert.NotNull(result);
            Assert.Null(result.Model); 
            Assert.True(_controller.ModelState.ContainsKey("ProductName")); 
        }

        [Fact]
        public void DeleteGetTest()
        {
            var result = _controller.Delete(1);
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void DeletePostTest()
        {
            var product = new Product { Id = 1, ProductName = "TestProduct", Price = 10.0M };
            var result = _controller.Delete(product) as RedirectToActionResult;
            Assert.NotNull(result);
            Assert.Equal("Index", result.ActionName);
        }
    }
    public class ProducentControllerTests
{
    [Fact]
    public void IndexTest()
    {
        var service = new MemoryProducentService();
        service.Add(new Producent() { Id = 1 });
        service.Add(new Producent() { Id = 2 });
        var controller = new ProducentController(service);
        var result = controller.Index() as ViewResult;
        Assert.NotNull(result);
        Assert.IsType<List<Producent>>(result.Model);
    }

    [Fact]
    public void CreateGetTest()
    {
        var service = new MemoryProducentService();
        var controller = new ProducentController(service);
        var result = controller.Create() as ViewResult;
        Assert.NotNull(result);
        Assert.IsType<Producent>(result.Model);
    }

    [Fact]
    public void CreatePostValidTest()
    {
        var service = new MemoryProducentService();
        var controller = new ProducentController(service);
        var producent = new Producent();
        var result = controller.Create(producent) as RedirectToActionResult;
        Assert.NotNull(result);
        Assert.Equal("Index", result.ActionName);
    }

    [Fact]
    public void EditGetTest()
    {
        var service = new MemoryProducentService();
        service.Add(new Producent() { Id = 1 });
        var controller = new ProducentController(service);
        var result = controller.Edit(1) as ViewResult;
        Assert.NotNull(result);
        Assert.IsType<Producent>(result.Model);
    }

    [Fact]
    public void EditPostValidTest()
    {
        var service = new MemoryProducentService();
        service.Add(new Producent() { Id = 1 });
        var controller = new ProducentController(service);
        var producent = new Producent();
        var result = controller.Edit(producent) as RedirectToActionResult;
        Assert.NotNull(result);
        Assert.Equal("Index", result.ActionName);
    }

    [Fact]
    public void DeleteGetTest()
    {
        var service = new MemoryProducentService();
        service.Add(new Producent() { Id = 1 });
        var controller = new ProducentController(service);
        var result = controller.Delete(1) as ViewResult;
        Assert.NotNull(result);
        Assert.IsType<Producent>(result.Model);
    }

    [Fact]
    public void DeletePostTest()
    {
        var service = new MemoryProducentService();
        service.Add(new Producent() { Id = 1 });
        var controller = new ProducentController(service);
        var producent = new Producent();
        var result = controller.Delete(producent) as RedirectToActionResult;
        Assert.NotNull(result);
        Assert.Equal("Index", result.ActionName);
    }

    [Fact]
    public void DetailsTest()
    {
        var service = new MemoryProducentService();
        service.Add(new Producent() { Id = 1 });
        var controller = new ProducentController(service);
        var result = controller.Details(1) as ViewResult;
        Assert.NotNull(result);
        Assert.IsType<Producent>(result.Model);
    }
}
}



