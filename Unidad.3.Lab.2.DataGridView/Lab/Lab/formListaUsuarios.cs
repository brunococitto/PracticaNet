using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab
{
    public partial class formListaUsuarios : Form
    {
        private Negocio.Usuarios _usuarios;
        public formListaUsuarios()
        {
            InitializeComponent();
            GenerarColumnas();
            this.dgvUsuarios.AutoGenerateColumns = false;
            this.oUsuarios = new Negocio.Usuarios();
            this.dgvUsuarios.DataSource = this.oUsuarios.GetAll();
        }
        public Negocio.Usuarios oUsuarios
        {
            get { return _usuarios; }
            set { _usuarios = value; }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.GuardarCambios();
            this.RecargarGrilla();
        }
        private void RecargarGrilla()
        {
            this.dgvUsuarios.DataSource = this.oUsuarios.GetAll();
        }
        private void GuardarCambios()
        {
            this.oUsuarios.GuardarCambios((DataTable)this.dgvUsuarios.DataSource);
        }
        private void GenerarColumnas()
        {
            //Creando la columna Nro. Documento
            DataGridViewTextBoxColumn colNroDoc = new DataGridViewTextBoxColumn();
            //Creamos la nueva columna y definimos el tipo de columna
            colNroDoc.Name = "nro_doc";
            //asignamos un nombre a la columna
            colNroDoc.HeaderText = "Nro. Documento";
            //indicamos el título a mostrar
            colNroDoc.DataPropertyName = "nro_doc";
            //indicamos con cual columna del DataTable que asignamos al
            //DataSource de la grilla debe vincularse
            colNroDoc.DisplayIndex = 0;
            // en que posición debe mostrarse, todas las columnas a la derecha
            // de la posición que indiquemos se moverán una posción a la derecha
            colNroDoc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgvUsuarios.Columns.Add(colNroDoc);
            //Agregamos la columna al DataGridView para que la muestre

            DataGridViewComboBoxColumn colTipoDoc = new DataGridViewComboBoxColumn();
            colTipoDoc.Name = "tipo_doc";
            colTipoDoc.HeaderText = "Tipo Documento";
            colTipoDoc.DataPropertyName = "tipo_doc";
            colTipoDoc.DisplayIndex = 0;

            colTipoDoc.DataSource = this.getTiposDocumento();
            //Asigno la lista de items que son válidos

            colTipoDoc.ValueMember = "cod_tipo_doc";
            //indico que el valor interno del combo es el
            //valor de la fila elegida y la columna cod_tipo_doc
            //del DataSource que asigné a la columna colTipoDoc

            colTipoDoc.DisplayMember = "desc_tipo_doc";
            //indico que el valor que se muestra al usuario es el
            //que se corresponde con la columna desc_tipo_doc
            //del DataSource que asigné a colTipoDoc independientemente
            //de la columna de la cual obtiene su valor

            this.dgvUsuarios.Columns.Add(colTipoDoc);

            //Telefono
            DataGridViewTextBoxColumn colTel = new DataGridViewTextBoxColumn();
            colTel.Name = "telefono";
            colTel.HeaderText = "Telefono";
            colTel.DataPropertyName = "telefono";
            this.dgvUsuarios.Columns.Add(colTel);

            //Email
            DataGridViewTextBoxColumn colEmail = new DataGridViewTextBoxColumn();
            colEmail.Name = "email";
            colEmail.HeaderText = "E-Mail";
            colEmail.DataPropertyName = "email";
            colEmail.Width = 250;
            this.dgvUsuarios.Columns.Add(colEmail);

            //Celular
            DataGridViewTextBoxColumn colCel = new DataGridViewTextBoxColumn();
            colCel.Name = "celular";
            colCel.HeaderText = "Celular";
            colCel.DataPropertyName = "celular";
            this.dgvUsuarios.Columns.Add(colCel);

            //Usuario
            DataGridViewTextBoxColumn colUsuario = new DataGridViewTextBoxColumn();
            colUsuario.Name = "usuario";
            colUsuario.HeaderText = "Usuario";
            colUsuario.DataPropertyName = "usuario";
            this.dgvUsuarios.Columns.Add(colUsuario);

            //Clave
            DataGridViewTextBoxColumn colClave = new DataGridViewTextBoxColumn();
            colClave.Name = "clave";
            colClave.HeaderText = "Clave";
            colClave.DataPropertyName = "clave";
            colClave.Visible = false;
            this.dgvUsuarios.Columns.Add(colClave);

            this.dgvUsuarios.Columns["direccion"].Width = 250;
            this.dgvUsuarios.Columns["apellido"].DefaultCellStyle.Font =
            new Font(this.dgvUsuarios.DefaultCellStyle.Font, FontStyle.Bold);
            this.dgvUsuarios.Columns["nombre"].DefaultCellStyle.Font =
            new Font(this.dgvUsuarios.DefaultCellStyle.Font, FontStyle.Bold);
            this.dgvUsuarios.Columns["fechaNacimiento"].DefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleRight;

        }
        private DataTable getTiposDocumento()
        {
            //Creo DataTable
            DataTable dtTiposDoc = new DataTable();

            //Agrego columnas al DataTable
            dtTiposDoc.Columns.Add("cod_tipo_doc", typeof(int));
            dtTiposDoc.Columns.Add("desc_tipo_doc", typeof(string));

            //Agrego filas al DataTable
            dtTiposDoc.Rows.Add(new object[] { 1, "DNI" });
            dtTiposDoc.Rows.Add(new object[] { 2, "Cédula" });
            dtTiposDoc.Rows.Add(new object[] { 3, "Pasaporte" });
            dtTiposDoc.Rows.Add(new object[] { 4, "Libreta Cívica" });
            dtTiposDoc.Rows.Add(new object[] { 5, "Libreta Enrolamiento" });

            return dtTiposDoc;
        }
    }
}
