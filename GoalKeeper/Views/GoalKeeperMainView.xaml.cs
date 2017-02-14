using System.Collections.Generic;
using GoalKeeper.Models;
using Xamarin.Forms;

namespace GoalKeeper.Views
{
	public partial class GoalKeeperMainView : ContentPage
	{
		//TODO: Pull the activity list into persistent storage.
		List<Activity> activities = new List<Activity>
			{
				new Activity{Id=1, Title = "Activity1", Description = "I am the first activity"},
				new Activity{Id = 2, Title = "Activity2", Description = "I am the second activity"}
			};

		public GoalKeeperMainView()
		{
			InitializeComponent();
			BindingContext = activities;
		}

		public async void AddActivity(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new ActivityView() { Title = "Add an Activity", Activity = new Activity() });
		}
	}
}
