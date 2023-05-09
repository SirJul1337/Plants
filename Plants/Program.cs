namespace Plants;
public class program
{
    public static void Main()
    {
        List<Plant> allPlants = new List<Plant>()
        {
            new AppleTree("Frederik's æbletræ", 2.2),
            new Bush("George' Busk",10.7),
            new Flower("Daniel's Blomst", "Blå")
        };
        foreach (var plant in allPlants)
        {
            plant.Grow();
            if(plant is AppleTree at)
            {
                at.GrowApple();
            }
        }

    }
}