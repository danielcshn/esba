
public class Main {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
        ClaseQueImplementaRelaciones objeto1 = new ClaseQueImplementaRelaciones(5);
        ClaseQueImplementaRelaciones objeto2 = new ClaseQueImplementaRelaciones(8);

        System.out.println("¿objeto1 es mayor que objeto2? " + objeto1.esMayor(objeto2));
        System.out.println("¿objeto1 es menor que objeto2? " + objeto1.esMenor(objeto2));
        System.out.println("¿objeto1 es igual a objeto2? " + objeto1.esIgual(objeto2));
    }

}
