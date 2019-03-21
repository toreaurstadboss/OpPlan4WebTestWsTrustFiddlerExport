using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
//using System.Xml;
using System.Xml.Linq;

namespace Fiddler.WebTesting 
{

    public class SamlTokenParameterizer : ISamlTokenParameterizer
    {

        // ReSharper disable once InconsistentNaming
        private const string TEMPORARY_FILE_NAME_SAML_TOKEN_PARAMETERIZED = "SamlTokenParameterFile.txt";

        public SamlTokenParameterizer()
        {
            SamlInterpretationHistory = new Dictionary<string, SamlTokenParametersInterpretation>();
        }

        public Dictionary<string, SamlTokenParametersInterpretation> SamlInterpretationHistory { get; set; }


        public string TokenizeSoapMessage(string soapEnvelope)
        {
            if (string.IsNullOrEmpty(soapEnvelope))
                return soapEnvelope;

            try
            {
                //Interpret the soap message with saml token
                var samlTokenInterpretation = new SamlTokenParametersInterpretation();
                var xdoc = XDocument.Parse(soapEnvelope);
                XNamespace oasis = XNamespace.Get("urn:oasis:names:tc:SAML:2.0:assertion");

                XNamespace ds = XNamespace.Get("http://www.w3.org/2000/09/xmldsig#");

                XNamespace u = XNamespace.Get("http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd");

                var assertion = xdoc.Descendants(oasis + "Assertion").First();

                var timeStamp = xdoc.Descendants(u + "Timestamp").First();

                var timeStampCreated = timeStamp.Element(u + "Created");

                var timeStampExpires = timeStamp.Element(u + "Expires");

                var issueInstant = assertion.Attribute("IssueInstant").Value;

                samlTokenInterpretation.SamlAssertionIssueInstant = issueInstant;

                var assertionId = assertion.Attribute("ID");

                var clientGuid = assertion.Descendants(oasis + "Attribute").First(x => x.Attribute("Name").Value == "http://schemas.hemit.no/Hemit/Iam/Claims/ClientGuid").Element(oasis + "AttributeValue").Value;

                samlTokenInterpretation.SamlTokenClaimsGlientGuid = clientGuid;

                samlTokenInterpretation.SamlAssertionId = assertionId.Value;

                var digitalSignature = assertion.Element(ds + "Signature");
                var digitalSignedInfo = digitalSignature.Element(ds + "SignedInfo");
                var digestValue = digitalSignedInfo.Element(ds + "Reference").Element(ds + "DigestValue").Value;

                samlTokenInterpretation.SamlDigestValue = digestValue;

                var digitalReferenceUri = digitalSignedInfo.Element(ds + "Reference").Attribute("URI");

                samlTokenInterpretation.SamlReferenceUri = digitalReferenceUri.Value;

                var signatureValue = digitalSignature.Element(ds + "SignatureValue").Value;

                samlTokenInterpretation.SamlDigitalSignature = signatureValue;

                var notBefore = assertion.Element(oasis + "Conditions").Attribute("NotBefore").Value;
                var notAfter = assertion.Element(oasis + "Conditions").Attribute("NotOnOrAfter").Value;

                samlTokenInterpretation.SamlNotBeforeCondition = notBefore;

                samlTokenInterpretation.SamlNotOnOrAfter = notAfter;

                samlTokenInterpretation.InterpretationTime = DateTime.UtcNow;

                samlTokenInterpretation.SamlCreated = timeStampCreated.Value;
                samlTokenInterpretation.SamlExpires = timeStampExpires.Value;

                SamlInterpretationHistory.Add(soapEnvelope, samlTokenInterpretation);

                //Next modify the soap envelope

                assertion.Attribute("ID").SetValue(@"{{SamlAssertionId}}");
                assertion.Attribute("IssueInstant").SetValue(@"{{SamlAssertionIssueInstant}}");
                assertion.Descendants(oasis + "Attribute").First(x => x.Attribute("Name").Value == "http://schemas.hemit.no/Hemit/Iam/Claims/ClientGuid")
                    .Element(oasis + "AttributeValue").SetValue(@"{{SamlTokenClaimsClientGuid}}");
                assertion.Element(oasis + "Conditions").Attribute("NotBefore").SetValue(@"{{SamlNotBeforeCondition}}");
                assertion.Element(oasis + "Conditions").Attribute("NotOnOrAfter").SetValue(@"{{SamlNotOnOrAfter}}");
                digitalSignature.Element(ds + "SignatureValue").SetValue(@"{{SamlDigitalSignature}}");
                digitalSignedInfo.Element(ds + "Reference").Element(ds + "DigestValue").SetValue(@"{{SamlDigestValue}}");
                timeStampCreated.SetValue(@"{{SamlCreated}}");
                timeStampExpires.SetValue(@"{{SamlExpires}}");
                digitalReferenceUri.SetValue(@"{{SamlReferenceUri}}");

                xdoc.Save(TEMPORARY_FILE_NAME_SAML_TOKEN_PARAMETERIZED, SaveOptions.DisableFormatting);
                string finalParameterizedSoapEnvelope = File.ReadAllText(TEMPORARY_FILE_NAME_SAML_TOKEN_PARAMETERIZED);

                return finalParameterizedSoapEnvelope;

                //string finalParameterizedSoapEnvelope = OutputXDocumentWithoutNewLines(xdoc);

                //finalParameterizedSoapEnvelope = Regex.Replace(finalParameterizedSoapEnvelope, " />", "/>");

                //return finalParameterizedSoapEnvelope; 
            }
            catch (Exception err)
            {
                return soapEnvelope;
            }
        }


        //private string OutputXDocumentWithoutNewLines(XDocument doc)
        //{
        //    var settings = new XmlWriterSettings
        //    {
        //        OmitXmlDeclaration = true,
        //        NewLineHandling = NewLineHandling.None,
        //        DoNotEscapeUriAttributes = true
        //    };

        //    using (var sw = new StringWriter())
        //    {
        //        using (var xw = XmlWriter.Create(sw, settings))
        //        {
        //            // ReSharper disable once UseNullPropagation
        //            if (doc.Root != null)
        //                doc.Root.WriteTo(xw);
        //        }
        //        var xmlString = sw.ToString();

        //        return xmlString;
        //    }
        //}

    }

}
