using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_TYPED_DATASET.Bussiness
{
    public static class DailyDoingsBLL 
    {
        static DailyDoingsBLL()
        {
        }

        public static Data.MyDataSet.DailyDoingsDataTable GetAllData()
        {
            var adapter =
                new Data.MyDataSetTableAdapters.DailyDoingsTableAdapter();

            var data = adapter.GetData();

            return data;
        }

        public static Data.MyDataSet.DailyDoingsDataTable GetDataByCardNo(long cardNo)
        {
            var adapter =
                new Data.MyDataSetTableAdapters.DailyDoingsTableAdapter();

            var data = 
                adapter.GetDataByCardNo(CardNo: cardNo);

            return data;
        }



    }
}
