using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using SubSonic;
using System.Security.Cryptography;
using System.Text;
using SmartCBSDataAccess;

namespace Common.DSMARTSecurity
{
    public static class DSMARTSecurity
    {
        public enum Privillages
        {
           FullAccess,
           NotSet,
           ViewAll,
           EditAll,
        }

        public enum AccessLevel
        { 
            View = 0,
            Maintain = 1,
            Add = 2,
            Edit = 3,
            Delete = 4,
            FullAccess = -1,
        }

        //public static UserLoginCollection validateUser(string userName, string password)
        //{
        //    Query q = UserLogin.CreateQuery();
        //    q.AddWhere(UserLogin.Columns.UserName, userName.Trim());
        //    q.AddWhere(UserLogin.Columns.Passworrd, password);
        //    q.AddWhere(UserLogin.Columns.IsActive, true);

        //    return new UserLoginController().FetchByQuery(q);
        //}

        //public static VwRolePrivillageCollection GetPrivillageForRole(int roleId)
        //{
        //    VwRolePrivillageCollection rolePrivillages = new VwRolePrivillageCollection();

        //    rolePrivillages.Where(VwRolePrivillage.Columns.RoleId, roleId);

        //    return rolePrivillages.Load();
        //}

        //public static UserMenuCollection GetUserMenus()
        //{
        //    System.Collections.Generic.List<int> ids = new System.Collections.Generic.List<int>();

        //    foreach (VwRolePrivillage p in UserSession.CurrentUserPrivillages)
        //    {
        //        ids.Add(p.PrivillageId.Value);
        //    }

        //    Query q = UserMenu.CreateQuery();
        //   q.AddWhere(UserMenu.Columns.PrivillageId, Comparison.In, ids);
        //   q.AddWhere(UserMenu.Columns.IsActive,true);

        //    q.ORDER_BY(UserMenu.Columns.TopMenuDisplayOrder, "ASC");

        //    return new UserMenuController().FetchByQuery(q);
        //}

        public static string Encrypt(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            //get hash result after compute it
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits
                //for each byte
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }

        public static string EncryptData(string toEncrypt)
        {
            byte[] keyArray;
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);

            //ConfigurationManager settingsReader = new ConfigurationManager();
            // Get the key from config file

            string key = ConfigurationManager.AppSettings["EncryptEmail"];
            //System.Windows.Forms.MessageBox.Show(key);
            //If hashing use get hashcode regards to your key

            MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
            keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            //Always release the resources and flush data
            // of the Cryptographic service provide. Best Practice

            hashmd5.Clear();

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            //set the secret key for the tripleDES algorithm
            tdes.Key = keyArray;
            //mode of operation. there are other 4 modes.
            //We choose ECB(Electronic code Book)
            tdes.Mode = CipherMode.ECB;
            //padding mode(if any extra byte added)

            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateEncryptor();
            //transform the specified region of bytes array to resultArray
            byte[] resultArray =
              cTransform.TransformFinalBlock(toEncryptArray, 0,
              toEncryptArray.Length);
            //Release resources held by TripleDes Encryptor
            tdes.Clear();
            //Return the encrypted data into unreadable string format
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        public static string Decrypt(string cipherString)
        {
            byte[] keyArray;
            //get the byte code of the string

            byte[] toEncryptArray = Convert.FromBase64String(cipherString);

            //System.Configuration.AppSettingsReader settingsReader =
            //                                    new AppSettingsReader();
            //Get your key from config file to open the lock!
            //string key = (string)settingsReader.GetValue("SecurityKey",
            //                                             typeof(String));

            string key = ConfigurationManager.AppSettings["EncryptEmail"];

            //if hashing was used get the hash code with regards to your key
            MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
            keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            //release any resource held by the MD5CryptoServiceProvider

            hashmd5.Clear();

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            //set the secret key for the tripleDES algorithm
            tdes.Key = keyArray;
            //mode of operation. there are other 4 modes. 
            //We choose ECB(Electronic code Book)

            tdes.Mode = CipherMode.ECB;
            //padding mode(if any extra byte added)
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(
                                 toEncryptArray, 0, toEncryptArray.Length);
            //Release resources held by TripleDes Encryptor                
            tdes.Clear();
            //return the Clear decrypted TEXT
            return UTF8Encoding.UTF8.GetString(resultArray);
        }

    }


}
