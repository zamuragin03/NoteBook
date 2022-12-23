using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBook_
{
    public class WorkingWithDB
    {
        private SQLiteConnection db;
        SQLiteDataReader reader;
        SQLiteCommand command;

        public WorkingWithDB()
        {
            db = new SQLiteConnection("Data Source = Data.db");
            db.Open();
        }

        public void AddData(DataStructure data)
        {
            command = new SQLiteCommand("insert into Note(Note_id,Date,Title,Description,IsDone) values " +
                                        "(@Note_id,@Date,@Title,@Description,@IsDone)", db);
            command.Parameters.AddWithValue("@Note_id", null);
            command.Parameters.AddWithValue("@Date", data.Date.ToShortDateString());
            command.Parameters.AddWithValue("@Title", data.Title);
            command.Parameters.AddWithValue("@Description", data.Description);
            command.Parameters.AddWithValue("@IsDone", data.IsDone);
            command.ExecuteNonQuery();

        }
        public void UpdateDateById(int id, DataStructure data)
        {
            command = new SQLiteCommand("Update Note " +
                                        $"set Date= '{data.Date.ToShortDateString()}'," +
                                        $"Title= '{data.Title}', " +
                                        $"Description = '{data.Description}', " +
                                        $"IsDone = '{data.IsDone}'" +
                                        $"where Note_id= {id}", db);
            command.ExecuteNonQuery();
        }

        public void DeleteById(int id)
        {
            command = new SQLiteCommand($"Delete from Note where Note_id={id}", db);
            command.ExecuteNonQuery();
        }

        public List<string[]> GetData()
        {
            List<string[]> arr = new();
            command = new SQLiteCommand($"select * from Note", db);
            reader = command.ExecuteReader();
            foreach (DbDataRecord el in reader)
            {
                string[] tmp =
                {
                    el["Note_id"].ToString(),
                    el["Date"].ToString(),
                    el["Title"].ToString(),
                    el["Description"].ToString(),
                    el["IsDone"].ToString(),
                };
                arr.Add(tmp);
            }

            return arr;
        }


        public DataStructure GetDataByID(int id)
        {
            command = new SQLiteCommand($"select * from Note where Note_id= '{id}'", db);
            reader = command.ExecuteReader();
            foreach (DbDataRecord el in reader)
            {
                return new DataStructure()
                {
                    Note_id = int.Parse(el["Note_id"].ToString()),
                    Date = DateTime.Parse(el["Date"].ToString()),
                    Title = el["Title"].ToString(),
                    Description = el["Description"].ToString(),
                    IsDone = el["IsDone"].ToString(),
                };

            }

            return new DataStructure();
        }

        public List<string[]> GetDataByDay(DateTime date)
        {
            List<string[]> arr = new();
            command = new SQLiteCommand($"select * from Note where Date='{date.ToShortDateString()}'", db);
            reader = command.ExecuteReader();
            foreach (DbDataRecord el in reader)
            {
                string[] tmp =
                {
                    el["Note_id"].ToString(),
                    el["Date"].ToString(),
                    el["Title"].ToString(),
                    el["Description"].ToString(),
                    el["IsDone"].ToString(),
                };
                arr.Add(tmp);
            }

            return arr;
        }

        public List<(DateTime, int)> GetStat(string month, int year)
        {
            command = new($"select Date, count(Date) from Note " +
                          $"where Date like '__.{month}.{year}' " +
                          $"group by Date", db);
            List<(DateTime, int)> temp = new();
            reader = command.ExecuteReader();
            foreach (DbDataRecord el in reader)
            {
                temp.Add((DateTime.Parse(el["Date"].ToString()), int.Parse(el["count(Date)"].ToString())));
            }

            return temp;
        }
    }
}
