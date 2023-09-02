
public class Main {

	public static void main(String[] args) {

        // Crear una instancia de Persona
        Persona persona = new Persona("Daniel", 31);

        // Imprimir datos personales de la persona
        System.out.println("Datos de la Persona:");
        persona.imprimirDatosPersonales();

        // Crear una instancia de Empleado
        Empleado empleado = new Empleado("Daniel", 31, 371595);

        // Imprimir datos personales y sueldo del empleado
        System.out.println("\nDatos del Empleado:");
        empleado.imprimirDatosPersonales();
        empleado.imprimirSueldo();
	}

}
