using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Provetex.Purchase
{
    public partial class F_CU : Form
    {
        public F_CU()
        {
            InitializeComponent();
        }
        /// <methods>

        private void custumaz()
        {
            //var supplier = (from sup_item in Program.provetex.suppliers_items
            //                where sup_item.C_supplier in(from sup in Program.provetex.suppliers
            //                                             select sup.C_id_supplier)ToList()
            //                           select new
            //                           {
            //                               name = sup.C_name_supplier,
            //                               id = sup.C_id_supplier
            //                           }).ToList();
            //comboBox_sup.DataSource = Program.ExecuterSelection(@"select s._id_supplier,s._name_supplier from supplier s 
            //                                                        where s._id_supplier in (select _supplier
            //                                                        from suppliers_items)");

            //comboBox_sup.ValueMember = "_id_supplier";
            //comboBox_sup.DisplayMember = "_name_supplier";
            comboBox_item.DataSource = Program.ExecuterSelection(@"select * 
                                                                    from item
                                                                    where item._id_item in (select _item
                                                                    from suppliers_items)");
            comboBox_item.ValueMember = "_id_item";
            comboBox_item.DisplayMember = "_name_item";
        }
        /// </methods>

        private void F_CU_Load(object sender, EventArgs e)
        {
            custumaz();
        }
    }
}
