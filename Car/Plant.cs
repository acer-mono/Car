using Car.CarStructure;

namespace Car
{
    public class Plant
    {
        private readonly Unit _car;
        public Plant()
        {
            _car = new Unit(){Name = "Car", Quantity = 1};
            var engine = new Unit() {Name = "Engine", Quantity = 1};
            var wheel = new Unit() {Name = "Wheel", Quantity = 4};
            var transmission = new Detail(10) {Name = "Transmission", Quantity = 1};
            var differential = new Unit() {Name = "Differential", Quantity = 2};
            var door = new Unit() {Name = "Door", Quantity = 4};
            var gasTank = new Detail(3) {Name = "Gas tank", Quantity = 1};

            
            _car.Add(engine);
            _car.Add(wheel);
            _car.Add(transmission);
            _car.Add(differential);
            _car.Add(door);
            _car.Add(gasTank);
            
            var pistonSystem = new Unit() {Name = "Piston system", Quantity = 1};
            var valveSystem = new Unit() {Name = "Valve system", Quantity = 1};
            var intakeManifold = new Detail(2) {Name = "intake manifold", Quantity = 1};
            var exhaustManifold = new Detail(2) {Name = "exhaust manifold", Quantity = 2};
            var radiator = new Detail(3) {Name = "Radiator", Quantity = 1};
            
            engine.Add(pistonSystem);
            engine.Add(valveSystem);
            engine.Add(intakeManifold);
            engine.Add(exhaustManifold);
            engine.Add(radiator);
            
            var piston = new Detail(1) {Name = "Piston", Quantity = 4};
            var crankshaft = new Detail(2) {Name = "Crankshaft", Quantity = 1};
            var link = new Detail(4) {Name = "Link", Quantity = 4};
            var gasket = new Detail(5) {Name = "Gasket", Quantity = 1};
            
            pistonSystem.Add(piston);
            pistonSystem.Add(crankshaft);
            pistonSystem.Add(link);
            pistonSystem.Add(gasket);
            
            var value = new Detail(6) {Name = "Value", Quantity = 24};
            var camshaft = new Detail(2) {Name = "Camshaft", Quantity = 2};
            
            valveSystem.Add(value);
            valveSystem.Add(camshaft);
            
            var disk = new Detail(11) {Name = "Disk", Quantity = 1};
            var tire = new Detail(12) {Name = "Tire", Quantity = 1};
            
            wheel.Add(disk);
            wheel.Add(tire);
            
            var glass = new Detail(9) {Name = "Glass", Quantity = 1};
            var doorCard = new Detail(2) {Name = "door card", Quantity = 1};
            
            door.Add(glass);
            door.Add(doorCard);
            
            var gears = new Detail(1) {Name = "gears", Quantity = 5};
            var bearing = new Detail(11) {Name = "bearing", Quantity = 3};
            var shank = new Detail(12) {Name = "shank", Quantity = 1};
            
            differential.Add(gears);
            differential.Add(bearing);
            differential.Add(shank);
        }

        public string GetCarInfo()
        {
            return _car.GetInfo();
        }
    }
}