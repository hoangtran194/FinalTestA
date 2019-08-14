using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

//Reference: System.Web.Extensions
using System.Web.Script.Serialization;


/*
 * STUDENT NAME: Tran Huy Hoang
 * STUDENT ID: 300 979 272
 * DESCRIPTION: This class for any ultilities use throughout the application
 */
namespace FinalTestA.Controllers
{
    public static class Ultilities
    {
        public static Random rnd = new Random();

        #region FILE IO
        /// <summary>
        /// This is for load Name from a file
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static List<string> LoadNames(string fileName)
        {
            try
            {
                List<string> result = new List<string>();
                using (var reader = new StreamReader(fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {

                        result.Add(line);
                    }
                }

                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        /// <summary>
        /// This is for write the name to the file
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static bool WriteToFile(string fileName, List<string> data)
        {
            try
            {
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }
                TextWriter writer = new StreamWriter(fileName);
                foreach (string lineData in data)
                {
                    writer.WriteLine(lineData);
                }
                writer.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        /// <summary>
        /// This is read serialized object fucntion
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static T ReadSerializedObjectFile<T>(string fileName)
        {
            try
            {
                T result;
                using (var reader = new StreamReader(fileName))
                {
                    result = Ultilities.deserializeObject<T>(reader.ReadToEnd());                    
                }

                return result;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return default(T);
            }
        }

        /// <summary>
        /// This it write serialized object
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fileName"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static bool WriteSerialObjectToFile<T>(string fileName, T data)
        {
            try
            {
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }
                TextWriter writer = new StreamWriter(fileName);
                string writenString = Ultilities.serializeObject<T>(data);
                writer.Write(writenString);
                writer.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }


        #endregion

        #region OTHER UTILITIES
        /// <summary>
        /// This is random number from max and min number
        /// </summary>
        /// <param name="minNumber"></param>
        /// <param name="maxNumber"></param>
        /// <returns></returns>
        public static int randomNumber(int minNumber, int maxNumber)
        {

            int result = rnd.Next(minNumber, maxNumber + 1);
            return result;
        }

        /// <summary>
        /// This function for serialized the object
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="toSerialize"></param>
        /// <returns></returns>
        public static string serializeObject<T>(this T toSerialize)
        {

            var jsonString = new JavaScriptSerializer().Serialize(toSerialize);
            return jsonString;
        }

        /// <summary>
        /// This function for deserialized object
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="stringDate"></param>
        /// <returns></returns>
        public static T deserializeObject<T>(string stringDate)
        {
            var result = new JavaScriptSerializer().Deserialize<T>(stringDate);
            return result;
        }
        #endregion

    }
}
