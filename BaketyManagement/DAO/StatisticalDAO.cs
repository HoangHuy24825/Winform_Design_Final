using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaketyManagement.DAO
{
    public class StatisticalDAO
    {
        private StatisticalDAO() { }
        private static StatisticalDAO instance;
        public static StatisticalDAO Instance
        {
            get
            {
                if (StatisticalDAO.instance == null)
                {
                    instance = new StatisticalDAO();
                }
                return instance;
            }
            private set => instance = value;
        }
        public DataTable Revenue7Days(DateTime startDate,DateTime endDate)
        {
            String query = "EXEC STP_StatisticalRevenue7Days @startDate , @endDate";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { startDate, endDate });
        }
        public DataTable TenBestSeller(DateTime startDate, DateTime endDate)
        {
            String query = "EXEC STP_Statistical10BestSeller @startDate , @endDate";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { startDate, endDate });
        }
        public DataTable TenSlowestSeller(DateTime startDate, DateTime endDate)
        {
            String query = "EXEC STP_Statistical10SlowestSeller @startDate , @endDate";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { startDate, endDate });
        }
        public DataTable Revenue3Moths(DateTime startDate, DateTime endDate)
        {
            String query = "EXEC STP_StatisticalRevenue3Months @startDate , @endDate";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { startDate, endDate });
        }
    }
}
