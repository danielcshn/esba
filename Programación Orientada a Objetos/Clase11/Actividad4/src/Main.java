
public class Main {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
        int[] intArray = {1, 5, 3, 7, 2, 8};
        double[] doubleArray = {2.5, 1.0, 3.2, 0.5, 4.8};

        Math3 math3 = new Math3();

        int minInt = math3.min(intArray);
        int maxInt = math3.max(intArray);

        double minDouble = math3.min(doubleArray);
        double maxDouble = math3.max(doubleArray);

        System.out.println("Mínimo entero: " + minInt);
        System.out.println("Máximo entero: " + maxInt);
        System.out.println("Mínimo doble: " + minDouble);
        System.out.println("Máximo doble: " + maxDouble);
	}

}
