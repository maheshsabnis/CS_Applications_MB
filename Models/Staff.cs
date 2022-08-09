using System;
using System.Collections;
using System.Collections.Generic;
namespace CS_SimpleClass.Models
{
    /// <summary>
    /// Entity Class
    /// </summary>
    public class Staff
    {
        private int _StatffId;
        public int StaffId
        {
            get { return _StatffId; }
            set { _StatffId = value; }
        }
        private string _StaffName;
        public string StaffName
        {
            get { return _StaffName; }
            set { _StaffName = value; }
        }

        private string _Address;
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

        private string _DeptName;
        public string DeptName
        {
            get { return _DeptName; }
            set { _DeptName = value; }
        }

        private string _StaffCategory;
        public string StaffCategory
        {
            get { return _StaffCategory; }
            set { _StaffCategory = value; }
        }

        private decimal _Income;
        public decimal Income
        {
            get { return _Income; }
            set { _Income = value; }
        }
        private decimal _Fees;
        public decimal Fees
        {
            get { return _Fees; }
            set { _Fees = value; }
        }
        private string _Ward;
        public string Ward
        {
            get { return _Ward; }
            set { _Ward = value; }
        }
        private string _Room;
        public string Room
        {
            get { return _Room; }
            set { _Room = value; }
        }
    }

    /// <summary>
    /// Logic Class With Methods
    /// </summary>
    public class StaffLogic
    {
        private ArrayList staffs;

        /// <summary>
        /// This class has a ArrayList as a dependency object
        /// So instantiate that using the Constructor
        /// Explicitly Defined Constructor
        /// </summary>
        public StaffLogic()
        {
            staffs = new ArrayList();
        }


        public ArrayList GetStaffs()
        {
            return staffs;
        }

        /// <summary>
        /// Method accept the Staff Instance and try to add in Data Structure
        /// </summary>
        /// <param name="staff"></param>
        /// <returns></returns>
        public ArrayList Register(Staff staff)
        { 
            staffs.Add(staff);
            return staffs;
        }

        public ArrayList Update(int id,Staff staff)
        {
            // Logic for Update
            return staffs;
        }


        public ArrayList Delete(int id)
        {
            // Logic for Delete
            return staffs;
        }

    }


    public class StaffLogicList
    {
        private List<Staff> staffs;

        /// <summary>
        /// This class has a ArrayList as a dependency object
        /// So instantiate that using the Constructor
        /// Explicitly Defined Constructor
        /// </summary>
        public StaffLogicList()
        {
            staffs = new List<Staff>();
        }


        public List<Staff> GetStaffs()
        {
            return staffs;
        }

        /// <summary>
        /// Method accept the Staff Instance and try to add in Data Structure
        /// </summary>
        /// <param name="staff"></param>
        /// <returns></returns>
        public List<Staff> Register(Staff staff)
        {
            staffs.Add(staff);
            return staffs;
        }

        public List<Staff> Update(int id, Staff staff)
        {
            // Logic for Update
            return staffs;
        }


        public List<Staff> Delete(int id)
        {
            // Logic for Delete
            return staffs;
        }

    }
}

