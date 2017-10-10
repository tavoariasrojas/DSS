using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BLL
{
    public class Funciones
    {
        #region Generar Lista de Series
        public List<string> generarSeries(string tipo, int ano_desde, int mes_desde, int ano_hasta, int mes_hasta)
        {
            string[] meses = new string[12] { "ENE-", "FEB-", "MAR-", "ABR-", "MAY-", "JUN-", "JUL-", "AGO-", "SEP-", "OCT-", "NOV-", "DIC-" };

            List<string> list = new List<string>();

            if (tipo.Equals("A"))
            {
                while (ano_desde <= ano_hasta)
                {
                    list.Add(Convert.ToString(ano_desde));
                    ano_desde += 1;
                }
            }

            if (tipo.Equals("M"))
            {
                DateTime fecha_inicial = new DateTime(ano_desde, mes_desde, 1);
                DateTime fecha_hasta = new DateTime(ano_hasta, mes_hasta, 1);

                while (fecha_inicial <= fecha_hasta)
                {
                    list.Add(meses[fecha_inicial.Month - 1] + Convert.ToString(fecha_inicial.Year));
                    fecha_inicial = fecha_inicial.AddMonths(1);
                }
            }
            return list;
        }
        #endregion

        #region Pasar DataSet a Diccionary
        public Dictionary<string, Int32> convertirDStoDictionary(DataSet ds)
        {
            Dictionary<string, Int32> dic = new Dictionary<string, Int32>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                dic.Add(dr[0].ToString(), Convert.ToInt32(dr[1].ToString()));
            }
            return dic;
        }
        #endregion

        #region Dar formato al Data Grid View
        public void formatearDataGrid(DataGridView dgv)
        {
            dgv.AllowDrop = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToOrderColumns = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;

            dgv.ColumnHeadersVisible = true;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightSteelBlue;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font(dgv.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);

            dgv.RowHeadersVisible = true;
            dgv.RowHeadersVisible = false;
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Font = new System.Drawing.Font("Tahoma", 8.25F);

            foreach (DataGridViewColumn column in dgv.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;

                if (column.Index == 0) column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                if (column.Index >= 2) column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

        }
        #endregion
    }
}
