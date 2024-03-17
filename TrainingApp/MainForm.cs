using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace TrainingApp
{
    public partial class MainForm : Form
    {
        private List<Workout> workouts = new List<Workout>();

        public MainForm()
        {
            InitializeComponent();
            InitializeComponents();
        }

        private void InitializeComponent()
        {
            
        }

        private void InitializeFromComponents()
        {
           
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = "Training Application";
        }

        private void btnAddWorkout_Click(object sender, EventArgs e)
        {
            try
            {
                string workoutType = txtWorkoutType.Text;
                int repetitions = Convert.ToInt32(txtRepetitions.Text);
                int sets = Convert.ToInt32(txtSets.Text);

                var obj = workouts.FirstOrDefault(x => x.Type == workoutType);
                if (obj == null)
                {
                    workouts.Add(
                        new Workout
                        {
                            Type = workoutType,
                            Repetitions = repetitions,
                            Sets = sets
                        }
                    );

                    string message = $"Added workout: {workoutType}, {repetitions} repetitions, {sets} sets";
                    MessageBox.Show(message, "Workout Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearInputFields();
                }
                else
                {
                    obj.Repetitions += repetitions;
                    obj.Sets += sets;

                    string message = $"Updated workout: {workoutType}, {obj.Repetitions} repetitions, {obj.Sets} sets";
                    MessageBox.Show(message, "Workout Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearInputFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnDisplayWorkouts_Click(object sender, EventArgs e)
        {
            if (workouts.Count == 0)
            {
                MessageBox.Show("No workouts to display.", "Workout List", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string workoutList = "Workout List:\n";
                foreach (var workout in workouts)
                {
                    workoutList += $"{workout.Type}, {workout.Repetitions} repetitions, {workout.Sets} sets\n";
                }

                MessageBox.Show(workoutList, "Workout List", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ClearInputFields()
        {
            txtWorkoutType.Text = "";
            txtRepetitions.Text = "";
            txtSets.Text = "";
        }
        
    }

    public class Workout
    {
        public string Type { get; set; }
        public int Repetitions { get; set; }
        public int Sets { get; set; }
    }
}
