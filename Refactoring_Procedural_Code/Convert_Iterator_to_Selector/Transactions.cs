﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Convert_Iterator_to_Selector
{
    public static class Transactions
    {
        public static IEnumerable<Sale> MondaySales { get; }
            = new List<Sale> {
                new Sale("Hook And Ladder", 25.16m, 0m, 4),
                new Sale("Engineer", 27.87m, 3m, 3),
                new Sale("Meatball", 18.78m, 0m, 2),
                new Sale("New York Steamer", 6.29m,  0m, 1),
                new Sale("Italian", 36.76m, 0m, 4),
                new Sale("Turkey Bacon Ranch", 13.38m, 0m, 2),
                new Sale("Club on a Sub", 9.78m,  0m, 2),
                new Sale("Firehouse Steak & Cheese", 29.37m, 0m, 3),
                new Sale("Sweet & Spicy Meatball", 12.57m, 0m, 3),
                new Sale("Firehouse Hero", 27.16m, 0m, 4),
                new Sale("Smokehouse Beef & Cheddar Brisket", 28.76m, 0m, 4),
                new Sale("Hook And Ladder", 15.96m, 0m, 4),
                new Sale("Engineer", 13.47m, 0m, 3),
                new Sale("Meatball", 12.57m, 3m, 3),
                new Sale("New York Steamer", 17.96m, 0m, 4),
                new Sale("Italian", 18.57m, 0m, 3),
                new Sale("Turkey Bacon Ranch", 19.38m, 0m, 2),
                new Sale("Club on a Sub", 6.69m,  0m, 1),
                new Sale("Firehouse Steak & Cheese", 19.58m, 0m, 2),
                new Sale("Sweet & Spicy Meatball", 23.56m, 4m, 4),
                new Sale("Firehouse Hero", 19.58m, 0m, 2),
                new Sale("Smokehouse Beef & Cheddar Brisket", 7.19m,  0m, 1),
                new Sale("Hook And Ladder", 11.97m, 0m, 3),
                new Sale("Engineer", 6.29m,  0m, 1),
                new Sale("Meatball", 11.98m, 0m, 2),
                new Sale("New York Steamer", 9.29m,  0m, 1),
                new Sale("Italian", 4.39m,  0m, 1),
                new Sale("Turkey Bacon Ranch", 9.69m,  0m, 1),
                new Sale("Club on a Sub", 14.67m, 0m, 3),
                new Sale("Firehouse Steak & Cheese", 6.79m,  1m, 1),
                new Sale("Sweet & Spicy Meatball", 8.99m,  0m, 1),
                new Sale("Firehouse Hero", 27.16m, 0m, 4),
                new Sale("Smokehouse Beef & Cheddar Brisket", 30.57m, 3m, 3),
                new Sale("Hook And Ladder", 11.97m, 0m, 3),
                new Sale("Engineer", 18.87m, 0m, 3),
                new Sale("Meatball", 37.56m, 0m, 4),
                new Sale("New York Steamer", 6.29m,  0m, 1),
                new Sale("Italian", 8.78m,  0m, 2),
                new Sale("Turkey Bacon Ranch", 38.76m, 0m, 4),
                new Sale("Club on a Sub", 13.38m, 0m, 2),
                new Sale("Firehouse Steak & Cheese", 39.16m, 0m, 4),
                new Sale("Sweet & Spicy Meatball", 8.38m,  2m, 2),
                new Sale("Firehouse Hero", 9.79m,  0m, 1),
                new Sale("Smokehouse Beef & Cheddar Brisket", 10.78m, 2m, 2),
                new Sale("Hook And Ladder", 18.58m, 0m, 2),
                new Sale("Engineer", 12.58m, 2m, 2),
                new Sale("Meatball", 37.56m, 0m, 4),
                new Sale("New York Steamer", 12.58m, 0m, 2),
                new Sale("Italian", 18.57m, 0m, 3),
                new Sale("Turkey Bacon Ranch", 14.67m, 0m, 3),
                new Sale("Club on a Sub", 26.76m, 0m, 4),
                new Sale("Firehouse Steak & Cheese", 4.99m,  0m, 1),
                new Sale("Sweet & Spicy Meatball", 4.19m,  1m, 1),
                new Sale("Firehouse Hero", 19.96m, 0m, 4),
                new Sale("Smokehouse Beef & Cheddar Brisket", 30.57m, 0m, 3),
                new Sale("Hook And Ladder", 3.99m,  0m, 1),
                new Sale("Engineer", 8.98m,  0m, 2),
                new Sale("Meatball", 5.99m,  0m, 1),
                new Sale("New York Steamer", 25.16m, 0m, 4),
                new Sale("Italian", 17.56m, 0m, 4),
                new Sale("Turkey Bacon Ranch", 38.76m, 0m, 4),
                new Sale("Club on a Sub", 6.69m,  0m, 1),
                new Sale("Firehouse Steak & Cheese", 6.79m,  0m, 1),
                new Sale("Sweet & Spicy Meatball", 8.99m,  0m, 1),
                new Sale("Firehouse Hero", 20.37m, 0m, 3),
                new Sale("Smokehouse Beef & Cheddar Brisket", 21.57m, 0m, 3),
            };
    }
}
