using AuthAPI;
using Microsoft.AspNetCore.Mvc;

namespace TestProject;

[TestClass]
public class PelajarControllerTest
{
    [TestMethod]
    public void LoginValid()
    {
        var controller = new AuthAPI.Controllers.PelajarController();
        var loginReq = new LoginReq { Username = "pela1", Password = "pass" };

        var result = controller.Login(loginReq);

        Assert.IsInstanceOfType(result.Result, typeof(OkObjectResult));
        var okResult = result.Result as OkObjectResult;
        Assert.IsNotNull(okResult);

        var pelajar = okResult.Value as Pelajar;
        Assert.IsNotNull(pelajar);
        Assert.AreEqual("pela1", pelajar.Username);
    }

    [TestMethod]
    public void LoginUnauthorized()
    {
        var controller = new AuthAPI.Controllers.PelajarController();
        var loginReq = new LoginReq { Username = "pela1", Password = "salah" };

        var result = controller.Login(loginReq);

        Assert.IsInstanceOfType(result.Result, typeof(UnauthorizedObjectResult));
    }

    [TestMethod]
    public void LoginBadReq()
    {
        var controller = new AuthAPI.Controllers.PelajarController();
        var loginReq = new LoginReq { Username = " ", Password = " " };

        var result = controller.Login(loginReq);

        Assert.IsInstanceOfType(result.Result, typeof(BadRequestObjectResult));
    }

    [TestMethod]
    public void Register_ValidInput_ReturnsCreated()
    {
        var controller = new AuthAPI.Controllers.PelajarController();
        var newPelajar = new Pelajar("PelajarBaru", "userbaru", "passbaru");

        var result = controller.Register(newPelajar);

        Assert.IsInstanceOfType(result.Result, typeof(CreatedAtActionResult));
        var createdResult = result.Result as CreatedAtActionResult;
        Assert.IsNotNull(createdResult);
        var pelajar = createdResult.Value as Pelajar;
        Assert.IsNotNull(pelajar);
        Assert.AreEqual("userbaru", pelajar.Username);
    }

    [TestMethod]
    public void Register_EmptyFields_ReturnsBadRequest()
    {
        var controller = new AuthAPI.Controllers.PelajarController();
        var invalidPelajar = new Pelajar("", "", "");

        var result = controller.Register(invalidPelajar);

        Assert.IsInstanceOfType(result.Result, typeof(BadRequestObjectResult));
    }

    [TestMethod]
    public void Register_UsernameAlreadyExists_ReturnsConflict()
    {
        var controller = new AuthAPI.Controllers.PelajarController();
        var existingPelajar = new Pelajar("Pelajar1", "pela1", "pass");

        var result = controller.Register(existingPelajar);

        Assert.IsInstanceOfType(result.Result, typeof(ConflictObjectResult));

    }
}