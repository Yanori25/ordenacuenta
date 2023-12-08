using ClosedXML.Excel;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenaCuenta.Utilities
{
    public  class exportaexcel
    {

        public void ExportarDataTableAExcel(DataTable dataTable, string rutaArchivo , string archivo)
        {
            using (var libro = new XLWorkbook())
            {
                var hoja = libro.Worksheets.Add(archivo);

                // Agregar los datos del DataTable a la hoja de trabajo
                hoja.Cell(1, 1).InsertTable(dataTable);

                // Guardar el libro en el archivo especificado
                libro.SaveAs(rutaArchivo);
                MaterialMessageBox.Show("Se descargo exitosamente el archivo de excel");

            }
        }
    }
}
