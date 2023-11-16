using ObjectOrientedPractices.Model.Discounts;

namespace ObjectOrientedPractices.Model
{
    internal interface IDiscount 
    { 
        string Info { get; } 
        double Calculate(List<Item> items); 
        double Apply(List<Item> items); 
        void Update(List<Item> items); 
    }
}
