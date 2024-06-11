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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Sql
{
    #region IDataSource
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IDataSource
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DataSource
    public partial class DataSource : Javax.Sql.IDataSource, Javax.Sql.ICommonDataSource, Java.Sql.IWrapper
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Sql.DataSource"/> to <see cref="Javax.Sql.CommonDataSource"/>
        /// </summary>
        public static implicit operator Javax.Sql.CommonDataSource(Javax.Sql.DataSource t) => t.Cast<Javax.Sql.CommonDataSource>();
        /// <summary>
        /// Converter from <see cref="Javax.Sql.DataSource"/> to <see cref="Java.Sql.Wrapper"/>
        /// </summary>
        public static implicit operator Java.Sql.Wrapper(Javax.Sql.DataSource t) => t.Cast<Java.Sql.Wrapper>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/sql/DataSource.html#getLoginTimeout()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public int GetLoginTimeout()
        {
            return IExecuteWithSignature<int>("getLoginTimeout", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/sql/DataSource.html#getLogWriter()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.PrintWriter"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Io.PrintWriter GetLogWriter()
        {
            return IExecuteWithSignature<Java.Io.PrintWriter>("getLogWriter", "()Ljava/io/PrintWriter;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/sql/DataSource.html#getConnection()"/>
        /// </summary>
        /// <returns><see cref="Java.Sql.Connection"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.Connection GetConnection()
        {
            return IExecuteWithSignature<Java.Sql.Connection>("getConnection", "()Ljava/sql/Connection;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/sql/DataSource.html#getConnection(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Sql.Connection"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.Connection GetConnection(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute<Java.Sql.Connection>("getConnection", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/sql/DataSource.html#setLoginTimeout(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetLoginTimeout(int arg0)
        {
            IExecuteWithSignature("setLoginTimeout", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/sql/DataSource.html#setLogWriter(java.io.PrintWriter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.PrintWriter"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetLogWriter(Java.Io.PrintWriter arg0)
        {
            IExecuteWithSignature("setLogWriter", "(Ljava/io/PrintWriter;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}