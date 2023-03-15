using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    internal class Encriptar
    {
        public static string ficPruebas = Path.Combine(Application.StartupPath, "Clave.xml");
        public static UTF8Encoding UTFEnc = new UTF8Encoding();
        public static RSACryptoServiceProvider RSACryp = new RSACryptoServiceProvider();
        public static byte[] byteString, byteEncriptar, byteDescencriptar;
        public static string strDesencriptar = string.Empty;
        public static string strEncriptar = string.Empty;

        public static void crearXMLclaves(string ficPruebas)
        {
            string xmlKey = RSACryp.ToXmlString(true);
            string dirPruebas = Path.GetDirectoryName(ficPruebas);
            if (Directory.Exists(dirPruebas) == false)
            {
                Directory.CreateDirectory(dirPruebas);
            }
            using (StreamWriter sw = new StreamWriter(ficPruebas, false, Encoding.UTF8))
            {
                sw.WriteLine(xmlKey);
                sw.Close();
            }
        }

        public static string Lee_clavesXML(string fichero)
        {
            string s;

            using (StreamReader sr = new StreamReader(fichero, Encoding.UTF8))
            {
                s = sr.ReadToEnd();
                sr.Close();
            }

            return s;
        }

        public static string Encriptar1(string texto)
        {
            if (File.Exists(ficPruebas) == false)
            {
                crearXMLclaves(ficPruebas);
            }

            string xmlKeys = Lee_clavesXML(ficPruebas);
            RSACryp.FromXmlString(xmlKeys);
            if (!(string.IsNullOrEmpty(texto)))
            {
                try
                {
                    byteString = UTFEnc.GetBytes(texto);
                    byteEncriptar = RSACryp.Encrypt(byteString, false);
                    strEncriptar = Convert.ToBase64String(byteEncriptar);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            else
            {
                MessageBox.Show("Escriba un Texto a Encriptar");
            }
            return (strEncriptar);
        }

        public static string Descencriptar1(string texto)
        {
            string xmlKeys = Lee_clavesXML(ficPruebas);
            RSACryp.FromXmlString(xmlKeys);
            if (!(string.IsNullOrEmpty(texto)))
            {
                try
                {
                    byteString = Convert.FromBase64String(texto);
                    byteDescencriptar = RSACryp.Decrypt(byteString, false);
                    strDesencriptar = UTFEnc.GetString(byteDescencriptar, 0,
                    byteDescencriptar.Length);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            else
            {
                MessageBox.Show("Escriba un Texto a Encriptar");
            }
            return (strDesencriptar);
        }
    }
}
