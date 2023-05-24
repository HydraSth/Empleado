using FluentValidation;
using Personas;

namespace EmpleadoValidator2{
    internal class Empleado_Validator:AbstractValidator<Empleado>{
            public Empleado_Validator(){
                RuleFor(x=>x.Nombre).NotEmpty().MaximumLength(50).WithMessage("El nombre no puede ser vacio");
                RuleFor(x=>x.Edad).NotNull().InclusiveBetween(18,65).WithMessage("La edad no puede ser menor a 18 o mayor a 65");
                RuleFor(x=>x.Antiguedad).NotNull().InclusiveBetween(0,47).WithMessage("La edad no puede ser menor a 18 o mayor a 65");
                RuleFor(x=>x.Basico).NotNull().GreaterThan(0).WithMessage("El basico no puede ser menor a 0");
            }
    }
}