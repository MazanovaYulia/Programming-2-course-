//parabola method
using System;
 
public class ParabolaMethod
{
 
    // Function to calculate f(x)
    static float func(float x)
    {
        return (float)Math.Log(x);
    }
 
    // Function for approximate integral
    static float simpsons_(float ll, float ul,
                                        int n)
    {
        // Calculating the value of h
        float h = (ul - ll) / n;
 
        // Array for storing value of x
        // and f(x)
        float[] x = new float[10];
        float[] fx= new float[10];
 
        // Calculating values of x and f(x)
        for (int i = 0; i <= n; i++) {
            x[i] = ll + i * h;
            fx[i] = func(x[i]);
        }
 
        // Calculating result
        float res = 0;
        for (int i = 0; i <= n; i++) {
            if (i == 0 || i == n)
                res += fx[i];
            else if (i % 2 != 0)
                res += 4 * fx[i];
            else
                res += 2 * fx[i];
        }
         
        res = res * (h / 3);
        return res;
    }
 
    // Driver Code
    public static void Main()
    {
        // Lower limit
        float lower_limit = 4;
         
        // Upper limit
        float upper_limit = (float)5.2;
         
        // Number of interval
        int n = 6;
         
        Console.WriteLine(simpsons_(lower_limit,
                                upper_limit, n));
    }
}

//method of trapezoids
class MethodTrapezoids {
     
    // A sample function whose definite
    // integral's approximate value
    // is computed using Trapezoidal
    // rule
    static float y(float x)
    {
         
        // Declaring the function
        // f(x) = 1/(1+x*x)
        return 1 / (1 + x * x);
    }
     
    // Function to evaluate the value
    // of integral
    static float trapezoidal(float a,
                       float b, float n)
    {
         
        // Grid spacing
        float h = (b - a) / n;
     
        // Computing sum of first and
        // last terms in above formula
        float s = y(a) + y(b);
     
        // Adding middle terms in above
        // formula
        for (int i = 1; i < n; i++)
            s += 2 * y( a + i * h);
     
        // h/2 indicates (b-a)/2n.
        // Multiplying h/2 with s.
        return (h / 2) * s;
    }
     
    // Driver code
    public static void Main ()
    {
         
        // Range of definite integral
        float x0 = 0;
        float xn = 1;
     
        // Number of grids. Higher
        // value means more accuracy
        int n = 6;
     
        Console.Write("Value of integral is "
          + Math.Round(trapezoidal(x0, xn, n)
                        * 10000.0) / 10000.0);
    }
}



//rectangle method
Rectangle rectangle1 = new Rectangle(70, 70, 100, 150);

private void DrawFirstRectangle()
{
    ControlPaint.DrawReversibleFrame(rectangle1, 
        SystemColors.Highlight, FrameStyle.Thick);
}

private void Button1_Click(object sender, EventArgs e)
{

    // Get the bounds of the screen.
    Rectangle screenRectangle = Screen.PrimaryScreen.Bounds;

    // Check to see if the rectangle is within the bounds of the screen.
    if (screenRectangle.Contains(rectangle1))

        // If so, erase the previous rectangle.
    {
        ControlPaint.DrawReversibleFrame(rectangle1, 
            SystemColors.Highlight, FrameStyle.Thick);

        // Call the Offset method to move the rectangle.
        rectangle1.Offset(20, 20);

        // Draw the new, offset rectangle.
        ControlPaint.DrawReversibleFrame(rectangle1, 
            SystemColors.Highlight, FrameStyle.Thick);
    }
}
