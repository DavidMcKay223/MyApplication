# Namespace: `MyApp.Application.Validators.Medical`

## Class: `AddressDtoValidator`

- **File Path:** `MyApp.Application/Validators/Medical/AddressDtoValidator.cs`
- **Inherits From:** `AbstractValidator<AddressDto>`

### Class Code

```csharp
public class AddressDtoValidator : AbstractValidator<AddressDto>
    {
        public AddressDtoValidator()
        {
            RuleFor(x => x.Street).MaximumLength(100).WithMessage("Street must be less than 100 characters.");
            RuleFor(x => x.City).MaximumLength(50).WithMessage("City must be less than 50 characters.");
            RuleFor(x => x.State).MaximumLength(2).WithMessage("State must be 2 characters.");
            RuleFor(x => x.ZipCode).MaximumLength(10).WithMessage("ZipCode must be less than 10 characters.");
            RuleFor(x => x.Phone).MaximumLength(20).WithMessage("Phone must be less than 20 characters.");
        }
    }
```

## Class: `ClaimDtoValidator`

- **File Path:** `MyApp.Application/Validators/Medical/ClaimDtoValidator.cs`
- **Inherits From:** `AbstractValidator<ClaimDto>`

### Class Code

```csharp
public class ClaimDtoValidator : AbstractValidator<ClaimDto>
    {
        public ClaimDtoValidator()
        {
            RuleFor(x => x.InsuredIdNumber).MaximumLength(20).WithMessage("Insured ID Number must be less than 20 characters.")
                .NotNull().WithMessage("Insured ID Number is required.");
            RuleFor(x => x.Patient).NotNull().WithMessage("Patient information is required.");
            RuleFor(x => x.Insured).NotNull().WithMessage("Insured information is required.");
            RuleFor(x => x.BillingProvider).NotNull().WithMessage("Billing provider information is required.");
            RuleFor(x => x.ServiceFacility).NotNull().WithMessage("Service facility information is required.");
            RuleFor(x => x.TotalCharge).GreaterThanOrEqualTo(0).WithMessage("Total charge must be greater than or equal to 0.");
            RuleFor(x => x.AmountPaid).GreaterThanOrEqualTo(0).WithMessage("Amount paid must be greater than or equal to 0.");
            RuleFor(x => x.PatientSignatureDate).LessThanOrEqualTo(DateTime.UtcNow).WithMessage("Patient signature date cannot be in the future.");
            RuleFor(x => x.PhysicianSignatureDate).LessThanOrEqualTo(DateTime.UtcNow).WithMessage("Physician signature date cannot be in the future.");

            RuleForEach(x => x.ServiceLines).SetValidator(new ServiceLineDtoValidator());
            RuleForEach(x => x.DiagnosisCodes).SetValidator(new DiagnosisCodeDtoValidator());

            RuleFor(x => x.Patient).SetValidator(new PatientInfoDtoValidator());
            RuleFor(x => x.Patient.Address).SetValidator(new AddressDtoValidator());

            RuleFor(x => x.Insured).SetValidator(new InsuredInfoDtoValidator());
            RuleFor(x => x.Insured.Address).SetValidator(new AddressDtoValidator());

            RuleFor(x => x.OtherInsurance).SetValidator(new OtherInsuranceInfoDtoValidator());

            RuleFor(x => x.BillingProvider).SetValidator(new ProviderInfoDtoValidator());
            RuleFor(x => x.BillingProvider.Address).SetValidator(new AddressDtoValidator());

            RuleFor(x => x.ServiceFacility).SetValidator(new ProviderInfoDtoValidator());
            RuleFor(x => x.ServiceFacility.Address).SetValidator(new AddressDtoValidator());
        }
    }
```

## Class: `DiagnosisCodeDtoValidator`

- **File Path:** `MyApp.Application/Validators/Medical/DiagnosisCodeDtoValidator.cs`
- **Inherits From:** `AbstractValidator<DiagnosisCodeDto>`

### Class Code

```csharp
public class DiagnosisCodeDtoValidator : AbstractValidator<DiagnosisCodeDto>
    {
        public DiagnosisCodeDtoValidator()
        {
            RuleFor(x => x.Code).NotEmpty().WithMessage("Diagnosis code is required.")
                .MaximumLength(10).WithMessage("Diagnosis code must be less than 10 characters.");
            RuleFor(x => x.Priority).InclusiveBetween(1, 12).WithMessage("Priority must be between 1 and 12.");
        }
    }
```

## Class: `InsuredInfoDtoValidator`

