using TubesKPL;

namespace TestProject;

[TestClass]
public class PenilaianEsaiTest
{
    [TestMethod]
    public void TestJawabanBenar()
    {
        var penilaian = new PenilaianEsai
        {
            JawabanBenar = "Pancasila"
        };

        int skor = penilaian.HitungSkor("Pancasila");

        Assert.AreEqual(100, skor);
    }

    [TestMethod]
    public void TestJawabanSalah()
    {
        var penilaian = new PenilaianEsai
        {
            JawabanBenar = "Pancasila"
        };

        int skor = penilaian.HitungSkor("UUD 1945");

        Assert.AreEqual(50, skor); 
    }

    [TestMethod]
    public void TestJawabanKosong()
    {
        var penilaian = new PenilaianEsai
        {
            JawabanBenar = "Pancasila"
        };

        int skor = penilaian.HitungSkor("");

        Assert.AreEqual(0, skor);
    }

    [TestMethod]
    public void TestJawabanDenganSpasiDanHurufBesar()
    {
        var penilaian = new PenilaianEsai
        {
            JawabanBenar = "Pancasila"
        };

        int skor = penilaian.HitungSkor("   pAnCAsila  ");

        Assert.AreEqual(100, skor);
    }
}
