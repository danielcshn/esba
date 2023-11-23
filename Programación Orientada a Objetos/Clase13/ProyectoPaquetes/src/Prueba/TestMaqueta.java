package Prueba;
import Maqueta.*;

public class TestMaqueta {
    public static void main(String[] args) {
        // Crear una bicicleta de montaña
        Montaña mountainBike = new Montaña("azul", 400.0, 120);

        // Crear una bicicleta de paseo
        Paseo cityBike = new Paseo("rojo", 250.0, 6);

        // Crear una bicicleta tandem
        Tandem tandemBike = new Tandem("verde", 600.0, 2);

        // Mostrar información de las bicicletas
        System.out.println("Información de la bicicleta de montaña:");
        mountainBike.mostrarInformacion();
        System.out.println("\nInformación de la bicicleta de paseo:");
        cityBike.mostrarInformacion();
        System.out.println("\nInformación de la bicicleta tandem:");
        tandemBike.mostrarInformacion();

        // Pintar una bicicleta
        System.out.println("\nPintando la bicicleta de montaña...");
        mountainBike.pintar();

        // Mostrar información actualizada después de pintar
        System.out.println("\nInformación de la bicicleta de montaña después de pintar:");
        mountainBike.mostrarInformacion();
    }
}
