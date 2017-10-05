using System;

namespace AdvRsJson
{
    class RsDataBlob
    {
        public string blob;

        public void CreateBase64Image( byte[] imageBytes )
        {
            blob = Convert.ToBase64String(imageBytes);
        }
    }
}
