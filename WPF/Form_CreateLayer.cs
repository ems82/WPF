using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPF
{
    public partial class Form_CreateLayer : Form
    {
        /// <summary>
        /// Название слоя введенное в текстовое поле
        /// </summary>
        public string LayerName
        {
            get { return this.textBox_layerName.Text.Trim(); }
          //  set { this.textBox_layerName.ToString() = value; }
        }
        /// <summary>
        /// Состояние слоя включен/отключен
        /// </summary>
        public bool LayerIsOn
        {
            get { return this.checkBox_isOn.Checked; }
        }
        /// <summary>
        /// Состотяние слоя заморожен/разморожен
        /// </summary>
        public bool LayerIsFrozen
        {
            get { return this.checkBox_isFrozen.Checked; }
        }

        public Form_CreateLayer()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Обработка нажатия кноппки ОК
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_ok_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(LayerName))
            { DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            { MessageBox.Show("Название слоя не может быть пустым"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ///
        }
    }
}
