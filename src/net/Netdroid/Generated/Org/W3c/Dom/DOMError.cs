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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.W3c.Dom
{
    #region DOMError declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/org/w3c/dom/DOMError.html"/>
    /// </summary>
    public partial class DOMError : MASES.JCOBridge.C2JBridge.JVMBridgeBase<DOMError>
    {
        const string _bridgeClassName = "org.w3c.dom.DOMError";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("DOMError class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public DOMError() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("DOMError class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public DOMError(params object[] args) : base(args) { }
    
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

    #region IDOMError
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IDOMError
    {
        #region Instance methods
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion

    #region DOMError implementation
    public partial class DOMError : Org.W3c.Dom.IDOMError
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/w3c/dom/DOMError.html#SEVERITY_ERROR"/>
        /// </summary>
        public static short SEVERITY_ERROR { get { if (!_SEVERITY_ERRORReady) { _SEVERITY_ERRORContent = SGetField<short>(LocalBridgeClazz, "SEVERITY_ERROR"); _SEVERITY_ERRORReady = true; } return _SEVERITY_ERRORContent; } }
        private static short _SEVERITY_ERRORContent = default;
        private static bool _SEVERITY_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/w3c/dom/DOMError.html#SEVERITY_FATAL_ERROR"/>
        /// </summary>
        public static short SEVERITY_FATAL_ERROR { get { if (!_SEVERITY_FATAL_ERRORReady) { _SEVERITY_FATAL_ERRORContent = SGetField<short>(LocalBridgeClazz, "SEVERITY_FATAL_ERROR"); _SEVERITY_FATAL_ERRORReady = true; } return _SEVERITY_FATAL_ERRORContent; } }
        private static short _SEVERITY_FATAL_ERRORContent = default;
        private static bool _SEVERITY_FATAL_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/w3c/dom/DOMError.html#SEVERITY_WARNING"/>
        /// </summary>
        public static short SEVERITY_WARNING { get { if (!_SEVERITY_WARNINGReady) { _SEVERITY_WARNINGContent = SGetField<short>(LocalBridgeClazz, "SEVERITY_WARNING"); _SEVERITY_WARNINGReady = true; } return _SEVERITY_WARNINGContent; } }
        private static short _SEVERITY_WARNINGContent = default;
        private static bool _SEVERITY_WARNINGReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/w3c/dom/DOMError.html#getRelatedData()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object GetRelatedData()
        {
            return IExecuteWithSignature("getRelatedData", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/w3c/dom/DOMError.html#getRelatedException()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object GetRelatedException()
        {
            return IExecuteWithSignature("getRelatedException", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/w3c/dom/DOMError.html#getMessage()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetMessage()
        {
            return IExecuteWithSignature<Java.Lang.String>("getMessage", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/w3c/dom/DOMError.html#getType()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetType()
        {
            return IExecuteWithSignature<Java.Lang.String>("getType", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/w3c/dom/DOMError.html#getLocation()"/>
        /// </summary>
        /// <returns><see cref="Org.W3c.Dom.DOMLocator"/></returns>
        public Org.W3c.Dom.DOMLocator GetLocation()
        {
            return IExecuteWithSignature<Org.W3c.Dom.DOMLocator>("getLocation", "()Lorg/w3c/dom/DOMLocator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/w3c/dom/DOMError.html#getSeverity()"/>
        /// </summary>
        /// <returns><see cref="short"/></returns>
        public short GetSeverity()
        {
            return IExecuteWithSignature<short>("getSeverity", "()S");
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}