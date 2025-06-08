using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoalLibrary;

namespace TubesKPL
{
    public static class SoalEditHelper
    {
        public static bool EditEsaiSoal(Soal soal)
        {
            string pertanyaan = Prompt.ShowDialog("Edit Pertanyaan:", "Edit Soal Esai", soal.Pertanyaan);
            if (pertanyaan == null) return false;

            string jawaban = Prompt.ShowDialog("Edit Jawaban:", "Edit Soal Esai", soal.Jawaban);
            if (jawaban == null) return false;

            soal.Pertanyaan = pertanyaan;
            soal.Jawaban = jawaban;
            return true;
        }

        public static bool EditPilihanGandaSoal(Soal soal)
        {
            string pertanyaan = Prompt.ShowDialog("Edit Pertanyaan:", "Edit Soal PG", soal.Pertanyaan);
            if (pertanyaan == null) return false;

            string opsiInput = Prompt.ShowDialog("Edit Opsi (pisahkan dengan koma):", "Edit Soal PG", string.Join(", ", soal.Opsi ?? new List<string>()));
            if (opsiInput == null) return false;

            var opsiList = opsiInput.Split(',').Select(o => o.Trim()).Where(o => !string.IsNullOrEmpty(o)).ToList();
            if (opsiList.Count < 2)
            {
                MessageBox.Show("Minimal harus ada 2 opsi.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string jawaban = Prompt.ShowDialog("Edit Jawaban:", "Edit Soal PG", soal.Jawaban);
            if (jawaban == null || !opsiList.Contains(jawaban))
            {
                MessageBox.Show("Jawaban harus termasuk dalam opsi.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            soal.Pertanyaan = pertanyaan;
            soal.Opsi = opsiList;
            soal.Jawaban = jawaban;
            return true;
        }
    }

    public static class Prompt
    {
        public static string ShowDialog(string text, string caption, string defaultText = "")
        {
            Form prompt = new Form()
            {
                Width = 400,
                Height = 160,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };

            Label textLabel = new Label() { Left = 10, Top = 20, Text = text, AutoSize = true };
            TextBox inputBox = new TextBox() { Left = 10, Top = 50, Width = 360, Text = defaultText };
            Button confirmation = new Button() { Text = "OK", Left = 210, Width = 80, Top = 80, DialogResult = DialogResult.OK };
            Button cancel = new Button() { Text = "Batal", Left = 290, Width = 80, Top = 80, DialogResult = DialogResult.Cancel };

            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(inputBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(cancel);
            prompt.AcceptButton = confirmation;
            prompt.CancelButton = cancel;

            return prompt.ShowDialog() == DialogResult.OK ? inputBox.Text.Trim() : null;
        }
    }
}
