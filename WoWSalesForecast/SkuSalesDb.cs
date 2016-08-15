using System;
using System.Collections.Generic;
using CsvHelper;
using System.IO;

namespace WoWSalesForecast
{
  public class SkuSalesDb
  {
    public Dictionary<long, int[]> Sales { get; private set; }
    public Dictionary<long, string> SkuLabels { get; private set; }

    public SkuSalesDb()
    {
      Sales = new Dictionary<long, int[]>();
      SkuLabels = new Dictionary<long, string>();
    }

    public void AddSkuSale(long skuId, int weekNumber, int saleQty)
    {
      if (!Sales.ContainsKey(skuId))
      {
        Sales.Add(skuId, new int[] {-1, -1, -1, -1});
      }
      Sales[skuId][weekNumber] = saleQty;
    }

    public void RemoveInvalidSkus()
    {
      foreach (var skuId in Sales.Keys)
      {
        if (Sales[skuId][0] < 0 || Sales[skuId][1] < 0 || Sales[skuId][2] < 0 || Sales[skuId][3] < 0)
        {
          Sales.Remove(skuId);
        }
      }
    }

    public void AddSkusFromFile(int weekNumber, string filePath)
    {
      if (File.Exists(filePath))
      {
        throw new Exception("File does not exist at specified path");
      }
      if (weekNumber < 0 || weekNumber > 3)
      {
        throw new Exception("Invalid Week specified. Select 0-3 (ie 1-4)");
      }
      try
      {
        using (CsvReader csv = new CsvReader(File.OpenText(filePath)))
        {

        }
      }
      catch (Exception e)
      {

      }
    }
  }
}