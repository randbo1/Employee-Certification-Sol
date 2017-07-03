using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpCertDal;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmpCertDalTests
{
    [TestClass]
   public class EquipmentTests
    {
        [TestMethod]
        public void AddEquipmentTest()
        {
            EmpCertDal.Equipment equip = new Equipment();
            Equipment equipAdd = new Equipment();
            equipAdd.Description = "Test Equipment";
            equipAdd.Status = EquipmentStatus.Working;
            equipAdd.PurchaseDate = new DateTime(2017,1,1);


            equipAdd.WarrantyPeriodDays = 750;
            equip.AddEquipment(equipAdd);

            Assert.AreEqual("Under Warranty", equipAdd.WarrantyStatus);

            equip.DeleteEquipment(equipAdd.Id);
        }

        [TestMethod]
        public void TestAddCountEquipment()
        {
            List<int> equIds = new List<int>();
            Equipment eq = new Equipment();
            eq.Description = "testToBeDeleted";
            eq.PurchaseDate = DateTime.Now;
            eq.Status = EquipmentStatus.UnKnown;
            eq.WarrantyPeriodDays = 100;
            
            for (int i = 0; i < 10; i++)
            {
                eq.AddEquipment(eq);
                equIds.Add(eq.Id);
            }
            Assert.AreEqual(equIds.Count,10);
            foreach (int i in equIds)
            {
                eq.DeleteEquipment(i);
            }
        }

      
    }
}
