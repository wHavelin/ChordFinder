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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ChordType = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ChordDisplay = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.StartingString = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ChordDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // RootNote
            // 
            this.RootNote.AccessibleName = "Root Note";
            this.RootNote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RootNote.FormattingEnabled = true;
            this.RootNote.Items.AddRange(new object[] {
            "Any Note",
            "A",
            "A#/Bb",
            "B",
            "C",
            "C#/Db",
            "D",
            "D#/Eb",
            "E",
            "F",
            "F#/Gb",
            "G",
            "G#/Ab"});
            this.RootNote.Location = new System.Drawing.Point(13, 25);
            this.RootNote.Name = "RootNote";
            this.RootNote.Size = new System.Drawing.Size(121, 21);
            this.RootNote.TabIndex = 0;
            this.RootNote.SelectedIndexChanged += new System.EventHandler(this.RootNote_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Root Note";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chord Type";
            // 
            // ChordType
            // 
            this.ChordType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChordType.FormattingEnabled = true;
            this.ChordType.Items.AddRange(new object[] {
            "Any Type",
            "Major",
            "Minor"});
            this.ChordType.Location = new System.Drawing.Point(13, 71);
            this.ChordType.Name = "ChordType";
            this.ChordType.Size = new System.Drawing.Size(121, 21);
            this.ChordType.TabIndex = 3;
            this.ChordType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Generate Chord";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.generateChord);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Current Chord";
            // 
            // ChordDisplay
            // 
            this.ChordDisplay.Image = ((System.Drawing.Image)(resources.GetObject("ChordDisplay.Image")));
            this.ChordDisplay.Location = new System.Drawing.Point(160, 91);
            this.ChordDisplay.Name = "ChordDisplay";
            this.ChordDisplay.Size = new System.Drawing.Size(195, 159);
            this.ChordDisplay.TabIndex = 7;
            this.ChordDisplay.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Starting String";
            // 
            // StartingString
            // 
            this.StartingString.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StartingString.FormattingEnabled = true;
            this.StartingString.Items.AddRange(new object[] {
            "Any String",
            "Low E",
            "A",
            "D",
            "G",
            "B",
            "High E"});
            this.StartingString.Location = new System.Drawing.Point(13, 117);
            this.StartingString.Name = "StartingString";
            this.StartingString.Size = new System.Drawing.Size(121, 21);
            this.StartingString.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 262);
            this.Controls.Add(this.StartingString);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ChordDisplay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ChordType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RootNote);
            this.Name = "Form1";
            this.Text = "Chord Library";
            ((System.ComponentModel.ISupportInitialize)(this.ChordDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox RootNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ChordType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox ChordDisplay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox StartingString;

    }
}

