
public class Coche extends Vehiculo {

	private int cilindrada;
	
	public Coche(int color, int numSerie, int cilindrada) {
		super(color, numSerie);
		this.cilindrada = cilindrada;
	}
	
	public int cilindrada() {
		return cilindrada;
	}
	
	public void cambiaCilindrada(int nuevaCilin) {
		this.cilindrada = nuevaCilin;
	}
	
	public String toString() {
		return super.toString() + ", cilindrada= "+ cilindrada;
	}
	
}
