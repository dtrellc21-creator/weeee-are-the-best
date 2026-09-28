namespace done_for_last_time
{
    public partial class MainPage : ContentPage
    {
        // R1: Parallel lists tracking Exercises and Reps
        private readonly List<string> exercises = new List<string>
        {
            "Bench Press", "Squats", "Deadlifts", "Overhead Press", "Barbell Rows",
            "Bicep Curls", "Tricep Pushdowns", "Lateral Raises", "Leg Press", "Calf Raises"
        };

        private readonly List<int> reps = new List<int>
        {
            40, 50, 24, 30, 45,
            48, 50, 60, 40, 75
        };

        public MainPage()
        {
            InitializeComponent();

            // Format numbers onto a display string list inside C# logic
            List<string> formattedRepsList = new List<string>();
            foreach (int repCount in reps)
            {
                formattedRepsList.Add($"{repCount} Reps");
            }

            // Explicitly finding and casting views to bypass auto-generated object errors
            var exercisesView = this.FindByName<CollectionView>("ExercisesCollectionView");
            var repsView = this.FindByName<CollectionView>("RepsCollectionView");

            if (exercisesView != null) exercisesView.ItemsSource = exercises;
            if (repsView != null) repsView.ItemsSource = formattedRepsList;
        }

        // R6 & R7: Event handler marked explicitly with standard signature
        public void OnCalculateTotalClicked(object? sender, EventArgs e)
        {
            int totalReps = 0;

            foreach (int repCount in reps)
            {
                totalReps += repCount;
            }

            // Safely find the label view to resolve missing definitions or null states
            var displayLabel = this.FindByName<Label>("TotalDisplayLabel");
            if (displayLabel != null)
            {
                displayLabel.Text = $"Total Reps: {totalReps}";
            }
        }
    }
}
