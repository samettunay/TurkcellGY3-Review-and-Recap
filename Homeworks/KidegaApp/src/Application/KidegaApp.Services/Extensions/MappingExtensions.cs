using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidegaApp.Services.Extensions
{
    public static class MappingExtensions
    {
        public static Tout ConverTo<Tin, Tout>(this IEnumerable<Tin> value, IMapper mapper)
        {
            return mapper.Map<Tout>(value);
        }
    }
}
