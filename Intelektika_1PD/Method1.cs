using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intelektika_1PD
{
    public class Method1
    {
        public string calculateData(string X, string Y, string Neib)
        {
            Database database = new Database();
            List<string> pointsData = database.getData();
            List<int> pointsFromDb = new List<int>();
            List<string> plusMinusList = new List<string>();
            for (int i = 0; i<pointsData.Count;i=i+3)
            {
                pointsFromDb.Add(Int32.Parse(pointsData[i]));
                pointsFromDb.Add(Int32.Parse(pointsData[i+1]));
                plusMinusList.Add(pointsData[i + 2]);
            }
            int x = Int32.Parse(X);
            int y = Int32.Parse(Y);
            int neib = Int32.Parse(Neib);
            List<double> results = new List<double>();
            for (int i =0; i<pointsFromDb.Count;i=i+2)
            {
                double res = Math.Sqrt((Math.Pow(x - pointsFromDb[i], 2)) + (Math.Pow(y - pointsFromDb[i+1], 2)));
                results.Add(res);
            }
            List<double> sortedList = results.OrderBy(result => result).ToList();
            List<string> sortedStringList = new List<string>();
            for(int i = 0; i<plusMinusList.Count;i++)
            {
                for (int k = 0; k<sortedList.Count;k++)
                {
                    if (sortedList[k]==results[i])
                    {
                        sortedStringList.Add(sortedList[i].ToString());
                        sortedStringList.Add(plusMinusList[k]);
                        
                    }
                }
            }
            List<string> finalResultList = new List<string>();
            for (int i =0;i<neib;i++)
            {

                finalResultList.Add(sortedList[i].ToString());

            }
            return X;
        }
    }
}
