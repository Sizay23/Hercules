using System;
using AccesoDatos;
using BE;
using Abstraccion;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLBitacora
    {
    private DALBitacora _dalBitacora;
        
    public BLLBitacora()
    {
            _dalBitacora = new DALBitacora();
    }

    public void Add(BEBitacora bitacora)
    {
        try
        {
                _dalBitacora.Agregar(bitacora);
        }
        catch (Exception)
        {

            throw;
        }
    }


    public IBitacorasPaginacion ObtenerFiltrado(int pagina, int porPagina, IBitacoraFiltros filtros)
    {
        try
        {
            return _dalBitacora.ObtenerFiltrado(pagina, porPagina, filtros);
        }
        catch (Exception)
        {

            throw;
        }
    }
    }
}
