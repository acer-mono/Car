namespace Car.CarStructure
{
    public class Detail : Component
    {
        private readonly int _weight;

        public Detail(int weight)
        {
            _weight = weight;
        }

        public override int Weight => Quantity * _weight;
    }
}