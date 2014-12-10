using System;
using System.Collections.Generic;
using System.Xml;

namespace Wampi
{
    internal class Source
    {
        public string Version;
        public string Architecture;
        public string Url;

        public override string ToString()
        {
            return Version + (String.IsNullOrEmpty(Architecture) ? "" : " (" + Architecture + "-bit)");
        }
    }

    internal class SourceLoader
    {
        private XmlDocument doc;

        public Dictionary<string, List<Source>> Sources;
        public HashSet<string> SourceTags = new HashSet<string>();

        public SourceLoader()
        {
            doc = new XmlDocument();
            Sources = new Dictionary<string, List<Source>>();
        }

        public void Parse(string xml)
        {
            doc.LoadXml(xml);
            Sources.Clear();
            foreach (string tag in SourceTags)
            {
                var sourceList = GetSourceList(GetSourceNode(tag));
                Sources.Add(tag, sourceList);
            }
        }

        private XmlNode GetSourceNode(string name)
        {
            return doc.DocumentElement.SelectSingleNode("/sources/" + name);
        }

        private List<Source> GetSourceList(XmlNode nodeList)
        {
            var list = new List<Source>();

            if (nodeList == null) return list;

            foreach (XmlNode node in nodeList)
            {
                var source = new Source();
                var attrVersion = node.Attributes.GetNamedItem("version");
                source.Version = attrVersion == null ? String.Empty : attrVersion.InnerText;
                var attrArchitecture = node.Attributes.GetNamedItem("architecture");
                source.Architecture = attrArchitecture == null ? String.Empty : attrArchitecture.InnerText;
                source.Url = node.InnerText;
                list.Add(source);
            }

            return list;
        }
    }
}