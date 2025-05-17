using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TubesKPL.MenuPelajar;

namespace TubesKPL
{
    public enum AppState
    {
        Login,
        MenuPelajar,
        MenuAdmin,
        Logout
    }
    public class AppStateManager
    {
        private static AppStateManager _instance;
        public static AppStateManager Instance => _instance ??= new AppStateManager();

        private AppState currentState;

        public void SetState(AppState state)
        {
            currentState = state;
        }

        public void ApplyState(Form currentForm)
        {
            if (currentForm == null)
            {
                Console.WriteLine("[AppStateManager] currentForm is null.");
                return;
            }

            switch (currentState)
            {
                case AppState.Logout:
                    var login = new LoginPelajar();
                    login.Show();
                    currentForm.Close();
                    break;

                default:
                    Console.WriteLine($"[AppStateManager] Unhandled AppState: {currentState}");
                    break;
            }
        }
    }
}
