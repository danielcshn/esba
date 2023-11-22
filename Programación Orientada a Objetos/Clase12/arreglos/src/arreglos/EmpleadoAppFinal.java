package arreglos;

import javax.swing.JOptionPane;

public class EmpleadoAppFinal {

	public static void main(String[] args) {

		Empleado arrayObjetos[] = new Empleado[2];
		
		int suma=0;
		for(int i=0;i<arrayObjetos.length;i++) {
			String nombre = JOptionPane.showInputDialog("Escribe un nombre");
			String apellido = JOptionPane.showInputDialog("Escribe un apellido");
			String texto = JOptionPane.showInputDialog("Escribe una edad");
			int edad = Integer.parseInt(texto);
			
			texto=JOptionPane.showInputDialog("Escribe un salario");
			double salario = Double.parseDouble(texto);
			
			arrayObjetos[i] = new Empleado(nombre, apellido, edad, salario);
		}

		for(int i=0;i<arrayObjetos.length;i++) {
			System.out.println(arrayObjetos[i]);
			suma+=arrayObjetos[i].getSalario();
		}

		System.out.println("La suma de salarios es "+suma);
	}

}
