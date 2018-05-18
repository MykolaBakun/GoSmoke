using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace GoSmoke
{
	public partial class MainPage : MasterDetailPage
    {
		public MainPage()
		{
			InitializeComponent();

        }
        void ButtonMenu_OnClicked(object sender, EventArgs args)
        {
            this.BackgroundColor = Color.Brown;
        }

    }
}
