using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    public class LoaiDT : List<Dienthoai>
    {
        public string TenLoai { get; set; }
        private LoaiDT(string tenLoai)
        {
            TenLoai = tenLoai;
        }
        public IList<LoaiDT> LoaiDTs { get; set; }
        public LoaiDT()
        {
            List < LoaiDT > l = new List<LoaiDT>
            {
                new LoaiDT("Samsung")
                {
                    new Dienthoai {TenDT="Samsung Galaxy A50s", Gia=4500000, Hinh="ss1.jpg", MoTa="Hàng chính hãng, 4GB/64GB, 3 camera"},
                    new Dienthoai {TenDT="Samsung Galaxy Note 10", Gia=21000000, Hinh="ss3.jpg", MoTa="Hàng chính hãng, 6GB/256GB, 3 camera, thiết kế đẹp, lịch lãm"},
                    new Dienthoai {TenDT="Samsung Galaxy S10", Gia=15000000, Hinh="ss2.jpg", MoTa="Hàng chính hãng, 6GB/256GB, 3 camera xuất sắc"}
                },
                new LoaiDT("Iphone")
                {
                    new Dienthoai {TenDT="Iphone 7 plus", Gia=7500000, Hinh="ip1.jpg", MoTa="Hàng chính hãng, 3GB/64GB, HĐH IOS"},
                    new Dienthoai {TenDT="Iphone 11 pro", Gia=29000000, Hinh="ip2.jpg", MoTa="Hàng chính hãng, 4GB/256GB, camera thời thượng"},
                    new Dienthoai {TenDT="Iphone 11 pro max", Gia=45000000, Hinh="ip3.jpg", MoTa="Hàng chính hãng, 4GB/512GB, camera thời thượng, pin trâu"}
                }
            };
        LoaiDTs = l;
        }
    }
}
namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListViewGroup : ContentPage
	{
		public ListViewGroup ()
		{
			InitializeComponent ();
            LoaiDT l = new LoaiDT();
            lstDT.ItemsSource = l.LoaiDTs;
		}
	}
}