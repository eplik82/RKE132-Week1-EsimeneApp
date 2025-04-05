string[] snacks = { "sushi", "pizza", "burger", "chicken", "fries" };
Random rnd = new Random();

int randomIndex = rnd.Next(snacks.Length);

Console.WriteLine($"Tonight we are eating {snacks[randomIndex]}.");