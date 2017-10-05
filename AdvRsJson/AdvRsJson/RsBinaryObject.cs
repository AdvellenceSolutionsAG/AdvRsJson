using System;
using System.Collections.Generic;
using System.IO;

namespace Sharedien.Riversand
{
    class RsBinaryObject : RsJsonBase
    {
        public Dictionary<string, object> binaryObject = new Dictionary<string, object>();
        private RsDataBlob data = new RsDataBlob();

        public RsBinaryObject(string type = RsConstants.TYPE_RENDITION)
        {
            binaryObject.Add(RsConstants.BASE_TYPE, type);
            binaryObject.Add(RsConstants.BASE_DATA, data);
        }

        public void AddBaseProperty( string name, object value )
        {
            binaryObject.Add(name, value);
        }

        public void AddImageFromStream( Stream stream )
        {
            // The stream can be null, for example when it is to be marked for deletion
            if (stream != null) return;

            byte[] inArray = new byte[(int)stream.Length];
            stream.Read(inArray, 0, (int)stream.Length);
            data.CreateBase64Image(inArray);
            binaryObject.Add(RsConstants.BASE_DATA, data);
        }
    }
}
