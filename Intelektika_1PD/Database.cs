using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intelektika_1PD
{
    public class Database
    {
        SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=Points.db; Version = 3; New = True; Compress = True; ");
        public List<string> getData()
        {
            sqlite_conn.Open();
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "Select X, Y, Class From Points";
            SQLiteDataReader sQLiteDataReader = sqlite_cmd.ExecuteReader();
            List<string> points = new List<string>();
            while (sQLiteDataReader.Read())
            {
                string X = sQLiteDataReader.GetString(0);
                string Y = sQLiteDataReader.GetString(1);
                string klass = sQLiteDataReader.GetString(2);
                points.Add(X);
                points.Add(Y);
                points.Add(klass);
            }
            sqlite_conn.Close();
            return points;
        }

        public List<string> getDataPoints()
        {
            sqlite_conn.Open();
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "Select X, Y From PointsTo";
            SQLiteDataReader sQLiteDataReader = sqlite_cmd.ExecuteReader();
            List<string> points = new List<string>();
            while (sQLiteDataReader.Read())
            {
                string X = sQLiteDataReader.GetString(0);
                string Y = sQLiteDataReader.GetString(1);
                points.Add(X);
                points.Add(Y);
            }
            sqlite_conn.Close();
            return points;
        }

        public void addToPoints(string X, string Y)
        {
            sqlite_conn.Open();
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "INSERT INTO PointsTo (X, Y) VALUES('" + X + "' ,'" + Y + "'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_conn.Close();
        }

        public void deleteFromPointsTo(string X, string Y)
        {
            sqlite_conn.Open();
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "DELETE FROM PointsTo WHERE X = '" + X + "' AND Y = '" + Y + "'";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_conn.Close();
        }
    }
}
