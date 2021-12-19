interface IBehaviours
{
    IBehaviours Run();
    IBehaviours RunRight();
    IBehaviours RunLeft();    
    IBehaviours Stop();
    IBehaviours Backward();
}
class Soldier : IBehaviours
{
    public IBehaviours Run()
    {
        Console.WriteLine("Soldier is running...");
        return this;
    }
    public IBehaviours RunRight()
    {
        Console.WriteLine("soldier is running right...");
        return this;
    }
    public IBehaviours RunLeft()
    {
        Console.WriteLine("soldier is running left....");
        return this;
    }
    public IBehaviours Stop()
    {
        Console.WriteLine("Soldier is stopping...");
        return this;
    }
    public IBehaviours Backward()
    {
        Console.WriteLine("soldier is backward...");
        return this;
    }
}
class MainClass
{
    static void Main(string[] args)
    {
        Soldier soldier = new Soldier();

        soldier.Run();
    }
}