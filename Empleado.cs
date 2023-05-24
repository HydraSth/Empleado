namespace Personas
{
    public class Empleado{
        public string Nombre { get; set; }
        public string Funcion { get; set; }
        public int Edad { get; set; }
        public double Basico { get; set; }
        public int Horas { get; set; }
        public int Antiguedad { get; set; }
        public double Salario { get; set; }

        public Empleado(string nombre, int edad, double basico, int horas, int antiguedad, string funcion, double salario=0)
        {
            Nombre=nombre;
            Edad=edad;
            Basico=basico;
            Horas=horas;
            Antiguedad=antiguedad;
            Salario=salario;
            Funcion=funcion;
        }
        public virtual double CalcularSalario(){
            return (Basico*Horas);
        }
    }

    public class Programador:Empleado{
         public Programador(string nombre, int edad, double basico, int horas, int antiguedad, string funcion, double salario=0):base(nombre, edad, basico, horas, antiguedad, funcion, salario){
        }
    }
    public class Analista:Empleado{
        public Analista(string nombre, int edad, double basico, int horas, int antiguedad, string funcion, double salario=0):base(nombre, edad, basico, horas, antiguedad, funcion, salario){
        }
        public override double CalcularSalario(){
            return base.CalcularSalario()+(Basico*Antiguedad);
        }
    }
}