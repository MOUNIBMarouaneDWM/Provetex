using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Provetex.Supplier
{
    public partial class F_Details : Form
    {
        public F_Details()
        {
            InitializeComponent();
        }
        //Methods
        private void ListSuppliers()
        {
            DataGrid_list.DataSource = (from sup in Program.provetex.suppliers
                                        join sup_item in Program.provetex.suppliers_items on sup.C_id_supplier equals sup_item.C_supplier
                                        group sup by new {sup.C_id_supplier,sup.C_name_supplier}
                                        into g
                                        select new 
                                        {
                                            ID = g.Key.C_id_supplier,
                                            FOURNISSEUR = g.Key.C_name_supplier,
                                            NOMBRE_ARTICLE= g.Count(),
                                        }
                                        ).ToList();
        }
        //
        private void F_Details_Load(object sender, EventArgs e)
        {
            ListSuppliers();
        }
    }
}
