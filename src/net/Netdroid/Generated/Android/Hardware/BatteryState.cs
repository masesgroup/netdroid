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

namespace Android.Hardware
{
    #region BatteryState declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/hardware/BatteryState.html"/>
    /// </summary>
    public partial class BatteryState : MASES.JCOBridge.C2JBridge.JVMBridgeBase<BatteryState>
    {
        const string _bridgeClassName = "android.hardware.BatteryState";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("BatteryState class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public BatteryState() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("BatteryState class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public BatteryState(params object[] args) : base(args) { }
    
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

    #region BatteryState implementation
    public partial class BatteryState
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/BatteryState.html#STATUS_CHARGING"/>
        /// </summary>
        public static int STATUS_CHARGING { get { if (!_STATUS_CHARGINGReady) { _STATUS_CHARGINGContent = SGetField<int>(LocalBridgeClazz, "STATUS_CHARGING"); _STATUS_CHARGINGReady = true; } return _STATUS_CHARGINGContent; } }
        private static int _STATUS_CHARGINGContent = default;
        private static bool _STATUS_CHARGINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/BatteryState.html#STATUS_DISCHARGING"/>
        /// </summary>
        public static int STATUS_DISCHARGING { get { if (!_STATUS_DISCHARGINGReady) { _STATUS_DISCHARGINGContent = SGetField<int>(LocalBridgeClazz, "STATUS_DISCHARGING"); _STATUS_DISCHARGINGReady = true; } return _STATUS_DISCHARGINGContent; } }
        private static int _STATUS_DISCHARGINGContent = default;
        private static bool _STATUS_DISCHARGINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/BatteryState.html#STATUS_FULL"/>
        /// </summary>
        public static int STATUS_FULL { get { if (!_STATUS_FULLReady) { _STATUS_FULLContent = SGetField<int>(LocalBridgeClazz, "STATUS_FULL"); _STATUS_FULLReady = true; } return _STATUS_FULLContent; } }
        private static int _STATUS_FULLContent = default;
        private static bool _STATUS_FULLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/BatteryState.html#STATUS_NOT_CHARGING"/>
        /// </summary>
        public static int STATUS_NOT_CHARGING { get { if (!_STATUS_NOT_CHARGINGReady) { _STATUS_NOT_CHARGINGContent = SGetField<int>(LocalBridgeClazz, "STATUS_NOT_CHARGING"); _STATUS_NOT_CHARGINGReady = true; } return _STATUS_NOT_CHARGINGContent; } }
        private static int _STATUS_NOT_CHARGINGContent = default;
        private static bool _STATUS_NOT_CHARGINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/BatteryState.html#STATUS_UNKNOWN"/>
        /// </summary>
        public static int STATUS_UNKNOWN { get { if (!_STATUS_UNKNOWNReady) { _STATUS_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "STATUS_UNKNOWN"); _STATUS_UNKNOWNReady = true; } return _STATUS_UNKNOWNContent; } }
        private static int _STATUS_UNKNOWNContent = default;
        private static bool _STATUS_UNKNOWNReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/BatteryState.html#isPresent()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsPresent()
        {
            return IExecuteWithSignature<bool>("isPresent", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/BatteryState.html#getCapacity()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetCapacity()
        {
            return IExecuteWithSignature<float>("getCapacity", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/BatteryState.html#getStatus()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetStatus()
        {
            return IExecuteWithSignature<int>("getStatus", "()I");
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}