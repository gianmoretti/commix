using Commix.LocalDatabase;
using Commix.LocalDatabase.LocalTestDatabaseDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static Commix.LocalDatabase.LocalTestDatabaseDataSet;

namespace Commix.Services
{
    class LocalRepository
    {
        //TODO utile per recuperare i report locali in progress
        public static DataRow[] ReadBy(string filter)
        {
            LocalTestTableTableAdapter adapter = new LocalTestTableTableAdapter();
            LocalTestDatabaseDataSet.LocalTestTableDataTable localTestTableDataTable = adapter.GetData();
            return localTestTableDataTable.Select($"Userid = '{filter}'");
        }

        public static void Save(int id, string userId, string title, bool completed)
        {
            LocalTestTableTableAdapter adapter = new LocalTestTableTableAdapter();
            adapter.Insert(id, userId, title, completed);
        }


    }
}
