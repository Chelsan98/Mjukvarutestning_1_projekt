interface IKonto
{
    string Namn { get; }
    int Ålder { get; }
    string EmailAdress { get; }
    int AnvändarID { get; }
    string NyRad(string namn);
}
