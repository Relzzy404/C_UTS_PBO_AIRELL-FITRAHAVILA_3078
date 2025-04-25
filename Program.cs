namespace perpustakaan_rz
{
    class Book
    {
        public int id;
        public string judul;
        public string penulis;
        public int tahunterbit;
        public string status;
    }

    class Perpustakaan
    {
        public string nama;
        public string alamat;

        public void TambahBuku(Book)
        {
            koleksi.Add(Book);
            Console.WriteLine("Buku ditambah.");
        }

        public void TampilkanBuku()
        {
            if (koleksi.Count == 0)
            {
                Console.WriteLine("Belum ada buku.");
                return;
}

           
