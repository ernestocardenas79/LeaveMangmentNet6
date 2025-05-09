using AutoMapper;
using LeaveManagment.W3b.Data;
using LeaveManagment.W3b.Models.LeaveType;

namespace LeaveManagment.W3b.MappingProfiles;

public class AutoMapperProfile:Profile
{
    public AutoMapperProfile()
    {
        CreateMap<LeaveType, IndexVM>();
    }
}
