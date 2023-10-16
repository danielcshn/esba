
public class Vehiculo {

	public static final int
		rojo=1,
		verde=2,
		azul=3;
	
	private int color;
	private int numSerie;
	
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
	
}
