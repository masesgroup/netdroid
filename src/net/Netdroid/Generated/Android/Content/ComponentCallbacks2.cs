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

namespace Android.Content
{
    #region ComponentCallbacks2 declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/content/ComponentCallbacks2.html"/>
    /// </summary>
    public partial class ComponentCallbacks2 : Android.Content.ComponentCallbacks
    {
        const string _bridgeClassName = "android.content.ComponentCallbacks2";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("ComponentCallbacks2 class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ComponentCallbacks2() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("ComponentCallbacks2 class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ComponentCallbacks2(params object[] args) : base(args) { }

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

    #region IComponentCallbacks2
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IComponentCallbacks2 : Android.Content.IComponentCallbacks
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ComponentCallbacks2 implementation
    public partial class ComponentCallbacks2 : Android.Content.IComponentCallbacks2
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ComponentCallbacks2.html#TRIM_MEMORY_BACKGROUND"/>
        /// </summary>
        public static int TRIM_MEMORY_BACKGROUND { get { if (!_TRIM_MEMORY_BACKGROUNDReady) { _TRIM_MEMORY_BACKGROUNDContent = SGetField<int>(LocalBridgeClazz, "TRIM_MEMORY_BACKGROUND"); _TRIM_MEMORY_BACKGROUNDReady = true; } return _TRIM_MEMORY_BACKGROUNDContent; } }
        private static int _TRIM_MEMORY_BACKGROUNDContent = default;
        private static bool _TRIM_MEMORY_BACKGROUNDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ComponentCallbacks2.html#TRIM_MEMORY_COMPLETE"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int TRIM_MEMORY_COMPLETE { get { if (!_TRIM_MEMORY_COMPLETEReady) { _TRIM_MEMORY_COMPLETEContent = SGetField<int>(LocalBridgeClazz, "TRIM_MEMORY_COMPLETE"); _TRIM_MEMORY_COMPLETEReady = true; } return _TRIM_MEMORY_COMPLETEContent; } }
        private static int _TRIM_MEMORY_COMPLETEContent = default;
        private static bool _TRIM_MEMORY_COMPLETEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ComponentCallbacks2.html#TRIM_MEMORY_MODERATE"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int TRIM_MEMORY_MODERATE { get { if (!_TRIM_MEMORY_MODERATEReady) { _TRIM_MEMORY_MODERATEContent = SGetField<int>(LocalBridgeClazz, "TRIM_MEMORY_MODERATE"); _TRIM_MEMORY_MODERATEReady = true; } return _TRIM_MEMORY_MODERATEContent; } }
        private static int _TRIM_MEMORY_MODERATEContent = default;
        private static bool _TRIM_MEMORY_MODERATEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ComponentCallbacks2.html#TRIM_MEMORY_RUNNING_CRITICAL"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int TRIM_MEMORY_RUNNING_CRITICAL { get { if (!_TRIM_MEMORY_RUNNING_CRITICALReady) { _TRIM_MEMORY_RUNNING_CRITICALContent = SGetField<int>(LocalBridgeClazz, "TRIM_MEMORY_RUNNING_CRITICAL"); _TRIM_MEMORY_RUNNING_CRITICALReady = true; } return _TRIM_MEMORY_RUNNING_CRITICALContent; } }
        private static int _TRIM_MEMORY_RUNNING_CRITICALContent = default;
        private static bool _TRIM_MEMORY_RUNNING_CRITICALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ComponentCallbacks2.html#TRIM_MEMORY_RUNNING_LOW"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int TRIM_MEMORY_RUNNING_LOW { get { if (!_TRIM_MEMORY_RUNNING_LOWReady) { _TRIM_MEMORY_RUNNING_LOWContent = SGetField<int>(LocalBridgeClazz, "TRIM_MEMORY_RUNNING_LOW"); _TRIM_MEMORY_RUNNING_LOWReady = true; } return _TRIM_MEMORY_RUNNING_LOWContent; } }
        private static int _TRIM_MEMORY_RUNNING_LOWContent = default;
        private static bool _TRIM_MEMORY_RUNNING_LOWReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ComponentCallbacks2.html#TRIM_MEMORY_RUNNING_MODERATE"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int TRIM_MEMORY_RUNNING_MODERATE { get { if (!_TRIM_MEMORY_RUNNING_MODERATEReady) { _TRIM_MEMORY_RUNNING_MODERATEContent = SGetField<int>(LocalBridgeClazz, "TRIM_MEMORY_RUNNING_MODERATE"); _TRIM_MEMORY_RUNNING_MODERATEReady = true; } return _TRIM_MEMORY_RUNNING_MODERATEContent; } }
        private static int _TRIM_MEMORY_RUNNING_MODERATEContent = default;
        private static bool _TRIM_MEMORY_RUNNING_MODERATEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ComponentCallbacks2.html#TRIM_MEMORY_UI_HIDDEN"/>
        /// </summary>
        public static int TRIM_MEMORY_UI_HIDDEN { get { if (!_TRIM_MEMORY_UI_HIDDENReady) { _TRIM_MEMORY_UI_HIDDENContent = SGetField<int>(LocalBridgeClazz, "TRIM_MEMORY_UI_HIDDEN"); _TRIM_MEMORY_UI_HIDDENReady = true; } return _TRIM_MEMORY_UI_HIDDENContent; } }
        private static int _TRIM_MEMORY_UI_HIDDENContent = default;
        private static bool _TRIM_MEMORY_UI_HIDDENReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/ComponentCallbacks2.html#onTrimMemory(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void OnTrimMemory(int arg0)
        {
            IExecuteWithSignature("onTrimMemory", "(I)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}