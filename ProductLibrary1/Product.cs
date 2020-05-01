using System;
public class Product
{
    private string name;
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException(
                "Name cannot be null or empty string",
                "Name");
            }
            name = value;
        }
    }
}

