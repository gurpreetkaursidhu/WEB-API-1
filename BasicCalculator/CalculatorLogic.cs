namespace BasicCalculator;
public class CalculatorLogic

{
    public static double Addition(double left, double right)

    {

        return left + right;

    }

    public static double Substraction(double left, double right)

    {

        return left - right;
    }

    public static double Multiplication(double left, double right)

    {
        return left * right;

    }


    public static double Division(double left, double right)

    {
        if (right != 0)
        {
            return left / right;
        }
        else
        {
            throw new DivideByZeroException();
        }
    }







}

