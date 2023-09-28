
public class Main {

	public static void main(String[] args) {
		// Crear una cafetera con capacidad máxima de 1000 c.c.
		Cafetera miCafetera = new Cafetera(1000);

		// Servir una taza de 200 c.c. de café
		miCafetera.servirTaza(200);

		// Agregar 300 c.c. de café a la cafetera
		miCafetera.agregarCafe(300);

		// Llenar la cafetera
		miCafetera.llenarCafetera();

		// Vaciar la cafetera
		miCafetera.vaciarCafetera();
	}

}
