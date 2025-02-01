# Project Documentation

This documentation provides an overview of the project's classes, organized by namespace.

## Table of Contents

- [Namespace: `MyApp.Application.Common`](MyApp_Application_Common.md)
  - [`AbstractSearchDto`](MyApp_Application_Common.md#class-abstractsearchdto)

- [Namespace: `MyApp.Application.Configurations`](MyApp_Application_Configurations.md)
  - [`AutoMapperConfiguration`](MyApp_Application_Configurations.md#class-automapperconfiguration)

- [Namespace: `MyApp.Application.DTOs.Management`](MyApp_Application_DTOs_Management.md)
  - [`CreateTaskItemDto`](MyApp_Application_DTOs_Management.md#class-createtaskitemdto)
  - [`DeleteTaskItemDto`](MyApp_Application_DTOs_Management.md#class-deletetaskitemdto)
  - [`SearchTaskItemDto`](MyApp_Application_DTOs_Management.md#class-searchtaskitemdto)
  - [`TaskItemDto`](MyApp_Application_DTOs_Management.md#class-taskitemdto)
  - [`UpdateTaskItemDto`](MyApp_Application_DTOs_Management.md#class-updatetaskitemdto)

- [Namespace: `MyApp.Application.DTOs.Medical`](MyApp_Application_DTOs_Medical.md)
  - [`AddressDto`](MyApp_Application_DTOs_Medical.md#class-addressdto)
  - [`ClaimDto`](MyApp_Application_DTOs_Medical.md#class-claimdto)
  - [`ConditionRelatedDto`](MyApp_Application_DTOs_Medical.md#class-conditionrelateddto)
  - [`DiagnosisCodeDto`](MyApp_Application_DTOs_Medical.md#class-diagnosiscodedto)
  - [`InsuredInfoDto`](MyApp_Application_DTOs_Medical.md#class-insuredinfodto)
  - [`OtherInsuranceInfoDto`](MyApp_Application_DTOs_Medical.md#class-otherinsuranceinfodto)
  - [`PatientInfoDto`](MyApp_Application_DTOs_Medical.md#class-patientinfodto)
  - [`ProviderInfoDto`](MyApp_Application_DTOs_Medical.md#class-providerinfodto)
  - [`SearchClaimDto`](MyApp_Application_DTOs_Medical.md#class-searchclaimdto)
  - [`ServiceLineDto`](MyApp_Application_DTOs_Medical.md#class-servicelinedto)

- [Namespace: `MyApp.Application.DTOs.Music`](MyApp_Application_DTOs_Music.md)
  - [`AlbumDto`](MyApp_Application_DTOs_Music.md#class-albumdto)
  - [`CDDto`](MyApp_Application_DTOs_Music.md#class-cddto)
  - [`CreateAlbumDto`](MyApp_Application_DTOs_Music.md#class-createalbumdto)
  - [`CreateCDDto`](MyApp_Application_DTOs_Music.md#class-createcddto)
  - [`CreateTrackDto`](MyApp_Application_DTOs_Music.md#class-createtrackdto)
  - [`DeleteAlbumDto`](MyApp_Application_DTOs_Music.md#class-deletealbumdto)
  - [`DeleteCDDto`](MyApp_Application_DTOs_Music.md#class-deletecddto)
  - [`DeleteTrackDto`](MyApp_Application_DTOs_Music.md#class-deletetrackdto)
  - [`SearchAlbumDto`](MyApp_Application_DTOs_Music.md#class-searchalbumdto)
  - [`TrackDto`](MyApp_Application_DTOs_Music.md#class-trackdto)
  - [`UpdateAlbumDto`](MyApp_Application_DTOs_Music.md#class-updatealbumdto)
  - [`UpdateCDDto`](MyApp_Application_DTOs_Music.md#class-updatecddto)
  - [`UpdateTrackDto`](MyApp_Application_DTOs_Music.md#class-updatetrackdto)

- [Namespace: `MyApp.Application.DTOs.NPI`](MyApp_Application_DTOs_NPI.md)
  - [`EndpointDto`](MyApp_Application_DTOs_NPI.md#class-endpointdto)
  - [`IdentifierDto`](MyApp_Application_DTOs_NPI.md#class-identifierdto)
  - [`ProviderDto`](MyApp_Application_DTOs_NPI.md#class-providerdto)

- [Namespace: `MyApp.Application.Mappings.Management`](MyApp_Application_Mappings_Management.md)
  - [`TaskItemProfile`](MyApp_Application_Mappings_Management.md#class-taskitemprofile)

- [Namespace: `MyApp.Application.Mappings.Medical`](MyApp_Application_Mappings_Medical.md)
  - [`ClaimProfile`](MyApp_Application_Mappings_Medical.md#class-claimprofile)

- [Namespace: `MyApp.Application.Mappings.Music`](MyApp_Application_Mappings_Music.md)
  - [`AlbumProfile`](MyApp_Application_Mappings_Music.md#class-albumprofile)
  - [`CDProfile`](MyApp_Application_Mappings_Music.md#class-cdprofile)
  - [`TrackProfile`](MyApp_Application_Mappings_Music.md#class-trackprofile)

- [Namespace: `MyApp.Application.Mappings.NPI`](MyApp_Application_Mappings_NPI.md)
  - [`ProviderProfile`](MyApp_Application_Mappings_NPI.md#class-providerprofile)

- [Namespace: `MyApp.Application.UseCases.Management`](MyApp_Application_UseCases_Management.md)
  - [`TaskItemUseCases`](MyApp_Application_UseCases_Management.md#class-taskitemusecases)

- [Namespace: `MyApp.Application.UseCases.Medical`](MyApp_Application_UseCases_Medical.md)
  - [`ClaimUseCases`](MyApp_Application_UseCases_Medical.md#class-claimusecases)

- [Namespace: `MyApp.Application.UseCases.Music`](MyApp_Application_UseCases_Music.md)
  - [`AlbumUseCases`](MyApp_Application_UseCases_Music.md#class-albumusecases)

- [Namespace: `MyApp.Application.UseCases.NPI`](MyApp_Application_UseCases_NPI.md)
  - [`ProviderUseCases`](MyApp_Application_UseCases_NPI.md#class-providerusecases)

- [Namespace: `MyApp.Application.Validators.Medical`](MyApp_Application_Validators_Medical.md)
  - [`AddressDtoValidator`](MyApp_Application_Validators_Medical.md#class-addressdtovalidator)
  - [`ClaimDtoValidator`](MyApp_Application_Validators_Medical.md#class-claimdtovalidator)
  - [`DiagnosisCodeDtoValidator`](MyApp_Application_Validators_Medical.md#class-diagnosiscodedtovalidator)
  - [`InsuredInfoDtoValidator`](MyApp_Application_Validators_Medical.md#class-insuredinfodtovalidator)
  - [`OtherInsuranceInfoDtoValidator`](MyApp_Application_Validators_Medical.md#class-otherinsuranceinfodtovalidator)
  - [`PatientInfoDtoValidator`](MyApp_Application_Validators_Medical.md#class-patientinfodtovalidator)
  - [`ProviderInfoDtoValidator`](MyApp_Application_Validators_Medical.md#class-providerinfodtovalidator)
  - [`ServiceLineDtoValidator`](MyApp_Application_Validators_Medical.md#class-servicelinedtovalidator)

- [Namespace: `MyApp.ConsoleApp`](MyApp_ConsoleApp.md)
  - [`Program`](MyApp_ConsoleApp.md#class-program)

- [Namespace: `MyApp.Domain.Entities.Management`](MyApp_Domain_Entities_Management.md)
  - [`TaskItem`](MyApp_Domain_Entities_Management.md#class-taskitem)
  - [`TaskTypeHelper`](MyApp_Domain_Entities_Management.md#class-tasktypehelper)

- [Namespace: `MyApp.Domain.Entities.Medical`](MyApp_Domain_Entities_Medical.md)
  - [`Address`](MyApp_Domain_Entities_Medical.md#class-address)
  - [`Claim`](MyApp_Domain_Entities_Medical.md#class-claim)
  - [`ConditionRelated`](MyApp_Domain_Entities_Medical.md#class-conditionrelated)
  - [`DiagnosisCode`](MyApp_Domain_Entities_Medical.md#class-diagnosiscode)
  - [`InsuredInfo`](MyApp_Domain_Entities_Medical.md#class-insuredinfo)
  - [`OtherInsuranceInfo`](MyApp_Domain_Entities_Medical.md#class-otherinsuranceinfo)
  - [`PatientInfo`](MyApp_Domain_Entities_Medical.md#class-patientinfo)
  - [`ProviderInfo`](MyApp_Domain_Entities_Medical.md#class-providerinfo)
  - [`ServiceLine`](MyApp_Domain_Entities_Medical.md#class-serviceline)

- [Namespace: `MyApp.Domain.Entities.Music`](MyApp_Domain_Entities_Music.md)
  - [`Album`](MyApp_Domain_Entities_Music.md#class-album)
  - [`CD`](MyApp_Domain_Entities_Music.md#class-cd)
  - [`Track`](MyApp_Domain_Entities_Music.md#class-track)

- [Namespace: `MyApp.Domain.Entities.NPI`](MyApp_Domain_Entities_NPI.md)
  - [`Endpoint`](MyApp_Domain_Entities_NPI.md#class-endpoint)
  - [`Identifier`](MyApp_Domain_Entities_NPI.md#class-identifier)
  - [`Provider`](MyApp_Domain_Entities_NPI.md#class-provider)

- [Namespace: `MyApp.Domain.Exceptions`](MyApp_Domain_Exceptions.md)
  - [`BadRequestException`](MyApp_Domain_Exceptions.md#class-badrequestexception)
  - [`NotFoundException`](MyApp_Domain_Exceptions.md#class-notfoundexception)

- [Namespace: `MyApp.Domain.Specifications.NPI`](MyApp_Domain_Specifications_NPI.md)
  - [`SearchProviderCriteria`](MyApp_Domain_Specifications_NPI.md#class-searchprovidercriteria)

- [Namespace: `MyApp.Infrastructure.ExternalServices.NPI`](MyApp_Infrastructure_ExternalServices_NPI.md)
  - [`NpiRegistryService`](MyApp_Infrastructure_ExternalServices_NPI.md#class-npiregistryservice)

- [Namespace: `MyApp.Infrastructure.ExternalServices.NPI.DTO`](MyApp_Infrastructure_ExternalServices_NPI_DTO.md)
  - [`Address`](MyApp_Infrastructure_ExternalServices_NPI_DTO.md#class-address)
  - [`Basic`](MyApp_Infrastructure_ExternalServices_NPI_DTO.md#class-basic)
  - [`Endpoint`](MyApp_Infrastructure_ExternalServices_NPI_DTO.md#class-endpoint)
  - [`Error`](MyApp_Infrastructure_ExternalServices_NPI_DTO.md#class-error)
  - [`Identifier`](MyApp_Infrastructure_ExternalServices_NPI_DTO.md#class-identifier)
  - [`OtherName`](MyApp_Infrastructure_ExternalServices_NPI_DTO.md#class-othername)
  - [`PracticeLocation`](MyApp_Infrastructure_ExternalServices_NPI_DTO.md#class-practicelocation)
  - [`Result`](MyApp_Infrastructure_ExternalServices_NPI_DTO.md#class-result)
  - [`Root`](MyApp_Infrastructure_ExternalServices_NPI_DTO.md#class-root)
  - [`Taxonomy`](MyApp_Infrastructure_ExternalServices_NPI_DTO.md#class-taxonomy)

- [Namespace: `MyApp.Infrastructure.Migrations`](MyApp_Infrastructure_Migrations.md)
  - [`AppDbContextModelSnapshot`](MyApp_Infrastructure_Migrations.md#class-appdbcontextmodelsnapshot)
  - [`InitialCreate`](MyApp_Infrastructure_Migrations.md#class-initialcreate)
  - [`InitialCreate`](MyApp_Infrastructure_Migrations.md#class-initialcreate)
  - [`NewClaims`](MyApp_Infrastructure_Migrations.md#class-newclaims)
  - [`NewClaims`](MyApp_Infrastructure_Migrations.md#class-newclaims)
  - [`NewTaskItem`](MyApp_Infrastructure_Migrations.md#class-newtaskitem)
  - [`NewTaskItem`](MyApp_Infrastructure_Migrations.md#class-newtaskitem)
  - [`UpdatedDBStructure`](MyApp_Infrastructure_Migrations.md#class-updateddbstructure)
  - [`UpdatedDBStructure`](MyApp_Infrastructure_Migrations.md#class-updateddbstructure)

- [Namespace: `MyApp.Infrastructure.Persistence`](MyApp_Infrastructure_Persistence.md)
  - [`AppDbContext`](MyApp_Infrastructure_Persistence.md#class-appdbcontext)

- [Namespace: `MyApp.Infrastructure.Repositories.Management`](MyApp_Infrastructure_Repositories_Management.md)
  - [`TaskItemRepository`](MyApp_Infrastructure_Repositories_Management.md#class-taskitemrepository)

- [Namespace: `MyApp.Infrastructure.Repositories.Medical`](MyApp_Infrastructure_Repositories_Medical.md)
  - [`ClaimRepository`](MyApp_Infrastructure_Repositories_Medical.md#class-claimrepository)

- [Namespace: `MyApp.Infrastructure.Repositories.Music`](MyApp_Infrastructure_Repositories_Music.md)
  - [`AlbumRepository`](MyApp_Infrastructure_Repositories_Music.md#class-albumrepository)

- [Namespace: `MyApp.Shared.DTOs`](MyApp_Shared_DTOs.md)
  - [`NavBarItemDto`](MyApp_Shared_DTOs.md#class-navbaritemdto)
  - [`StateDto`](MyApp_Shared_DTOs.md#class-statedto)

- [Namespace: `MyApp.Shared.Services`](MyApp_Shared_Services.md)
  - [`NavBarService`](MyApp_Shared_Services.md#class-navbarservice)
  - [`StateService`](MyApp_Shared_Services.md#class-stateservice)

---
*Generated by MyApp.ReportGenerator*
