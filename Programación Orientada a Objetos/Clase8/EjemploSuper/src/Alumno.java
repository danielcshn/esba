
public class Alumno extends Persona {
	private int curso;
	private String nivelAcademico;
	
	public Alumno(String n, int e, int c, String nivel) {
		super(n, e);
		curso = c; nivelAcademico = nivel;
	}
	
	public static void main(String[] args) {
		Alumno a = new Alumno("Pepe", 1, 2, "bueno");
	}
}
