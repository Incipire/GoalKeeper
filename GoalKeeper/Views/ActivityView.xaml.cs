using System;
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

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			if (string.IsNullOrEmpty(activity.Title) || string.IsNullOrEmpty(activity.Description))
			{
				return;
			}
			ActivityRepository.Instance.Add(activity);
			Navigation.PopAsync();
		}
	}
}
