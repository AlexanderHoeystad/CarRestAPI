namespace CarRestAPI
{
    public class CarsRepository
    {
        private List<Car> cars = new List<Car>
            {
                new Car { Id = 1, Brand = "Ford", Model = "Focus", HorsePower = 100 },
                new Car { Id = 2, Brand = "Toyota", Model = "Corolla", HorsePower = 120 },
                new Car { Id = 3, Brand = "Volkswagen", Model = "Golf", HorsePower = 110 },
                new Car { Id = 4, Brand = "Audi", Model = "A4", HorsePower = 150 },
                new Car { Id = 5, Brand = "BMW", Model = "3 Series", HorsePower = 200 },
                new Car { Id = 6, Brand = "Mercedes-Benz", Model = "C-Class", HorsePower = 180 },
                new Car { Id = 7, Brand = "Honda", Model = "Civic", HorsePower = 130 },
                new Car { Id = 8, Brand = "Chevrolet", Model = "Cruze", HorsePower = 140 },
                new Car { Id = 9, Brand = "Hyundai", Model = "Elantra", HorsePower = 128 },
                new Car { Id = 10, Brand = "Kia", Model = "Forte", HorsePower = 147 },
                new Car { Id = 11, Brand = "Nissan", Model = "Sentra", HorsePower = 124 },
                new Car { Id = 12, Brand = "Subaru", Model = "Impreza", HorsePower = 152 },
                new Car { Id = 13, Brand = "Mazda", Model = "3", HorsePower = 155 },
                new Car { Id = 14, Brand = "Lexus", Model = "IS", HorsePower = 241 },
                new Car { Id = 15, Brand = "Acura", Model = "ILX", HorsePower = 201 },
                new Car { Id = 16, Brand = "Infiniti", Model = "Q50", HorsePower = 300 },
                new Car { Id = 17, Brand = "Tesla", Model = "Model 3", HorsePower = 283 },
                new Car { Id = 18, Brand = "Volvo", Model = "S60", HorsePower = 250 },
                new Car { Id = 19, Brand = "Genesis", Model = "G70", HorsePower = 252 },
                new Car { Id = 20, Brand = "Jaguar", Model = "XE", HorsePower = 247 },
                new Car { Id = 21, Brand = "Lincoln", Model = "MKZ", HorsePower = 245 },
                new Car { Id = 22, Brand = "Buick", Model = "Verano", HorsePower = 180 },
                new Car { Id = 23, Brand = "Cadillac", Model = "ATS", HorsePower = 272 },
                new Car { Id = 24, Brand = "Maserati", Model = "Ghibli", HorsePower = 345 },
                new Car { Id = 25, Brand = "Porsche", Model = "Panamera", HorsePower = 325 },
                new Car { Id = 26, Brand = "Ferrari", Model = "Portofino", HorsePower = 591 },
                new Car { Id = 27, Brand = "Lamborghini", Model = "Huracan", HorsePower = 631 },
                new Car { Id = 28, Brand = "McLaren", Model = "570S", HorsePower = 562 },
                new Car { Id = 29, Brand = "Bugatti", Model = "Chiron", HorsePower = 1479 },
                new Car { Id = 30, Brand = "Rolls-Royce", Model = "Phantom", HorsePower = 563 },
                new Car { Id = 31, Brand = "Bentley", Model = "Continental GT", HorsePower = 542 },
                new Car { Id = 32, Brand = "Aston Martin", Model = "DB11", HorsePower = 600 },
                new Car { Id = 33, Brand = "Lotus", Model = "Evora", HorsePower = 416 },
                new Car { Id = 34, Brand = "Alfa Romeo", Model = "Giulia", HorsePower = 280 },
                new Car { Id = 35, Brand = "Renault", Model = "Megane", HorsePower = 118 },
                new Car { Id = 36, Brand = "Peugeot", Model = "308", HorsePower = 131 },
                new Car { Id = 37, Brand = "Citroen", Model = "C4", HorsePower = 108 },
                new Car { Id = 38, Brand = "Dacia", Model = "Sandero", HorsePower = 75 },
                new Car { Id = 39, Brand = "Seat", Model = "Leon", HorsePower = 148 },
                new Car { Id = 40, Brand = "Skoda", Model = "Octavia", HorsePower = 148 },
                new Car { Id = 41, Brand = "Fiat", Model = "Tipo", HorsePower = 118 },
                new Car { Id = 42, Brand = "Opel", Model = "Astra", HorsePower = 128 },
                new Car { Id = 43, Brand = "Mini", Model = "Cooper", HorsePower = 134 },
                new Car { Id = 44, Brand = "Smart", Model = "ForTwo", HorsePower = 89 },
                new Car { Id = 45, Brand = "Dodge", Model = "Charger", HorsePower = 292 },
                new Car { Id = 46, Brand = "Jeep", Model = "Wrangler", HorsePower = 285 },
                new Car { Id = 47, Brand = "Chrysler", Model = "300", HorsePower = 292 },
                new Car { Id = 48, Brand = "Ram", Model = "1500", HorsePower = 305 },
                new Car { Id = 49, Brand = "GMC", Model = "Sierra", HorsePower = 285 },
                new Car { Id = 50, Brand = "Ford", Model = "Fusion", HorsePower = 175 }
            };


        public List<Car> GetAllCars()
        {
            return new List<Car>(cars);
        }

        public Car? GetCarById(int id)
        {
            return cars.FirstOrDefault(c => c.Id == id);
        }

        public void AddCar(Car car)
        {
            car.ValidateId();
            car.ValidateBrand();
            car.ValidateModel();
            car.ValidateHorsePower();

            cars.Add(car);
        }

        public void UpdateCar(Car car)
        {
            car.ValidateId();
            car.ValidateBrand();
            car.ValidateModel();
            car.ValidateHorsePower();

            var existingCar = GetCarById(car.Id);
            if (existingCar == null)
            {
                throw new ArgumentException("Car not found");
            }

            existingCar.Brand = car.Brand;
            existingCar.Model = car.Model;
            existingCar.HorsePower = car.HorsePower;
        }

        public void DeleteCar(int id)
        {
            var existingCar = GetCarById(id);
            if (existingCar == null)
            {
                throw new ArgumentException("Car not found");
            }

            cars.Remove(existingCar);
        }

    }
}
