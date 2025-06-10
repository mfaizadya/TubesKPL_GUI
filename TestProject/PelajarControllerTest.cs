using AuthAPI;
using AuthAPI.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject;

[TestClass]
public class PelajarControllerTest
{
    [TestMethod]
    public void LoginValid()
    {
        var controller = new PelajarController();
        var loginReq = new LoginReq { Username = "pela1", Password = "pass" };

        var actionResult = controller.Login(loginReq);
        var result = actionResult as OkObjectResult;

        Assert.IsNotNull(result);

        // Strong-typed cast
        var pelajar = result.Value as Pelajar;

        Assert.IsNotNull(pelajar);
        Assert.AreEqual("pela1", pelajar.Username);
    }

    [TestMethod]
    public void LoginUnauthorized()
    {
        var controller = new PelajarController();
        var loginReq = new LoginReq { Username = "pela1", Password = "salah" };

        var actionResult = controller.Login(loginReq);
        var result = actionResult as UnauthorizedObjectResult;

        Assert.IsNotNull(result);
    }

    [TestMethod]
    public void LoginBadReq()
    {
        var controller = new PelajarController();
        var loginReq = new LoginReq { Username = " ", Password = " " };

        var actionResult = controller.Login(loginReq);
        var result = actionResult as BadRequestObjectResult;

        Assert.IsNotNull(result);
    }

    [TestMethod]
    public void Register_ValidInput_ReturnsCreated()
    {
        var controller = new PelajarController();
        var newPelajar = new Pelajar("PelajarBaru", "userbaru", "passbaru");

        var actionResult = controller.Register(newPelajar);
        var result = actionResult as CreatedAtActionResult;

        Assert.IsNotNull(result);

        var pelajar = result.Value as Pelajar;

        Assert.IsNotNull(pelajar);
        Assert.AreEqual("userbaru", pelajar.Username);
    }

    [TestMethod]
    public void Register_EmptyFields_ReturnsBadRequest()
    {
        var controller = new PelajarController();
        var invalidPelajar = new Pelajar("", "", "");

        var actionResult = controller.Register(invalidPelajar);
        var result = actionResult as BadRequestObjectResult;

        Assert.IsNotNull(result);
    }

    [TestMethod]
    public void Register_UsernameAlreadyExists_ReturnsConflict()
    {
        var controller = new PelajarController();
        var existingPelajar = new Pelajar("Pelajar1", "pela1", "pass");

        var actionResult = controller.Register(existingPelajar);
        var result = actionResult as ConflictObjectResult;

        Assert.IsNotNull(result);
    }
}
