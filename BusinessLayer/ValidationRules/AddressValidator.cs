using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(x => x.Description1).NotEmpty().WithMessage("Açıklama 1 Boş Geçilemez.");
            RuleFor(x => x.Description2).NotEmpty().WithMessage("Açıklama 2 Boş Geçilemez.");
            RuleFor(x => x.Description3).NotEmpty().WithMessage("Açıklama 3 Boş Geçilemez.");
            RuleFor(x => x.Description4).NotEmpty().WithMessage("Açıklama 4 Boş Geçilemez.");
            RuleFor(x => x.Mapinfo).NotEmpty().WithMessage("Harita Bilgisi Boş Geçilemez.");
            RuleFor(x => x.Description1).NotEmpty().MaximumLength(25).WithMessage("Lütfen Açıklamayı 25 Harf ile Kısaltınız.");
            RuleFor(x => x.Description2).NotEmpty().MaximumLength(25).WithMessage("Lütfen Açıklamayı 25 Harf ile Kısaltınız.");
            RuleFor(x => x.Description3).NotEmpty().MaximumLength(25).WithMessage("Lütfen Açıklamayı 25 Harf ile Kısaltınız.");
            RuleFor(x => x.Description4).NotEmpty().MaximumLength(25).WithMessage("Lütfen Açıklamayı 25 Harf ile Kısaltınız.");
        }
    }
}
