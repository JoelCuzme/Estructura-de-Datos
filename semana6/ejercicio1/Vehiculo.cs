using System;
public class Vehiculo
{
    // Campos públicos para acceso directo
    public string Placa;
    public string Marca;
    public string Modelo;
    public int Anio;
    public decimal Precio;

    public Vehiculo(string placa, string marca, string modelo, int anio, decimal precio)
    {
        this.Placa = placa;
        this.Marca = marca;
        this.Modelo = modelo;
        this.Anio = anio;
        this.Precio = precio;
    }

    public override string ToString()
    {
        // Acceso directo a los campos públicos
        return $"Placa: {Placa}, Marca: {Marca}, Modelo: {Modelo}, Año: {Anio}, Precio: ${Precio:N2}";
    }
}