class Spelare : IKonto
{
    public string Namn { get; private set; }
    public int Ålder { get; private set; }
    public string EmailAdress { get; private set; }
    public int AnvändarID { get; private set; }

    public Spelare(string namn, int ålder, string emailAdress, int användarID)
    {
        Namn = namn;
        Ålder = ålder;
        EmailAdress = emailAdress;
        AnvändarID = användarID;
    }

    public string NyRad(string namn)
    {
        // Denna metod kommer att skapa en ny lottorad när spelaren väljer att göra det
        return $"Skapar ny rad när {namn} väljer det";
    }
}