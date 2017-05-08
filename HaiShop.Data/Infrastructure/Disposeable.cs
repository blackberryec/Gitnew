using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaiShop.Data.Infrastructure
{
    public class Disposeable : IDisposable //interface cho phep nhung class ke thuwa tu động hủy
    {
        public bool isDisposed;

        ~Disposeable()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if(!isDisposed && disposing)
            {
                DisposeCore();
            }
            isDisposed = true;
        }

        //Overide this to dispose custom objects
        protected virtual void DisposeCore()
        {

        }
    }
}
