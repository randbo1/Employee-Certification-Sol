using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Migrations;
using System.Linq;

namespace EmpCertDal
{
    /// <summary>
    ///     The equipment.
    /// </summary>
    public class Equipment:baseConnect
    {

      
        /// <summary>
        ///     Gets or sets the id.
        /// </summary>
      
        [MaxLength(50)]
        public string Description { get; set; }

        public DateTime PurchaseDate { get; set; }
        public int  WarrantyPeriodDays { get; set; } 
        public EquipmentStatus Status { get; set; }


        public List<Equipment> GetEquipment()
        {
            return cntx.EquipmentList.ToList();
        }

        public Equipment GetEquipment(int id)
        {
            return cntx.EquipmentList.FirstOrDefault(x => x.Id == id);
        }

        public void AddEquipment(Equipment equip)
        {
            DateTime now = DateTime.Now;
            equip.CreatedDate = now;
            equip.ModifiedDate = now;
            cntx.EquipmentList.Add(equip);
            cntx.SaveChanges();
        }

        public void UpdateEquipment(Equipment equip)
        {
            equip.ModifiedDate = DateTime.Now;
            cntx.EquipmentList.AddOrUpdate(equip);
            cntx.SaveChanges();
        }

        public void DeleteEquipment(int equipmentId)
        {
            Equipment eq = cntx.EquipmentList.FirstOrDefault(x => x.Id == equipmentId);
            if (eq != null)
            {
                cntx.EquipmentList.Remove(eq);
                cntx.SaveChanges();
            }
        }

        public string WarrantyStatus
        {
            get
            {
                if (this.PurchaseDate.AddDays(this.WarrantyPeriodDays)   >= System.DateTime.Now)
                {
                    return "Under Warranty";
                }
                else
                {
                    return "Warranty Expired";
                }
            }
        }

    }

    public enum EquipmentStatus
    {
        Working =1,
        InForRepair =2,
        OutOfService =3,
        NotSafe =4,
        UnKnown = -99
    }
}