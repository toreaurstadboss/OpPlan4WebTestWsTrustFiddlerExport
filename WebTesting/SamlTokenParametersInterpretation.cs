using System;

namespace Fiddler.WebTesting
{

    public class SamlTokenParametersInterpretation
    {

        public string SamlAssertionIssueInstant { get; set; }

        public string SamlTokenClaimsGlientGuid { get; set; }

        public string SamlAssertionId { get; set; }

        public string SamlDigestValue { get; set; }

        public string SamlReferenceUri { get; set; }

        public string SamlDigitalSignature { get; set; }

        public string SamlNotBeforeCondition { get; set; }

        public string SamlNotOnOrAfter { get; set; }

        public string SamlCreated { get; set; }

        public string SamlExpires { get; set; }

        public DateTime InterpretationTime { get; set; }

    }

}
