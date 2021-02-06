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
            sqlite_cmd.CommandText = "Select X, Y, Z, Class From Points";
            SQLiteDataReader sQLiteDataReader = sqlite_cmd.ExecuteReader();
            List<string> points = new List<string>();
            while (sQLiteDataReader.Read())
            {
                string X = sQLiteDataReader.GetString(0);
                string Y = sQLiteDataReader.GetString(1);
                string Z = sQLiteDataReader.GetString(2);
                string klass = sQLiteDataReader.GetString(3);
                points.Add(X);
                points.Add(Y);
                points.Add(Z);
                points.Add(klass);
            }
            sqlite_conn.Close();
            return points;
        }

        public List<string> getDataPoints()
        {
            sqlite_conn.Open();
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "Select X, Y, Z From PointsTo";
            SQLiteDataReader sQLiteDataReader = sqlite_cmd.ExecuteReader();
            List<string> points = new List<string>();
            while (sQLiteDataReader.Read())
            {
                string X = sQLiteDataReader.GetString(0);
                string Y = sQLiteDataReader.GetString(1);
                string Z = sQLiteDataReader.GetString(2);
                points.Add(X);
                points.Add(Y);
                points.Add(Z);
            }
            sqlite_conn.Close();
            return points;
        }

        public void addToPoints(string X, string Y, string Z)
        {
            sqlite_conn.Open();
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "INSERT INTO PointsTo (X, Y, Z) VALUES('" + X + "' ,'" + Y + "','" + Z + "' ); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_conn.Close();
        }

        public void addPoint(string X, string Y, string klass, string Z)
        {
            sqlite_conn.Open();
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "INSERT INTO Points (X, Y, Class, Z) VALUES('" + X + "' ,'" + Y + "','" + klass + "','" + Z + "'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_conn.Close();
        }

        public void deleteFromPointsTo(string X, string Y, string Z)
        {
            sqlite_conn.Open();
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "DELETE FROM PointsTo WHERE X = '" + X + "' AND Y = '" + Y + "' AND Z = '" + Z + "' ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_conn.Close();
        }
    }
}
