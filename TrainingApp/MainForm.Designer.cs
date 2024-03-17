namespace TrainingApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponents()
{
    this.SuspendLayout();

  
    txtWorkoutType = new System.Windows.Forms.TextBox
    {
        Location = new System.Drawing.Point(50, 30),
        Size = new System.Drawing.Size(300, 30),
        Font = new System.Drawing.Font("Segoe UI", 12F),
        Text = "Enter workout type",
        ForeColor = System.Drawing.Color.Gray,
        BackColor = System.Drawing.Color.White,
        BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    };
    txtWorkoutType.Enter += TextBox_Enter;
    txtWorkoutType.Leave += TextBox_Leave;

    
    txtRepetitions = new System.Windows.Forms.TextBox
    {
        Location = new System.Drawing.Point(50, 70),
        Size = new System.Drawing.Size(300, 30),
        Font = new System.Drawing.Font("Segoe UI", 12F),
        Text = "Enter repetitions",
        ForeColor = System.Drawing.Color.Gray,
        BackColor = System.Drawing.Color.White,
        BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    };
    txtRepetitions.Enter += TextBox_Enter;
    txtRepetitions.Leave += TextBox_Leave;

    
    txtSets = new System.Windows.Forms.TextBox
    {
        Location = new System.Drawing.Point(50, 110),
        Size = new System.Drawing.Size(300, 30),
        Font = new System.Drawing.Font("Segoe UI", 12F),
        Text = "Enter sets",
        ForeColor = System.Drawing.Color.Gray,
        BackColor = System.Drawing.Color.White,
        BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    };
    txtSets.Enter += TextBox_Enter;
    txtSets.Leave += TextBox_Leave;

    
    btnAddWorkout = new System.Windows.Forms.Button
    {
        Text = "Add Workout",
        Location = new System.Drawing.Point(50, 150),
        Size = new System.Drawing.Size(150, 40),
        Font = new System.Drawing.Font("Segoe UI", 12F),
        BackColor = System.Drawing.Color.Green,
        ForeColor = System.Drawing.Color.White,
        FlatStyle = System.Windows.Forms.FlatStyle.Flat
    };
    btnAddWorkout.Click += new System.EventHandler(this.btnAddWorkout_Click);

    
    btnDisplayWorkouts = new System.Windows.Forms.Button
    {
        Text = "Display Workouts",
        Location = new System.Drawing.Point(200, 150),
        Size = new System.Drawing.Size(150, 40),
        Font = new System.Drawing.Font("Segoe UI", 12F),
        BackColor = System.Drawing.Color.SteelBlue,
        ForeColor = System.Drawing.Color.White,
        FlatStyle = System.Windows.Forms.FlatStyle.Flat
    };
    btnDisplayWorkouts.Click += new System.EventHandler(this.btnDisplayWorkouts_Click);

    this.Controls.AddRange(new System.Windows.Forms.Control[] { txtWorkoutType, txtRepetitions, txtSets, btnAddWorkout, btnDisplayWorkouts });

    this.ResumeLayout(false);
}

private void TextBox_Enter(object sender, EventArgs e)
{
    var textBox = (TextBox)sender;
    if (textBox.ForeColor == System.Drawing.Color.Gray)
    {
        textBox.Text = "";
        textBox.ForeColor = System.Drawing.Color.Black;
    }
}

private void TextBox_Leave(object sender, EventArgs e)
{
    var textBox = (TextBox)sender;
    if (string.IsNullOrWhiteSpace(textBox.Text))
    {
        textBox.Text = textBox == txtWorkoutType ? "Enter workout type" : (textBox == txtRepetitions ? "Enter repetitions" : "Enter sets");
        textBox.ForeColor = System.Drawing.Color.Gray;
    }
}


        private System.Windows.Forms.TextBox txtWorkoutType;
        private System.Windows.Forms.TextBox txtRepetitions;
        private System.Windows.Forms.TextBox txtSets;
        private System.Windows.Forms.Button btnAddWorkout;
        private System.Windows.Forms.Button btnDisplayWorkouts;
    }
}
