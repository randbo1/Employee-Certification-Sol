using System.Linq;

namespace EmpCertDal
{
    using System;

    public class EmployeeCertification
    {
        private EmployeeCertContext _cntx;
        private EmployeeCertContext Cntx
        { get {
            if (_cntx == null)
            {
                    _cntx = new EmployeeCertContext();
            }
            return _cntx;
        } }
        public DateTime CertificationDate { get; set; }

        /// <summary>
        ///     Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        public bool IsValid
        {
            get
            {
                var certTimeSpan = Cntx.Certifications.FirstOrDefault(a => a.Id == this.Id).CertRenewalTime;
                DateTime expireDate = this.CertificationDate.Add(certTimeSpan);

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