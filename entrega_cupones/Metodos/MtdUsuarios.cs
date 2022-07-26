using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoGestion;

namespace entrega_cupones.Metodos
{
  class MtdUsuarios
  {
    public static string GetUsuario(int UsuarioId)
    {
      using (var context = new lts_sindicatoDataContext())
      {
        var usuario = from a in context.Usuarios where a.idUsuario == UsuarioId select a;
        if (usuario.Count() > 0)
        {
          return usuario.SingleOrDefault().Usuario;
        }
        else
        {
          return "";
        }
      }
    }
  }
}
