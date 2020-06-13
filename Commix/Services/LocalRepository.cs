using Commix.Databases;
using Commix.Databases.LocalTestDatabaseDataSetTableAdapters;
using Commix.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Web.UI.MobileControls;

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

        public static void SaveReportByEntity() {
            GeneralModel gm = new GeneralModel();
            Report report = gm.Reports.Create();
            report.stato = "prova";

            report.data_download = DateTime.Now;
            report.data_upload = DateTime.Now;
            report.data_ultimo_salvataggio = DateTime.Now;
            gm.Reports.Add(report);
            gm.SaveChanges();
            
        }

        public static void SaveReportWith(string content)
        {
            GeneralModel gm = new GeneralModel();
            Report report = gm.Reports.Create();
            report.Id = new Random().Next();
            report.stato = "prova";
            report.contenuto = Encoding.ASCII.GetBytes(content);
            report.data_download = DateTime.Now;
            report.data_upload = DateTime.Now;
            report.data_ultimo_salvataggio = DateTime.Now;
            gm.Reports.Add(report);
            gm.SaveChanges();

        }
        
        public static List<Report> ReadAllReports()
        {
            GeneralModel gm = new GeneralModel();
            return gm.Reports.ToList();
        }

        public static TestModel ReadContentById(int id)
        {
            GeneralModel gm = new GeneralModel();
            Report selected = gm.Reports.Find(id);
            string bytesAsString = Encoding.UTF8.GetString(selected.contenuto);
            return JsonConvert.DeserializeObject<TestModel>(bytesAsString);
        }
    }
}
