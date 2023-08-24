namespace LibraryCenterAPI.Model;

public class Tourist
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string DNI { get; set; }
    
    // Generador de nombres aleatorios
    private static Random random = new Random();
    private static List<string> availableNames = new List<string> { "John", "Jane", "Michael", "Emily", "David", "Sophia" };
    private static List<string> availableLastNames = new List<string> { "Smith", "Johnson", "Williams", "Brown", "Jones", "Miller" };

    public static Tourist GenerateRandomTourist()
    {
        Tourist randomTourist = new Tourist();

        randomTourist.Name = availableNames[random.Next(availableNames.Count)];
        randomTourist.LastName = availableLastNames[random.Next(availableLastNames.Count)];
        randomTourist.Age = random.Next(18, 65); 
        randomTourist.DNI = GenerateRandomDNI();

        return randomTourist;
    }

    private static string GenerateRandomDNI()
    {
        // Generar un DNI ficticio para el ejemplo
        return $"{random.Next(10000000, 99999999)}";
    }
}
