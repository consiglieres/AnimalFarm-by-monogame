using System;
using System.Threading;
using System.Windows.Forms.VisualStyles;

namespace AnimalFarm;

public class RandomUnit
{
    public static int RandomChicken() 
    {
        var x = new Random();
        var value = x.Next(300, 650);
        Thread.Sleep(500);
        return (value);
    }

    public static void BlackChicken()
    {
        var randomX = new Random();
        var randomY = new Random();
        return;
    }
    
    public static int Cow()
    {
        var x = new Random();
        var value = x.Next(300, 650);
        Thread.Sleep(600);
        return(value);
    }
    
    public static int Goat()
    {
        var x = new Random();
        var value = x.Next(300, 650);
        Thread.Sleep(600);
        return(value);
    }
}