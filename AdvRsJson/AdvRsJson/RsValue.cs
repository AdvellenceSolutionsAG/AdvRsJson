namespace Sharedien.Riversand
{
    class RsValue
    {
        public string source;
        public string locale;
        public string id;
        public object value;

        public RsValue( object value, string id = null, string locale = RsConstants.VALUE_LOCALE, string source = RsConstants.VALUE_SOURCE)
        {
            this.source = source;
            this.locale = locale;
            if (string.IsNullOrEmpty(id)) this.id = System.Guid.NewGuid().ToString();
            else this.id = id;
            this.value = value;
        }
    }
}
