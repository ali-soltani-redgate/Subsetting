namespace Subsetting.Domain
{
    public abstract class Entity
    {
        int? _requestedHashCode;
        int _Id;        
        public virtual int Id 
        {
            get
            {
                return _Id;
            }
            protected set
            {
                _Id = value;
            }
        }
    }
}