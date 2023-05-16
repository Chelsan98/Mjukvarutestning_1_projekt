using System;

class Klarna : Betalning
{
    public override decimal Summa { get; } = 400;

    public override void BetalMetod()
    {
        Console.WriteLine("\tVald betalmetod är Klarna med summa {0:C}", Summa);
    }
}
