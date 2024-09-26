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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Sql
{
    #region RowIdLifetime declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/sql/RowIdLifetime.html"/>
    /// </summary>
    public partial class RowIdLifetime : Java.Lang.Enum<Java.Sql.RowIdLifetime>
    {
        const string _bridgeClassName = "java.sql.RowIdLifetime";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public RowIdLifetime() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public RowIdLifetime(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region RowIdLifetime implementation
    public partial class RowIdLifetime
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/RowIdLifetime.html#ROWID_UNSUPPORTED"/>
        /// </summary>
        public static Java.Sql.RowIdLifetime ROWID_UNSUPPORTED { get { if (!_ROWID_UNSUPPORTEDReady) { _ROWID_UNSUPPORTEDContent = SGetField<Java.Sql.RowIdLifetime>(LocalBridgeClazz, "ROWID_UNSUPPORTED"); _ROWID_UNSUPPORTEDReady = true; } return _ROWID_UNSUPPORTEDContent; } }
        private static Java.Sql.RowIdLifetime _ROWID_UNSUPPORTEDContent = default;
        private static bool _ROWID_UNSUPPORTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/RowIdLifetime.html#ROWID_VALID_FOREVER"/>
        /// </summary>
        public static Java.Sql.RowIdLifetime ROWID_VALID_FOREVER { get { if (!_ROWID_VALID_FOREVERReady) { _ROWID_VALID_FOREVERContent = SGetField<Java.Sql.RowIdLifetime>(LocalBridgeClazz, "ROWID_VALID_FOREVER"); _ROWID_VALID_FOREVERReady = true; } return _ROWID_VALID_FOREVERContent; } }
        private static Java.Sql.RowIdLifetime _ROWID_VALID_FOREVERContent = default;
        private static bool _ROWID_VALID_FOREVERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/RowIdLifetime.html#ROWID_VALID_OTHER"/>
        /// </summary>
        public static Java.Sql.RowIdLifetime ROWID_VALID_OTHER { get { if (!_ROWID_VALID_OTHERReady) { _ROWID_VALID_OTHERContent = SGetField<Java.Sql.RowIdLifetime>(LocalBridgeClazz, "ROWID_VALID_OTHER"); _ROWID_VALID_OTHERReady = true; } return _ROWID_VALID_OTHERContent; } }
        private static Java.Sql.RowIdLifetime _ROWID_VALID_OTHERContent = default;
        private static bool _ROWID_VALID_OTHERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/RowIdLifetime.html#ROWID_VALID_SESSION"/>
        /// </summary>
        public static Java.Sql.RowIdLifetime ROWID_VALID_SESSION { get { if (!_ROWID_VALID_SESSIONReady) { _ROWID_VALID_SESSIONContent = SGetField<Java.Sql.RowIdLifetime>(LocalBridgeClazz, "ROWID_VALID_SESSION"); _ROWID_VALID_SESSIONReady = true; } return _ROWID_VALID_SESSIONContent; } }
        private static Java.Sql.RowIdLifetime _ROWID_VALID_SESSIONContent = default;
        private static bool _ROWID_VALID_SESSIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/RowIdLifetime.html#ROWID_VALID_TRANSACTION"/>
        /// </summary>
        public static Java.Sql.RowIdLifetime ROWID_VALID_TRANSACTION { get { if (!_ROWID_VALID_TRANSACTIONReady) { _ROWID_VALID_TRANSACTIONContent = SGetField<Java.Sql.RowIdLifetime>(LocalBridgeClazz, "ROWID_VALID_TRANSACTION"); _ROWID_VALID_TRANSACTIONReady = true; } return _ROWID_VALID_TRANSACTIONContent; } }
        private static Java.Sql.RowIdLifetime _ROWID_VALID_TRANSACTIONContent = default;
        private static bool _ROWID_VALID_TRANSACTIONReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/RowIdLifetime.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Sql.RowIdLifetime"/></returns>
        public static Java.Sql.RowIdLifetime ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Sql.RowIdLifetime>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/sql/RowIdLifetime;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/sql/RowIdLifetime.html#values()"/>
        /// </summary>
        /// <returns><see cref="Java.Sql.RowIdLifetime"/></returns>
        public static Java.Sql.RowIdLifetime[] Values()
        {
            return SExecuteWithSignatureArray<Java.Sql.RowIdLifetime>(LocalBridgeClazz, "values", "()[Ljava/sql/RowIdLifetime;");
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}