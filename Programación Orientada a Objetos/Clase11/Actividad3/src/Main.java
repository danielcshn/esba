
public class Main {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
        double[] array = { 1.0, 2.0, 3.0, 4.0, 5.0 };
        ArrayReales estadisticasArray = new ArrayReales(array);

        System.out.println("Mínimo: " + estadisticasArray.minimo());
        System.out.println("Máximo: " + estadisticasArray.maximo());
        System.out.println("Sumatorio: " + estadisticasArray.sumatorio());
	}

}
