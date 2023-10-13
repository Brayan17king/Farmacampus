using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IUnitOfWork
    {
        ICiudadRepository Ciudades { get; }
        IContactoPersonaRepository ContactoPersona { get; }
        IDepartamentoRepository Departamentos { get; }
        IDetalleMovimientoInventarioRepository DetalleMovimientoInventarios { get; }
        IFacturaRepository Facturas { get; }
        IFormaPagoRepository FormaPagos { get; }
        IInventarioRepository Inventario { get; }
        IMarcaRepository Marcas { get; }
        IMovimientoInventarioRepository MovimientoInventarios { get; }
        IPaisRepository Paises { get; }
        IPersonaRepository Personas { get; }
        IPresentacionRepository Presentaciones { get; }
        IProductoRepository Productos { get; }
        IRolPersonaRepository RolPersonas { get; }

        ITipoContactoRepository TipoContactos { get; }

        ITipoDocumentoRepository TipoDocumentos { get; }

        ITipoMovimientoInventarioRepository TipoMovimientoInventarios { get; }
        ITipoPersonaRepository TipoPersonas { get; }

        IUbicacionPersonaRepository UbicacionPersonas { get; }
        Task<int> SaveAsync();
    }
}