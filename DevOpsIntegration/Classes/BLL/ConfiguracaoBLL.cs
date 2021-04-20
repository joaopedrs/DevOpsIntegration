using DevOpsIntegration.Classes.Info;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace DevOpsIntegration.Classes.BLL
{
    public class ConfiguracaoBLL
    {
        string _filename = "config.xml";
        string _path = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);

        public ConfiguracaoInfo Carregar()
        {
            string fullfilepath = string.Format(@"{0}\{1}", _path, _filename);

            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(ConfiguracaoInfo));
                if (File.Exists(fullfilepath))
                {
                    using (FileStream fs = new FileStream(fullfilepath, FileMode.Open, FileAccess.ReadWrite))
                    {
                        return xs.Deserialize(fs) as ConfiguracaoInfo;
                    }
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Salvar(ConfiguracaoInfo info)
        {
            string fullfilepath = string.Format(@"{0}\{1}", _path, _filename);

            XmlSerializer xs = new XmlSerializer(typeof(ConfiguracaoInfo));
            using (FileStream fs = new FileStream(fullfilepath, FileMode.Create))
            {
                xs.Serialize(fs, info);
            }
        }
    }
}