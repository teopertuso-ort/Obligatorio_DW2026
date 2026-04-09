using LogicaAccesoDatos.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaAplicacion.CasosUso
{
    public class CUBajaTema
    {
        public void EjecutarBaja(int id)
        {
            RepositorioTemas repo = new RepositorioTemas();
            repo.Remove(id);
        }
    }
}
