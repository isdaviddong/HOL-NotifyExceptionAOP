using isRock.Core.AOP;

var bc = new BmiCalculator();

bc.Height = 170;
bc.Weight = 70;

var BmiResult = bc.Calculate();
Console.WriteLine($"BMI:{BmiResult}");

public class BmiCalculator  
{
    public int Weight { get; set; }
    public int Height { get; set; }
    public decimal BMI
    {
        get
        {
            return Calculate();
        }
    }

    public decimal Calculate()
    {
        decimal result = 0;
        //將float改成int試試看
        decimal height = (decimal)Height / 100;
        result = Weight / (height * height);

        return result;
    }
}