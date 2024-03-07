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
        string wokroutType = txtWorkoutType.Text;
        int repetitions = Convert.ToInt32(txtRepetitions.Text);
        int sets = Convert.ToInt32(txtSets.Text);
    }
}