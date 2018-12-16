﻿using System.Xml.Serialization;

namespace Upnp
{
    [XmlRoot("container", Namespace = "urn:schemas-upnp-org:metadata-1-0/DIDL-Lite/")]
    public class DIDLContainer
    {
        [XmlAttribute("parentID")]
        public string ParentID { get; set; }

        [XmlAttribute("id")]
        public string Id { get; set; }

        [XmlAttribute("refId")]
        public string RefId { get; set; }

        [XmlAttribute("restricted")]
        public int Restricted { get; set; }

        [XmlAttribute("childCount")]
        public int ChildCount { get; set; }

        [XmlAttribute("numberOfAlbums")]
        public int NumberOfAlbums { get; set; }

        [XmlElement("name", Namespace = "urn:schemas-raumfeld-com:meta-data/raumfeld")]
        public string Name { get; set; }

        [XmlElement("class", Namespace = "urn:schemas-upnp-org:metadata-1-0/upnp/")]
        public string Class { get; set; }

        [XmlElement("section", Namespace = "urn:schemas-raumfeld-com:meta-data/raumfeld")]
        public string Section { get; set; }

        [XmlElement("totalPlayTime", Namespace = "urn:schemas-raumfeld-com:meta-data/raumfeld")]
        public string TotalPlayTime { get; set; }

        [XmlElement("title", Namespace = "http://purl.org/dc/elements/1.1/")]
        public string Title { get; set; }

        [XmlElement("date", Namespace = "http://purl.org/dc/elements/1.1/")]
        public string Date { get; set; }

        [XmlElement("album", Namespace = "urn:schemas-upnp-org:metadata-1-0/upnp/")]
        public string Album { get; set; }

        [XmlElement("artist", Namespace = "urn:schemas-upnp-org:metadata-1-0/upnp/")]
        public string Artist { get; set; }

        [XmlElement("genre", Namespace = "urn:schemas-upnp-org:metadata-1-0/upnp/")]
        public string Genre { get; set; }

        [XmlElement("creator", Namespace = "http://purl.org/dc/elements/1.1/")]
        public string Creator { get; set; }

        [XmlElement("description", Namespace = "http://purl.org/dc/elements/1.1/")]
        public string Description { get; set; }

        [XmlElement("albumArtURI", Namespace = "urn:schemas-upnp-org:metadata-1-0/upnp/")]
        public DIDLAlbumArtUriData AlbumArtUri { get; set; }

        [XmlElement("res")]
        public DIDLResData Res { get; set; }
    }
}
