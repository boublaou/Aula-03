public class quadrado
{
public double Lado { get; set; }
public double Area { get => Lado * Lado;}   
public double Perimetro{ get => 4 *Lado;} 
public quadrado(double lado) => Lado = lado;


}
