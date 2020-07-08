using System;

namespace BAL.Domain
{
    public interface IBaseDto<Tkey>
    {
        Tkey GetId();
    }

    public abstract class BaseDto<Tkey>: IBaseDto<Tkey>
    {
        public Tkey Id { get; set; }

        public Tkey GetId()
        {
            return Id;
        }
    }
    public abstract class BaseDto : BaseDto<long>
    {

    }
}
