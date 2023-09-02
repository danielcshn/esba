// Clase Persona
public class Persona {

    // Atributos
    private String nombre;
    private int edad;
    
    // Constructor
    public Persona(String nombre, int edad) {
        this.nombre = nombre;
        this.edad = edad;
    }

    // Métodos
    public void cargarDatosPersonales(String nombre, int edad) {
        this.nombre = nombre;
        this.edad = edad;
    }

    public void imprimirDatosPersonales() {
        System.out.println("Nombre: " + nombre);
        System.out.println("Edad: " + edad);
    }

}