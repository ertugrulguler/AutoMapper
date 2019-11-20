using AutoMapper;
using SampleAutomapper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleAutomapper.App_Start
{
    public static class MappingProfile
    {
        
          public static  IMapper _mapper;
        #region Eski Yöntem
        //public MappingProfile()
        //{
        //    var config = new MapperConfiguration(i => { i.CreateMap<Employee, Person>(); });
        //    _mapper = config.CreateMapper();
        //} 
        #endregion

        public static void Mapping()
        {
            var config = new MapperConfiguration(i => { i.CreateMap<Employee, Person>(); });
            _mapper = config.CreateMapper();
        }

    }
}