using System.Drawing;
using System.Xml.XPath;

Pizza pizza = new Pizza();
Pizza pizza2 = new Pizza("large",20,10,30);

Console.WriteLine(pizza.toString());
Console.WriteLine(pizza2.toString());

class Pizza {
    private string size; //small, medium, or large
    private int numCheeseTop;
    private int numPepperoniTop;
    private int numHamTop;

    public Pizza(string _size = "medium", int _numCheeseTop = 0, int _numPepperoniTop = 0, int _numHamTop = 0)
    {
        size = _size;
        numCheeseTop = _numCheeseTop;
        numPepperoniTop = _numPepperoniTop;
        numHamTop = _numHamTop;
    }

    public string getSize() { return  size; }
    public int getNumCheeseTop() { return numCheeseTop; }
    public int getNumPepperoniTop() { return numPepperoniTop; }
    public int getNumHamTop() { return numHamTop; }

    public void setSize(string _size) { size = _size; }
    public void setNumCheeseTop(int top) { numCheeseTop = top; }
    public void setNumPepperoniTo(int top) { numPepperoniTop = top; }
    public void setNumHamTop(int top) { numHamTop = top; }

    public double CalculateCost()
    {
        double price = 0.0;
        switch (size)
        {
            case "small":
                price = 10;break;
            case "medium":
                price = 12;break;
            case "large":
                price = 14;break;
            default:
                price = 0;break;
        }
        return price + ((double)numCheeseTop + (double)numPepperoniTop + (double)numHamTop)*2.0;
    }

    public string toString()
    {
        string result = "A " + size + " pizza with " + getNumCheeseTop() + " cheese toppings and " + getNumPepperoniTop() + " pepperoni toppings and " + getNumHamTop() + " ham toppings. totaling $" + CalculateCost() + ".";

        return result;
    }

}