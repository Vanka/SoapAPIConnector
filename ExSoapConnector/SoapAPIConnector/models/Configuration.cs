﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace APICon.conf
{    
    [XmlRoot(ElementName = "document")]
    public class Document
    {
        [XmlElement(ElementName = "doctype")]
        public string Doctype { get; set; }
        [XmlElement(ElementName = "custom_sign_extension")]
        public string custom_sign_extension { get; set; }
        [XmlElement(ElementName = "localPath")]
        public List<string> LocalPath { get; set; }
        [XmlElement(ElementName = "remoteFileNamePrefix")]
        public string remoteFileNamePrefix { get; set; }
        [XmlElement(ElementName = "localArchive")]
        public List<string> LocalArchive { get; set; }
        [XmlElement(ElementName = "ticketPath")]
        public List<string> TicketPath { get; set; }
        [XmlElement(ElementName = "thumpprint")]
        public string Thumpprint { get; set; }
        [XmlAttribute(AttributeName = "needToBeSigned")]
        public bool NeedToBeSigned { get; set; }
        [XmlAttribute(AttributeName = "needToBeZipped")]
        public bool NeedToBeZipped { get; set; }
        [XmlAttribute(AttributeName = "ticketsGenerate")]
        public bool TicketsGenerate { get; set; }
        /**/
        [XmlElement(ElementName = "status")]
        public string status { get; set; }
        [XmlElement(ElementName = "remoteFolder")]
        public string remoteFolder { get; set; }
    }
    [XmlRoot]
    public class ChainContainer
    {
        [XmlAttribute]
        public bool enable { get; set; }
        [XmlAttribute]
        public bool useSubFolders { get; set; }
        [XmlAttribute]
        public bool codeBase { get; set; }
        [XmlAttribute]
        public string signExtension { get; set; }
        [XmlText]
        public string value { get; set; }
    }

    [XmlRoot(ElementName = "inbound")]
    public class InboundOutbound
    {        
        [XmlElement(ElementName = "defaultPath")]
        public string DefaultPath { get; set; }
        [XmlElement(ElementName = "defaultArchive")]
        public string DefaultArchive { get; set; }
        [XmlElement(ElementName = "defaultError")]
        public string DefaultError { get; set; }
        [XmlElement(ElementName = "document")]
        public List<Document> Document { get; set; }
        [XmlAttribute(AttributeName = "enable")]
        public bool Enable { get; set; }
        [XmlAttribute(AttributeName = "isArchive")]
        public bool IsArchive { get; set; }
        [XmlAttribute(AttributeName = "useSubFoldersByDocType")]
        public bool SubFolders { get; set; }
        [XmlAttribute(AttributeName = "downloadALL")]
        public bool DownloadALL { get; set; }

        /*  for local container storage*/
        [XmlElement(ElementName = "chainContainer")]
        public ChainContainer chainContainer { get; set; }
    }    

    [XmlRoot(ElementName = "configuration")]
    public class Configuration
    {
        [XmlAttribute(AttributeName = "debug")]
        public bool debug { get; set; }
        [XmlElement(ElementName = "transport_schema")]
        public string TransportSchema { get; set; }
        [XmlElement(ElementName = "soap_endpoint")]
        public string SoapEndpointUrl { get; set; }
        [XmlElement(ElementName = "rest_endpoint")]
        public string RestEndpointUrl { get; set; }
        [XmlElement(ElementName = "login")]
        public string Login { get; set; }
        [XmlElement(ElementName = "soap_pass")]
        public string Soap_pass { get; set; }
        [XmlElement(ElementName = "api_pass")]
        public string Api_pass { get; set; }
        [XmlElement(ElementName = "thumpprint")]
        public string Thumpprint { get; set; }
        [XmlElement(ElementName = "logFile")]
        public string LogFile { get; set; }
        [XmlElement(ElementName = "inbound")]
        public InboundOutbound Inbound { get; set; }
        [XmlElement(ElementName = "outbound")]
        public InboundOutbound Outbound { get; set; }
        [XmlElement(ElementName = "EDOTickets")]
        public InboundOutbound EDOTickets { get; set; }

        public string getTransportSchema()
        {
            return (TransportSchema != null && TransportSchema.Equals("http")) ? "http" : "https";
        }

        public string getSoapEndpoint()
        {
            return SoapEndpointUrl != null ? SoapEndpointUrl : "soap-api.e-vo.ru";
        }

        public string getRestEndpoint()
        {
            return RestEndpointUrl != null ? RestEndpointUrl : "api-service.e-vo.ru";
        }

        public bool IsSecure()
        {
            return getTransportSchema().Equals("https");
        }

        public Document GetCustomInboundSettings(string docType)
        {
            foreach (Document doc in this.Inbound.Document)
                if (doc.Doctype == docType)
                    return doc;
            return null;
        }
        public Document GetCustomOutboundSettings(string docType)
        {
            foreach (Document doc in this.Outbound.Document)
                if (doc.Doctype == docType)
                    return doc;
            return null;
        }
        public Document GetCustomOutboundSettingsByPath(string docType, string path)
        {
            List<string> upd = new List<string>(new string[] { "ON_SCHFDOPPR", "ON_NSCHFDOPPR" });
            List<string> pok = new List<string>(new string[] { "ON_SCHFDOPPOK", "ON_NSCHFDOPPOK" });

            string dirName = Path.GetDirectoryName(path);
            foreach (Document doc in this.Outbound.Document)
            {
                if ((doc.LocalPath.Contains(dirName)) || (doc.LocalPath.Contains(dirName + "\\")))
                    if (doc.Doctype == docType)
                    {
                        return doc;
                    }
                    else
                    {
                        if ((upd.Contains(doc.Doctype)) && (upd.Contains(docType)))
                        {
                            return doc;
                        }
                        else if (((doc.Doctype.StartsWith("ON_SCHFDOPPR")) || (doc.Doctype.StartsWith("ON_NSCHFDOPPR"))) && ((docType.StartsWith("ON_SCHFDOPPR")) || (docType.StartsWith("ON_NSCHFDOPPR"))))
                        {
                            return doc;
                        }
                        else if ((pok.Contains(doc.Doctype)) && (pok.Contains(docType)))
                        {
                            return doc;
                        }
                        else if (((doc.Doctype.StartsWith("ON_SCHFDOPPOK")) || (doc.Doctype.StartsWith("ON_NSCHFDOPPOK"))) && ((docType.StartsWith("ON_SCHFDOPPOK")) || (docType.StartsWith("ON_NSCHFDOPPOK"))))
                        {
                            return doc;
                        }
                    }
                
            }
            return null;
        }
        public Document GetCustomEDOTicketSettings(string docType)
        {
            foreach (Document doc in this.EDOTickets.Document)
                if (doc.Doctype == docType)
                    return doc;
            return null;
        }
    }
}