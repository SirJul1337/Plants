namespace Plants;

internal abstract class Tree : Plant
{
    internal double Height { get; private set; }
    public bool HasFruits { get; set; }
    public Tree(string name, double height, bool hasFruits) : base(name)
    {
        Height = height;
        HasFruits = hasFruits;
    }

}
