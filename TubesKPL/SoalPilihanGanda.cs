using System;
using System.Collections.Generic;

namespace TubesKPL
{
    /// <summary>
    /// Representasi model Soal Pilihan Ganda.
    /// </summary>
    public class SoalPilihanGanda
    {
        public string Pertanyaan { get; private set; }
        public List<string> Opsi { get; private set; }
        public string JawabanBenar { get; private set; }
        public int Id { get; internal set; }

        public SoalPilihanGanda(string pertanyaan)
        {
            if (string.IsNullOrWhiteSpace(pertanyaan))
                throw new ArgumentException("Pertanyaan tidak boleh kosong.", nameof(pertanyaan));

            Pertanyaan = pertanyaan.Trim();
            Opsi = new List<string>();
        }

        public void TambahOpsi(string opsi)
        {
            if (string.IsNullOrWhiteSpace(opsi))
                throw new ArgumentException("Opsi tidak boleh kosong.", nameof(opsi));

            Opsi.Add(opsi.Trim());
        }

        public void SetJawabanBenar(string jawaban)
        {
            if (string.IsNullOrWhiteSpace(jawaban))
                throw new ArgumentException("Jawaban tidak boleh kosong.", nameof(jawaban));

            if (!Opsi.Contains(jawaban))
                throw new InvalidOperationException("Jawaban harus merupakan salah satu opsi yang sudah dimasukkan.");

            JawabanBenar = jawaban;
        }
    }
}
