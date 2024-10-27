namespace OOPArv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create instances of each animal with specified properties
            Lion Lion = new Lion("Lion", 10, "Meat", "Roars", "Simba", 20);
            Elephant Elephant = new Elephant("Elephant", 15, "Fruit", "Trumpets", "Ellie", 120);
            Eagle Eagle = new Eagle("Eagle", 5, "Fish", "Screams", "Eddie", 180);

            // Create instances of specific lion types with additional unique properties
            AfricanLion AfricanLion = new AfricanLion("African Lion", 13, "Meat", "Roars", "Ambis", 10, 20);
            AsianLion AsianLion = new AsianLion("Asian Lion", 13, "Meat", "Roars", "Leo", 10, "Jungle");

            // Invoke methods for each animal to demonstrate their sounds and unique actions
            Lion.MakeSound();
            Lion.Hunting();

            Elephant.MakeSound();
            Elephant.Stomping();

            Eagle.MakeSound();
            Eagle.Flying();

            AfricanLion.MakeSound();
            AfricanLion.Temperature(); // Unique method for AfricanLion's temperature tolerance

            AsianLion.MakeSound();
            AsianLion.Habitat(); // Unique method for AsianLion's habitat type
        }
    }
}
