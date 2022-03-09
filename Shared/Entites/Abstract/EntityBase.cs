using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entites.Shared
{
    //Polymorphism için
    public abstract class EntityBase
    {

        public virtual int Id { get; set; }
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;

        public virtual DateTime ModifiedDateTime { get; set; } = DateTime.Now;

        public virtual bool IsDeleted { get; set; } = false; //silindi mi

        public virtual bool IsActive { get; set; } = true;

        public virtual string  CreatedByName { get; set; }

        public virtual string  ModifiedByName { get; set; }

    }
}
