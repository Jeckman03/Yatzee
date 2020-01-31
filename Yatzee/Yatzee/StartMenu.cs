using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StartMenu
{
    //field
    private string title = "YATZEE";

    //constructor
    public StartMenu()
    {
    }

    //properties
    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    //methods
    public void TitleName()
    {
        Console.WriteLine(Title);
    }
}
