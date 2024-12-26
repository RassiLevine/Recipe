using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public class bizCuisine:bizObject<bizCuisine>
    {
        private int _cuisineid;
        private string _cuisinetype = "";

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

        public string CuisineType
        {
            get => _cuisinetype;
            set
            {
                if (_cuisinetype != value)
                {
                    _cuisinetype = value;
                    InvokePropertyChanged();
                }
            }
        }


    }
}
