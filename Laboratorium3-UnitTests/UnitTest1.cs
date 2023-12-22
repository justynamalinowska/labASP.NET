using Laboratorium3.Controllers;
using Laboratorium3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Laboratorium3_UnitTests;

public class ContactControllerTest
{
    private ContactController _controller;
    private IContactService _service;
    private IDateTimeProvider _dateTimeProvider;

    public ContactControllerTest()
    {
        _dateTimeProvider = new CurrentDateTimeProvider();
        _service = new MemoryContactService(_dateTimeProvider);
        _service.Add(new Contact() { Id = 1 });
        _service.Add(new Contact() { Id = 2 });
        _controller = new ContactController(_service);
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
        var model = view.Model as List<Contact>;
        Assert.Equal(2,model.Count);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    public void DetailsTestForExistingContacts(int value)
    {
        var result = _controller.Details(value);
        Assert.IsType<ViewResult>(result);
        var view = result as ViewResult;
        var model = view.Model as Contact;
        Assert.Equal(value,model.Id);
    }
    
    [Fact]
    public void DetailsTestForNotExistingContacts()
    {
        var result = _controller.Details(3);
        Assert.IsType<NotFoundResult>(result);
    }

    
    
}
