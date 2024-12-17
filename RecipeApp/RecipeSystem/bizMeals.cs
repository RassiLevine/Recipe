using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public class bizMeals:bizObject<bizMeals>
    {
        private int _mealsid;
        private int _staffid;
        private string _mealname = "";
        private bool _active = true;
        private DateTime _datecreated;
        private string _mealpic = "";
        private string _mealsdesc = "";
        private int _totalrecipes;


        public int MealsId
        {
            get => _mealsid;
            set
            {
                if (_mealsid != value)
                {
                    _mealsid = value;
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

        public string MealName
        {
            get => _mealname;
            set
            {
                if (_mealname != value)
                {
                    _mealname = value;
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

        public string MealPic
        {
            get => _mealpic;
            set
            {
                if (_mealpic != value)
                {
                    _mealpic = value;
                    InvokePropertyChanged();
                }
            }
        }



        public string MealsDesc
        {
            get => _mealsdesc;
            set
            {
                if (_mealsdesc != value)
                {
                    _mealsdesc = value;
                    InvokePropertyChanged();
                }
            }
        }
        
        public int TotalRecipes
        {
            get => _totalrecipes;
            set
            {
                if (_totalrecipes != value)
                {
                    _totalrecipes = value;
                    InvokePropertyChanged();
                }
            }
        }


    }
}
