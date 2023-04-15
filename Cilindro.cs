/*using System;

public class Cilindro {
  private Circulo baseCilindro;
  private UInt32 altura;

  public Cilindro(UInt32 raio, UInt32 altura) {
    baseCilindro = new Circulo();
    baseCilindro.SetRaio(raio);
    this.altura = altura;
  }

  public double CalcularArea() {
    double areaBase = baseCilindro.CalcularArea();
    double areaLateral = 2 * Math.PI * 
   baseCilindro.GetRaio() * altura;
    return 2 * areaBase + areaLateral;
  }
}

*/