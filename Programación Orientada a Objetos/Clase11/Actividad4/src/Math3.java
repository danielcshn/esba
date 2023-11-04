public final class Math3 implements Extremos {
    @Override
    public int min(int[] a) {
        if (a.length == 0) {
            throw new IllegalArgumentException("El arreglo no debe estar vacío.");
        }

        int minValue = a[0];
        for (int value : a) {
            if (value < minValue) {
                minValue = value;
            }
        }
        return minValue;
    }

    @Override
    public int max(int[] a) {
        if (a.length == 0) {
            throw new IllegalArgumentException("El arreglo no debe estar vacío.");
        }

        int maxValue = a[0];
        for (int value : a) {
            if (value > maxValue) {
                maxValue = value;
            }
        }
        return maxValue;
    }

    @Override
    public double min(double[] a) {
        if (a.length == 0) {
            throw new IllegalArgumentException("El arreglo no debe estar vacío.");
        }

        double minValue = a[0];
        for (double value : a) {
            if (value < minValue) {
                minValue = value;
            }
        }
        return minValue;
    }

    @Override
    public double max(double[] a) {
        if (a.length == 0) {
            throw new IllegalArgumentException("El arreglo no debe estar vacío.");
        }

        double maxValue = a[0];
        for (double value : a) {
            if (value > maxValue) {
                maxValue = value;
            }
        }
        return maxValue;
    }
}
