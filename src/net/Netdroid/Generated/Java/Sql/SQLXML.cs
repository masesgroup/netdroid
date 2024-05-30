/*
*  Copyright 2024 MASES s.r.l.
*
*  Licensed under the Apache License, Version 2.0 (the "License");
*  you may not use this file except in compliance with the License.
*  You may obtain a copy of the License at
*
*  http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing, software
*  distributed under the License is distributed on an "AS IS" BASIS,
*  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
*  See the License for the specific language governing permissions and
*  limitations under the License.
*
*  Refer to LICENSE for more information.
*/

/*
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Sql
{
    #region ISQLXML
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ISQLXML
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.sql/java/sql/SQLXML.html#getBinaryStream()"/> 
        /// </summary>
        Java.Io.InputStream BinaryStream { get; }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.sql/java/sql/SQLXML.html#getCharacterStream()"/> 
        /// </summary>
        Java.Io.Reader CharacterStream { get; }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.sql/java/sql/SQLXML.html#getString()"/> <see href="https://developer.android.com/reference/java.sql/java/sql/SQLXML.html#setString(java.lang.String)"/>
        /// </summary>
        Java.Lang.String String { get; set; }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.sql/java/sql/SQLXML.html#setResult(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"><see cref="Javax.Xml.Transform.IResult"/></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        T SetResult<T>(Java.Lang.Class arg0) where T: Javax.Xml.Transform.IResult, new();
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.sql/java/sql/SQLXML.html#getSource(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"><see cref="Javax.Xml.Transform.ISource"/></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        T GetSource<T>(Java.Lang.Class arg0) where T: Javax.Xml.Transform.ISource, new();
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.sql/java/sql/SQLXML.html#setBinaryStream()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.OutputStream"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        Java.Io.OutputStream SetBinaryStream();
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.sql/java/sql/SQLXML.html#setCharacterStream()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.Writer"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        Java.Io.Writer SetCharacterStream();
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.sql/java/sql/SQLXML.html#free()"/>
        /// </summary>
        /// <exception cref="Java.Sql.SQLException"/>
        void Free();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region SQLXML
    public partial class SQLXML : Java.Sql.ISQLXML
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.sql/java/sql/SQLXML.html#getBinaryStream()"/> 
        /// </summary>
        public Java.Io.InputStream BinaryStream
        {
            get { return IExecuteWithSignature<Java.Io.InputStream>("getBinaryStream", "()Ljava/io/InputStream;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.sql/java/sql/SQLXML.html#getCharacterStream()"/> 
        /// </summary>
        public Java.Io.Reader CharacterStream
        {
            get { return IExecuteWithSignature<Java.Io.Reader>("getCharacterStream", "()Ljava/io/Reader;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.sql/java/sql/SQLXML.html#getString()"/> <see href="https://developer.android.com/reference/java.sql/java/sql/SQLXML.html#setString(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String String
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getString", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setString", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.sql/java/sql/SQLXML.html#setResult(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"><see cref="Javax.Xml.Transform.IResult"/></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public T SetResult<T>(Java.Lang.Class arg0) where T: Javax.Xml.Transform.IResult, new()
        {
            return IExecuteWithSignature<T>("setResult", "(Ljava/lang/Class;)Ljavax/xml/transform/Result;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.sql/java/sql/SQLXML.html#getSource(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"><see cref="Javax.Xml.Transform.ISource"/></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public T GetSource<T>(Java.Lang.Class arg0) where T: Javax.Xml.Transform.ISource, new()
        {
            return IExecuteWithSignature<T>("getSource", "(Ljava/lang/Class;)Ljavax/xml/transform/Source;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.sql/java/sql/SQLXML.html#setBinaryStream()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.OutputStream"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Io.OutputStream SetBinaryStream()
        {
            return IExecuteWithSignature<Java.Io.OutputStream>("setBinaryStream", "()Ljava/io/OutputStream;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.sql/java/sql/SQLXML.html#setCharacterStream()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.Writer"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Io.Writer SetCharacterStream()
        {
            return IExecuteWithSignature<Java.Io.Writer>("setCharacterStream", "()Ljava/io/Writer;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.sql/java/sql/SQLXML.html#free()"/>
        /// </summary>
        /// <exception cref="Java.Sql.SQLException"/>
        public void Free()
        {
            IExecuteWithSignature("free", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}