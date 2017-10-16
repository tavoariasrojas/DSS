using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Media;

namespace DecisionSupportSystem.Mapa
{
    public partial class frm_mapa : Form
    {
        public frm_mapa()
        {
            InitializeComponent();

            /*var r = new Random();

            var values = new Dictionary<string, double>();

            values["CR"] = r.Next(0, 100);
            values["CA"] = r.Next(0, 100);
            values["US"] = r.Next(0, 100);
            values["IN"] = r.Next(0, 100);
            values["CN"] = r.Next(0, 100);
            values["JP"] = r.Next(0, 100);
            values["BR"] = r.Next(0, 100);
            values["DE"] = r.Next(0, 100);
            values["FR"] = r.Next(0, 100);
            values["GB"] = r.Next(0, 100);

            var lang = new Dictionary<string, string>();
            lang["MX"] = "México"; // change the language if necessary

            gm_main.HeatMap = values;
            gm_main.LanguagePack = lang;
            gm_main.Source = @"C:\Users\garias\Source\DSS\DecisionSupportSystem\DecisionSupportSystem\Mapa\World.xml";*/


            var values = new Dictionary<string, double>();
            //Cartago
            values["1128"] = 100;//r.Next(0, 0);
            //Heredia
            values["1129"] = 500;//r.Next(0, 0);
            //Limón
            values["1130"] = 50;//r.Next(0, 3);
            //Puntarenas
            values["167"] = 100;//r.Next(0, 0);
            //San José
            values["1131"] = 1000;//r.Next(0, 200);
            //Alajuela
            values["1132"] = 700;//r.Next(0, 75);
            //Guanacaste
            values["1133"] = 25;//r.Next(0, 0);

            var lang = new Dictionary<string, string>();
            lang["CR"] = "Costa Rica"; // change the language if necessary

            gm_main.HeatMap = values;
            gm_main.LanguagePack = lang;
            gm_main.BackColor = System.Drawing.Color.White;
            gm_main.DefaultLandFill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255,255,255,255));

            GradientStopCollection grsc = new GradientStopCollection(2);
            /*grsc.Add(new GradientStop(System.Windows.Media.Color.FromArgb(100, 100, 0, 0), 0));
            grsc.Add(new GradientStop(System.Windows.Media.Color.FromArgb(100, 0, 100, 0), 1));*/

            grsc.Add(new GradientStop(System.Windows.Media.Color.FromArgb(150, 0, 250, 0), 0));
            grsc.Add(new GradientStop(System.Windows.Media.Color.FromArgb(200, 0, 70, 0), 2));

            /*grsc.Add(new GradientStop(System.Windows.Media.Color.FromArgb(100, 2, 100, 190), 0));
            grsc.Add(new GradientStop(System.Windows.Media.Color.FromArgb(255, 2, 50, 190), 1));*/

            gm_main.GradientStopCollection = grsc;
            gm_main.EnableZoomingAndPanning = true;

            gm_main.Source = @"C:\Users\garias\Source\DSS\DecisionSupportSystem\DecisionSupportSystem\Mapa\Costa Rica.xml";
            
        }

        private void frm_mapa_Load(object sender, System.EventArgs e)
        {

        }
    }
}
