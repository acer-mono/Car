namespace Car.CarStructure
{
    public abstract class Component
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public abstract int Weight { get; }

        public virtual string GetInfo(int n = 0)
        {
            return $"{new string('\t', n)}Name: {Name}\n" +
                   $"{new string('\t', n)}Quantity: {Quantity}\n" +
                   $"{new string('\t', n)}Weight: {Weight}\n" +
                   $"{new string('\t', n)}{new string('_', n)}\n";
        }
    }
}