using System;
class ProductEx
{
    string name;
    double price;
    ProductEx(string name, double price)
    {
        this.name = name;
        this.price = price;
    }
    public override string ToString()
    {
        string s = price.ToString();
        return "Product: " + name + " " + s;
    }
}
