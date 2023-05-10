using AutoMapper;

namespace Application.Utility.Mapping
{
    /// <summary>
    /// An interface which allows an implementation to be mapped with SourceT.
    /// 
    /// More specifically, the interface makes its implementation to automatically register an AutoMapper mapping,
    /// where SourceT is a source mapping, and the implementation is a destination mapping.
    /// 
    /// You can optionally override a default mapping.
    /// </summary>
    /// <typeparam name="SourceT">Source mapping</typeparam>
    public interface IMapWith<SourceT>
    {
        void Mapping(Profile profile) =>
            profile.CreateMap(typeof(SourceT), destinationType: GetType());
    }
}
