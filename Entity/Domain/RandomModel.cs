using com.enestekle.Core.Abstract;

namespace com.enestekle.Entity.Domain
{
    public class RandomModel : IEntity   
    {
        public Guid IdWagaxis { get; set; }
        public double Wagaxis { get; set; }
    }
}
