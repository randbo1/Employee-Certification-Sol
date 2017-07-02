using System;

namespace EmpCertDal
{
    using System.Collections.Generic;

    public class Certification
    {
        public ICollection<EmployeeCertification> EmployeeCerts { get; set; }

        public int Id { get; set; }

        public int LeadDays { get; set; }

        public string Location { get; set; }

        public string VenderName { get; set; }

        public TimeSpan CertRenewalTime { get; set; }
    }
}