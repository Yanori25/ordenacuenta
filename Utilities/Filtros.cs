using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdenaCuenta.Utilities
{
    internal class Filtros
    {
        public  Filtros() { }

        public void Filtrarlistview(string txtfiltro , List<ListViewItem> elementosOriginales , MaterialListView listamaterial )
        {
            string filtro = txtfiltro.ToLower();

            if (string.IsNullOrEmpty(filtro))
            {
                // Si no hay texto de búsqueda, restaura todos los elementos originales.
                listamaterial.Items.Clear();
                listamaterial.Items.AddRange(elementosOriginales.ToArray());
            }
            else
            {
                // Si hay texto de búsqueda, aplica el filtro.
                List<ListViewItem> elementosFiltrados = new List<ListViewItem>();

                foreach (ListViewItem item in elementosOriginales)
                {
                    bool contieneTexto = false;
                    foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                    {
                        if (subItem.Text.ToLower().Contains(filtro))
                        {
                            contieneTexto = true;
                            break;
                        }
                    }

                    if (contieneTexto)
                    {
                        elementosFiltrados.Add(item);
                    }
                }

                // Borra todos los elementos actuales en el MaterialListView y agrega los elementos filtrados.
                listamaterial.Items.Clear();
                listamaterial.Items.AddRange(elementosFiltrados.ToArray());
            }


        }
    }
}
