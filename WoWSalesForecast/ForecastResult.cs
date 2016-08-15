using System;

namespace WoWSalesForecast
{
  public class ForecastResult
  {
    public long SkuId { get; set; }
    public string SkuLabel { get; set; }
    public int[] WeeklySales { get; set; }
    public double Slope { get; set; }
    public double Intercept { get; set; }
    public string Formula { get; set; }
    public int[] ForcastSales { get; set; }
    public int ForcastMonthlySales { get; set; }
  }
}