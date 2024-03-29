
public class Vehiculo {

	public static final int
		rojo=1,
		verde=2,
		azul=3;
	
	public static final String[] nombre= {"error","rojo","verde","azul"};
	
	private int color;
	private int numSerie;
	
	public Vehiculo(int color, int numSerie) {
		this.color = color;
		this.numSerie = numSerie;
	}
	
	public int numSerie(){
		return numSerie;
	}
	
	public int color(){
		return color;
	}
	
	public void cambiaNumSerie(int numSerie) {
		this.numSerie = numSerie;
	}
	
	public void pinta(int nuevoColor) {
		color = nuevoColor;
	}
	
	public String toString() {
		return "Vehiculo -> numSerie= " + numSerie + ", color= "+ nombre[color];
	}
	
}
