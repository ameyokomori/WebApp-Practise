using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        double result = 0;
        double input1 = 0;
        double input2 = 0;

        Tb_Output_B10.Text = "0";
        Tb_Output_B2.Text = "0";
        Tb_Output_Num0.Text = "0";
        Tb_Output_Num1.Text = "0";

        try
        {
            input1 = Convert.ToDouble(Tb_Input_1.Text);
            input2 = Convert.ToDouble(Tb_Input_2.Text);
        }
        catch (FormatException fe)
        {
            Console.WriteLine("Exception caught: {0}", fe);
            Tb_Input_1.Text = "Wrong input!";
            Tb_Input_2.Text = "Try again!";
        }

        if (DropDownList1.SelectedValue.Equals("+"))
        {
            result = input1 + input2;
        }
        else if (DropDownList1.SelectedValue.Equals("-"))
        {
            result = input1 - input2;
        }
        else if (DropDownList1.SelectedValue.Equals("*"))
        {
            result = input1 * input2;
        }
        else if (DropDownList1.SelectedValue.Equals("/"))
        {
            result = input1 / input2;
        }

        Tb_Output_B10.Text = result.ToString();
        Tb_Output_B2.Text = CalculateBase2(result);

    }

    protected String CalculateBase2(double input)
    {
        int integerNum = (int)input;
        double doubleNum = Math.Abs(input - integerNum);

        if (doubleNum == 0)
        {
            String base2Int = CalculateIntBase2(integerNum);
            return base2Int;
        }
        else
        {
            String base2Int = CalculateIntBase2(integerNum);
            String base2Double = CalculateFloatBase2(doubleNum);
            return base2Int + "." + base2Double;
        }
    }

    protected String CalculateIntBase2(int input)
    {
        return Convert.ToString(input, 2);
    }

    protected String CalculateFloatBase2(double input)
    {
        input *= 2;

        return (input == 1) ? "1" : (((int)input).ToString() + CalculateFloatBase2(input - (int)input));
    }
    
    protected void Button2_Click(object sender, EventArgs e)
    {
        Tb_Output_Num0.Text = (Tb_Output_B2.Text.Split('0').Length - 1).ToString();
        Tb_Output_Num1.Text = (Tb_Output_B2.Text.Split('1').Length - 1).ToString();
    }
}