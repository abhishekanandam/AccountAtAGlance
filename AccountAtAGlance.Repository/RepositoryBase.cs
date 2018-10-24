using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountAtAGlance.Repository
{
    public class RepositoryBase<C> : IDisposable where C : DbContext, new()
    {
        private C _DataContext;

        public bool AllowSerialization
        {
            get
            {
                return _DataContext.Configuration.ProxyCreationEnabled;
            }
            set
            {
                _DataContext.Configuration.ProxyCreationEnabled = !value;
            }
        }

        public virtual C DataContext
        {
            get
            {
                if(_DataContext == null)
                {
                    _DataContext = new C();
                    this.AllowSerialization = true;
                }
                return _DataContext;
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
