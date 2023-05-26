public class Car
{
    private Engine engine;

    public Car()
    {
        engine = new Engine(); 
    }

    public void StartCar()
    {
        engine.Start();
    }
   
    public void StopCar()
    {
        engine.Stop();
    }
}
