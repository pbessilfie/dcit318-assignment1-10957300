using System;

class TriangleTypeIdentifier
{
    static void Main()
    {
      
        Console.Write("Enter the length of side 1: ");
        string input1 = Console.ReadLine();
        Console.Write("Enter the length of side 2: ");
        string input2 = Console.ReadLine();
        Console.Write("Enter the length of side 3: ");
        string input3 = Console.ReadLine();

      
        bool isValid1 = int.TryParse(input1, out int side1);
        bool isValid2 = int.TryParse(input2, out int side2);
        bool isValid3 = int.TryParse(input3, out int side3);

        
        if (isValid1 && isValid2 && isValid3 && side1 > 0 && side2 > 0 && side3 > 0)
        {
          
            string triangleType;

            if (side1 == side2 && side2 == side3)
            {
                triangleType = "Equilateral";
            }
            else if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                triangleType = "Isosceles";
            }
            else
            {
                triangleType = "Scalene";
            }

            
            Console.WriteLine($"The triangle is {triangleType}.");
        }
        else
        {
            
            Console.WriteLine("Invalid input. Please enter positive numerical values for the sides.");
        }
    }
}
