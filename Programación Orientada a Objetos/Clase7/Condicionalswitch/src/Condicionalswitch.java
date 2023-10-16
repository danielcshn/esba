
public class Condicionalswitch {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

        String dia = "Lunes"; // Cambia esto al día de la semana que desees comparar

        switch (dia) {
            case "Lunes":
                System.out.println("Hoy es: "+dia);
                break;
            case "Martes":
            	System.out.println("Hoy es: "+dia);
                break;
            case "Miércoles":
            	System.out.println("Hoy es: "+dia);
                break;
            case "Jueves":
            	System.out.println("Hoy es: "+dia);
                break;
            case "Viernes":
            	System.out.println("Hoy es: "+dia);
                break;
            case "Sábado":
            	System.out.println("Hoy es: "+dia);
                break;
            case "Domingo":
            	System.out.println("Hoy es: "+dia);
                break;
            default:
                System.out.println("No has introducido un dia correcto");
        }
		
	}

}
