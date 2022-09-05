using InvestmentApp.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvestmentApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBaFt/QHJqVVhjWlpFdEBBXHxAd1p/VWJYdVt5flBPcDwsT3RfQF9jTnxbdkJjXX5bcXJTTw==;Mgo+DSMBPh8sVXJ0S0R+XE9HcFRDX3xKf0x/TGpQb19xflBPallYVBYiSV9jS3xTcUdrWXhedHVQR2haUQ==;ORg4AjUWIQA/Gnt2VVhiQlFadVlJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxRdkJhUX9ZcHBUQ2FVWUQ=;Njg1OTYwQDMyMzAyZTMyMmUzMGFrbzF3ekx6UFQ2cklDVDlOSmwrQ0xkU0ZVbWorOTVFTGFMYWl5cE9yMkE9;Njg1OTYxQDMyMzAyZTMyMmUzMGlEZWNhZmZSekI4a25mc1JUWlZXRmJwajdkZ1lHZTRlUXp4OUlLY211eVU9;NRAiBiAaIQQuGjN/V0Z+Xk9EaFxEVmJLYVB3WmpQdldgdVRMZVVbQX9PIiBoS35RdEVkW3ded3RRR2VeVkR+;Njg1OTYzQDMyMzAyZTMyMmUzMGZldjA2RUNMa0JMc1VpOTVmRE5EVGFsaXMyTnNxYWlZWmZkYVExbkV5elU9;Njg1OTY0QDMyMzAyZTMyMmUzMEE5MS9MeXlTWldXakQ3cjRuMEl3TlRJZDJ3Z0xaSG1UaHV3aVdGMDgyQUE9;Mgo+DSMBMAY9C3t2VVhiQlFadVlJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxRdkJhUX9ZcHBUQ2NZVUw=;Njg1OTY2QDMyMzAyZTMyMmUzMEwxbDRrUDhXK1RVN21rWTZIbUVDdFhQTWpxY1B3bW4xTk5IU3BCOFBuRmM9;Njg1OTY3QDMyMzAyZTMyMmUzMEFrbFNucmVmTXlNUmxKZUxSVUlDWG1ZUkVhTHRoTUxPN0VTbHVqbHdVU1U9;Njg1OTY4QDMyMzAyZTMyMmUzMGZldjA2RUNMa0JMc1VpOTVmRE5EVGFsaXMyTnNxYWlZWmZkYVExbkV5elU9");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.Investment_App());
        }
    }
}