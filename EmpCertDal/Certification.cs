using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;

namespace EmpCertDal
{
    using System.Collections.Generic;

    public class Certification:BaseConnect
    {
        #region "Public Properties"
        public ICollection<EmployeeCertification> EmployeeCerts { get; set; }
 

        public int LeadDays { get; set; }

        public string Location { get; set; }

        public string VendorName { get; set; }

        public int CertRenewalDays { get; set; }
        #endregion

        public void Add(Certification newCert)
        {
            DateTime now = DateTime.Now;
            newCert.CreatedDate = now;
            newCert.ModifiedDate = now;
            cntx.Certifications.Add(newCert);
            cntx.SaveChanges();
           
        }

        public void Update(Certification cert)
        {
            cert.ModifiedDate = DateTime.Now;
            cntx.Certifications.AddOrUpdate(cert);
            cntx.SaveChanges();
        }

        public async Task<List<Certification>> GetCertsAsync()
        {
            var result = await cntx.Certifications.ToListAsync();
            return result;
        }

        public async Task<Certification> GetCertAsync(int i)
        {
            return await cntx.Certifications.FindAsync( i);
        }

    }
}