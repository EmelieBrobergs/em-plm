using System.Reflection;
using Application.Common.Models;
using AutoMapper;
using Domain.Entities;

namespace Application.Common.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // TODO: Decide one way of using this, etherlike bolow or implument the interface on entity class
        CreateMap<StyleViewModel, Style>().ReverseMap();
        CreateMap<MeasurementViewModel, Measurement>().ReverseMap();
        CreateMap<CompanyViewModel, Company>().ReverseMap();
        CreateMap<SizeRangeViewModel,SizeRange>().ReverseMap();
        CreateMap<SizeViewModel, Size>().ReverseMap();
        CreateMap<GradingViewModel, Grading>().ReverseMap();


        ApplyMappingsFromAssembly(Assembly.GetExecutingAssembly());
    }

    private void ApplyMappingsFromAssembly(Assembly assembly)
    {
        var types = assembly.GetExportedTypes()
            .Where(t => t.GetInterfaces().Any(i =>
                i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IMapFrom<>)))
            .ToList();

        foreach (var type in types)
        {
            var instance = Activator.CreateInstance(type);

            var methodInfo = type.GetMethod("Mapping")
                ?? type.GetInterface("IMapFrom`1")!.GetMethod("Mapping");

            methodInfo?.Invoke(instance, new object[] { this });

        }
    }
}
