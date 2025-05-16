using TubesKPL;

namespace TestProject;

[TestClass]
public class LogOutTest
{
    [TestMethod]
    public void TestSetAndApplyLogoutState()
    {
        var appStateManager = AppStateManager.Instance;
        appStateManager.SetState(AppState.Logout);

        Assert.AreEqual(typeof(AppStateManager), appStateManager.GetType());
    }
}
