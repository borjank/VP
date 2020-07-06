using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_project
{
    class Todo
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public int Hour { get; set; }
        public int Minute { get; set; }
        public string Color { get; set; }
        public bool Completed { get; set; }
        public Todo()
        {
            
        }
        public Todo(string title, string text, int d, int m, int y, int H, int M, string color)
        {
            this.Title = title;
            this.Text = text;
            this.Day = d;
            this.Month = m;
            this.Year = y;
            this.Hour = H;
            this.Minute = M;
            this.Color = color;
            this.Completed = false;
        }
    }
}
