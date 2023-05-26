public class Program
{
    public static void Main(string[] args)
    {
        Car car = new Car();
        car.StartCar();
        car.StopCar();

        Dacia dacia = new Dacia();
        dacia.DescribeWreck();
        dacia.DescribeDecent();
        dacia.DescribeBeauty();

        Volkswagen volkswagen = new Volkswagen();
        volkswagen.DescribeWreck();
        volkswagen.DescribeDecent();
        volkswagen.DescribeBeauty();

        Porsche porsche = new Porsche();
        porsche.DescribeWreck();
        porsche.DescribeDecent();
        porsche.DescribeBeauty();

        Bicycle bicycle = new Bicycle();
        bicycle.DescribeWreck();
        bicycle.DescribeDecent();
        bicycle.DescribeBeauty();

        KickScooter kickScooter = new KickScooter();
        kickScooter.DescribeWreck();
        kickScooter.DescribeDecent();
        kickScooter.DescribeBeauty();
    }
}
