namespace Framework.util
{
    public class GlobalUtil
    {
        public string currentDirectorys = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
        
        public string browserType = "chrome";
        public string applicationURL = "https://demo.opencart.com/";

    }
}
