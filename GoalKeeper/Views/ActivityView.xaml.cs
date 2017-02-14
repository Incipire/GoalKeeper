using GoalKeeper.Models;
using Xamarin.Forms;

namespace GoalKeeper.Views
{
	public partial class ActivityView : ContentPage
	{
		public ActivityView()
		{
			InitializeComponent();
		}

		Activity activity;

		public Activity Activity
		{
			get
			{
				return activity;
			}

			set
			{
				activity = value;
				BindingContext = activity;
			}
		}
	}
}
