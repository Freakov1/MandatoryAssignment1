namespace MandatoryAssignment
{
    public class FootballPlayer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int ShirtNumber { get; set; }

        public void ValidateName()
        {
            if(Name.Length < 2) throw new ArgumentOutOfRangeException("Navn skal være mere end 2 karaktere");
        }

        public void ValidateAge()
        {
            if(Age < 1) throw new ArgumentOutOfRangeException("Alder skal være større end 1");
        }

        public void ValidateShirt()
        {
            if (ShirtNumber < 1 || ShirtNumber > 99) throw new ArgumentOutOfRangeException("Trøjenummer skal være imellem 1 og 99");
        }
    }
}