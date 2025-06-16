using SoalLibrary;
using TubesKPL;

namespace TestProject;

[TestClass]
public class SoalManagerTests
{
    private readonly string testFilePath = "test_data_level.json";
    

    [TestInitialize]
    public void Setup()
    {
        SoalManager.filePath = Path.Combine(Path.GetTempPath(), $"test_data_{Guid.NewGuid()}.json");
    }

    [TestMethod]
    public void TestAddSoal()
    {
        var soal = new Soal
        {
            Pertanyaan = "Apa itu OOP?",
            Jawaban = "Pemrograman berbasis objek",
            Jenis = JenisSoal.Esai
        };

        SoalManager.Add(soal);
        var data = SoalManager.Load();

        Assert.AreEqual(1, data.Count);
        Assert.AreEqual("Apa itu OOP?", data[0].Pertanyaan);
    }

    [TestMethod]
    public void TestEditSoal()
    {
        var soal = new Soal
        {
            Pertanyaan = "Soal awal",
            Jawaban = "Jawaban awal",
            Jenis = JenisSoal.Esai
        };
        SoalManager.Add(soal);
        var data = SoalManager.Load();

        var soalBaru = data.First();
        soalBaru.Pertanyaan = "Soal edit";
        soalBaru.Jawaban = "Jawaban edit";

        SoalManager.Edit(soalBaru);
        var edited = SoalManager.Load().First();

        Assert.AreEqual("Soal edit", edited.Pertanyaan);
        Assert.AreEqual("Jawaban edit", edited.Jawaban);
    }

    [TestMethod]
    public void TestDeleteSoal()
    {
        var soal = new Soal
        {
            Pertanyaan = "Soal untuk dihapus",
            Jawaban = "Jawaban",
            Jenis = JenisSoal.Esai
        };
        SoalManager.Add(soal);

        var data = SoalManager.Load();
        int id = data.First().Id;

        SoalManager.Delete(id);
        var afterDelete = SoalManager.Load();

        Assert.AreEqual(0, afterDelete.Count);
    }
}


    

