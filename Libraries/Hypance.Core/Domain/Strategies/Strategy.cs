namespace Hypance.Core.Domain.Strategies
{
    public class Strategy : BaseEntity 
    {
        public string Name { get; set; }
        public List<Signal> Signal { get; set; }

    }

}