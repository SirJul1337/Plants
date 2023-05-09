
namespace Plants;

internal class AppleTree : Tree
{
    public AppleTree(string name, double height):base(name, height, true)
    {
    }
    internal override void Grow()
    {
        Console.WriteLine($"{GetType().Name} | {this.Name} Grows, Height is {this.Height} meter");
    }
    internal void GrowApple()
    {
        Console.WriteLine($"{GetType().Name} | {this.Name} Grows an apple");
    }
}
