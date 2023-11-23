// En la clase Paseo
package Maqueta;

public class Paseo extends Bicicleta implements Pintable {
    private int cambios;

    public Paseo(String color, double precio, int cambios) {
        super(color, precio);
        this.cambios = cambios;
    }

    public int getCambios() {
        return cambios;
    }

    public void setCambios(int cambios) {
        this.cambios = cambios;
    }

    @Override
    public void mostrarInformacion() {
        super.mostrarInformacion();
        System.out.println("Tipo: Paseo");
        System.out.println("Cantidad de cambios: " + cambios);
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
