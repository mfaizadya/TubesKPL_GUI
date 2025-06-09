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
        // Enumerasi untuk representasi status aplikasi saat ini
        Login,
        MenuPelajar,
        MenuAdmin,
        Logout
    }

    // Class yang mengelola perubahan state aplikasi
    public class AppStateManager
    {
        // Single instance dari AppStateManager
        private static AppStateManager _instance;
        // Properti untuk mengakses instance secara global
        public static AppStateManager Instance => _instance ??= new AppStateManager();
        // Variabel untuk menyimpan state saat ini
        private AppState currentState;

        // Mengatur state aplikasi saat ini.
        public void SetState(AppState state)
        {
            currentState = state;
        }

        // Menerapkan logika berdasarkan state yang sedang aktif.
        public void ApplyState(Form currentForm)
        {
            // Mengatur state aplikasi saat ini (Secure Coding)
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
