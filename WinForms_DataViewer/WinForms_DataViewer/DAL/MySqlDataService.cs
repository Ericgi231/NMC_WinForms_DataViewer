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
    class MySqlDataService : IDataService
    {
        public string ConnectionString { get; set; }
        public MySqlDataService()
        {
            ConnectionString = DataSettings.ConnectionString;
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
