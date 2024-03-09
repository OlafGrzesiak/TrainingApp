using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace TrainingApp;

public partial class MainForm : Form
{

    private List<Workout> workouts = new List<Workout>();
    
    private TextBox txtWorkoutType;
    private TextBox txtRepetitions;
    private TextBox txtSets;
    private Button btnAddWorkout;
    private Button btnDisplayWorkouts;
    public MainForm()
    {
        InitializeComponent();
        InitializeComponents();
    }

    private void InitializeComponents()
    {
        txtWorkoutType = new TextBox { Location = new System.Drawing.Point(150, 30), Size = new System.Drawing.Size(200, 20) };
        txtRepetitions = new TextBox { Location = new System.Drawing.Point(150, 70), Size = new System.Drawing.Size(200, 20) };
        txtSets = new TextBox { Location = new System.Drawing.Point(150, 110), Size = new System.Drawing.Size(200, 20) };

        btnAddWorkout = new Button { Text = "Add Workout", Location = new System.Drawing.Point(50, 150) };
        btnAddWorkout.Click += new EventHandler(btnAddWorkout_Click);

        btnDisplayWorkouts = new Button { Text = "Display Workouts", Location = new System.Drawing.Point(200, 150) };
        btnDisplayWorkouts.Click += new EventHandler(btnDisplayWorkouts_Click);

        this.Controls.AddRange(new Control[] { txtWorkoutType, txtRepetitions, txtSets, btnAddWorkout, btnDisplayWorkouts });
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        this.Text = "Training Application";
    }

    private void btnAddWorkout_click(object sender, EventArgs e)
    {
        try
        {
            string wokroutType = txtWorkoutType.Text;
            int repetitions = Convert.ToInt32(txtRepetitions.Text);
            int sets = Convert.ToInt32(txtSets.Text);

            workouts.Add(new Workout { Type = workoutType, Repetitions = repetitions, Sets = sets });

            string message = $"Added workout: {workoutType}, {repetitions} repetitions, {sets} sets";

            ClearInputFields();
        }
        catch (FormatException)
        {
            MessageBox.Show("Invalid input. Please enter numeric values for repetitions and sets.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }

    private void btinDisplayWorkouts_Click(object sender, EventArgs e)
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


}