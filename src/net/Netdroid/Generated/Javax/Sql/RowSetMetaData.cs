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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Sql
{
    #region IRowSetMetaData
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IRowSetMetaData : Java.Sql.IResultSetMetaData
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region RowSetMetaData
    public partial class RowSetMetaData : Javax.Sql.IRowSetMetaData
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
        /// <see href="https://developer.android.com/reference/javax/sql/RowSetMetaData.html#setAutoIncrement(int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetAutoIncrement(int arg0, bool arg1)
        {
            IExecute("setAutoIncrement", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/sql/RowSetMetaData.html#setCaseSensitive(int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetCaseSensitive(int arg0, bool arg1)
        {
            IExecute("setCaseSensitive", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/sql/RowSetMetaData.html#setCatalogName(int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetCatalogName(int arg0, Java.Lang.String arg1)
        {
            IExecute("setCatalogName", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/sql/RowSetMetaData.html#setColumnCount(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetColumnCount(int arg0)
        {
            IExecuteWithSignature("setColumnCount", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/sql/RowSetMetaData.html#setColumnDisplaySize(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetColumnDisplaySize(int arg0, int arg1)
        {
            IExecute("setColumnDisplaySize", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/sql/RowSetMetaData.html#setColumnLabel(int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetColumnLabel(int arg0, Java.Lang.String arg1)
        {
            IExecute("setColumnLabel", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/sql/RowSetMetaData.html#setColumnName(int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetColumnName(int arg0, Java.Lang.String arg1)
        {
            IExecute("setColumnName", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/sql/RowSetMetaData.html#setColumnType(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetColumnType(int arg0, int arg1)
        {
            IExecute("setColumnType", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/sql/RowSetMetaData.html#setColumnTypeName(int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetColumnTypeName(int arg0, Java.Lang.String arg1)
        {
            IExecute("setColumnTypeName", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/sql/RowSetMetaData.html#setCurrency(int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetCurrency(int arg0, bool arg1)
        {
            IExecute("setCurrency", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/sql/RowSetMetaData.html#setNullable(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetNullable(int arg0, int arg1)
        {
            IExecute("setNullable", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/sql/RowSetMetaData.html#setPrecision(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetPrecision(int arg0, int arg1)
        {
            IExecute("setPrecision", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/sql/RowSetMetaData.html#setScale(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetScale(int arg0, int arg1)
        {
            IExecute("setScale", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/sql/RowSetMetaData.html#setSchemaName(int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetSchemaName(int arg0, Java.Lang.String arg1)
        {
            IExecute("setSchemaName", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/sql/RowSetMetaData.html#setSearchable(int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetSearchable(int arg0, bool arg1)
        {
            IExecute("setSearchable", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/sql/RowSetMetaData.html#setSigned(int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetSigned(int arg0, bool arg1)
        {
            IExecute("setSigned", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/sql/RowSetMetaData.html#setTableName(int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetTableName(int arg0, Java.Lang.String arg1)
        {
            IExecute("setTableName", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}