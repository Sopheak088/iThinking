using System;
using System.Drawing;
using System.IO;

namespace ProjectManagement.Helper
{
    public static class Helper
    {
        /// <summary>
        /// Convert from string to Currency
        /// </summary>
        /// <param name="String"></param>
        /// <returns></returns>
        public static decimal StringToCurrency(string String)
        {
            if (!String.IsNullOrEmpty(String) || !String.IsNullOrWhiteSpace(String))
                String = string.Format("{0:C}", decimal.Parse(String));
            return (decimal.Parse(String));
        }

        public static float CurrencyToString(string String)
        {
            float sal;
            int n = Int16.Parse(String.Length.ToString());
            if (String.Substring(0, 1) == "$")
                sal = float.Parse(String.Substring(1, n - 1));
            else
            {
                sal = float.Parse(String);
            }
            return sal;
        }

        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            Image returnImage;
            try
            {
                MemoryStream ms = new MemoryStream(byteArrayIn, 0, byteArrayIn.Length);
                ms.Write(byteArrayIn, 0, byteArrayIn.Length);
                returnImage = Image.FromStream(ms, true); //Exception occurs here
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return returnImage;
        }

        public static byte[] ImageToByteArray(Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        public static byte[] StringToByteArray(string stringValue)
        {
            byte[] photo = null;
            if (!string.IsNullOrWhiteSpace(stringValue))
            {
                photo = File.ReadAllBytes(stringValue);
            }
            return (photo);
        }
    }
}