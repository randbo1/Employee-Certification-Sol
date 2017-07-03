using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using EmpCertDal;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmpCertDalTests
{
    [TestClass]
  public  class CertificateTests
    {
        [TestMethod]
        public   void AddCertTest()
        {
            Certification cert = new Certification();
            cert.CertRenewalDays = 100;
            cert.LeadDays = 100;
            cert.Location = "some location";
            cert.VendorName = "My vendor Name";
            cert.Add(cert);

            var task = GetCertAsync(2);
            task.Wait();
            var result = task.Result;
            result.CertRenewalDays = 2;
 
            cert.Update(result);
        }
        [TestMethod]
        public void GetCertsAsyncTest()
        {
            var task = GetCertsAsync();
            task.Wait();
            var result = task.Result;

            Assert.AreNotEqual(1, result.Count);

        }



        static Task<List<Certification>> GetCertsAsync()
        {
            Certification cert = new Certification();
            var result = cert.GetCertsAsync();
            return result;
        }
        static Task<Certification> GetCertAsync(int certId)
        {
            Certification cert = new Certification();

            var result = cert.GetCertAsync(certId);
            return result;

        }
    }
}
