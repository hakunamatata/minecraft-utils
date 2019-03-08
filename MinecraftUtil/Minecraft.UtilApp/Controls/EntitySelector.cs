using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Minecraft.UtilApp.Components;
using Minecraft.UtilApp.Core;

namespace Minecraft.UtilApp.Controls
{
    public partial class EntitySelector : MCUserControl
    {
        public EntityType EntityType { get; set; } = EntityType.Default;
        public MCEntity SelectedEntity => comboBox1.SelectedItem as MCEntity;
        public EntitySelector()
        {
            InitializeComponent();
        }

        public EntitySelector(EntityType type) : this()
        {
            EntityType = type;
        }
        /// <summary>
        /// 添加新物品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            var itemCreateForm = new EntityCreateForm(EntityType);
            if (itemCreateForm.ShowDialog() == DialogResult.OK) {
                Database.Add(itemCreateForm.Entity);
                Database.Save();
                selectionBind();
            }
        }

        /// <summary>
        /// 删除物品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && Alert("确定删除吗？") == DialogResult.OK) {
                Database.Remove(comboBox1.SelectedItem as MCEntity);
                Database.Save();
                comboBox1.Items.Remove(comboBox1.SelectedItem);
            }
        }

        private void selectionBind()
        {
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Code";
            comboBox1.DataSource = Database.AllEntities.OrderBy(p => p.Dex).ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var box = sender as ComboBox;
            if (box.SelectedItem != null) {
                button2.Enabled = true;
                pictureBox1.Image = (box.SelectedItem as MCEntity).Icon;
            }
            else {
                button2.Enabled = false;
                pictureBox1.Image = null;
            }
        }

        private void EntitySelector_Load(object sender, EventArgs e)
        {
            if (EntityType != EntityType.Default)
                selectionBind();
        }

    }
}
