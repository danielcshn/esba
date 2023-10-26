
public abstract class Empleado {

	protected final static double SALARIO_DEF=600;
	protected String nombre;
	protected String apellido;
	protected int edad;
	protected double salario;
	
	public String getNombre() {
		return nombre;
	}
	
	public void setNombre(String nombre) {
		this.nombre = nombre;
	}
	
	public int getEdad() {
		return edad;
	}
	
	public double getSalario() {
		return salario;
	}
	
	public void setSalario(double salario) {
		this.salario = salario;
	}

	/* Dejamos un método sin implementar, por ejemplo, el método plus, para que cada clase
	 * hija implemente su propio método de forma diferente:
	 * */
	
	public abstract boolean plus(double sueldoPlus);
	
	public Empleado() {
		this("","",0, SALARIO_DEF);
	}
	
	public Empleado(String nombre, String apellido, int edad, double salario) {
		this.nombre = nombre;
		this.apellido = apellido;
		this.edad = edad;
		this.salario = salario;
	}
	
}
