namespace Library;

public class SumarEdadVisitor : IVisitor<Person>
{
    private int edadTotal = 0;

    public int EdadTotal
    {
        get
        {
            return this.edadTotal;
        }
    }

    public void Visit(Node<Person> node)
    {
        edadTotal += node.Value.Edad;
    }
}