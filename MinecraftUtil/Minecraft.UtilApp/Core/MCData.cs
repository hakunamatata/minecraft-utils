using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft.UtilApp.Core
{
    public class MCData
    {
        static readonly string root = Environment.CurrentDirectory;
        static readonly string dataPath = $"{root}\\mcdata";
        public static string ResourcePath => $"{root}\\mcres";
        static readonly string itemsFileName = $"{dataPath}\\items.dat";
        static readonly string blocksFileName = $"{dataPath}\\blocks.dat";
        public static MCData Database;
        public static void LoadDatabase()
        {
            #region === 文件检查 === 
            if (!Directory.Exists(dataPath))
                Directory.CreateDirectory(dataPath);
            if (!File.Exists(itemsFileName))
                File.WriteAllBytes(itemsFileName, "[]".S2B());
            if (!File.Exists(blocksFileName))
                File.WriteAllBytes(blocksFileName, "[]".S2B());
            #endregion

            var itemsContent = File.ReadAllBytes(itemsFileName);
            var blocksContent = File.ReadAllBytes(blocksFileName);

            Database = new MCData();
            Database.Items = JsonConvert.DeserializeObject<List<MCEntityRaw>>(itemsContent.B2S()).Select(p => (MCEntity)p).ToList();
            Database.Blocks = JsonConvert.DeserializeObject<List<MCEntityRaw>>(blocksContent.B2S()).Select(p => (MCEntity)p).ToList();
        }

        public List<MCEntity> Items { get; private set; }
        public List<MCEntity> Blocks { get; private set; }

        public List<MCEntity> AllEntities
        {
            get {
                return Blocks.Concat(Items).ToList();
            }
        }

        public void Add(MCEntity me)
        {
            switch (me.Type) {
                default:
                    if (Database.Blocks.Any(p => p.Code == me.Code)) {
                        // 如果数据库中已经存在
                        // 保存新值
                        Database.Blocks.Single(p => p.Code == me.Code).Reset(me);
                    }
                    else {
                        // 不存在， 则添加新值
                        Database.Blocks.Add(me);
                    }
                    break;
                case EntityType.Item:
                    if (Database.Items.Any(p => p.Code == me.Code)) {
                        // 如果数据库中已经存在
                        // 保存新值
                        Database.Items.Single(p => p.Code == me.Code).Reset(me);
                    }
                    else {
                        // 不存在， 则添加新值
                        Database.Items.Add(me);
                    }
                    break;
            }
        }

        public void Save()
        {
            File.WriteAllBytes(itemsFileName, JsonConvert.SerializeObject(Database.Items.Select(p => (MCEntityRaw)p)).S2B());
            File.WriteAllBytes(blocksFileName, JsonConvert.SerializeObject(Database.Blocks.Select(p => (MCEntityRaw)p)).S2B());
        }

        public void Remove(MCEntity e)
        {
            if (Blocks.Any(p => p.Code == e.Code)) {
                var i = Blocks.Single(p => p.Code == e.Code);
                Blocks.Remove(i);
            }

            if (Items.Any(p => p.Code == e.Code)) {
                var i = Items.Single(p => p.Code == e.Code);
                Items.Remove(i);
            }
        }

        //private void saveEntityIcon(MCEntity entity)
        //{
        //    if (!Directory.Exists(ResourcePath))
        //        Directory.CreateDirectory(ResourcePath);
        //    var filePath = $"{ResourcePath}\\{entity.Code}.png";
        //    entity.Icon.Save(filePath);

        //}
    }

    public class MCEntity
    {
        public Image Icon { get; private set; }
        public string Name { get; private set; }
        public string Code { get; private set; }
        public int Dex { get; private set; }
        public EntityType Type { get; private set; } = EntityType.Block;

        public MCEntity()
        {

        }

        public MCEntity(Image icon, string name, string code, int dex, EntityType type)
        {
            Icon = icon;
            Name = name;
            Code = code;
            Dex = dex;
            Type = type;
        }

        public MCEntity(Image icon, string name, string code, int dex) : this(icon, name, code, dex, EntityType.Block)
        {

        }

        public void Reset()
        {
            this.Icon = default(Image);
            this.Name = default(string);
            this.Code = default(string);
            this.Dex = default(int);
            this.Type = default(EntityType);
        }
        public void Reset(MCEntity e)
        {
            this.Icon = e.Icon;
            this.Name = e.Name;
            this.Code = e.Code;
            this.Dex = e.Dex;
            this.Type = e.Type;
        }

        public static implicit operator MCEntityRaw(MCEntity e)
        {
            string icon = null;
            try {
                if (e.Icon != null) {
                    if (!Directory.Exists(MCData.ResourcePath))
                        Directory.CreateDirectory(MCData.ResourcePath);
                    var filePath = $"{MCData.ResourcePath}\\{e.Code}.png";
                    e.Icon.Save(filePath);
                    icon = filePath;
                }
            }
            catch {
                icon = null;
            }

            return new MCEntityRaw {
                Code = e.Code,
                Dex = e.Dex,
                Icon = icon,
                Name = e.Name,
                Type = (int)e.Type
            };
        }
    }

    public class MCEntityRaw
    {
        public string Icon { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int Dex { get; set; }
        public int Type { get; set; }

        public static implicit operator MCEntity(MCEntityRaw er)
        {
            Image icon;
            try {
                icon = Image.FromFile(er.Icon);
            }
            catch {
                icon = null;
            }

            return new MCEntity(icon, er.Name, er.Code, er.Dex, (EntityType)er.Type);
        }
    }

    public enum EntityType
    {
        Default = 0,
        Block,
        Item,
    }
}
