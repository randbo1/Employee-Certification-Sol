using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using EmpCertDal;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmpCertDalTests
{
    [TestClass]
   public class EmployeeCertificationTest
    {
        [TestMethod]
        public void AddEmployeeCertificationTest()
        {
            using (var context = new EmployeeCertContext())
            {
                EmployeeCertification cert = new EmployeeCertification()
                {
                    EmployeeId = 2,
                    CertId = 3
                };
                cert.AddCert(cert);
              

            }
               
           
             
        }
        [TestMethod]
        public void TestIsValid()
        {

         EmployeeCertContext cntx = new EmployeeCertContext();

           var mycert = cntx.EmployeeCertifications.FirstOrDefault(a => a.Id == 1);

            Assert.AreEqual(false,mycert.IsValid);


              mycert = cntx.EmployeeCertifications.FirstOrDefault(a => a.Id == 2);

            Assert.AreEqual(true, mycert.IsValid);
        }
    }
}
