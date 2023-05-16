using System;

class PayPal : Betalning
{
    public override decimal Summa { get; } = 100;
    public override void BetalMetod()
    {
        Console.WriteLine("\tVald betalmetod är PayPal med summa {0:C}", Summa);
    }
}
