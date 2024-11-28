using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public class bizIngredients:bizObject<bizIngredients>
    {
        private int _ingredientsid;
        private string _ingredientname = "";
        private string _ingpic = "";

        public List<bizIngredients> Search(string ingredientnameval)
        {
            SqlCommand cmd = SQLutility.GetSqlCommand(this.GetSprocName);
            SQLutility.SetParamValue(cmd, "@IngredientName", ingredientnameval);
            DataTable dt = SQLutility.GetDataTable(cmd);
            return this.GetListFromDatatable(dt);
        }
        public int IngredientsId { get=> _ingredientsid;
            set
            {
                if (_ingredientsid != value)
                {
                    _ingredientsid = value;
                    InvokePropertyChanged();
                }
            }
            }

        public string IngredientName
        {
            get => _ingredientname;
            set
            {
                if (_ingredientname != value)
                {
                    _ingredientname = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string IngPic
        {
            get => _ingpic;
            set
            {
                if (_ingpic != value)
                {
                    _ingpic = value;
                    InvokePropertyChanged();
                }
            }
        }
    }
}
