package Maqueta;

public class Bicicleta {
    private String color;
    private double precio;

    // Constructor único para establecer color y precio
    public Bicicleta(String color, double precio) {
        this.color = color;
        this.precio = precio;
    }

    public String getColor() {
        return color;
    }

    public void setColor(String color) {
        this.color = color;
    }

    public double getPrecio() {
        return precio;
    }

    public void setPrecio(double precio) {
        this.precio = precio;
    }

    // Método para mostrar color y precio de la bicicleta
    public void mostrarColorYPrecio() {
        System.out.println("Color: " + color);
        System.out.println("Precio: $" + precio);
    }

	public void mostrarInformacion() {
		// TODO Auto-generated method stub
		
	}
}
