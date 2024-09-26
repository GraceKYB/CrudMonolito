using Capa_logica;
using System;
using System.Diagnostics;
using System.Web.UI.WebControls;
using Capa_Datos;

namespace CrudMonolito.mantenimiento
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarProductos();
            }
        }
        private void CargarProductos(string type = "", string busqueda = "")
        {
            try
            {
                var productos = Cl_tbl_producto.listar();
                gvProductos.DataSource = productos;
                gvProductos.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.Message);
            }
        }
        protected void gvProductos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int productId = Convert.ToInt32(gvProductos.DataKeys[e.RowIndex].Value);

            try
            {
                Cl_tbl_producto.Delete(productId);
                CargarProductos();
            }
            catch (Exception ex)
            {
                // Manejo de errores
                Response.Write("Error al eliminar el producto: " + ex.Message);
            }
        }
        protected void gvProductos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Editar":
                    {
                        int productId;
                        if (int.TryParse(e.CommandArgument.ToString(), out productId))
                        {
                            Response.Redirect($"Agregar.aspx?id={productId}");
                        }

                        break;
                    }
                case "Borrar":
                    {
                        int productId;
                        if (int.TryParse(e.CommandArgument.ToString(), out productId))
                        {
                            Cl_tbl_producto.Delete(productId);
                            CargarProductos();
                        }
                        break;
                    }
            }
        }
        protected void text_changed_Buscar(object sender, EventArgs e)
        {
            var bus = ddl_busqueda.SelectedValue;
            var busqueda = txt_busqueda.Text;
            if (busqueda == string.Empty)
            {
                CargarProductos();
                return;
            }
            switch (bus)
            {
                case "N":
                    var productos = Cl_tbl_producto.listarN(busqueda);
                    gvProductos.DataSource = productos;
                    gvProductos.DataBind();
                    break;
                case "C":
                    int cant;
                    if (int.TryParse(busqueda, out cant))
                    {
                        var productos2 = Cl_tbl_producto.listarC(cant);
                        gvProductos.DataSource = productos2;
                        gvProductos.DataBind();
                        break;
                    }
                    CargarProductos();
                    break;
                case "P":
                    int idPro;
                    if (int.TryParse(busqueda, out idPro))
                    {
                        var productos3 = Cl_tbl_producto.listarPro(idPro);
                        gvProductos.DataSource = productos3;
                        gvProductos.DataBind();
                        break;
                    }
                    CargarProductos();
                    break;
                default:
                    CargarProductos();
                    break;
            }
        }
    }
}
