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

namespace Android.Service.Chooser
{
    #region ChooserTargetService declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/service/chooser/ChooserTargetService.html"/>
    /// </summary>
    [global::System.Obsolete()]
    public partial class ChooserTargetService : Android.App.Service
    {
        const string _bridgeClassName = "android.service.chooser.ChooserTargetService";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("ChooserTargetService class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ChooserTargetService() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("ChooserTargetService class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ChooserTargetService(params object[] args) : base(args) { }

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
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region ChooserTargetService implementation
    public partial class ChooserTargetService
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/chooser/ChooserTargetService.html#BIND_PERMISSION"/>
        /// </summary>
        [global::System.Obsolete()]
        public static Java.Lang.String BIND_PERMISSION { get { if (!_BIND_PERMISSIONReady) { _BIND_PERMISSIONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "BIND_PERMISSION"); _BIND_PERMISSIONReady = true; } return _BIND_PERMISSIONContent; } }
        private static Java.Lang.String _BIND_PERMISSIONContent = default;
        private static bool _BIND_PERMISSIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/chooser/ChooserTargetService.html#META_DATA_NAME"/>
        /// </summary>
        [global::System.Obsolete()]
        public static Java.Lang.String META_DATA_NAME { get { if (!_META_DATA_NAMEReady) { _META_DATA_NAMEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "META_DATA_NAME"); _META_DATA_NAMEReady = true; } return _META_DATA_NAMEContent; } }
        private static Java.Lang.String _META_DATA_NAMEContent = default;
        private static bool _META_DATA_NAMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/chooser/ChooserTargetService.html#SERVICE_INTERFACE"/>
        /// </summary>
        [global::System.Obsolete()]
        public static Java.Lang.String SERVICE_INTERFACE { get { if (!_SERVICE_INTERFACEReady) { _SERVICE_INTERFACEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SERVICE_INTERFACE"); _SERVICE_INTERFACEReady = true; } return _SERVICE_INTERFACEContent; } }
        private static Java.Lang.String _SERVICE_INTERFACEContent = default;
        private static bool _SERVICE_INTERFACEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/chooser/ChooserTargetService.html#onGetChooserTargets(android.content.ComponentName,android.content.IntentFilter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.ComponentName"/></param>
        /// <param name="arg1"><see cref="Android.Content.IntentFilter"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        [global::System.Obsolete()]
        public Java.Util.List<Android.Service.Chooser.ChooserTarget> OnGetChooserTargets(Android.Content.ComponentName arg0, Android.Content.IntentFilter arg1)
        {
            return IExecuteWithSignature<Java.Util.List<Android.Service.Chooser.ChooserTarget>>("onGetChooserTargets", "(Landroid/content/ComponentName;Landroid/content/IntentFilter;)Ljava/util/List;", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}