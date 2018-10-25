using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_DataViewer.Data
{
    public static class DataSettings
    {
        //public const string ConnectionString = "server=ericgi231.me;user id=ericgi231;password=Wgi23E1g20;database=data_viewer";
        public const string ConnectionString = "mongodb://Ericgi231:<PASSWORD>@nmc-shard-00-00-q04rl.mongodb.net:27017,nmc-shard-00-01-q04rl.mongodb.net:27017,nmc-shard-00-02-q04rl.mongodb.net:27017/test?ssl=true&replicaSet=NMC-shard-0&authSource=admin&retryWrites=true";
    }
}
