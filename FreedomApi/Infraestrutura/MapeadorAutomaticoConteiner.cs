using AutomacaoFreedom.Entidade.Tipologia;
using AutomacaoFreedom.Entidades.Tipologia;
using AutomacaoFreedom.Modelo.Tipologia;
using AutomacaoFreedom.Modelos.Tipologia;
using AutomacaoFreedomApi.Entidade.Hardware;
using AutomacaoFreedomApi.Modelo.Hardware;
using AutoMapper;

namespace AutomacaoFreedomApi.Infraestrutura
{
    public static class MapeadorAutomaticoConteiner
    {
        public static void Initialize()
        {
            Mapper.Initialize(cfg => {

                #region TIPOLOGIA
                
                cfg.CreateMap<Local, LocalDto>().AfterMap((origin, src) => src.AffterMap(origin));
                cfg.CreateMap<Local, LocalCreacaoDto>();
                cfg.CreateMap<Local, LocalAtuazacaoDto>();
                cfg.CreateMap<LocalDto, LocalCreacaoDto>();
                cfg.CreateMap<LocalDto, Local>();


                cfg.CreateMap<SubLocal, SubLocalDto>();//.AfterMap((origin, src) => src.AffterMap(origin));
                cfg.CreateMap<SubLocalDto, SubLocal>();
                cfg.CreateMap<SubLocalCreacaoDto, SubLocal>();
                cfg.CreateMap<SubLocal, SubLocalCreacaoDto>();
                cfg.CreateMap<SubLocalDto, SubLocalCreacaoDto>();
                cfg.CreateMap<SubLocalAtualizacaoDto, SubLocal>();
                cfg.CreateMap<SubLocal, SubLocalAtualizacaoDto>();

                cfg.CreateMap<Unidade, UnidadeDto>().AfterMap((origin, src) => src.AffterMap(origin));
                cfg.CreateMap<UnidadeDto, Unidade>();
                cfg.CreateMap<Unidade, UnidadeCriacaoDto>();
                cfg.CreateMap<UnidadeCriacaoDto, Unidade>();
                cfg.CreateMap<Unidade, UnidadeAtualizacaoDto>();
                cfg.CreateMap<UnidadeAtualizacaoDto, Unidade>();


                #endregion

                #region Hardware

                cfg.CreateMap<Device, DeviceDto>();
                cfg.CreateMap<DeviceDto, Device>();

                cfg.CreateMap<Device, DeviceCriacaoDto>();
                cfg.CreateMap<DeviceCriacaoDto, Device>();

                cfg.CreateMap<DeviceAtualizacaoDto, Device>();
                cfg.CreateMap<Device, DeviceAtualizacaoDto>();

                #endregion

            });
        }
    }
}