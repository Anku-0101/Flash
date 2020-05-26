this is text

using System;

Class Solution 
{
    Static Void Main()
    {
        
    }

    public int multiplication(int x, int y)
    {
        return x*y;
    }
    
    public int Add(int x, int y)
    {
        pass;
    }
    
    public int Subtraction(int x, int y)
    {
        return x-y;
    }
    
    public int Divison(int x, int y)
    {
        return x/y;
    }

    public int sign(int x, int y)
    {
        int k = x- y;
        if(k > 0)return 1;
        else if(k < 0) return -1;
        else return 0;
    }

    public float random(int x, int y)
    {
        return (x/y)*(x-y);
    }

}