namespace PracticaFinal
{
    using Microsoft.VisualBasic;
    using Models;
    using System.ComponentModel;
    using System.Collections.Generic;

    public partial class Form1 : Form
    {
        private BindingList<Cliente> clientes = new BindingList<Cliente>();

        public event EventHandler<decimal> ImporteMayorADiezMil;
        public Form1()
        {
            InitializeComponent();
            dgvClientes.AutoGenerateColumns = true;
            dgvPagados.AutoGenerateColumns = true;
            dgvPendientes.AutoGenerateColumns = true;
            dgvClientes.DataSource = clientes;

            dgvClientes.SelectionChanged += DgvClientes_SelectionChanged;
            ImporteMayorADiezMil += Form1_ImporteMayorADiezMil;
        }
        private void Form1_ImporteMayorADiezMil(object sender, decimal total)
        {
            MessageBox.Show($"Atencion: el total a pagar supera los 10.000 (Total: {total:C}.",
                "Importe Alto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void DgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            RefrescarCobros();
        }
        private void RefrescarCobros()
        {
            var cli = ClienteSeleccionado;
            if (cli == null)
            {
                dgvPendientes.DataSource = null;
                dgvPagados.DataSource = null;
                return;
            }
            var pendientes = cli.cobros.Where(c => !c.Pagado).ToList();
            var pagados = cli.cobros.Where(c => c.Pagado).ToList();
            dgvPendientes.DataSource = pendientes;
            dgvPagados.DataSource = pagados;

            RefrescarOrdenados();
            RefrescarResumen();
        }
        private Cliente ClienteSeleccionado =>
            dgvClientes.CurrentRow?.DataBoundItem as Cliente; // Nos fijamos si esta siendo seleccionada una fila
        private void Form1_Load(object sender, EventArgs e)
        {
            nudImporte.Value = 0;
            dtpVencimiento.Value = DateTime.Today;
            rbNormal.Checked = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(Interaction.InputBox("Ingrese legajo"), out int legajo))
                {
                    throw new Exception("El legajo debe ser numerico");
                }
                string nombre = Interaction.InputBox("Ingrese Nombre");
                if (string.IsNullOrEmpty(nombre))
                {
                    throw new Exception("Ingrese el nombre del cliente");
                }
                if (clientes.Any(c => c.Legajo == legajo))
                {
                    throw new Exception("Ya existe un cliente con ese legajo");
                }
                var cli = new Cliente
                {
                    Legajo = legajo,
                    Nombre = nombre
                };

                clientes.Add(cli);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                var cli = ClienteSeleccionado;
                if (cli == null) throw new Exception("Seleccione un cliente");
                if (!int.TryParse(Interaction.InputBox("Ingrese nuevo legajo"), out int legajo))
                {
                    throw new Exception("El legajo debe ser numerico");
                }
                string NombreModificado = Interaction.InputBox("Ingrese nuevo nombre");
                if (String.IsNullOrEmpty(NombreModificado))
                {
                    throw new Exception("Ingrese un nombre valido");
                }
                if (clientes.Any(c => c.Legajo == legajo && c != cli))
                {
                    throw new Exception("Ya existe otro cliente con ese legajo");
                }
                cli.Legajo = legajo;
                cli.Nombre = NombreModificado;

                dgvClientes.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var cli = ClienteSeleccionado;
                if (cli == null) throw new Exception("Ingrese el cliente a eliminar");
                if (cli.cobros.Any()) // Busca si hay algun cobro, si es asi...
                {
                    throw new Exception("No se puede eliminar un cliente con cobros");
                }
                clientes.Remove(cli);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnAgregarCobro_Click(object sender, EventArgs e)
        {
            try
            {
                if (nudImporte.Value == 0)
                {
                    var r = MessageBox.Show("Usted ingreso un monto de $0\n Desea modificarlo?"
                        , "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (r == DialogResult.OK)
                    {
                        int valor = int.Parse(Interaction.InputBox("Ingrese el valor"));
                        nudImporte.Value = valor;
                    }
                }
                var cli = ClienteSeleccionado;
                if (cli == null) throw new Exception("Seleccione un CLIENTE");
                if (!int.TryParse(Interaction.InputBox("Ingrese codigo del cobro"), out int codigo))
                {
                    throw new Exception("Ingrese un codigo valido");
                }
                string NombreCobro = Interaction.InputBox("Ingrese nombre del cobro");
                if (String.IsNullOrEmpty(NombreCobro))
                {
                    throw new Exception("Ingrese un nombre valido");
                }
                if (clientes.SelectMany(c => c.cobros).Any(c => c.Codigo == codigo))
                {
                    throw new Exception("Ya existe un cobro con ese codigo");
                }
                int pendientes = cli.cobros.Count(c => !c.Pagado); // Se cuenta cuantos cobros del ciente tienen pagado == false, o sea, pendientes.
                if (pendientes >= 2) throw new Exception
                ("El cliente no puede tener 2 o mas cobros pendientes");
                var tipo = rbEspecial.Checked ?
                    Cobro.TipoCobro.Especial
                    : Cobro.TipoCobro.Normal;

                var cobro = new Cobro
                {
                    Codigo = codigo,
                    Nombre = NombreCobro,
                    Importe = nudImporte.Value,
                    FechaVencimiento = dtpVencimiento.Value.Date,
                    Tipo = tipo,
                    Pagado = false
                };
                LimpiarCamposCobro();
                cli.cobros.Add(cobro);
                RefrescarCobros();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarCamposCobro()
        {
            nudImporte.Value = 0;
            dtpVencimiento.Value = DateTime.Today;
            rbNormal.Checked = true;
        }

        private void btnPagarCobro_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPendientes.CurrentRow == null)
                {
                    throw new Exception("Seleccione un cobro pendiente de la grilla 2");
                }
                var cobro = dgvPendientes.CurrentRow.DataBoundItem as Cobro;
                if (cobro == null) return;
                DateTime fechaPago = DateTime.Now;
                decimal recargo = cobro.CalcularRecargo(fechaPago);
                decimal total = cobro.Importe + recargo;

                string texto = $"Importe a pagar: {cobro.Importe:C}\n" +
                    $"Recargo: {recargo:C}\n" +
                    $"Total: {total:C}\n";

                var r = MessageBox.Show(texto, "Confirmar pago",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (r == DialogResult.OK)
                {
                    cobro.Pagado = true;
                    cobro.FechaPago = fechaPago;
                    cobro.TotalPagado = total;
                    if (total >= 10000m) ImporteMayorADiezMil?.Invoke(this, total);
                    RefrescarCobros();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        class CobroTotalComparer : IComparer<Cobro>
        {
            private bool _desc;
            public CobroTotalComparer(bool desc)
            {
                _desc = desc;
            }
            public int Compare(Cobro? x, Cobro? y)
            {
                //Manejo de posibles nulls
                if (x == null && y == null) return 0;
                if (x == null) return _desc ? 1 : -1;
                if (y == null) return _desc ? -1 : 1;
                decimal tx = x.TotalPagado;
                decimal ty = y.TotalPagado;

                int result = tx.CompareTo(ty); //<0 si tx<ty ;  0 si son iguales y  >0 si tx>ty
                return _desc ? -result : result; // si es descendente invierto el resultado
            }
        }
        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            RefrescarOrdenados();
        }
        private void RefrescarOrdenados()
        {
            var cli = ClienteSeleccionado;
            if (cli == null || !cli.cobros.Any(c => c.Pagado))
            {
                dgvOrdenados.DataSource = null;
                return;
            }
            var pagados = cli.cobros.Where(c => c.Pagado).ToList();
            bool desc = rbMayorMenor.Checked;
            pagados.Sort(new CobroTotalComparer(desc));
            dgvOrdenados.DataSource = pagados;
        }
        private void RefrescarResumen()
        {
            var datos = clientes
                .Select(c => new
                {
                    Cliente = c.Nombre,
                    ImporteTotalCancelado = c.cobros
                    .Where(co => co.Pagado)
                    .Sum(co => co.TotalPagado)
                })
                .ToList();
            dgvResumen.DataSource = datos;
        }
    }
}
