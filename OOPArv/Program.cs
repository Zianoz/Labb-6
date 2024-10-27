namespace OOPArv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lion Lion = new Lion("Lion", 10, "Meat", "Roars", "Simba", 20);
            Elephant Elephant = new Elephant("Elephant", 15, "Fruit", "Trumpets", "Ellie", 120);
            Eagle Eagle = new Eagle("Eagle", 5, "Fish", "Screams", "Eddie", 180);

            AfricanLion AfricanLion = new AfricanLion("African Lion", 13, "Meat", "Roars", "Ambis", 10, 20);
            AsianLion AsianLion = new AsianLion("Asian Lion", 13, "Meat", "Roars", "Leo", 10, "Jungle");

            Lion.MakeSound();
            Lion.Hunting();

            Elephant.MakeSound();
            Elephant.Stomping();

            Eagle.MakeSound();
            Eagle.Flying();

            AfricanLion.MakeSound();
            AfricanLion.Temperature();

            AsianLion.MakeSound();
            AsianLion.Habitat();
        }
    }
}
