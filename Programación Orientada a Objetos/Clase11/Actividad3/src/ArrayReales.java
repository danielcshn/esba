public class ArrayReales implements Estadisticas {
    private double[] datos;

    public ArrayReales(double[] datos) {
        this.datos = datos;
    }

    @Override
    public double minimo() {
        if (datos.length == 0) {
            throw new RuntimeException("El array está vacío");
        }

        double min = datos[0];
        for (int i = 1; i < datos.length; i++) {
            if (datos[i] < min) {
                min = datos[i];
            }
        }
        return min;
    }

    @Override
    public double maximo() {
        if (datos.length == 0) {
            throw new RuntimeException("El array está vacío");
        }

        double max = datos[0];
        for (int i = 1; i < datos.length; i++) {
            if (datos[i] > max) {
                max = datos[i];
            }
        }
        return max;
    }

    @Override
    public double sumatorio() {
        double suma = 0;
        for (double dato : datos) {
            suma += dato;
        }
        return suma;
    }
}
