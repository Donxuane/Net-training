namespace WebApplication1;

public class Service2(Service3 service3)
{
    public int Substract(int x)
    {
        service3.Number -= x;
        return service3.Number;
    }
}
