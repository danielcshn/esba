// En la clase Tandem
package Maqueta;

public class Tandem extends Bicicleta implements Pintable {
    private int asientos;

    public Tandem(String color, double precio, int asientos) {
        super(color, precio);
        this.asientos = asientos;
    }

    public int getAsientos() {
        return asientos;
    }

    public void setAsientos(int asientos) {
        this.asientos = asientos;
    }

    @Override
    public void mostrarInformacion() {
        super.mostrarInformacion();
        System.out.println("Tipo: Tandem");
        System.out.println("Cantidad de asientos: " + asientos);
    }


    @Override
    public void pintar() {
        String colorAnterior = getColor(); // Guardar el color anterior antes de pintar
        setColor("nuevo color"); // Cambiar el color
        setPrecio(getPrecio() + Pintable.COSTO_PINTURA); // Sumar el costo de la pintura al precio

        // Mostrar el color anterior y el color actual después de pintar
        System.out.println("Color anterior: " + colorAnterior);
        System.out.println("Color actual: " + getColor());
    }
}
