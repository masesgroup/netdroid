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

namespace Javax.Sql
{
    #region IRowSetReader
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IRowSetReader
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.sql/javax/sql/RowSetReader.html#readData(javax.sql.RowSetInternal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.RowSetInternal"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        void ReadData(Javax.Sql.RowSetInternal arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region RowSetReader
    public partial class RowSetReader : Javax.Sql.IRowSetReader
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
        /// <see href="https://developer.android.com/reference/java.sql/javax/sql/RowSetReader.html#readData(javax.sql.RowSetInternal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.RowSetInternal"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void ReadData(Javax.Sql.RowSetInternal arg0)
        {
            IExecuteWithSignature("readData", "(Ljavax/sql/RowSetInternal;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}