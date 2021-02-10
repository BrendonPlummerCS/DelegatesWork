using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegates
{
    public partial class Form1 : Form
    {
        public delegate void MyDelegate(string inputString);     //Initialise Delegate

        public class Observer  //Class that handles Delegates
        {
            private List<MyDelegate> delegateList = new List<MyDelegate>(); //Holds a <private> list of delegates

            public void RegisterDelegate(MyDelegate InputDelegate)
            {
                delegateList.Add(InputDelegate); //Adds delegates to the list
            }

            public void Notify(string inputString)
            {
                foreach(MyDelegate delegates in delegateList)
                {
                    delegates(inputString); //Invokes each delegate in the list with the InputString
                }
            }
        }


        Observer OnButtonCLick = new Observer(); 

        public Form1()
        {
            InitializeComponent();
            OnButtonCLick.RegisterDelegate(UpdateLabel);
            OnButtonCLick.RegisterDelegate(UpdateOtherLabel);
        }

        private void UpdateLabel(string inputString)
        {
            lbl_ScreenLabel.Text = inputString;
        }
        private void UpdateOtherLabel(string inputString)
        {
            lbl_ScreenLabel2.Text = inputString;
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            OnButtonCLick.Notify(txtBox_TextDisplay.Text);
        }


    }
}






#region Questions 1 & 2

/*public delegate void MyDelegate(string args);   //Create Delegate
public delegate void MyOtherDelegate(string args);


public MyDelegate myDelegate = null;            //Initialise Delegate
public MyOtherDelegate myOtherDelegate = null;

public Form1()
{
    InitializeComponent();
    myDelegate = new MyDelegate(UpdateLabel);           //Creates new instance of delegate, assigned to 'UpdateLabel' method
    myOtherDelegate = new MyOtherDelegate(UpdateOtherLabel);
}

private void UpdateLabel(string inputString)
{
    lbl_ScreenLabel.Text = inputString;
}
private void UpdateOtherLabel(string inputString)
{
    lbl_ScreenLabel2.Text = inputString;
}

private void ButtonClick(object sender, EventArgs e)
{
    myDelegate(txtBox_TextDisplay.Text);
    myOtherDelegate(txtBox_TextDisplay.Text + " I say.");
}*/

#endregion
