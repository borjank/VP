namespace VP_project
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.todo_color = new System.Windows.Forms.ComboBox();
            this.todo_add = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.todo_minutes = new System.Windows.Forms.NumericUpDown();
            this.todo_hours = new System.Windows.Forms.NumericUpDown();
            this.todo_date = new System.Windows.Forms.DateTimePicker();
            this.todo_text = new System.Windows.Forms.TextBox();
            this.todo_title = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.show_date = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.completed_checkbox = new System.Windows.Forms.CheckBox();
            this.showButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.todo_minutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todo_hours)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.todo_color);
            this.groupBox1.Controls.Add(this.todo_add);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.todo_minutes);
            this.groupBox1.Controls.Add(this.todo_hours);
            this.groupBox1.Controls.Add(this.todo_date);
            this.groupBox1.Controls.Add(this.todo_text);
            this.groupBox1.Controls.Add(this.todo_title);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // todo_color
            // 
            resources.ApplyResources(this.todo_color, "todo_color");
            this.todo_color.FormattingEnabled = true;
            this.todo_color.Name = "todo_color";
            // 
            // todo_add
            // 
            this.todo_add.BackColor = System.Drawing.Color.LimeGreen;
            resources.ApplyResources(this.todo_add, "todo_add");
            this.todo_add.Name = "todo_add";
            this.todo_add.UseVisualStyleBackColor = false;
            this.todo_add.Click += new System.EventHandler(this.todo_add_Click);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // todo_minutes
            // 
            resources.ApplyResources(this.todo_minutes, "todo_minutes");
            this.todo_minutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.todo_minutes.Name = "todo_minutes";
            // 
            // todo_hours
            // 
            resources.ApplyResources(this.todo_hours, "todo_hours");
            this.todo_hours.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.todo_hours.Name = "todo_hours";
            // 
            // todo_date
            // 
            resources.ApplyResources(this.todo_date, "todo_date");
            this.todo_date.Name = "todo_date";
            // 
            // todo_text
            // 
            resources.ApplyResources(this.todo_text, "todo_text");
            this.todo_text.Name = "todo_text";
            // 
            // todo_title
            // 
            resources.ApplyResources(this.todo_title, "todo_title");
            this.todo_title.Name = "todo_title";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.showButton);
            this.groupBox2.Controls.Add(this.completed_checkbox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.show_date);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // show_date
            // 
            resources.ApplyResources(this.show_date, "show_date");
            this.show_date.Name = "show_date";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // completed_checkbox
            // 
            resources.ApplyResources(this.completed_checkbox, "completed_checkbox");
            this.completed_checkbox.Name = "completed_checkbox";
            this.completed_checkbox.UseVisualStyleBackColor = true;
            this.completed_checkbox.CheckedChanged += new System.EventHandler(this.completed_checkbox_CheckedChanged);
            // 
            // showButton
            // 
            resources.ApplyResources(this.showButton, "showButton");
            this.showButton.Name = "showButton";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.todo_minutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todo_hours)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker todo_date;
        private System.Windows.Forms.TextBox todo_text;
        private System.Windows.Forms.TextBox todo_title;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown todo_minutes;
        private System.Windows.Forms.NumericUpDown todo_hours;
        private System.Windows.Forms.Button todo_add;
        private System.Windows.Forms.ComboBox todo_color;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker show_date;
        private System.Windows.Forms.CheckBox completed_checkbox;
        private System.Windows.Forms.Button showButton;
    }
}

