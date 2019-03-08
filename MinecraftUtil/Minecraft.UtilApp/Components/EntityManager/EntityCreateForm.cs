using Minecraft.UtilApp.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft.UtilApp.Components
{
    public partial class EntityCreateForm : MCForm
    {
        public Image ItemIcon
        {
            get {
                return pictureBox1.Image;
            }
            set {
                pictureBox1.Image = value;
            }
        }
        public string ItemName
        {
            get {
                return textBox2.Text.Trim();
            }
            set {
                textBox2.Text = value;
            }
        }
        public string ItemCode
        {
            get {
                return textBox1.Text.Trim();
            }
            set {
                textBox1.Text = value;
            }
        }
        public EntityType Type { get; private set; }
        public int ItemDex
        {
            get {
                return Convert.ToInt32(numberBox1.Value);
            }
            set {
                numberBox1.Value = value;
            }
        }

        public MCEntity Entity { get; set; }

        public EntityCreateForm()
        {
            InitializeComponent();
        }

        public EntityCreateForm(EntityType type) : this()
        {
            Type = type;
        }

        /// <summary>
        /// 浏览图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var dialog = new OpenFileDialog()) {
                if (dialog.ShowDialog() == DialogResult.OK) {
                    pictureBox1.Image = Image.FromFile(dialog.FileName);
                }
            }
        }
        /// <summary>
        /// 保存按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ItemName) || string.IsNullOrEmpty(ItemCode)) {
                Alert("物品名称或者物品编码不可以留空");
            }
            else {
                Entity = new MCEntity(
                    ItemIcon,
                    ItemName,
                    ItemCode,
                    ItemDex,
                    Type
                );
                DialogResult = DialogResult.OK;
            }
        }
        /// <summary>
        /// 清除按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            ItemIcon = null;
            ItemCode = null;
            ItemDex = 0;
            ItemName = null;
        }
    }
}
