namespace MaquinaCafe;

public class Vasos
{
    public int Cantidad { get; set; }

    public Vasos(int cantidad)
    {
        Cantidad = cantidad;
    }

    public bool EntregarVaso()
    {
        if (Cantidad > 0)
        {
            Cantidad--;
            return true;
        }
        return false;
    }
}
