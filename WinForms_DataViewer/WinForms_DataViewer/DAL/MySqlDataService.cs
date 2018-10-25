using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms_DataViewer.Data;
using WinForms_DataViewer.Models;

namespace WinForms_DataViewer.DAL
{
    public class MySqlDataService : IDataService
    {
        static string _connectionString;

        public MySqlDataService()
        {
            _connectionString = DataSettings.ConnectionString;
        }

        public List<Character> ReadAll()
        {
            List<Character> dataSet = new List<Character>();

            

            return dataSet;
        }

        public void WriteAll(List<Character> characters)
        {
            throw new NotImplementedException();
        }
    }
}
