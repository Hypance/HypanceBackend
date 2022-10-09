namespace Hypance.Core.Domain.Strategies
{
    public class Strategy : BaseEntity 
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Signal> Signals { get; set; }
    }

}