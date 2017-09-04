using System;
using System.Collections.Generic;
using System.Data;

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
    }
}
