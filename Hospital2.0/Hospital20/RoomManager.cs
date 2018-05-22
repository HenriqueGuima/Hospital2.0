using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital20
{
    public class RoomManager<R>
    {
        protected IList<R> r_list = new List<R>();

        public virtual void Add(R item) { }
        public virtual void Remove(R item) { }
        //public virtual int Find(R item) { }
    }
}
