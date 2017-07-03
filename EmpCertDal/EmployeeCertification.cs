using System.Collections.Generic;
using System.Linq;

namespace EmpCertDal
{
    using System;

    public class EmployeeCertification:baseConnect
    { 
     

       
   
        public DateTime CertificationDate { get; set; }

        /// <summary>
        ///     Gets or sets the id.
        /// </summary>
   

        public bool IsValid
        {
            get
            {
                var certTimeSpan = cntx.Certifications.FirstOrDefault(a => a.Id == this.Id).CertRenewalDays;
                DateTime expireDate = this.CertificationDate.AddDays(certTimeSpan);

                if (expireDate > DateTime.Now)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }
    }
}