using System;
namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany 
    {
        public SUV()
        {
        }

        public double EngineSize { get; set; } = 5.0;
        public string Model { get; set; } = "Escape";
        public string Make { get; set; } = "Ford";
        public int SeatCount { get; set; } = 4;
        public bool HasChangedGears { get; set; }
        public string Name { get; set; } = "Ford";
        public string Motto { get; set; } = "Built Ford Tough";

        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now driving forward. . .");
        }

        public void Park()
        {
            if(HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} is now in park...");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't park until we change gears...");
            }
        }

        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now reversing. . .");
                HasChangedGears = false;

            }
            else
            {
                Console.WriteLine("Can't reverse until we change gears. . .");
            }
              

        }
    }
}
