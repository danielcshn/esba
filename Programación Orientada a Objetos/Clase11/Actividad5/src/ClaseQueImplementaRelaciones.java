
class ClaseQueImplementaRelaciones implements Relaciones {
    private int valor;

    public ClaseQueImplementaRelaciones(int valor) {
        this.valor = valor;
    }

    @Override
    public boolean esMayor(Object b) {
        if (b instanceof ClaseQueImplementaRelaciones) {
            ClaseQueImplementaRelaciones otraClase = (ClaseQueImplementaRelaciones) b;
            return this.valor > otraClase.valor;
        }
        return false;
    }

    @Override
    public boolean esMenor(Object b) {
        if (b instanceof ClaseQueImplementaRelaciones) {
            ClaseQueImplementaRelaciones otraClase = (ClaseQueImplementaRelaciones) b;
            return this.valor < otraClase.valor;
        }
        return false;
    }

    @Override
    public boolean esIgual(Object b) {
        if (b instanceof ClaseQueImplementaRelaciones) {
            ClaseQueImplementaRelaciones otraClase = (ClaseQueImplementaRelaciones) b;
            return this.valor == otraClase.valor;
        }
        return false;
    }
}