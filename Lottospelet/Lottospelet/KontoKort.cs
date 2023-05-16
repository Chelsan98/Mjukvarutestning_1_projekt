using System;

class KontoKort : Betalning
{
    public override decimal Summa { get; } = 200;
    public override void BetalMetod()
    {
        Console.WriteLine("\tVald betalmetod är KontoKort med summa {0:C}", Summa);
    }
}