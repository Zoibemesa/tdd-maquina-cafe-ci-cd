namespace MaquinaCafe;

public class Cafetera
{
    public int CantidadCafe { get; set; }

    public Cafetera(int cantidad)
    {
        CantidadCafe = cantidad;
    }

    public bool ServirCafe(int onzas)
    {
        if (CantidadCafe >= onzas)
        {
            CantidadCafe -= onzas;
            return true;
        }
        return false;
    }
}
