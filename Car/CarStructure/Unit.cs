using System.Collections.Generic;
using System.Linq;

namespace Car.CarStructure
{
    public class Unit : Component
    {
        private readonly List<Component> _children = new List<Component>();
        
        public void Add(Component component)
        {
            _children.Add(component);
        }

        public void Remove(Component component)
        {
            _children.Remove(component);
        }

        public override int Weight => Quantity * _children.Sum(child => child.Weight);

        public override string GetInfo(int n = 0)
        {
            var result = base.GetInfo(n);

            n++;
            return _children.Aggregate(result, (current, child) => 
                current + child.GetInfo(n));
        }
    }
}