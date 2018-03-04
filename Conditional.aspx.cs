using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Conditional : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        forecah();
    }

    public void LuckyStatus (int number)
    {
        string result = "";
        //Switch Example
        switch(number)
        {
            case 1:
                {
                    result = "You are Hero";
                    break;
                }
            case 2:
                {
                    result = "You are Lazy";
                    break;
                }
            case 3:
                {
                    result = "You are Good Boy";
                    break;
                }
            case 4:
                {
                    result = "You are Good Boy";
                    break;
                }
            case 5:
                {
                    result = "You are Robot";
                    break;
                }
            default :{
                 result = "You are Human Beaing..";
                    break;
            }
        }
        userStatus.InnerText = result;
    }
    protected void btnStatus_Click(object sender, EventArgs e)
    {

        LuckyStatus(Convert.ToInt32(enterLucky.Text));
    }
    protected void ddlTaxInfo_SelectedIndexChanged(object sender, EventArgs e)
    {
        int money = Convert.ToInt32(ddlTaxInfo.Text);
        //Conditional statements if, else if
        if (money > 0)
        {
            if (money == 1)
            {
                txtPercentage.InnerText = "you Need to Pay 5%";
            }
            else if (money == 2)
            {
                txtPercentage.InnerText = "you Need to Pay 10%";
            }
            else if (money == 3)
            {
                txtPercentage.InnerText = "you Need to Pay 15%";
            }
            else if (money == 4)
            {
                txtPercentage.InnerText = "you Need to Pay 20%";
            }
            else
            {
                txtPercentage.InnerText = "you Need to Pay 30%";
            }
        }

        else
        {
            txtPercentage.InnerText = "Select Any ";
        }
    }

    public void forLoop(int j)
    {
        
        string ptable="";
     for(int i=1; i<=10 ; i++)
     {
         ptable = ptable+j+"*"+i+"="+(i*j)+"<br />";

     }
     forLoop1.InnerHtml = ptable;
    }
    public void whileLoop(int j)
    { 
        if(j<100 && j>0)
        {
            string ptable="";
           while(j>=0)
           {
               ptable = ptable+j + "<br />";
               j = j-1;
           }
           whileLoop1.InnerHtml = ptable;
        }
        else
        {
            dowhile(j);
        }

    }
    protected void getTable_Click(object sender, EventArgs e)
    {
        if(Convert.ToInt32(mTable.Text)>0)
        { 
        forLoop(Convert.ToInt32(mTable.Text));
        }
        else
        {
            forLoop1.InnerHtml = "Enter Number >0";
        }
    }
    protected void btnPrint_Click(object sender, EventArgs e)
    {
        whileLoop(Convert.ToInt32(txtWhile.Text));
    }
    public void dowhile (int j)
    {
       string ptable="";
       do
       {
           ptable = ptable + j + "<br />";
           j=j-1;
       }
       while (j > 100 && j <= 110);
      
       whileLoop1.InnerHtml = ptable;
    }

   public void forecah()
    {
        var values = "";

        int[] a = new int[] {10,20,30,4,5,6};  

        foreach(int element in a)
        { 
        
            values = values +" "+ element;
        }

        aForEach.InnerText = values.ToString();
    }
}