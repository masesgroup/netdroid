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
    #region ICommonDataSource
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ICommonDataSource
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region CommonDataSource
    public partial class CommonDataSource : Javax.Sql.ICommonDataSource
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
        /// <see href="https://developer.android.com/reference/javax/sql/CommonDataSource.html#getLoginTimeout()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public int GetLoginTimeout()
        {
            return IExecuteWithSignature<int>("getLoginTimeout", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/sql/CommonDataSource.html#getLogWriter()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.PrintWriter"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Io.PrintWriter GetLogWriter()
        {
            return IExecuteWithSignature<Java.Io.PrintWriter>("getLogWriter", "()Ljava/io/PrintWriter;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/sql/CommonDataSource.html#getParentLogger()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Logging.Logger"/></returns>
        /// <exception cref="Java.Sql.SQLFeatureNotSupportedException"/>
        public Java.Util.Logging.Logger GetParentLogger()
        {
            return IExecuteWithSignature<Java.Util.Logging.Logger>("getParentLogger", "()Ljava/util/logging/Logger;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/sql/CommonDataSource.html#setLoginTimeout(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetLoginTimeout(int arg0)
        {
            IExecuteWithSignature("setLoginTimeout", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/sql/CommonDataSource.html#setLogWriter(java.io.PrintWriter)"/>
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