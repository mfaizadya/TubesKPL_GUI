using TubesKPL;

namespace TestProject;

[TestClass]
public class SoalPilihanGandaTest
{
    [TestMethod]
    public void TestTambahOpsi()
    {
        var soal = new SoalPilihanGanda("Apa warna langit?");
        soal.TambahOpsi("Biru");
        soal.TambahOpsi("Merah");
        Assert.AreEqual(2, soal.Opsi.Count);
        CollectionAssert.Contains(soal.Opsi, "Biru");
        CollectionAssert.Contains(soal.Opsi, "Merah");
    }

    [TestMethod]
    public void TestSetJawabanBenar()
    {
        var soal = new SoalPilihanGanda("2 + 2 = ?");
        soal.TambahOpsi("3");
        soal.TambahOpsi("4");
        soal.SetJawabanBenar("4");

        Assert.AreEqual("4", soal.JawabanBenar);
    }
}
