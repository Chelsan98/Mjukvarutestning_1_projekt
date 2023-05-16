static class PensionärsRabatt
{
    private static bool FårPensionärsRabatt(int ålder)
    {
        if (ålder < 66)
            return false;
        else
            return true;
    }
    public static string RabattEllerInte(IKonto konto)
    {
        if (PensionärsRabatt.FårPensionärsRabatt(konto.Ålder))
            return $"{konto.Namn} får pensionärsrabatt";
        else
            return $"{konto.Namn} får inte pensionärsrabatt";
    }
}