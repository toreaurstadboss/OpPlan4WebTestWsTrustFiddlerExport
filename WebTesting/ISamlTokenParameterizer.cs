namespace Fiddler.WebTesting
{
    public interface ISamlTokenParameterizer
    {
        string TokenizeSoapMessage(string soapMessage);
    }
}