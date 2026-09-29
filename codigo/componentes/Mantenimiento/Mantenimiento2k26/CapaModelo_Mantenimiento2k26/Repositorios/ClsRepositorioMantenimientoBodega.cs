using CapaModelo_Mantenimiento2K26.Contratos;
using CapaModelo_Mantenimiento2K26.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;

namespace CapaModelo_Mantenimiento2K26.Repositorios
{
    public class ClsRepositorioMantenimientoBodega
        : ClsSentencias, IRepositorioMantenimientoBodega
    {
        private string _SelectAll;
        private string _Insert;
        private string _Update;
        private string _Delete;

        public ClsRepositorioMantenimientoBodega()
        {
            _SelectAll =
                "SELECT * FROM tblbodegas";

            _Insert =
                "INSERT INTO tblbodegas " +
                "(codigo_bodega, nombre_bodega, estatus_bodega) " +
                "VALUES (?, ?, ?)";

            _Update =
                "UPDATE tblbodegas SET " +
                "nombre_bodega=?, estatus_bodega=? " +
                "WHERE codigo_bodega=?";

            _Delete =
                "DELETE FROM tblbodegas " +
                "WHERE codigo_bodega=?";
        }

        public int SeguridadMetAgregar(
            ClsMantenimientoBodega Entidad)
        {
            var Parametros =
                new List<OdbcParameter>();

            Parametros.Add(
                new OdbcParameter(
                    "p_codigo_bodega",
                    Entidad.CodigoBodega));

            Parametros.Add(
                new OdbcParameter(
                    "p_nombre_bodega",
                    Entidad.NombreBodega));

            Parametros.Add(
                new OdbcParameter(
                    "p_estatus_bodega",
                    Entidad.EstatusBodega));

            return SeguridadMetEjecucionNonQuery(
                _Insert,
                Parametros,
                CommandType.Text);
        }

        public int SeguridadMetEditar(
            ClsMantenimientoBodega Entidad)
        {
            var Parametros =
                new List<OdbcParameter>();

            Parametros.Add(
                new OdbcParameter(
                    "p_nombre_bodega",
                    Entidad.NombreBodega));

            Parametros.Add(
                new OdbcParameter(
                    "p_estatus_bodega",
                    Entidad.EstatusBodega));

            Parametros.Add(
                new OdbcParameter(
                    "p_codigo_bodega",
                    Entidad.CodigoBodega));

            return SeguridadMetEjecucionNonQuery(
                _Update,
                Parametros,
                CommandType.Text);
        }

        public int SeguridadMetRemover(
            ClsMantenimientoBodega Entidad)
        {
            var Parametros =
                new List<OdbcParameter>();

            Parametros.Add(
                new OdbcParameter(
                    "p_codigo_bodega",
                    Entidad.CodigoBodega));

            return SeguridadMetEjecucionNonQuery(
                _Delete,
                Parametros,
                CommandType.Text);
        }

        public IEnumerable<ClsMantenimientoBodega>
            SeguridadMetObtenerTodos()
        {
            var ListaBodegas =
                new List<ClsMantenimientoBodega>();

            var TablaDatos =
                SeguridadMetEjecucionConsulta(
                    _SelectAll,
                    CommandType.Text);

            foreach (DataRow Fila in TablaDatos.Rows)
            {
                var Bodega =
                    new ClsMantenimientoBodega();

                Bodega.CodigoBodega =
                    Fila[0].ToString();

                Bodega.NombreBodega =
                    Fila[1].ToString();

                Bodega.EstatusBodega =
                    Fila[2].ToString();

                Bodega.CreatedAt =
                    Convert.ToDateTime(Fila[3]);

                Bodega.UpdatedAt =
                    Convert.ToDateTime(Fila[4]);

                ListaBodegas.Add(Bodega);
            }

            TablaDatos.Clear();
            TablaDatos = null;

            return ListaBodegas;
        }
    }
}