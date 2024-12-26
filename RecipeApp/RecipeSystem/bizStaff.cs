using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public class bizStaff:bizObject<bizStaff>
    {
        private int _staffid;
        private string _stafffirstname = "";
        private string _stafflastname = "";
        private string _user = "";

        public int StaffId
        {
            get => _staffid;
            set
            {
                if (_staffid != value)
                {
                    _staffid = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string StaffFistName
        {
            get => _stafffirstname;
            set
            {
                if (_stafffirstname != value)
                {
                    _stafffirstname = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string StaffLastName
        {
            get => _stafflastname;
            set
            {
                if (_stafflastname != value)
                {
                    _stafflastname = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string User
        {
            get => _user;
            set
            {
                if (_user != value)
                {
                    _user = value;
                    InvokePropertyChanged();
                }
            }
        }
    }
}
