using System;
using System.Windows.Forms;
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
        private static readonly Lazy<AppStateManager> _instance = new Lazy<AppStateManager>(() => new AppStateManager());        // Properti untuk mengakses instance secara global
        public static AppStateManager Instance => _instance.Value;

        // Variabel untuk menyimpan state saat ini
        private AppState currentState;

        private AppStateManager() { }

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

            try
            {
                switch (currentState)
                {
                    case AppState.Logout:
                        var loginForm = new LoginPelajar();
                        loginForm.Show();
                        currentForm.Close();
                        break;

                    default:
                        LogWarning($"State '{currentState}' belum memiliki implementasi di ApplyState().");
                        break;
                }
            }
            catch (Exception ex)
            {
                LogError($"Terjadi kesalahan saat menerapkan state '{currentState}': {ex.Message}");
                MessageBox.Show("Terjadi kesalahan sistem saat memproses navigasi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method untuk mencetak pesan error dengan warna merah di console.
        private void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[AppStateManager][ERROR] {message}");
            Console.ResetColor();
        }

        // Method untuk mencetak peringatan (warning) dengan warna kuning di console.
        private void LogWarning(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"[AppStateManager][WARNING] {message}");
            Console.ResetColor();
        }
    }
}

