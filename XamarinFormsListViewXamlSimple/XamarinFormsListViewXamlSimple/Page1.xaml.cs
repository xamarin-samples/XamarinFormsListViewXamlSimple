using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinFormsListViewXamlSimple
{
	public partial class Page1 : ContentPage
	{
		public Page1()
		{
			InitializeComponent();

			// Make string list
			List<string> list = new List<string>();
			for(int i = 0; i < 20; i++)
			{
				list.Add(string.Format("item-{0}", i));
			}

			// Bind
			this.BindingContext = list;
		}
	}
}
