﻿using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Data;
using LiveCharts.WinForms;

namespace BLL
{
    public class GraficoLiveCharts
    {
        #region variables
        /// <summary>
        /// Variables de la clase GraficoLivecharts
        /// </summary>
        /// <param name="ds">DataSet</param>
        /// <param name="campo">Campo</param>
        /// <param name="lista">Lista</param>
        ///
        private DataSet _ds;
        public DataSet ds
        {
            get { return _ds; }
            set { _ds = value; }
        }

        private string _campo;

        public string campo
        {
            get { return _campo; }
            set { _campo = value; }
        }

        private List<string> _lista;
        public List<string> lista
        {
            get { return _lista; }
            set { _lista = value; }
        }
        #endregion

        #region Utilidades de gráficos
        /// <summary>
        /// Método para limpiar gráfico
        /// </summary>
        /// <param name="cht">Gráfico</param>
        ///
        public void limpiarGrafico(LiveCharts.WinForms.CartesianChart cht)
        {
            int cantidad = 0;

            cantidad = cht.AxisX.Count;
            if (cantidad > 0)
            {
                for (int i = 0; i < cantidad; i++)
                {
                    cht.AxisX.RemoveAt(0);
                }
            }

            cantidad = cht.AxisY.Count;
            if (cantidad > 0)
            {
                for (int i = 0; i < cantidad; i++)
                {
                    cht.AxisY.RemoveAt(0);
                }
            }

            cantidad = cht.Series.Count;
            if (cantidad > 0)
            {
                for (int i = 0; i < cantidad; i++)
                {
                    cht.Series.RemoveAt(0);
                }
            }
        }
        #endregion

        #region metodos

        #region Agregar columnas
        /// <summary>
        /// Método para agregar columnas
        /// </summary>
        /// <param name="columna">Columna</param>
        ///
        public ColumnSeries agregarColumSeries(string columna)
        {
            LiveCharts.Wpf.ColumnSeries col = new ColumnSeries
            {
                Title = columna,
                Values = llenarChartValues(columna)
            };

            return col;
        }
        #endregion
        /// <summary>
        /// Método para llenar valores
        /// </summary>
        /// <param name="columna">Columna</param>
        ///
        #region Llenar valores
        public ChartValues<double> llenarChartValues(string columna)
        {
            var tmpcv = new List<double>();
            foreach (DataRow fila in this.ds.Tables[0].Rows)
            {
                tmpcv.Add(Convert.ToDouble(fila[columna].ToString()));
            }

            var cv = new ChartValues<double>();
            cv.AddRange(tmpcv.ToArray());

            return cv;
        }
        #endregion

        #region Llenar eje
        /// <summary>
        /// Método para llenar eje
        /// </summary>
        ///
        public List<string> llenarEje()
        {
            var tmpax = new List<string>();

            foreach (DataRow fila in this.ds.Tables[0].Rows)
            {
                tmpax.Add(fila[this.campo].ToString());
            }
            return tmpax;
        }
        #endregion

        #endregion
    }
}
