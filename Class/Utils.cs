using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace CapoeiraTimer.Class
{
    public static class Utils
    {
        #region [Methods]

        /// <summary>
        /// Serialize an object to XML
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string SerializeXml<T>( T obj ) where T : class
        {
            string _xml = string.Empty;
            XmlSerializer serializer = new XmlSerializer( typeof( T ) );

            using ( var output = new StringWriter() )
            {
                using ( XmlWriter writer = XmlWriter.Create( output ) )
                {
                    serializer.Serialize( writer, obj );
                    _xml = output.ToString();
                }
            }

            return _xml;
        }

        /// <summary>
        /// Save a file in a path
        /// </summary>
        /// <param name="path"></param>
        public static void SaveXml( string fileName, string data )
        {
            if ( !string.IsNullOrEmpty( fileName ) && !string.IsNullOrEmpty( data ) )
            {
                XmlDocument _xmlDocument = new XmlDocument();
                _xmlDocument.LoadXml( data );
                _xmlDocument.Save( $"{fileName}.xml" );
            }
        }

        /// <summary>
        /// Returns the path where the application is running
        /// </summary>
        public static string GetExecutionPath()
        {
            return Path.GetDirectoryName( System.Reflection.Assembly.GetExecutingAssembly().Location );
        }
        #endregion
    }
}
