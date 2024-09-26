using Capa_Datos;
using Capa_logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CrudMonolito.mantenimiento
{
    public partial class Agregar : System.Web.UI.Page
    {
        private tbl_producto productoinfo = new tbl_producto();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargar_proveedor();
                if (Request.QueryString["id"] == null) return;
                int productId;
                if (!int.TryParse(Request.QueryString["id"], out productId)) return;
                CargarDatosProducto(productId);
                
            }
        }
        private void CargarDatosProducto(int productId)
        {
            var producto = Cl_tbl_producto.GetById(productId);

            if (producto == null) return;
            txtNombreProducto.Text = producto.pro_nombre;
            txtCantidad.Text = producto.pro_cantidad.ToString();
            ddl_proveedor.SelectedValue = producto.prov_id.ToString();

           
        }
        private void cargar_proveedor()
        {
            var listProv = Cl_tbl_proveedor.listar();

            ddl_proveedor.DataSource = listProv;
            ddl_proveedor.DataTextField = "prov_nombre";
            ddl_proveedor.DataValueField = "prov_id";
            ddl_proveedor.DataBind();
        }
        protected void btn_guardar_Click(object sender, EventArgs e)
        {
            if (txtNombreProducto.Text == string.Empty || txtCantidad.Text == string.Empty )
                
            {
                lblResultado.ForeColor = System.Drawing.Color.Red;
                lblResultado.Text = "Debes rellenar todos los campos!";
                return;
            }

            try
            {
                
                if (!string.IsNullOrEmpty(Request.QueryString["id"]))
                {
                    int productId;
                    if (int.TryParse(Request.QueryString["id"], out productId))
                    {
                        var productoExistente = Cl_tbl_producto.GetById(productId);

                        if (productoExistente != null)
                        {
                            productoExistente.pro_nombre = txtNombreProducto.Text;
                            productoExistente.pro_cantidad = int.Parse(txtCantidad.Text);
                            productoExistente.prov_id = int.Parse(ddl_proveedor.SelectedValue);
                         

                            Cl_tbl_producto.modificar(productoExistente);

                            lblResultado.ForeColor = System.Drawing.Color.Green;
                            lblResultado.Text = "Producto actualizado correctamente!";
                        }
                    }
                }
                else
                {
                    // Agregar nuevo producto
                    var nuevoProducto = new tbl_producto
                    {
                        pro_nombre = txtNombreProducto.Text,
                        pro_cantidad = int.Parse(txtCantidad.Text),
                        prov_id = int.Parse(ddl_proveedor.SelectedValue),
                        
                    };

                    Cl_tbl_producto.guardar(nuevoProducto);

                    lblResultado.ForeColor = System.Drawing.Color.Green;
                    lblResultado.Text = "Producto guardado correctamente!";
                }

                ClearForm();
            }
            catch (Exception ex)
            {
                lblResultado.ForeColor = System.Drawing.Color.Red;
                lblResultado.Text = "Error: " + ex.Message;
            }
        }

        private void ClearForm()
        {
            txtNombreProducto.Text = string.Empty;
            txtCantidad.Text = string.Empty;
            ddl_proveedor.SelectedValue = "1";
        }
    }
}
