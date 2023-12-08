using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace OrdenaCuenta.Utilities
{


    public  class MaterialFrmEstilo 
    {
      

        public void frmMaterial ( MaterialForm formulario )
        {

             MaterialSkin.MaterialSkinManager materialSkinManagera;


            materialSkinManagera = MaterialSkin.MaterialSkinManager.Instance;
          //  materialSkinManagera.EnforceBackcolorOnAllComponents = true;
            materialSkinManagera.AddFormToManage(formulario); // se agrega quien se el formulario que se le dara el estilo
            materialSkinManagera.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT; // tema del formulario 
            // url de paleta de colores de mateial design 
            // https://desarrollador-android.com/material-design/diseno-material-design/estilo/color/ 
            // tutorial de explicacion https://www.youtube.com/watch?v=gEtXGyn8OMA&ab_channel=FoxLearn
            // colores del formulario parte superior en desgradado color de texto y color de la barra del menu seleccionado
            materialSkinManagera.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green500/*Indigo500*/,
                MaterialSkin.Primary.Green700/*Indigo700*/,
                MaterialSkin.Primary.Green100 /*Indigo100*/,
                MaterialSkin.Accent.Pink200,
                MaterialSkin.TextShade.WHITE);

        }


        public void frmMensaje(MaterialForm formulario)
        {

            MaterialSkin.MaterialSkinManager materialSkinManagera;


            materialSkinManagera = MaterialSkin.MaterialSkinManager.Instance;
            //  materialSkinManagera.EnforceBackcolorOnAllComponents = true;
            materialSkinManagera.AddFormToManage(formulario); // se agrega quien se el formulario que se le dara el estilo
            materialSkinManagera.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT; // tema del formulario 
            // url de paleta de colores de mateial design 
            // https://desarrollador-android.com/material-design/diseno-material-design/estilo/color/ 
            // tutorial de explicacion https://www.youtube.com/watch?v=gEtXGyn8OMA&ab_channel=FoxLearn
            // colores del formulario parte superior en desgradado color de texto y color de la barra del menu seleccionado
            materialSkinManagera.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Amber500/*Indigo500*/,
                MaterialSkin.Primary.Amber700/*Indigo700*/,
                MaterialSkin.Primary.Amber100 /*Indigo100*/,
                MaterialSkin.Accent.Pink200,
                MaterialSkin.TextShade.WHITE);

        }

    }
}
