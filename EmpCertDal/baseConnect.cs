using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpCertDal
{
    public class baseConnect : IDisposable
    {
        private EmployeeCertContext _cntx;

        internal EmployeeCertContext cntx
        {
            get
            {
                if (_cntx == null)
                {
                    _cntx = new EmployeeCertContext();
                }
                return _cntx;
            }
        }


        public void Dispose()
        {
         
        }
    }
}
