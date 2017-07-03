using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpCertDal;

namespace CertificateConsTest
{
    class Program
    {
        static  void Main(string[] args)
        {
            Task < Certification > task  = GetCertAsync(2);

            task.Wait();

            var x = task.Result;

          Console.WriteLine(x.LeadDays);
            Console.ReadLine();

               
        }

        static Task<Certification> GetCertAsync(int certId)
        {
            Certification cert = new Certification();

           var result = cert.GetCertAsync(certId) ;
          return  result ;

        }
    }
}
