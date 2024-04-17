using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarRestAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRestAPI.Tests
{
    [TestClass()]
    public class CarsRepositoryTests
    {

        CarsRepository _carsRepository = new CarsRepository();


        [TestMethod()]
        public void GetAllCarsTest()
        {
            List<Car> cars = _carsRepository.GetAllCars();
            Assert.IsNotNull(cars);
            Assert.AreEqual(cars[0].Brand, "Ford");
            Assert.AreEqual(50, cars.Count);
            
            var CarsThatStartWithF = cars.Where(c => c.Brand.StartsWith("F"));
            Assert.AreEqual(4, CarsThatStartWithF.Count());

            var CarsWithHorsePowerOver300 = cars.Where(c => c.HorsePower > 300);
            Assert.AreEqual(11, CarsWithHorsePowerOver300.Count());

            var CarsWithHorsePowerBetween200And300 = cars.Where(c => c.HorsePower >= 200 && c.HorsePower <= 300);
            Assert.AreEqual(15, CarsWithHorsePowerBetween200And300.Count());
                
            
        }

        [TestMethod()]
        public void GetCarByIdTest()
        {
            Car? car = _carsRepository.GetCarById(49);
            Assert.IsNotNull(car);
            Assert.AreEqual(car.Brand, "GMC");

        }

        [TestMethod()]
        public void AddCarTest()
        {
            _carsRepository.AddCar(new Car { Id = 51, Brand = "Chevrolet", Model = "Camaro", HorsePower = 275 });
            List<Car> cars = _carsRepository.GetAllCars();
            Assert.AreEqual(51, cars.Count);
            Assert.AreEqual("Chevrolet", cars[50].Brand);
            
        }

        [TestMethod()]
        public void UpdateCarTest()
        {

            Car car = new Car { Id = 51, Brand = "Chevrolet", Model = "Camaro", HorsePower = 275 };
            _carsRepository.AddCar(car);
            car.Brand = "Chevy";
            _carsRepository.UpdateCar(car);
            Car? updatedCar = _carsRepository.GetCarById(51);
            Assert.AreEqual("Chevy", updatedCar?.Brand);
            
        }

        [TestMethod()]
        public void DeleteCarTest()
        {
            _carsRepository.DeleteCar(1);
            List<Car> cars = _carsRepository.GetAllCars();
            Assert.AreEqual(49, cars.Count);
            Assert.IsNull(_carsRepository.GetCarById(1));
            
        }
    }
}