using System;

public class gestionBancaria
{
    public double saldo;  // Saldo inicial de la cuenta, 1000€

    public gestionBancaria(double saldoInicial)
    {
        saldo = saldoInicial;
    }

    public double obtenerSaldo()
    {
        return saldo;
    }

    public void realizarReintegro(double cantidad)
    {
        if (cantidad < 0)
        {
            throw new ArgumentOutOfRangeException("La cantidad indicada es negativa");
        }

        if (cantidad > saldo)
        {
            throw new ArgumentOutOfRangeException("Saldo insuficiente");
        }

        saldo -= cantidad;
    }

    public void realizarIngreso(double cantidad)
    {
        if (cantidad < 0)
        {
            throw new ArgumentOutOfRangeException("La cantidad indicada es negativa");
        }

        saldo += cantidad;
    }
}
