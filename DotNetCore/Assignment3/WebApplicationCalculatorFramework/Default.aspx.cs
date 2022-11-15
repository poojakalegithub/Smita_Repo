using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationCalculatorFramework
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Add(object sender, EventArgs e)
        {
            int num1=int.Parse(TextBox1.Text);
            int num2 = int.Parse(TextBox2.Text);
            int res=num1 + num2;
            TextBox3.Text = res.ToString();

        }

        protected void Substract(object sender, EventArgs e)
        {
            int num1 = int.Parse(TextBox1.Text);
            int num2 = int.Parse(TextBox2.Text);
            int res = num1 - num2;
            TextBox3.Text = res.ToString();
        }
        protected void Multiply(object sender, EventArgs e)
        {
            int num1 = int.Parse(TextBox1.Text);
            int num2 = int.Parse(TextBox2.Text);
            int res = num1 * num2;
            TextBox3.Text = res.ToString();
        }
        protected void Divide(object sender, EventArgs e)
        {
            int num1 = int.Parse(TextBox1.Text);
            int num2 = int.Parse(TextBox2.Text);
            int res = num1 / num2;
            TextBox3.Text = res.ToString();
        }




    }
}