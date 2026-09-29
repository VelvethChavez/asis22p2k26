using CapaModelo_Mantenimiento2K26.Contratos;
using CapaModelo_Mantenimiento2K26.Entidades;
using CapaModelo_Mantenimiento2K26.Repositorios;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaControlador_Mantenimiento2K26.Modelos_de_controladores
{
    public class ClsModeloMantenimientoBodegas
    {
        private string _CodigoBodega;
        private string _NombreBodega;
        private string _EstatusBodega;

        
    }
}
using CapaModelo_Mantenimiento2K26.Contratos;
using CapaModelo_Mantenimiento2K26.Entidades;
using CapaModelo_Mantenimiento2K26.Repositorios;
using System.Collections.Generic;

namespace CapaControlador_Mantenimiento2K26.Modelos_de_controladores
{
    public class ClsModeloMantenimientoBodegas
    {
        private IRepositorioMantenimientoBodega _Repositorio;

        public string CodigoBodega { get; set; }
        public string NombreBodega { get; set; }
        public string EstatusBodega { get; set; }

        public ClsModeloMantenimientoBodegas()
        {
            _Repositorio =
                new ClsRepositorioMantenimientoBodega();
        }

        public int SeguridadMetAgregar()
        {
            var Bodega =
                new ClsMantenimientoBodega();

            Bodega.CodigoBodega =
                CodigoBodega;

            Bodega.NombreBodega =
                NombreBodega;

            Bodega.EstatusBodega =
                EstatusBodega;

            return _Repositorio.SeguridadMetAgregar(
                Bodega);
        }

        public int SeguridadMetEditar()
        {
            var Bodega =
                new ClsMantenimientoBodega();

            Bodega.CodigoBodega =
                CodigoBodega;

            Bodega.NombreBodega =
                NombreBodega;

            Bodega.EstatusBodega =
                EstatusBodega;

            return _Repositorio.SeguridadMetEditar(
                Bodega);
        }

        public int SeguridadMetRemover()
        {
            var Bodega =
                new ClsMantenimientoBodega();

            Bodega.CodigoBodega =
                CodigoBodega;

            return _Repositorio.SeguridadMetRemover(
                Bodega);
        }

        public IEnumerable<ClsMantenimientoBodega>
            SeguridadMetObtenerTodos()
        {
            return _Repositorio.SeguridadMetObtenerTodos();
        }
    }
}