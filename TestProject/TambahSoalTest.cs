using System.Windows.Forms;
using SoalLibrary;
using TubesKPL;

namespace TestProject;

[TestClass]
public class TambahSoalTest
{
    [TestMethod]
    public void tambahsoal()
    {
        var form = new FormMenambahSoalEssay();

        var pertanyaan = "Apa itu OOP?";
        var jawaban = "Object-Oriented Programming";

        var textBoxPertanyaan = form.Controls.Find("textBoxPertanyaan", true)[0] as TextBox;
        var textBoxJawaban = form.Controls.Find("textBoxJawaban", true)[0] as TextBox;

        textBoxPertanyaan.Text = pertanyaan;
        textBoxJawaban.Text = jawaban;

        var method = form.GetType().GetMethod("btnSelesai_Click",
            System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

        method.Invoke(form, new object[] { form, System.EventArgs.Empty });

        var soal = form.AmbilSoal();

        Assert.IsNotNull(soal);
        Assert.AreEqual(pertanyaan, soal.Pertanyaan);
        Assert.AreEqual(jawaban, soal.Jawaban);
        Assert.AreEqual(JenisSoal.Esai, soal.Jenis);
    }
}
