namespace MaquinaCafe;

public class MaquinaCafe
{
    private Cafetera cafetera;
    private Vasos vasos;
    private Azucarero azucarero;

    public MaquinaCafe(Cafetera c, Vasos v, Azucarero a)
    {
        cafetera = c;
        vasos = v;
        azucarero = a;
    }

    public string PrepararCafe(int tamaño, int azucar)
    {
        if (!vasos.EntregarVaso())
            return "No hay vasos";

        if (!cafetera.ServirCafe(tamaño))
            return "No hay café";

        if (azucar > 0 && !azucarero.ServirAzucar(azucar))
            return "No hay azúcar";

        return "Café listo";
    }
}
