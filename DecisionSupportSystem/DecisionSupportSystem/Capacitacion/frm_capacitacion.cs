using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using BLL;

namespace DecisionSupportSystem.Capacitacion
{
    public partial class frm_capacitacion : Form
    {
        Capacitar objCapacitar = new Capacitar();

        public frm_capacitacion()
        {
            InitializeComponent();
        }

        private void frm_capacitacion_Load(object sender, EventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            txt_ruta.Clear();
            // Al pulsar el botón Buscar, busca la ubicación del archivo txt.
            ofd_participantes.Title = "Seleccionar fichero";
            ofd_participantes.Filter = "Documentos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            ofd_participantes.FileName = txt_ruta.Text;
            if (ofd_participantes.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txt_ruta.Text = ofd_participantes.FileName;
            }
        }

        public DataTable ConvertToDataTable(string filePath, int numberOfColumns)
        {
            DataTable tbl = new DataTable();

            for (int col = 0; col < numberOfColumns; col++)
                tbl.Columns.Add(new DataColumn("Column" + (col + 1).ToString()));


            string[] lines = System.IO.File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                var cols = line.Split('\t');

                DataRow dr = tbl.NewRow();
                for (int cIndex = 0; cIndex < 2; cIndex++)
                {
                    dr[cIndex] = cols[cIndex];
                }

                tbl.Rows.Add(dr);
            }

            return tbl;
        }

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            DataTable dt = ConvertToDataTable(txt_ruta.Text, 2);
            foreach (DataRow row in dt.Rows)
            {
                dgv_participantes.Rows.Add(Convert.ToString(row[0]), Convert.ToString(row[1]));
            }
        }

        private void dgv_participantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_participantes.CurrentCell.GetType() == typeof(DataGridViewCheckBoxCell))
            {
                if (dgv_participantes.CurrentCell.Value.Equals("S"))
                {
                    dgv_participantes.CurrentCell.Value = "N";
                }
                else
                {
                    dgv_participantes.CurrentCell.Value = "S";
                }
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            List<string> participante = new List<string>();
            foreach (DataGridViewRow row in dgv_participantes.Rows)
            {
                if (row.Cells[1].Value.ToString().Equals("S"))
                {
                    participante.Add(row.Cells[0].Value.ToString());
                }
            }

            if (objCapacitar.ingresarParticipante(participante))
            {
                MessageBox.Show("Datos agregados correctamente.", "Validación del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("No se puede cargar la información.", "Validación del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            int num_participantes = objCapacitar.cantidadParticipantes("C");
            if(num_participantes > 0)
            {
                Random rnd = new Random();
                int numero = rnd.Next(1, num_participantes);
                l_participante.Text = objCapacitar.escogerParticipante("S", numero);
            }
            else
            {
                l_participante.Text = "NO HAY PARTICIPANTES AGREGADOS PARA EL PROCEOS.";
            }
            
        }
    }
}
