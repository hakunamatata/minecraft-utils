using Minecraft.UtilApp.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft.UtilApp.Components.EntityManager
{
    public partial class EntityForm : Form
    {
        public EntityType EntityType { get; set; }
        public EntityForm()
        {
            InitializeComponent();
        }

        public EntityForm(EntityType type) : this()
        {
            EntityType = type;
        }

        private void EntityForm_Load(object sender, EventArgs e)
        {
            entitySelector1.EntityType = EntityType;
        }
    }
}
