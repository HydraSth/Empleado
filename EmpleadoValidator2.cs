using FluentValidation;
using Personas;


public class MyClass
{
    internal class Empleado_Validator:AbstractValidator<Empleado>{
        public Empleado_Validator(){
            RuleFor(x=>x.Nombre).NotEmpty().MaximumLength(50);
            RuleFor(x=>x.Funcion).NotEmpty().MaximumLength(50);
        }
    }
}