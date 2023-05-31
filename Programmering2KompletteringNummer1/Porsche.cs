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
}
