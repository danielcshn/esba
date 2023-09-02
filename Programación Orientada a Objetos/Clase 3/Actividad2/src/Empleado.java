// Clase Empleado (hereda de Persona)
public class Empleado extends Persona {
    // Atributos adicionales
    private double sueldo;

    // Constructor
    public Empleado(String nombre, int edad, double sueldo) {
        super(nombre, edad);
        this.sueldo = sueldo;
    }

    // Métodos adicionales
    public void cargarSueldo(double sueldo) {
        this.sueldo = sueldo;
    }

    public void imprimirSueldo() {
        System.out.println("Sueldo: $" + sueldo);
    }
}