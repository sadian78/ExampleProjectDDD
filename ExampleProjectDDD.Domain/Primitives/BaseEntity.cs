using ExampleProjectDDD.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProjectDDD.Domain.Primitives
{
    public abstract class BaseEntity
    {
        public BaseId Id { get; private set; }
        protected BaseEntity(BaseId id)
        {
            Id = id;
        }
    }
}
