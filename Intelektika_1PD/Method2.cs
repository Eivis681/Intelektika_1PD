using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intelektika_1PD
{
    public class Method2
    {
        public List<Data> calculateData(string X, string Y, string Neib)
        {
            Database database = new Database();
            List<string> pointsData = database.getData();
            List<int> pointsFromDb = new List<int>();
            List<string> plusMinusList = new List<string>();
            for (int i = 0; i < pointsData.Count; i = i + 3)
            {
                pointsFromDb.Add(Int32.Parse(pointsData[i]));
                pointsFromDb.Add(Int32.Parse(pointsData[i + 1]));
                plusMinusList.Add(pointsData[i + 2]);
            }
            int x = Int32.Parse(X);
            int y = Int32.Parse(Y);
            int neib = Int32.Parse(Neib);
            List<double> results = new List<double>();
            for (int i = 0; i < pointsFromDb.Count; i = i + 2)
            {
                double firs = Math.Abs( x - pointsFromDb[i]);
                double second =Math.Abs( y - pointsFromDb[i + 1]);
                if (firs > second)
                {
                    results.Add(firs);
                }
                else results.Add(second);
            }
            List<Item> items = new List<Item>();
            for (int i = 0; i < plusMinusList.Count; i++)
            {
                items.Add(new Item { result = results[i], klass = plusMinusList[i] });
            }
            List<Item> sortedItemList = items.OrderBy(o => o.result).ToList();
            List<Item> asdasdasd = sortedItemList;
            for (int i = 0; i < sortedItemList.Count; i++)
            {
                if (i == sortedItemList.Count - 1)
                {
                    
                }
                else if (sortedItemList[i].result == sortedItemList[i + 1].result)
                {
                    if (sortedItemList[i].klass != sortedItemList[i + 1].klass)
                    {
                        if (neib > i)
                        {
                            neib = neib - 1;
                        }
                        sortedItemList.RemoveAt(i);
                        sortedItemList.RemoveAt(i);
                        sortedItemList.Add(new Item { result = 0, klass = "asd" });
                        i = -1;
                    }
                }
            }
            int plustCount = 0;
            int minusCount = 0;
            for (int i = 0; i < neib; i++)
            {
                if (sortedItemList[i].klass == "+")
                {
                    plustCount++;
                }
                else if (sortedItemList[i].klass == "-")
                {
                    minusCount++;
                }
            }
            List<Data> finalResult = new List<Data>();
            if (plustCount == minusCount)
            {
                finalResult.Add(new Data { X = x, Y = y, klass = "no" });
            }
            else if (plustCount > minusCount)
            {
                finalResult.Add(new Data { X = x, Y = y, klass = "+" });
            }
            else if (plustCount < minusCount)
            {
                finalResult.Add(new Data { X = x, Y = y, klass = "-" });
            }
              return finalResult;
        }
    }
}
