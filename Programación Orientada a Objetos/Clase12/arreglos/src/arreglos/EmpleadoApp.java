package arreglos;

public class EmpleadoApp {

	public static void main(String[] args) {

		Empleado arrayObjetos[] = new Empleado[3];
		
		arrayObjetos[0]= new Empleado("Fernando", "Ureña", 23, 1000);
		arrayObjetos[1]= new Empleado("Epi", "Dermis", 30, 1500);
		arrayObjetos[2]= new Empleado("Blas", "Femia", 25, 1200);
		
		int suma=0;
		for(int i=0;i<arrayObjetos.length;i++) {
			suma+=arrayObjetos[i].getSalario();
		}
		System.out.println("La suma de salarios es "+suma);
		
	}

}
