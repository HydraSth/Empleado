using Personas;
using SpreadsheetLight;

string ruta = @"C:\Users\Usuario\Desktop\MdfDatosC\Empleados.xlsx";
List<Empleado> empleados = new List<Empleado>();

SLDocument documento = new SLDocument(ruta);

string nombre;
int edad;
double basico;
int horas;
int antiguedad;
string funcion;
double salario;

int fila = 2;
while (documento.GetCellValueAsString(fila,1)!="")
{
    nombre = documento.GetCellValueAsString(fila, 1);
    edad = documento.GetCellValueAsInt32(fila, 2);
    basico = documento.GetCellValueAsDouble(fila, 3);
    horas = documento.GetCellValueAsInt32(fila, 4);
    antiguedad  = documento.GetCellValueAsInt32(fila, 5);
    funcion = documento.GetCellValueAsString(fila, 6);
    salario = documento.GetCellValueAsDouble(fila, 7);
    fila++;
    if(funcion=="ANALISTA"){
        empleados.Add(new Analista(nombre, edad, basico, horas, antiguedad, funcion, salario));
    }else{
        empleados.Add(new Programador(nombre, edad, basico, horas, antiguedad, funcion, salario));
    }
}

SLDocument doc_guardar= new SLDocument();
doc_guardar.SetCellValue(1,1,"Nombre");
doc_guardar.SetCellValue(1,2,"Edad");
doc_guardar.SetCellValue(1,3,"Basico");
doc_guardar.SetCellValue(1,4,"Horas");
doc_guardar.SetCellValue(1,5,"Antiguedad");
doc_guardar.SetCellValue(1,6,"Funcion");
doc_guardar.SetCellValue(1,7,"Salario");

fila=2;
foreach (var empleado in empleados){
    doc_guardar.SetCellValue(fila,1,empleado.Nombre);
    doc_guardar.SetCellValue(fila,2,empleado.Edad);
    doc_guardar.SetCellValue(fila,3,empleado.Basico);
    doc_guardar.SetCellValue(fila,4,empleado.Horas);
    doc_guardar.SetCellValue(fila,5,empleado.Antiguedad);
    doc_guardar.SetCellValue(fila,6,empleado.Funcion);
    doc_guardar.SetCellValue(fila,7,empleado.CalcularSalario());
    fila++;
}

doc_guardar.SaveAs(@"C:\Users\Usuario\Desktop\MdfDatosC\EmpleadosConSalarios.xlsx");