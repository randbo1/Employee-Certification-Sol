using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;

namespace EmpCertDal
{
    using System;

    public class EmployeeCertification:BaseConnect
    { 
 

        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }

        public int CertId { get; set; }
        [ForeignKey("CertId")]
        public virtual Certification Cert { get; set; }
         

        public DateTime CertificationDate { get; set; }
 
      public void AddCert(EmployeeCertification newCert)
      {
          DateTime createDate = DateTime.Now;
        
          newCert.CertificationDate = createDate;
          newCert.CreatedDate = createDate;
          newCert.ModifiedDate = createDate;
          cntx.EmployeeCertifications.Add(newCert);
          cntx.SaveChanges();

      }

        public bool IsValid
        {
            get
            {
                var firstOrDefault = cntx.Certifications.FirstOrDefault(a => a.Id == this.Id);
                if (this.CertificationDate.AddDays(Cert.CertRenewalDays) < DateTime.Now)
                {
                    return false;
                }
                else
                {
                    return true;
                }
                
            }
        }
    }
}