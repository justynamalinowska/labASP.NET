using Laboratorium3_Product.Controllers;
using Laboratorium3_Product.Models;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorium3_Product_UnitTests;

public class UnitTest1
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
    }
}