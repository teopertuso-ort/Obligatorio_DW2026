using LogicaAccesoDatos.Repositorios;
using LogicaNegocio.ClasesDominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaAplicacion.CasosUso
{
    public class CUModificarTema
    {
        public void EjecutarModificacion(Tema t)
        {
            RepositorioTemas repo = new RepositorioTemas();
            repo.Update(t);
        }
    }
}
