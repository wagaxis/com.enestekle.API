using Core.Abstract;

namespace Entity.Domain
{
    public class RandomModel : IEntity   
    {
        public Guid IdWagaxis { get; set; }
        public double Wagaxis { get; set; }
    }
}
