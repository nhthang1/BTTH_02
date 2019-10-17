using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public class hoa
    {
        public string TenHoa { get; set; }
        public string Hinh  { get; set; }
        public Double Gia  { get; set; }
        public string MoTa { get; set; }

    }
    public partial class PageListViewHoa : ContentPage
    {
        ObservableCollection<hoa> Hoas = new ObservableCollection<hoa>();
        public PageListViewHoa()
        {
            InitializeComponent();
            Hoas.Add(new hoa { TenHoa = "Đón xuân", Gia = 50000, Hinh = "hoa1.jpg", MoTa = "hoa 1" });
            Hoas.Add(new hoa { TenHoa = "Đón xuân", Gia = 50000, Hinh = "hoa1.jpg", MoTa = "hoa 1" });
            Hoas.Add(new hoa { TenHoa = "Đón xuân", Gia = 50000, Hinh = "hoa1.jpg", MoTa = "hoa 1" });
            lsvHoa.ItemsSource = Hoas;
        }
    }
}