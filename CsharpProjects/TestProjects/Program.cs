﻿Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Stampa il numero random generato
Console.WriteLine($"Randomly generated days until expiration: {daysUntilExpiration}");

if (daysUntilExpiration <= 10) {
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days");

} else if (daysUntilExpiration <= 5) {
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days");

} else if (daysUntilExpiration <= 1) {
    Console.WriteLine($"Your subscription expires within a day!\nRenew now and save 20%!");
} else if (daysUntilExpiration <= 0) {
    Console.WriteLine("Your subscription has expired");
}
