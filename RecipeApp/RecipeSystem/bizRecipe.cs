using CPUFramework;
using System.Diagnostics;
using System.Dynamic;
namespace RecipeSystem
{
    public class bizRecipe: bizObject<bizRecipe>
    {
        public bizRecipe() 
        {

        }

        private int _recipeid;
        private int _cuisineid;
        private int _staffid;
        private string? _user ="";
        private string _recipename = "";
        private int _calories;
        private DateTime _datedraft;
        private DateTime? _datepublished;
        private DateTime? _datearchived;
        private string _recipestatus = "";
        private string _recipepic = "";
        private string _isvegan ="";
        private int _numingredients;
        public List<bizRecipe> Search(string recipenameval)
        {
            SqlCommand cmd = SQLutility.GetSqlCommand(this.GetSprocName);
            SQLutility.SetParamValue(cmd, "@RecipeName", recipenameval);
            DataTable dt = SQLutility.GetDataTable(cmd);
            return this.GetListFromDatatable(dt);
        }

        public List<bizRecipe> ListRecipeBasedOnCookbook(int cookbookid)
        {
            DataTable dt = Cookbook.LoadCookbookRecipe(cookbookid);
            return GetListFromDatatable(dt);
        }
        public List<bizRecipe> ListRecipeBaseOnCuisine(int cuisineid)
        {
            DataTable dt = Recipe.LoadRecipeByCuisine(cuisineid);
            return GetListFromDatatable(dt);
        }
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

        public string? User
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

        public string isVegan
        {
            get => _isvegan;
            set
            {
                if (_isvegan != value)
                {
                    _isvegan = value;
                    InvokePropertyChanged();
                }
            }

        }

        public int NumIngredients
        {
            get => _numingredients;
            set
            {
                if (_numingredients != value)
                {
                    _numingredients = value;
                    InvokePropertyChanged();
                }
            }
        }

    }
}
