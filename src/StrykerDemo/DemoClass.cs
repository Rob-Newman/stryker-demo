namespace StrykerDemo;

public static class DemoClass
{
    public static bool IsGreaterThan5AndLessThan10(int input) 
        => input is > 0 and < 10;
}
