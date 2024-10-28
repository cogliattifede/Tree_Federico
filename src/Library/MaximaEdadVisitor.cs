namespace Library;

public class MaximaEdadVisitor : IVisitor<Person>
{
    private int edadMaxima = int.MinValue;

    public int EdadMaxima
    {
        get { return this.edadMaxima; }
    }

    public void Visit(Node<Person> node)
    {
        if (node.Children.Count == 0)
        {
            if (node.Value.Edad > edadMaxima)
            {
                edadMaxima = node.Value.Edad;
            }
        }
    }
}
