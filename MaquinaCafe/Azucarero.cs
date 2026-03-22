namespace MaquinaCafe;

public class Azucarero
{
    public int CantidadAzucar { get; set; }

    public Azucarero(int cantidad)
    {
        CantidadAzucar = cantidad;
    }

    public bool ServirAzucar(int cucharadas)
    {
        if (CantidadAzucar >= cucharadas)
        {
            CantidadAzucar -= cucharadas;
            return true;
        }
        return false;
    }
}
