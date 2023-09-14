
import javax.swing.JOptionPane;


public class Ejemplos {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int precioProducto=300;
		final double IVA=0.21;
		
		// System.out.println("Información del producto");
		// System.out.println("El precio del producto es "+precioProducto);
		// System.out.println("El precio del producto, incluyendo el IVA, es "+(precioProducto+(precioProducto*IVA)));
		
		JOptionPane.showMessageDialog(null, "El precio del producto, Incluido el IVA es "+(precioProducto+(precioProducto*IVA)));

		
	}

}
