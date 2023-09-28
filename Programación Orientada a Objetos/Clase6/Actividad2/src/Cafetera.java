
public class Cafetera {
    private int capacidadMaxima;
    private int cantidadActual;

    // Constructor predeterminado
    public Cafetera() {
        capacidadMaxima = 1000;
        cantidadActual = 0;
    }

    // Constructor con la capacidad máxima de la cafetera
    public Cafetera(int capacidadMaxima) {
        this.capacidadMaxima = capacidadMaxima;
        cantidadActual = capacidadMaxima;
    }

    // Constructor con la capacidad máxima y la cantidad actual
    public Cafetera(int capacidadMaxima, int cantidadActual) {
        this.capacidadMaxima = capacidadMaxima;
        if (cantidadActual > capacidadMaxima) {
            this.cantidadActual = capacidadMaxima;
        } else {
            this.cantidadActual = cantidadActual;
        }
    }

    // Llena la cafetera
    public void llenarCafetera() {
        cantidadActual = capacidadMaxima;
    }

    // Sirve una taza con la capacidad indicada
    public void servirTaza(int capacidadTaza) {
        if (cantidadActual >= capacidadTaza) {
            cantidadActual -= capacidadTaza;
            System.out.println("Se ha servido una taza de " + capacidadTaza + " c.c. de café.");
        } else {
            System.out.println("No hay suficiente café para llenar la taza.");
            cantidadActual = 0;
        }
    }

    // Vacía la cafetera
    public void vaciarCafetera() {
        cantidadActual = 0;
    }

    // Agrega la cantidad de café indicada a la cafetera
    public void agregarCafe(int cantidad) {
        if (cantidadActual + cantidad <= capacidadMaxima) {
            cantidadActual += cantidad;
            System.out.println("Se han agregado " + cantidad + " c.c. de café a la cafetera.");
        } else {
            cantidadActual = capacidadMaxima;
            System.out.println("La cafetera está llena. No se puede agregar más café.");
        }
    }

    // Getter para obtener la cantidad actual de café en la cafetera
    public int getCantidadActual() {
        return cantidadActual;
    }

    // Getter para obtener la capacidad máxima de la cafetera
    public int getCapacidadMaxima() {
        return capacidadMaxima;
    }
}
