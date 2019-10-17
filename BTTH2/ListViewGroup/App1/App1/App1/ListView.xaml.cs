using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    public class Dienthoai
    {
        public string TenDT { get; set; }
        public string Hinh { get; set; }
        public double Gia { get; set; }
        public string MoTa { get; set; }
    }
}
namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListView : ContentPage
	{
        ObservableCollection<Dienthoai> Dt = new ObservableCollection<Dienthoai>();
        public ListView ()
		{
			InitializeComponent ();
            Dt.Add(new Dienthoai { TenDT = "Iphone 11 pro", Gia = 30000000, Hinh = "ip2.jpg", MoTa = "Hàng chính hãng, 4GB/256GB, camera thời thượng" });
            Dt.Add(new Dienthoai { TenDT = "Iphone 7 plus", Gia = 7000000, Hinh = "ip1.jpg", MoTa = "Máy chính hãng, 3GB/64GB" });
            Dt.Add(new Dienthoai { TenDT = "Samsung Galaxy Note 10", Gia = 21000000, Hinh = "ss3.jpg", MoTa = "Hàng chính hãng, 6GB/256GB, 3 camera, thiết kế đẹp, lịch lãm" });
            lsvDT.ItemsSource = Dt;
        }
	}
}