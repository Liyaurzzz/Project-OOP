public class HelloWorld
{
    int angkaSatu;
    int angkaDua;

    string halo = "halo";

    public void operasiTambah(int angkaSatuPar, int angkaDuaPar)
    {
        this.angkaSatu = angkaSatuPar;
        this.angkaDua = angkaDuaPar;
        Console.WriteLine("Hasil Pertambahan: " + (angkaSatuPar + angkaDuaPar));
    }
 public void operasiKurang(int angkaSatuPar, int angkaDuaPar)
    {
        this.angkaSatu = angkaSatuPar;
        this.angkaDua = angkaDuaPar;
        Console.WriteLine("Hasil Pengurangan: " +(angkaSatuPar - angkaDuaPar));
    } public void operasiKali(int angkaSatuPar, int angkaDuaPar)
    {
        this.angkaSatu = angkaSatuPar;
        this.angkaDua = angkaDuaPar;
        Console.WriteLine("Hasil Perkalian: " +(angkaSatuPar * angkaDuaPar));
    }
     public void operasiPembagian(int angkaSatuPar, int angkaDuaPar)
    {
        this.angkaSatu = angkaSatuPar;
        this.angkaDua = angkaDuaPar;
        Console.WriteLine("Hasil Pembagian: " +(angkaSatuPar / angkaDuaPar));
    }
    public static void Main()
    {
        Console.WriteLine("Merdeka");
        HelloWorld inisiasiHello = new HelloWorld();
        Console.WriteLine(inisiasiHello.halo);

        
        inisiasiHello.operasiTambah(2,1);
        inisiasiHello.operasiKurang(2,1);
        inisiasiHello.operasiKali(2,1);
        inisiasiHello.operasiPembagian(2,1);
    }
}