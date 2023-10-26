
public class Comercial extends Empleado {

	private double comision;
	public boolean plus (double sueldoPlus) {
		boolean aumento=false;
		if(comision<50) {
			salario+=sueldoPlus;
			aumento=true;
		}
		return aumento;
	}
	
	public Comercial() {
		this.comision=0;
	}
	
	public Comercial(String nombre, String apellido, int edad, double salario, double comision) {
		super(nombre,apellido,edad,salario);
		this.comision=comision;
	}
	
}
