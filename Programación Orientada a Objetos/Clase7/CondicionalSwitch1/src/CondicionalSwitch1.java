import javax.swing.JOptionPane;

public class CondicionalSwitch1 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub


        String dia = JOptionPane.showInputDialog("Introduce un dia de la semana");

        switch (dia) {
            case "Lunes":
            case "Martes":
            case "Miércoles":
            case "Jueves":
            case "Viernes":
            	System.out.println("Es un dia laboral");
                break;
            case "Sábado":
            case "Domingo":
            	System.out.println("Es un dia festivo");
                break;
            default:
                System.out.println("Introduce un dia de la semana");
        }
		
	}

}
