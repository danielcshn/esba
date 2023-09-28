
public class Cuenta {
    private static long numeroCuentaActual = 100001; // Número de cuenta inicial
    private long numeroCuenta;
    private long dniCliente;
    private double saldoActual;
    private double interesAnual;

    // Constructor por defecto
    public Cuenta() {
        this.numeroCuenta = numeroCuentaActual++;
        this.dniCliente = 0;
        this.saldoActual = 0.0;
        this.interesAnual = 0.0;
    }

    // Constructor con DNI, saldo e interés
    public Cuenta(long dniCliente, double saldoInicial, double interesAnual) {
        this.numeroCuenta = numeroCuentaActual++;
        this.dniCliente = dniCliente;
        this.saldoActual = saldoInicial;
        this.interesAnual = interesAnual;
    }

    // Método para actualizar el saldo con el interés diario
    public void actualizarSaldo() {
        double interesDiario = (interesAnual / 365) / 100;
        saldoActual += saldoActual * interesDiario;
    }

    // Método para ingresar una cantidad en la cuenta
    public void ingresar(double cantidad) {
        saldoActual += cantidad;
    }

    // Método para retirar una cantidad de la cuenta si hay saldo suficiente
    public void retirar(double cantidad) {
        if (saldoActual >= cantidad) {
            saldoActual -= cantidad;
        } else {
            System.out.println("Saldo insuficiente");
        }
    }

    // Método para mostrar todos los datos de la cuenta
    public void mostrarDatosCuenta() {
        System.out.println("Número de Cuenta: " + numeroCuenta);
        System.out.println("DNI del Cliente: " + dniCliente);
        System.out.println("Saldo Actual: " + saldoActual);
        System.out.println("Interés Anual: " + interesAnual + "%");
    }

    public static void main(String[] args) {
        // Ejemplo de uso
        Cuenta cuenta1 = new Cuenta(123456789, 1000.0, 3.5);
        cuenta1.mostrarDatosCuenta();

        cuenta1.actualizarSaldo();
        cuenta1.mostrarDatosCuenta();

        cuenta1.ingresar(500.0);
        cuenta1.mostrarDatosCuenta();

        cuenta1.retirar(200.0);
        cuenta1.mostrarDatosCuenta();
    }
}
