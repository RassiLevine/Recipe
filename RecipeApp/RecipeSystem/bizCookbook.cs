using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public class bizCookbook:bizObject<bizCookbook>
    {
        private int _cookbookid;
        private int _staffid;
        private string _user;
        private string _cookbookname = "";
        private decimal _price;
        private bool _active = true;
        private DateTime _datecreated;
        private string _cookbookpic= "";
        private int _skilllevel;
        private string _skillleveldescription = "";

        public int CookbookId
        {
            get => _cookbookid;
            set
            {
                if (_cookbookid != value)
                {
                    _cookbookid = value;
                    InvokePropertyChanged();
                }
            }
        }

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

        public string CookbookName
        {
            get => _cookbookname;
            set
            {
                if (_cookbookname != value)
                {
                    _cookbookname = value;
                    InvokePropertyChanged();
                }
            }
        }

        public decimal Price
        {
            get => _price;
            set
            {
                if (_price != value)
                {
                    _price = value;
                    InvokePropertyChanged();
                }
            }
        }


        public bool Active
        {
            get => _active;
            set
            {
                if (_active != value)
                {
                    _active = value;
                    InvokePropertyChanged();
                }
            }
        }

        public DateTime DateCreated
        {
            get => _datecreated;
            set
            {
                if (_datecreated != value)
                {
                    _datecreated = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string CookbookPic
        {
            get => _cookbookpic;
            set
            {
                if (_cookbookpic != value)
                {
                    _cookbookpic = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int SkillLevel
        {
            get => _skilllevel;
            set
            {
                if (_skilllevel != value)
                {
                    _skilllevel = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string SkillLevelDescription
        {
            get => _skillleveldescription;
            set
            {
                if (_skillleveldescription != value)
                {
                    _skillleveldescription = value;
                    InvokePropertyChanged();
                }
            }
        }


    }
}
