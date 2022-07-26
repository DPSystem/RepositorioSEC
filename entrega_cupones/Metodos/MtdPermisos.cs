using AutoGestion.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGestion.Metodos
{
  class MtdPermisos
  {
    public static List<MdlPermisos> GetPermisosDeUsuario(int UserId)
    {

      using (var context = new lts_autogestionDataContext())
      {
        var permisos = from a in context.UsuariosObjetos_
                       where a.UsuarioId == UserId
                       join obj in context.Objetos_ on a.ObjetoId equals obj.ID
                       
                       select new MdlPermisos
                       {
                          ObjetoNombre = obj.Nombre,
                          ObjetoEstado = (int)a.Estado
                       };
        return permisos.ToList();
      }
    }
  }
}
