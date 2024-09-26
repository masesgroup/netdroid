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

namespace Org.W3c.Dom
{
    #region TypeInfo declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/org/w3c/dom/TypeInfo.html"/>
    /// </summary>
    public partial class TypeInfo : MASES.JCOBridge.C2JBridge.JVMBridgeBase<TypeInfo>
    {
        const string _bridgeClassName = "org.w3c.dom.TypeInfo";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("TypeInfo class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public TypeInfo() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("TypeInfo class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public TypeInfo(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region ITypeInfo
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ITypeInfo
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TypeInfo implementation
    public partial class TypeInfo : Org.W3c.Dom.ITypeInfo
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/w3c/dom/TypeInfo.html#DERIVATION_EXTENSION"/>
        /// </summary>
        public static int DERIVATION_EXTENSION { get { if (!_DERIVATION_EXTENSIONReady) { _DERIVATION_EXTENSIONContent = SGetField<int>(LocalBridgeClazz, "DERIVATION_EXTENSION"); _DERIVATION_EXTENSIONReady = true; } return _DERIVATION_EXTENSIONContent; } }
        private static int _DERIVATION_EXTENSIONContent = default;
        private static bool _DERIVATION_EXTENSIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/w3c/dom/TypeInfo.html#DERIVATION_LIST"/>
        /// </summary>
        public static int DERIVATION_LIST { get { if (!_DERIVATION_LISTReady) { _DERIVATION_LISTContent = SGetField<int>(LocalBridgeClazz, "DERIVATION_LIST"); _DERIVATION_LISTReady = true; } return _DERIVATION_LISTContent; } }
        private static int _DERIVATION_LISTContent = default;
        private static bool _DERIVATION_LISTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/w3c/dom/TypeInfo.html#DERIVATION_RESTRICTION"/>
        /// </summary>
        public static int DERIVATION_RESTRICTION { get { if (!_DERIVATION_RESTRICTIONReady) { _DERIVATION_RESTRICTIONContent = SGetField<int>(LocalBridgeClazz, "DERIVATION_RESTRICTION"); _DERIVATION_RESTRICTIONReady = true; } return _DERIVATION_RESTRICTIONContent; } }
        private static int _DERIVATION_RESTRICTIONContent = default;
        private static bool _DERIVATION_RESTRICTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/w3c/dom/TypeInfo.html#DERIVATION_UNION"/>
        /// </summary>
        public static int DERIVATION_UNION { get { if (!_DERIVATION_UNIONReady) { _DERIVATION_UNIONContent = SGetField<int>(LocalBridgeClazz, "DERIVATION_UNION"); _DERIVATION_UNIONReady = true; } return _DERIVATION_UNIONContent; } }
        private static int _DERIVATION_UNIONContent = default;
        private static bool _DERIVATION_UNIONReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/w3c/dom/TypeInfo.html#isDerivedFrom(java.lang.String,java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsDerivedFrom(Java.Lang.String arg0, Java.Lang.String arg1, int arg2)
        {
            return IExecuteWithSignature<bool>("isDerivedFrom", "(Ljava/lang/String;Ljava/lang/String;I)Z", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/w3c/dom/TypeInfo.html#getTypeName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetTypeName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getTypeName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/w3c/dom/TypeInfo.html#getTypeNamespace()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetTypeNamespace()
        {
            return IExecuteWithSignature<Java.Lang.String>("getTypeNamespace", "()Ljava/lang/String;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}