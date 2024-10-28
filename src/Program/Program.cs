using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<Person> abuelo = new Node<Person>(new Person("Abuelo", 83));
            Node<Person> abuela = new Node<Person>(new Person("Abuela", 80));
            Node<Person> padre = new Node<Person>(new Person("Padre", 51));
            Node<Person> madre = new Node<Person>(new Person("Madre", 50));
            Node<Person> mayor = new Node<Person>(new Person("Mayor", 27));
            Node<Person> medio = new Node<Person>(new Person("Medio", 21));
            Node<Person> menor = new Node<Person>(new Person("Abuelo", 13));
            
            abuelo.AddChildren(padre);
            abuelo.AddChildren(madre);
            padre.AddChildren(mayor);
            padre.AddChildren(medio);
            madre.AddChildren(menor);

            MaximaEdadVisitor maximaEdad = new MaximaEdadVisitor();
            abuelo.Accept(maximaEdad);

            SumarEdadVisitor sumarEdad = new SumarEdadVisitor();
            abuelo.Accept(sumarEdad);

            NombreMasLargoVisitor nombreLargo = new NombreMasLargoVisitor();
            abuelo.Accept(nombreLargo);

        }
    }
}
