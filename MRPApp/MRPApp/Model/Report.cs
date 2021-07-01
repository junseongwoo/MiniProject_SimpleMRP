using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRPApp.Model
{
    public class Report
    {
        // 있는 애들은 복사하면 되는데 
        public int SchIdx { get; set; }
        public string PlantCode { get; set; }
        public Nullable<int> SchAmount { get; set; }
        public System.DateTime PrcDate { get; set; }

        // 가상 테이블은 만들어야한다.
        public Nullable<int> PrcOkAmount { get; set; }
        public Nullable<int> PrcFailAmount { get; set; }

    }
}
