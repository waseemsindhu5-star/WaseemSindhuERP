using System.Collections.ObjectModel;
using WaseemSindhuERP.Models;

namespace WaseemSindhuERP.ViewModels;

public class DashboardViewModel
{
    public ObservableCollection<DashboardMetric> Metrics { get; }
        = new()
        {
            new DashboardMetric { Title = "Total Sales", Value = "PKR 1.25M", Trend = "+12.4% vs last month", Accent = "#22C55E" },
            new DashboardMetric { Title = "Purchases", Value = "PKR 820K", Trend = "+7.8%", Accent = "#3B82F6" },
            new DashboardMetric { Title = "Inventory", Value = "1,480 Units", Trend = "Healthy stock", Accent = "#F59E0B" },
            new DashboardMetric { Title = "Profit", Value = "PKR 360K", Trend = "+9.1%", Accent = "#8B5CF6" }
        };
}
