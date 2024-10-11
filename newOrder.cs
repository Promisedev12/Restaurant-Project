using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restoran_Project
{
    public partial class newOrder : UserControl
    {
        public int FoodId { get; set; }

        public string FoodName
        {
            get { return gunaLabel20.Text; }
            set { gunaLabel20.Text = value; }
        }

        public string FoodPrice
        {
            get { return gunaLabel22.Text; }
            set { gunaLabel22.Text = value; }
        }

        public int Quantity
        {
            get { return (int)gunaNumeric1.Value; }
            set { gunaNumeric1.Value = value; }
        }

        public event EventHandler QuantityChanged;

        public event EventHandler ItemRemoved;

        public newOrder()
        {
            InitializeComponent();
            gunaNumeric1.ValueChanged += GunaNumeric1_ValueChanged;
        }

        private void gunaElipsePanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void gunaPictureBox7_Click(object sender, EventArgs e)
        {
            OnItemRemoved(EventArgs.Empty);
            //this.Parent.Controls.Remove(this);
        }

        private void GunaNumeric1_ValueChanged(object sender, EventArgs e)
        {
            OnQuantityChanged(EventArgs.Empty);
        }

        protected virtual void OnQuantityChanged(EventArgs e)
        {
            QuantityChanged?.Invoke(this, e);
        }

        protected virtual void OnItemRemoved(EventArgs e)
        {
            ItemRemoved?.Invoke(this, e);
        }

        public void IncrementQuantity()
        {
            Quantity++;
            OnQuantityChanged(EventArgs.Empty);
        }
    }
}