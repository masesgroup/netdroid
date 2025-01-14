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

namespace Android.Health.Connect.Datatypes
{
    #region BodyTemperatureMeasurementLocation declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BodyTemperatureMeasurementLocation.html"/>
    /// </summary>
    public partial class BodyTemperatureMeasurementLocation : MASES.JCOBridge.C2JBridge.JVMBridgeBase<BodyTemperatureMeasurementLocation>
    {
        const string _bridgeClassName = "android.health.connect.datatypes.BodyTemperatureMeasurementLocation";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public BodyTemperatureMeasurementLocation() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public BodyTemperatureMeasurementLocation(params object[] args) : base(args) { }
    
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

    #region BodyTemperatureMeasurementLocation implementation
    public partial class BodyTemperatureMeasurementLocation
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BodyTemperatureMeasurementLocation.html#MEASUREMENT_LOCATION_ARMPIT"/>
        /// </summary>
        public static int MEASUREMENT_LOCATION_ARMPIT { get { if (!_MEASUREMENT_LOCATION_ARMPITReady) { _MEASUREMENT_LOCATION_ARMPITContent = SGetField<int>(LocalBridgeClazz, "MEASUREMENT_LOCATION_ARMPIT"); _MEASUREMENT_LOCATION_ARMPITReady = true; } return _MEASUREMENT_LOCATION_ARMPITContent; } }
        private static int _MEASUREMENT_LOCATION_ARMPITContent = default;
        private static bool _MEASUREMENT_LOCATION_ARMPITReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BodyTemperatureMeasurementLocation.html#MEASUREMENT_LOCATION_EAR"/>
        /// </summary>
        public static int MEASUREMENT_LOCATION_EAR { get { if (!_MEASUREMENT_LOCATION_EARReady) { _MEASUREMENT_LOCATION_EARContent = SGetField<int>(LocalBridgeClazz, "MEASUREMENT_LOCATION_EAR"); _MEASUREMENT_LOCATION_EARReady = true; } return _MEASUREMENT_LOCATION_EARContent; } }
        private static int _MEASUREMENT_LOCATION_EARContent = default;
        private static bool _MEASUREMENT_LOCATION_EARReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BodyTemperatureMeasurementLocation.html#MEASUREMENT_LOCATION_FINGER"/>
        /// </summary>
        public static int MEASUREMENT_LOCATION_FINGER { get { if (!_MEASUREMENT_LOCATION_FINGERReady) { _MEASUREMENT_LOCATION_FINGERContent = SGetField<int>(LocalBridgeClazz, "MEASUREMENT_LOCATION_FINGER"); _MEASUREMENT_LOCATION_FINGERReady = true; } return _MEASUREMENT_LOCATION_FINGERContent; } }
        private static int _MEASUREMENT_LOCATION_FINGERContent = default;
        private static bool _MEASUREMENT_LOCATION_FINGERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BodyTemperatureMeasurementLocation.html#MEASUREMENT_LOCATION_FOREHEAD"/>
        /// </summary>
        public static int MEASUREMENT_LOCATION_FOREHEAD { get { if (!_MEASUREMENT_LOCATION_FOREHEADReady) { _MEASUREMENT_LOCATION_FOREHEADContent = SGetField<int>(LocalBridgeClazz, "MEASUREMENT_LOCATION_FOREHEAD"); _MEASUREMENT_LOCATION_FOREHEADReady = true; } return _MEASUREMENT_LOCATION_FOREHEADContent; } }
        private static int _MEASUREMENT_LOCATION_FOREHEADContent = default;
        private static bool _MEASUREMENT_LOCATION_FOREHEADReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BodyTemperatureMeasurementLocation.html#MEASUREMENT_LOCATION_MOUTH"/>
        /// </summary>
        public static int MEASUREMENT_LOCATION_MOUTH { get { if (!_MEASUREMENT_LOCATION_MOUTHReady) { _MEASUREMENT_LOCATION_MOUTHContent = SGetField<int>(LocalBridgeClazz, "MEASUREMENT_LOCATION_MOUTH"); _MEASUREMENT_LOCATION_MOUTHReady = true; } return _MEASUREMENT_LOCATION_MOUTHContent; } }
        private static int _MEASUREMENT_LOCATION_MOUTHContent = default;
        private static bool _MEASUREMENT_LOCATION_MOUTHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BodyTemperatureMeasurementLocation.html#MEASUREMENT_LOCATION_RECTUM"/>
        /// </summary>
        public static int MEASUREMENT_LOCATION_RECTUM { get { if (!_MEASUREMENT_LOCATION_RECTUMReady) { _MEASUREMENT_LOCATION_RECTUMContent = SGetField<int>(LocalBridgeClazz, "MEASUREMENT_LOCATION_RECTUM"); _MEASUREMENT_LOCATION_RECTUMReady = true; } return _MEASUREMENT_LOCATION_RECTUMContent; } }
        private static int _MEASUREMENT_LOCATION_RECTUMContent = default;
        private static bool _MEASUREMENT_LOCATION_RECTUMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BodyTemperatureMeasurementLocation.html#MEASUREMENT_LOCATION_TEMPORAL_ARTERY"/>
        /// </summary>
        public static int MEASUREMENT_LOCATION_TEMPORAL_ARTERY { get { if (!_MEASUREMENT_LOCATION_TEMPORAL_ARTERYReady) { _MEASUREMENT_LOCATION_TEMPORAL_ARTERYContent = SGetField<int>(LocalBridgeClazz, "MEASUREMENT_LOCATION_TEMPORAL_ARTERY"); _MEASUREMENT_LOCATION_TEMPORAL_ARTERYReady = true; } return _MEASUREMENT_LOCATION_TEMPORAL_ARTERYContent; } }
        private static int _MEASUREMENT_LOCATION_TEMPORAL_ARTERYContent = default;
        private static bool _MEASUREMENT_LOCATION_TEMPORAL_ARTERYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BodyTemperatureMeasurementLocation.html#MEASUREMENT_LOCATION_TOE"/>
        /// </summary>
        public static int MEASUREMENT_LOCATION_TOE { get { if (!_MEASUREMENT_LOCATION_TOEReady) { _MEASUREMENT_LOCATION_TOEContent = SGetField<int>(LocalBridgeClazz, "MEASUREMENT_LOCATION_TOE"); _MEASUREMENT_LOCATION_TOEReady = true; } return _MEASUREMENT_LOCATION_TOEContent; } }
        private static int _MEASUREMENT_LOCATION_TOEContent = default;
        private static bool _MEASUREMENT_LOCATION_TOEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BodyTemperatureMeasurementLocation.html#MEASUREMENT_LOCATION_UNKNOWN"/>
        /// </summary>
        public static int MEASUREMENT_LOCATION_UNKNOWN { get { if (!_MEASUREMENT_LOCATION_UNKNOWNReady) { _MEASUREMENT_LOCATION_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "MEASUREMENT_LOCATION_UNKNOWN"); _MEASUREMENT_LOCATION_UNKNOWNReady = true; } return _MEASUREMENT_LOCATION_UNKNOWNContent; } }
        private static int _MEASUREMENT_LOCATION_UNKNOWNContent = default;
        private static bool _MEASUREMENT_LOCATION_UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BodyTemperatureMeasurementLocation.html#MEASUREMENT_LOCATION_VAGINA"/>
        /// </summary>
        public static int MEASUREMENT_LOCATION_VAGINA { get { if (!_MEASUREMENT_LOCATION_VAGINAReady) { _MEASUREMENT_LOCATION_VAGINAContent = SGetField<int>(LocalBridgeClazz, "MEASUREMENT_LOCATION_VAGINA"); _MEASUREMENT_LOCATION_VAGINAReady = true; } return _MEASUREMENT_LOCATION_VAGINAContent; } }
        private static int _MEASUREMENT_LOCATION_VAGINAContent = default;
        private static bool _MEASUREMENT_LOCATION_VAGINAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/health/connect/datatypes/BodyTemperatureMeasurementLocation.html#MEASUREMENT_LOCATION_WRIST"/>
        /// </summary>
        public static int MEASUREMENT_LOCATION_WRIST { get { if (!_MEASUREMENT_LOCATION_WRISTReady) { _MEASUREMENT_LOCATION_WRISTContent = SGetField<int>(LocalBridgeClazz, "MEASUREMENT_LOCATION_WRIST"); _MEASUREMENT_LOCATION_WRISTReady = true; } return _MEASUREMENT_LOCATION_WRISTContent; } }
        private static int _MEASUREMENT_LOCATION_WRISTContent = default;
        private static bool _MEASUREMENT_LOCATION_WRISTReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}