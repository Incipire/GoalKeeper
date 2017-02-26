using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using GoalKeeper.Models;

namespace GoalKeeper
{
	public class ActivityRepository
	{
		public static ActivityRepository Instance { get; private set; }

		static ActivityRepository()
		{
			Instance = new ActivityRepository();
		}

		private ActivityRepository()
		{
		}

		readonly ObservableCollection<Activity> _activities =
			new ObservableCollection<Activity>
			{
				new Activity{Id=1, Title = "Activity1", Description = "I am the first activity from the repository"},
				new Activity{Id = 2, Title = "Activity2", Description = "I am the second activity"}
			};

		public IEnumerable<Activity> GetAll()
		{
			return _activities;
		}

		public void Add(Activity item)
		{
			_activities.Add(item);
		}
	}
}
