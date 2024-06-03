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
    #region IStruct
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IStruct
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Struct
    public partial class Struct : Java.Sql.IStruct
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
        /// <see href="https://developer.android.com/reference/java/sql/Struct.html#getAttributes()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public object[] GetAttributes()
        {
            return IExecuteWithSignatureArray<object>("getAttributes", "()[Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Struct.html#getAttributes(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public object[] GetAttributes(Java.Util.Map<Java.Lang.String, Java.Lang.Class> arg0)
        {
            return IExecuteWithSignatureArray<object>("getAttributes", "(Ljava/util/Map;)[Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/Struct.html#getSQLTypeName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Lang.String GetSQLTypeName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getSQLTypeName", "()Ljava/lang/String;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}