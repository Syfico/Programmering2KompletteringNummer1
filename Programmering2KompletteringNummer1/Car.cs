public class Car
{
    private Engine engine;
    private Wreck wreck;
    private Decent decent;
    private Beauty beauty;

    public Car()
    {
        engine = new Engine();
        wreck = new Wreck();
        decent = new Decent();
        beauty = new Beauty();
    }

    public void StartCar()
    {
        engine.Start();
    }
   
    public void StopCar()
    {
        engine.Stop();
    }

    public void DescribeWreck()
    {
        wreck.Describe();
    }

    public void DescribeDecent()
    {
        decent.Describe();
    }

    public void DescribeBeauty()
    {
        beauty.Describe();
    }
}
