public class Porsche : Car
{
    private Wreck wreck;
    private Decent decent;
    private Beauty beauty;

    public Porsche()
    {
        wreck = new Wreck();
        decent = new Decent();
        beauty = new Beauty();
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
