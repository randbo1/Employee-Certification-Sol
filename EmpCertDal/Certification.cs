using System;

namespace EmpCertDal
{
    using System.Collections.Generic;

    public class Certification:baseConnect
    {
        #region "Public Properties"
        public ICollection<EmployeeCertification> EmployeeCerts { get; set; }

        public int Id { get; set; }

        public int LeadDays { get; set; }

        public string Location { get; set; }

        public string VendorName { get; set; }

        public int CertRenewalDays { get; set; }
        #endregion

        public void Add(Certification newCert)
        {
            cntx.Certifications.Add(newCert);
        }

    }
}