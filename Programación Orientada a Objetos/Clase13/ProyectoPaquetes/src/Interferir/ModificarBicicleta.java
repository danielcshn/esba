package Interferir;
import Maqueta.*;

public class ModificarBicicleta {
    public static void main(String[] args) {
        // Crear una bicicleta de paseo y mostrar su información inicial
        Paseo cityBike = new Paseo("rojo", 250.0, 6);
        System.out.println("Información de la bicicleta de paseo antes de interferir:");
        cityBike.mostrarInformacion();

        // Cambiar el color de la bicicleta de paseo
        cityBike.setColor("nuevo color");

        // Mostrar información actualizada después de interferir
        System.out.println("\nInformación de la bicicleta de paseo después de interferir:");
        cityBike.mostrarInformacion();
    }
}
