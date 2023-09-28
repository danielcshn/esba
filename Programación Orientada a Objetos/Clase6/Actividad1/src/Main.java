
public class Main {

	public static void main(String[] args) {
        // Crear una cuenta bancaria usando el constructor con DNI, saldo e interés
        Cuenta cuenta1 = new Cuenta(33995654, 1000.0, 3.5);

        // Mostrar los datos iniciales de la cuenta
        System.out.println("Datos iniciales de la cuenta:");
        cuenta1.mostrarDatosCuenta();

        // Actualizar el saldo con el interés diario
        cuenta1.actualizarSaldo();
        System.out.println("\nDespués de la actualización de saldo:");
        cuenta1.mostrarDatosCuenta();

        // Realizar un depósito en la cuenta
        cuenta1.ingresar(500.0);
        System.out.println("\nDespués de realizar un depósito de 500.0:");
        cuenta1.mostrarDatosCuenta();

        // Realizar un retiro de la cuenta
        cuenta1.retirar(200.0);
        System.out.println("\nDespués de realizar un retiro de 200.0:");
        cuenta1.mostrarDatosCuenta();

        // Intentar retirar más dinero del disponible
        cuenta1.retirar(1000.0);
	}

}
