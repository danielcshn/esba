package bucles;

import javax.swing.JOptionPane;

public class BUCLESDOWHILE {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		int num;
		
		do {
			String texto = JOptionPane.showInputDialog("Introduce un numero entre 0 y 10");
			num=Integer.parseInt(texto);
		} while(num>=10 || num<0);
		
	}
	
}