package Maqueta;

public class Montaña extends Bicicleta implements Pintable {
    private int suspension;

    public Montaña(String color, double precio, int suspension) {
        super(color, precio);
        this.suspension = suspension;
    }

    public int getSuspension() {
        return suspension;
    }

    public void setSuspension(int suspension) {
        this.suspension = suspension;
    }

    @Override
    public void mostrarInformacion() {
        super.mostrarInformacion();
        System.out.println("Tipo: Montaña");
        System.out.println("Suspensión: " + suspension + " mm");
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
