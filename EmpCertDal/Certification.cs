using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpCertDal
{
    public class Certification
    {
        public int Id { get; set; }
        public int LeadDays { get; set; }
        public string VenderName { get; set; }
        public string  Location { get; set; }

        public ICollection<EmployeeCertification> EmployeeCerts { get; set; }
    
    }
}