- **File Path:** `MyApp.Application/Validators/Medical/InsuredInfoDtoValidator.cs`
- **Inherits From:** `AbstractValidator<InsuredInfoDto>`

### Class Code

```csharp
public class InsuredInfoDtoValidator : AbstractValidator<InsuredInfoDto>
    {
        public InsuredInfoDtoValidator()
        {
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Last Name required")
                .MaximumLength(50).WithMessage("Last Name must be less than 50 characters.");
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("First Name required")
                .MaximumLength(50).WithMessage("First Name must be less than 50 characters.");
            RuleFor(x => x.GroupNumber).MaximumLength(20).WithMessage("Group Number must be less than 20 characters.");

            RuleFor(x => x.Address).SetValidator(new AddressDtoValidator());
        }
    }
```

## Class: `OtherInsuranceInfoDtoValidator`

- **File Path:** `MyApp.Application/Validators/Medical/OtherInsuranceInfoDtoValidator.cs`
- **Inherits From:** `AbstractValidator<OtherInsuranceInfoDto>`

### Class Code

```csharp
public class OtherInsuranceInfoDtoValidator : AbstractValidator<OtherInsuranceInfoDto>
    {
        public OtherInsuranceInfoDtoValidator()
        {
            RuleFor(x => x.PolicyHolderName).MaximumLength(50).WithMessage("Policy Holder Name must be less than 50 characters.");
            RuleFor(x => x.PolicyNumber).MaximumLength(20).WithMessage("Policy Number must be less than 20 characters.");
            RuleFor(x => x.PlanName).MaximumLength(50).WithMessage("Plan Name must be less than 50 characters.");
        }
    }
```

## Class: `PatientInfoDtoValidator`

- **File Path:** `MyApp.Application/Validators/Medical/PatientInfoDtoValidator.cs`
- **Inherits From:** `AbstractValidator<PatientInfoDto>`

### Class Code

```csharp
public class PatientInfoDtoValidator : AbstractValidator<PatientInfoDto>
    {
        public PatientInfoDtoValidator()
        {
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Last Name required.")
                .MaximumLength(50).WithMessage("Last Name must be less than 50 characters.");
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("First Name required.").MaximumLength(50).WithMessage("First Name must be less than 50 characters.");
            RuleFor(x => x.BirthDate).NotEmpty().WithMessage("Birth Date required.");
        }
    }
```

## Class: `ProviderInfoDtoValidator`

- **File Path:** `MyApp.Application/Validators/Medical/ProviderInfoDtoValidator.cs`
- **Inherits From:** `AbstractValidator<ProviderInfoDto>`

### Class Code

```csharp
public class ProviderInfoDtoValidator : AbstractValidator<ProviderInfoDto>
    {
        public ProviderInfoDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Provider Name required.").MaximumLength(100).WithMessage("Provider Name must be less than 100 characters.");
            RuleFor(x => x.FederalTaxId).NotEmpty().WithMessage("Federal Tax Id required.")
                .MaximumLength(20).WithMessage("Federal Tax Id must be less than 20 characters.");
            RuleFor(x => x.NpiNumber).MaximumLength(20).WithMessage("Npi Number must be less than 20 characters.");
            RuleFor(x => x.Phone).MaximumLength(20).WithMessage("Phone must be less than 20 characters.");
        }
    }
```

## Class: `ServiceLineDtoValidator`

- **File Path:** `MyApp.Application/Validators/Medical/ServiceLineDtoValidator.cs`
- **Inherits From:** `AbstractValidator<ServiceLineDto>`

### Class Code

```csharp
public class ServiceLineDtoValidator : AbstractValidator<ServiceLineDto>
    {
        public ServiceLineDtoValidator()
        {
            RuleFor(x => x.ProcedureCode).NotEmpty().WithMessage("Procedure code is required.")
                .MaximumLength(10).WithMessage("Procedure code must be less than 10 characters.");
            RuleFor(x => x.Modifier).MaximumLength(2).WithMessage("Modifier must be less than 2 characters.");
            RuleFor(x => x.DiagnosisPointer).MaximumLength(10).WithMessage("Diagnosis pointer must be less than 10 characters.");
            RuleFor(x => x.Charge).GreaterThanOrEqualTo(0).WithMessage("Charge must be greater than or equal to 0.");
            RuleFor(x => x.RenderingProviderId).NotEmpty().WithMessage("Rendering provider ID is required.")
                .MaximumLength(20).WithMessage("Rendering provider ID must be less than 20 characters.");
            RuleFor(x => x.ServiceEndDate).GreaterThanOrEqualTo(x => x.ServiceStartDate)
                .WithMessage("End date must be after start date.");
        }
    }
```

