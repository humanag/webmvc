using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public interface IBaseEntity { }

    /// <summary>
    /// Describes an entity.
    /// </summary>
    public interface IEntity<TKey> : IBaseEntity
    {
        [Key]
        TKey Id { get; set; }
    }

    public abstract class BaseEntity : IEntity<long>, IBaseEntity
    {
        [Key]
        public virtual long Id { get; set; }
    }
}
