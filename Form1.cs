using MaterialSkin.Controls; // el proyecto tiene material design 2.0 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdenaCuenta
{
    public partial class Form1 : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public Form1()
        {
            
            InitializeComponent();
          //  el proyecto tiene material design 2.0
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green500/*Indigo500*/, MaterialSkin.Primary.Green700/*Indigo700*/,
                MaterialSkin.Primary.Green100 /*Indigo100*/, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);


          
        }
    }
}
