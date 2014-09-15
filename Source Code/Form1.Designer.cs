namespace WindowsFormsApplication4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RootNote = new System.Windows.Forms.ComboBox();
            this.RootNoteLabel = new System.Windows.Forms.Label();
            this.ChordTypeLabel = new System.Windows.Forms.Label();
            this.ChordType = new System.Windows.Forms.ComboBox();
            this.GenerateChordButton = new System.Windows.Forms.Button();
            this.CurrentChordLabel = new System.Windows.Forms.Label();
            this.ChordDisplay = new System.Windows.Forms.PictureBox();
            this.CurrentRoot = new System.Windows.Forms.Label();
            this.CurrentType = new System.Windows.Forms.Label();
            this.fret = new System.Windows.Forms.Label();
            this.StartingFret = new System.Windows.Forms.Label();
            this.IncrementTuning = new System.Windows.Forms.NumericUpDown();
            this.Tuning = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ChordDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncrementTuning)).BeginInit();
            this.SuspendLayout();
            // 
            // RootNote
            // 
            resources.ApplyResources(this.RootNote, "RootNote");
            this.RootNote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RootNote.FormattingEnabled = true;
            this.RootNote.Items.AddRange(new object[] {
            resources.GetString("RootNote.Items"),
            resources.GetString("RootNote.Items1"),
            resources.GetString("RootNote.Items2"),
            resources.GetString("RootNote.Items3"),
            resources.GetString("RootNote.Items4"),
            resources.GetString("RootNote.Items5"),
            resources.GetString("RootNote.Items6"),
            resources.GetString("RootNote.Items7"),
            resources.GetString("RootNote.Items8"),
            resources.GetString("RootNote.Items9"),
            resources.GetString("RootNote.Items10"),
            resources.GetString("RootNote.Items11"),
            resources.GetString("RootNote.Items12")});
            this.RootNote.Name = "RootNote";
            this.RootNote.SelectedIndexChanged += new System.EventHandler(this.RootNote_SelectedIndexChanged);
            // 
            // RootNoteLabel
            // 
            resources.ApplyResources(this.RootNoteLabel, "RootNoteLabel");
            this.RootNoteLabel.Name = "RootNoteLabel";
            // 
            // ChordTypeLabel
            // 
            resources.ApplyResources(this.ChordTypeLabel, "ChordTypeLabel");
            this.ChordTypeLabel.Name = "ChordTypeLabel";
            // 
            // ChordType
            // 
            this.ChordType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChordType.FormattingEnabled = true;
            this.ChordType.Items.AddRange(new object[] {
            resources.GetString("ChordType.Items"),
            resources.GetString("ChordType.Items1"),
            resources.GetString("ChordType.Items2")});
            resources.ApplyResources(this.ChordType, "ChordType");
            this.ChordType.Name = "ChordType";
            this.ChordType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // GenerateChordButton
            // 
            resources.ApplyResources(this.GenerateChordButton, "GenerateChordButton");
            this.GenerateChordButton.Name = "GenerateChordButton";
            this.GenerateChordButton.UseVisualStyleBackColor = true;
            this.GenerateChordButton.Click += new System.EventHandler(this.generateChord);
            // 
            // CurrentChordLabel
            // 
            resources.ApplyResources(this.CurrentChordLabel, "CurrentChordLabel");
            this.CurrentChordLabel.Name = "CurrentChordLabel";
            // 
            // ChordDisplay
            // 
            resources.ApplyResources(this.ChordDisplay, "ChordDisplay");
            this.ChordDisplay.Name = "ChordDisplay";
            this.ChordDisplay.TabStop = false;
            // 
            // CurrentRoot
            // 
            resources.ApplyResources(this.CurrentRoot, "CurrentRoot");
            this.CurrentRoot.Name = "CurrentRoot";
            // 
            // CurrentType
            // 
            resources.ApplyResources(this.CurrentType, "CurrentType");
            this.CurrentType.Name = "CurrentType";
            // 
            // fret
            // 
            resources.ApplyResources(this.fret, "fret");
            this.fret.Name = "fret";
            // 
            // StartingFret
            // 
            resources.ApplyResources(this.StartingFret, "StartingFret");
            this.StartingFret.Name = "StartingFret";
            // 
            // IncrementTuning
            // 
            resources.ApplyResources(this.IncrementTuning, "IncrementTuning");
            this.IncrementTuning.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.IncrementTuning.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.IncrementTuning.Name = "IncrementTuning";
            // 
            // Tuning
            // 
            resources.ApplyResources(this.Tuning, "Tuning");
            this.Tuning.Name = "Tuning";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Controls.Add(this.Tuning);
            this.Controls.Add(this.IncrementTuning);
            this.Controls.Add(this.StartingFret);
            this.Controls.Add(this.fret);
            this.Controls.Add(this.CurrentType);
            this.Controls.Add(this.CurrentRoot);
            this.Controls.Add(this.ChordDisplay);
            this.Controls.Add(this.CurrentChordLabel);
            this.Controls.Add(this.GenerateChordButton);
            this.Controls.Add(this.ChordType);
            this.Controls.Add(this.ChordTypeLabel);
            this.Controls.Add(this.RootNoteLabel);
            this.Controls.Add(this.RootNote);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ChordDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncrementTuning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox RootNote;
        private System.Windows.Forms.Label RootNoteLabel;
        private System.Windows.Forms.Label ChordTypeLabel;
        private System.Windows.Forms.ComboBox ChordType;
        private System.Windows.Forms.Button GenerateChordButton;
        private System.Windows.Forms.Label CurrentChordLabel;
        private System.Windows.Forms.PictureBox ChordDisplay;
        private System.Windows.Forms.Label CurrentRoot;
        private System.Windows.Forms.Label CurrentType;
        private System.Windows.Forms.Label fret;
        private System.Windows.Forms.Label StartingFret;
        private System.Windows.Forms.NumericUpDown IncrementTuning;
        private System.Windows.Forms.Label Tuning;

    }
}

