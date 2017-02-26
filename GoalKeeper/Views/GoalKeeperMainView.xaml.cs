using System.Collections.Generic;
using GoalKeeper.Models;
using Xamarin.Forms;

namespace GoalKeeper.Views
{
	public partial class GoalKeeperMainView : ContentPage
	{
		private ActivityRepository _activities = ActivityRepository.Instance;

		public GoalKeeperMainView()
		{
			InitializeComponent();
			BindingContext = _activities.GetAll();
		}

		public async void AddActivity(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new ActivityView() { Title = "Add an Activity", Activity = new Activity() });
			BindingContext = _activities.GetAll();
		}
	}
}
