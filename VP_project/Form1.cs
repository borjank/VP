using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_project
{
    public partial class Form1 : Form
    {
        private List<Todo> todo_uncompleted = new List<Todo>();
        private List<Todo> todo_completed = new List<Todo>();
        private List<Panel> todo_panels = new List<Panel>();
        private bool loggedIn = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void validate()
        {
            if (this.textBox1.Text == "test")
            {
                if (this.loggedIn == false)
                {
                    loggedIn = true;
                    panel2.BringToFront();
                }
                else
                {
                    MessageBox.Show("You are already logged in !", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Wrong password !", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public string right_now()
        {
            string result = "";
            result = DateTime.Now.ToString();
            
            return result;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            validate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                validate();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.panel1.BringToFront();
            this.todo_color.Items.Add("WHITE");
            this.todo_color.Items.Add("YELLOW");
            this.todo_color.Items.Add("ORANGE");
            this.todo_color.Items.Add("RED");
            this.todo_color.Items.Add("GREEN");
            this.todo_color.Items.Add("BLUE");
            this.todo_color.Items.Add("PURPLE");
            this.todo_color.SelectedItem = "YELLOW";
        }

        private void todo_add_Click(object sender, EventArgs e)
        {
            string title, text, color;
            title = this.todo_title.Text;
            text = this.todo_text.Text;
            int dd, mm, yy;
            dd = this.todo_date.Value.Day;
            mm = this.todo_date.Value.Month;
            yy = this.todo_date.Value.Year;
            int HH, MM;
            HH = Convert.ToInt32(this.todo_hours.Value);
            MM = Convert.ToInt32(this.todo_minutes.Value);
            color = this.todo_color.SelectedItem.ToString();
            Todo td = new Todo(title, text, dd, mm, yy, HH, MM,color);
            todo_uncompleted.Add(td);
        }
        private void showAllPanels()
        {
            int row = 0, column = 0;
            for (int i = 0; i < this.todo_panels.Count; i++)
            {
                if (this.todo_panels.Count == 1)
                {
                    todo_panels[0].Location = new Point(10, 10);
                    column++;
                }
                else if(this.todo_panels.Count >= 1)
                {
                    if (column == 3)
                    {
                        todo_panels[i].Location = new Point(10 + (column * 310), 10 + (row * 110));
                        column = 0;
                        row++;
                    }
                    else
                    {
                        todo_panels[i].Location = new Point(10 + (column * 310), 10 + (row * 110));
                        column++;
                    }

                }
                else
                {

                }
            }
            for (int i = 0; i < this.todo_panels.Count; i++)
            {
                this.panel2.Controls.Add(todo_panels[i]);
            }
        }

        private void showPanelsByDate(int dd, int mm, int yy)
        {
            this.todo_panels.Clear();
            for(int i = 0; i < this.todo_uncompleted.Count; i++)
            {
                if (this.completed_checkbox.Checked)
                {
                    if (this.todo_completed[i].Day == dd && this.todo_completed[i].Month == mm && this.todo_completed[i].Year == yy)
                    {
                        //generatePanel(this.todo_completed[i]);
                    }
                }
                else
                {
                    if (this.todo_uncompleted[i].Day == dd && this.todo_uncompleted[i].Month == mm && this.todo_uncompleted[i].Year == yy)
                    {
                        generatePanel(this.todo_uncompleted[i]);
                    }
                }
                
            }
            int row = 0, column = 0;
            for (int i = 0; i < this.todo_panels.Count; i++)
            {
                if (this.todo_panels.Count == 1)
                {
                    todo_panels[0].Location = new Point(10, 10);
                    column++;
                }
                else if (this.todo_panels.Count >= 1)
                {
                    if (column == 3)
                    {
                        todo_panels[i].Location = new Point(10 + (column * 310), 10 + (row * 110));
                        column = 0;
                        row++;
                    }
                    else
                    {
                        todo_panels[i].Location = new Point(10 + (column * 310), 10 + (row * 110));
                        column++;
                    }

                }
                else
                {
                    
                }
            }
            
            for (int i = 0; i < this.todo_panels.Count; i++)
            {
                this.panel2.Controls.Add(todo_panels[i]);
            }
        }

        private void generatePanel(Todo todo)
        {
            Button check = new Button();
            Button delete = new Button();
            Label title = new Label();
            Label text = new Label();
            Label date = new Label();
            Label time = new Label();
            Panel p = new Panel();
            //Panel
            p.Size = new Size(300, 100);
            if (todo.Color=="WHITE")
            {
                p.BackColor = Color.White;
                text.ForeColor = Color.Black;
                title.ForeColor = Color.Black;
                date.ForeColor = Color.Black;
                time.ForeColor = Color.Black;
            }
            else if (todo.Color == "YELLOW")
            {
                p.BackColor = Color.Yellow;
                text.ForeColor = Color.Black;
                title.ForeColor = Color.Black;
                date.ForeColor = Color.Black;
                time.ForeColor = Color.Black;
            }
            else if (todo.Color == "ORANGE")
            {
                p.BackColor = Color.Orange;
                text.ForeColor = Color.Black;
                title.ForeColor = Color.Black;
                date.ForeColor = Color.Black;
                time.ForeColor = Color.Black;
            }
            else if (todo.Color == "RED")
            {
                p.BackColor = Color.Red;
                text.ForeColor = Color.White;
                title.ForeColor = Color.White;
                date.ForeColor = Color.White;
                time.ForeColor = Color.White;
            }
            else if (todo.Color == "GREEN")
            {
                p.BackColor = Color.Green;
                text.ForeColor = Color.White;
                title.ForeColor = Color.White;
                date.ForeColor = Color.White;
                time.ForeColor = Color.White;
            }
            else if (todo.Color == "BLUE")
            {
                p.BackColor = Color.Blue;
                text.ForeColor = Color.White;
                title.ForeColor = Color.White;
                date.ForeColor = Color.White;
                time.ForeColor = Color.White;
            }
            else if (todo.Color == "PURPLE")
            {
                p.BackColor = Color.Purple;
                text.ForeColor = Color.White;
                title.ForeColor = Color.White;
                date.ForeColor = Color.White;
                time.ForeColor = Color.White;
            }
            //Title
            title.AutoSize = true;
            title.Location = new Point(5, 5);
            title.Text = todo.Title;
            title.Font = new Font("Microsoft Sans Serif", 16);
            //Text
            text.AutoSize = true;
            text.Location = new Point(7, 30);
            text.Text = todo.Text;
            text.Font = new Font("Microsoft Sans Serif", 12);
            //Date
            date.AutoSize = true;
            date.Location = new Point(7, 55);
            date.Text = todo.Day+"/" +todo.Month +"/" +todo.Year+"    "+todo.Hour+":"+todo.Minute;
            date.Font = new Font("Microsoft Sans Serif", 10);
            //Time
            time.AutoSize = true;
            time.Location = new Point(45, 55);
            time.Text = todo.Hour + ":" + todo.Minute;
            time.Font = new Font("Microsoft Sans Serif", 10);
            //Check
            check.Size = new Size(30, 30);
            check.Location = new Point(220, 60);
            check.Text = "√";
            check.BackColor = Color.Green;
            check.ForeColor = Color.White;
            check.Font = new Font("Microsoft Sans Serif", 14);
            //Delete
            delete.Size = new Size(30, 30);
            delete.Location = new Point(260, 60);
            delete.Text = "×";
            delete.BackColor = Color.Red;
            delete.ForeColor = Color.White;
            delete.Font = new Font("Microsoft Sans Serif", 14);
            //Control
            p.Controls.Add(text);
            p.Controls.Add(title);
            p.Controls.Add(date);
            p.Controls.Add(time);
            p.Controls.Add(check);
            p.Controls.Add(delete);
            this.todo_panels.Add(p);
        }

        private void completed_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.completed_checkbox.Checked)
            {
                this.completed_checkbox.Text = "Show incompleted";
            }
            else
            {
                this.completed_checkbox.Text = "Show completed";
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            showPanelsByDate(this.show_date.Value.Day, this.show_date.Value.Month, this.show_date.Value.Year);
        }
    }
}
