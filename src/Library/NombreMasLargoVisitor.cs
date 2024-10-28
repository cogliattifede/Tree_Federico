namespace Library;

public class NombreMasLargoVisitor : IVisitor<Person>
{
    private string nombreLargo = string.Empty;

    public string NombreLargo
    {
        get
        {
            return this.nombreLargo;
        }
    }

    public void Visit(Node<Person> node)
    {
        if (node.Value.Nombre.Length > nombreLargo.Length)
        {
            nombreLargo = node.Value.Nombre;
        }
    }
}