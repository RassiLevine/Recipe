using CPUFramework;
using System.Dynamic;
namespace RecipeSystem
{
    public class bizRecipe: bizObject
    {
        public bizRecipe() 
        {

        }

        private int _recipeid;
        private int _cuisineid;
        private int _staffid;
        private string _recipename = "";
        private int _calories;
        private DateTime _datedraft;
        private DateTime? _datepublished;
        private DateTime? _datearchived;
        private string _recipestatus = "";
        private string _recipepic = "";

        public int RecipeId
        {
            get => _recipeid;
            set
            {
                if(_recipeid != value)
                {
                    _recipeid = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int CuisineId
        {
            get => _cuisineid;
            set
            {
                if (_cuisineid != value)
                {
                    _cuisineid = value;
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

        public string RecipeName
        {
            get => _recipename;
            set
            {
                if(_recipename != value)
                {
                    _recipename = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int Calories
        {
            get => _calories;
            set
            {
                if (_calories != value)
                {
                    _calories = value;
                    InvokePropertyChanged();
                }
            }
        }

        public DateTime DateDraft
        {
            get => _datedraft;
                set
            {
                if (_datedraft != value)
                {
                    _datedraft = value;
                    InvokePropertyChanged();
                }
            }
        }

        public DateTime? DatePublished
        {
            get => _datepublished;
            set
            {
                if (_datepublished != value)
                {
                    _datepublished = value;
                    InvokePropertyChanged();
                }
            }
        }

        public DateTime? DateArchived
        {
            get => _datearchived;
            set
            {
                if (_datearchived != value)
                {
                    _datearchived = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string RecipeStatus
        {
            get => _recipestatus;
            set
            {
                if(_recipestatus != value)
                {
                    _recipestatus = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string RecipePic
        {
            get => _recipepic;
            set
            {
                if (_recipepic != value)
                {
                    _recipepic = value;
                    InvokePropertyChanged();
                }
            }
        }
    }
}
