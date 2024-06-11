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
    #region IRowSetInternal
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IRowSetInternal
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region RowSetInternal
    public partial class RowSetInternal : Javax.Sql.IRowSetInternal
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
        /// <see href="https://developer.android.com/reference/javax/sql/RowSetInternal.html#getParams()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public object[] GetParams()
        {
            return IExecuteWithSignatureArray<object>("getParams", "()[Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/sql/RowSetInternal.html#getConnection()"/>
        /// </summary>
        /// <returns><see cref="Java.Sql.Connection"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.Connection GetConnection()
        {
            return IExecuteWithSignature<Java.Sql.Connection>("getConnection", "()Ljava/sql/Connection;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/sql/RowSetInternal.html#getOriginal()"/>
        /// </summary>
        /// <returns><see cref="Java.Sql.ResultSet"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.ResultSet GetOriginal()
        {
            return IExecuteWithSignature<Java.Sql.ResultSet>("getOriginal", "()Ljava/sql/ResultSet;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/sql/RowSetInternal.html#getOriginalRow()"/>
        /// </summary>
        /// <returns><see cref="Java.Sql.ResultSet"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.ResultSet GetOriginalRow()
        {
            return IExecuteWithSignature<Java.Sql.ResultSet>("getOriginalRow", "()Ljava/sql/ResultSet;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/sql/RowSetInternal.html#setMetaData(javax.sql.RowSetMetaData)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.RowSetMetaData"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetMetaData(Javax.Sql.RowSetMetaData arg0)
        {
            IExecuteWithSignature("setMetaData", "(Ljavax/sql/RowSetMetaData;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}