using MPT_6lab;

class Program
{
    static void println(string message) {  Console.WriteLine(message); }
    static void Main(string[] args)
    {
        ComplexEditor test = new ComplexEditor();

        

        println(test.AddZeroReal());
        println(test.AddZeroImaginary());

        println(test.AddDigitReal(5));
        println(test.AddDigitReal(5));

        println(test.BackspaceReal());
        println(test.BackspaceImaginary());
        println(test.BackspaceReal());
        println(test.BackspaceImaginary());

        println(test.AddDigitImaginary(5));
        println(test.AddDigitImaginary(5));

        println(test.AddZeroReal());
        println(test.AddZeroImaginary());

        println(test.AddDotReal());
        println(test.AddDotImaginary());

        println(test.AddDotReal());
        println(test.AddDotImaginary());

        println(test.AddZeroReal());
        println(test.AddZeroImaginary());

        println(test.AddZeroReal());
        println(test.AddZeroImaginary());

        println(test.AddDigitImaginary(5));
        println(test.AddDigitReal(5));

        println(test.BackspaceReal());
        println(test.BackspaceImaginary());
        println(test.BackspaceReal());
        println(test.BackspaceImaginary());
        println(test.Clear());
    }
}