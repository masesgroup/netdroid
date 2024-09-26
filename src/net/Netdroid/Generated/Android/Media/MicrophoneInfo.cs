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

namespace Android.Media
{
    #region MicrophoneInfo declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/media/MicrophoneInfo.html"/>
    /// </summary>
    public partial class MicrophoneInfo : MASES.JCOBridge.C2JBridge.JVMBridgeBase<MicrophoneInfo>
    {
        const string _bridgeClassName = "android.media.MicrophoneInfo";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public MicrophoneInfo() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public MicrophoneInfo(params object[] args) : base(args) { }

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
        #region Coordinate3F declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MicrophoneInfo.Coordinate3F.html"/>
        /// </summary>
        public partial class Coordinate3F : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Coordinate3F>
        {
            const string _bridgeClassName = "android.media.MicrophoneInfo$Coordinate3F";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Coordinate3F() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Coordinate3F(params object[] args) : base(args) { }

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
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

    
    }
    #endregion

    #region MicrophoneInfo implementation
    public partial class MicrophoneInfo
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MicrophoneInfo.html#ORIENTATION_UNKNOWN"/>
        /// </summary>
        public static Android.Media.MicrophoneInfo.Coordinate3F ORIENTATION_UNKNOWN { get { if (!_ORIENTATION_UNKNOWNReady) { _ORIENTATION_UNKNOWNContent = SGetField<Android.Media.MicrophoneInfo.Coordinate3F>(LocalBridgeClazz, "ORIENTATION_UNKNOWN"); _ORIENTATION_UNKNOWNReady = true; } return _ORIENTATION_UNKNOWNContent; } }
        private static Android.Media.MicrophoneInfo.Coordinate3F _ORIENTATION_UNKNOWNContent = default;
        private static bool _ORIENTATION_UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MicrophoneInfo.html#POSITION_UNKNOWN"/>
        /// </summary>
        public static Android.Media.MicrophoneInfo.Coordinate3F POSITION_UNKNOWN { get { if (!_POSITION_UNKNOWNReady) { _POSITION_UNKNOWNContent = SGetField<Android.Media.MicrophoneInfo.Coordinate3F>(LocalBridgeClazz, "POSITION_UNKNOWN"); _POSITION_UNKNOWNReady = true; } return _POSITION_UNKNOWNContent; } }
        private static Android.Media.MicrophoneInfo.Coordinate3F _POSITION_UNKNOWNContent = default;
        private static bool _POSITION_UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MicrophoneInfo.html#SENSITIVITY_UNKNOWN"/>
        /// </summary>
        public static float SENSITIVITY_UNKNOWN { get { if (!_SENSITIVITY_UNKNOWNReady) { _SENSITIVITY_UNKNOWNContent = SGetField<float>(LocalBridgeClazz, "SENSITIVITY_UNKNOWN"); _SENSITIVITY_UNKNOWNReady = true; } return _SENSITIVITY_UNKNOWNContent; } }
        private static float _SENSITIVITY_UNKNOWNContent = default;
        private static bool _SENSITIVITY_UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MicrophoneInfo.html#SPL_UNKNOWN"/>
        /// </summary>
        public static float SPL_UNKNOWN { get { if (!_SPL_UNKNOWNReady) { _SPL_UNKNOWNContent = SGetField<float>(LocalBridgeClazz, "SPL_UNKNOWN"); _SPL_UNKNOWNReady = true; } return _SPL_UNKNOWNContent; } }
        private static float _SPL_UNKNOWNContent = default;
        private static bool _SPL_UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MicrophoneInfo.html#CHANNEL_MAPPING_DIRECT"/>
        /// </summary>
        public static int CHANNEL_MAPPING_DIRECT { get { if (!_CHANNEL_MAPPING_DIRECTReady) { _CHANNEL_MAPPING_DIRECTContent = SGetField<int>(LocalBridgeClazz, "CHANNEL_MAPPING_DIRECT"); _CHANNEL_MAPPING_DIRECTReady = true; } return _CHANNEL_MAPPING_DIRECTContent; } }
        private static int _CHANNEL_MAPPING_DIRECTContent = default;
        private static bool _CHANNEL_MAPPING_DIRECTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MicrophoneInfo.html#CHANNEL_MAPPING_PROCESSED"/>
        /// </summary>
        public static int CHANNEL_MAPPING_PROCESSED { get { if (!_CHANNEL_MAPPING_PROCESSEDReady) { _CHANNEL_MAPPING_PROCESSEDContent = SGetField<int>(LocalBridgeClazz, "CHANNEL_MAPPING_PROCESSED"); _CHANNEL_MAPPING_PROCESSEDReady = true; } return _CHANNEL_MAPPING_PROCESSEDContent; } }
        private static int _CHANNEL_MAPPING_PROCESSEDContent = default;
        private static bool _CHANNEL_MAPPING_PROCESSEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MicrophoneInfo.html#DIRECTIONALITY_BI_DIRECTIONAL"/>
        /// </summary>
        public static int DIRECTIONALITY_BI_DIRECTIONAL { get { if (!_DIRECTIONALITY_BI_DIRECTIONALReady) { _DIRECTIONALITY_BI_DIRECTIONALContent = SGetField<int>(LocalBridgeClazz, "DIRECTIONALITY_BI_DIRECTIONAL"); _DIRECTIONALITY_BI_DIRECTIONALReady = true; } return _DIRECTIONALITY_BI_DIRECTIONALContent; } }
        private static int _DIRECTIONALITY_BI_DIRECTIONALContent = default;
        private static bool _DIRECTIONALITY_BI_DIRECTIONALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MicrophoneInfo.html#DIRECTIONALITY_CARDIOID"/>
        /// </summary>
        public static int DIRECTIONALITY_CARDIOID { get { if (!_DIRECTIONALITY_CARDIOIDReady) { _DIRECTIONALITY_CARDIOIDContent = SGetField<int>(LocalBridgeClazz, "DIRECTIONALITY_CARDIOID"); _DIRECTIONALITY_CARDIOIDReady = true; } return _DIRECTIONALITY_CARDIOIDContent; } }
        private static int _DIRECTIONALITY_CARDIOIDContent = default;
        private static bool _DIRECTIONALITY_CARDIOIDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MicrophoneInfo.html#DIRECTIONALITY_HYPER_CARDIOID"/>
        /// </summary>
        public static int DIRECTIONALITY_HYPER_CARDIOID { get { if (!_DIRECTIONALITY_HYPER_CARDIOIDReady) { _DIRECTIONALITY_HYPER_CARDIOIDContent = SGetField<int>(LocalBridgeClazz, "DIRECTIONALITY_HYPER_CARDIOID"); _DIRECTIONALITY_HYPER_CARDIOIDReady = true; } return _DIRECTIONALITY_HYPER_CARDIOIDContent; } }
        private static int _DIRECTIONALITY_HYPER_CARDIOIDContent = default;
        private static bool _DIRECTIONALITY_HYPER_CARDIOIDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MicrophoneInfo.html#DIRECTIONALITY_OMNI"/>
        /// </summary>
        public static int DIRECTIONALITY_OMNI { get { if (!_DIRECTIONALITY_OMNIReady) { _DIRECTIONALITY_OMNIContent = SGetField<int>(LocalBridgeClazz, "DIRECTIONALITY_OMNI"); _DIRECTIONALITY_OMNIReady = true; } return _DIRECTIONALITY_OMNIContent; } }
        private static int _DIRECTIONALITY_OMNIContent = default;
        private static bool _DIRECTIONALITY_OMNIReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MicrophoneInfo.html#DIRECTIONALITY_SUPER_CARDIOID"/>
        /// </summary>
        public static int DIRECTIONALITY_SUPER_CARDIOID { get { if (!_DIRECTIONALITY_SUPER_CARDIOIDReady) { _DIRECTIONALITY_SUPER_CARDIOIDContent = SGetField<int>(LocalBridgeClazz, "DIRECTIONALITY_SUPER_CARDIOID"); _DIRECTIONALITY_SUPER_CARDIOIDReady = true; } return _DIRECTIONALITY_SUPER_CARDIOIDContent; } }
        private static int _DIRECTIONALITY_SUPER_CARDIOIDContent = default;
        private static bool _DIRECTIONALITY_SUPER_CARDIOIDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MicrophoneInfo.html#DIRECTIONALITY_UNKNOWN"/>
        /// </summary>
        public static int DIRECTIONALITY_UNKNOWN { get { if (!_DIRECTIONALITY_UNKNOWNReady) { _DIRECTIONALITY_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "DIRECTIONALITY_UNKNOWN"); _DIRECTIONALITY_UNKNOWNReady = true; } return _DIRECTIONALITY_UNKNOWNContent; } }
        private static int _DIRECTIONALITY_UNKNOWNContent = default;
        private static bool _DIRECTIONALITY_UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MicrophoneInfo.html#GROUP_UNKNOWN"/>
        /// </summary>
        public static int GROUP_UNKNOWN { get { if (!_GROUP_UNKNOWNReady) { _GROUP_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "GROUP_UNKNOWN"); _GROUP_UNKNOWNReady = true; } return _GROUP_UNKNOWNContent; } }
        private static int _GROUP_UNKNOWNContent = default;
        private static bool _GROUP_UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MicrophoneInfo.html#INDEX_IN_THE_GROUP_UNKNOWN"/>
        /// </summary>
        public static int INDEX_IN_THE_GROUP_UNKNOWN { get { if (!_INDEX_IN_THE_GROUP_UNKNOWNReady) { _INDEX_IN_THE_GROUP_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "INDEX_IN_THE_GROUP_UNKNOWN"); _INDEX_IN_THE_GROUP_UNKNOWNReady = true; } return _INDEX_IN_THE_GROUP_UNKNOWNContent; } }
        private static int _INDEX_IN_THE_GROUP_UNKNOWNContent = default;
        private static bool _INDEX_IN_THE_GROUP_UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MicrophoneInfo.html#LOCATION_MAINBODY"/>
        /// </summary>
        public static int LOCATION_MAINBODY { get { if (!_LOCATION_MAINBODYReady) { _LOCATION_MAINBODYContent = SGetField<int>(LocalBridgeClazz, "LOCATION_MAINBODY"); _LOCATION_MAINBODYReady = true; } return _LOCATION_MAINBODYContent; } }
        private static int _LOCATION_MAINBODYContent = default;
        private static bool _LOCATION_MAINBODYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MicrophoneInfo.html#LOCATION_MAINBODY_MOVABLE"/>
        /// </summary>
        public static int LOCATION_MAINBODY_MOVABLE { get { if (!_LOCATION_MAINBODY_MOVABLEReady) { _LOCATION_MAINBODY_MOVABLEContent = SGetField<int>(LocalBridgeClazz, "LOCATION_MAINBODY_MOVABLE"); _LOCATION_MAINBODY_MOVABLEReady = true; } return _LOCATION_MAINBODY_MOVABLEContent; } }
        private static int _LOCATION_MAINBODY_MOVABLEContent = default;
        private static bool _LOCATION_MAINBODY_MOVABLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MicrophoneInfo.html#LOCATION_PERIPHERAL"/>
        /// </summary>
        public static int LOCATION_PERIPHERAL { get { if (!_LOCATION_PERIPHERALReady) { _LOCATION_PERIPHERALContent = SGetField<int>(LocalBridgeClazz, "LOCATION_PERIPHERAL"); _LOCATION_PERIPHERALReady = true; } return _LOCATION_PERIPHERALContent; } }
        private static int _LOCATION_PERIPHERALContent = default;
        private static bool _LOCATION_PERIPHERALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MicrophoneInfo.html#LOCATION_UNKNOWN"/>
        /// </summary>
        public static int LOCATION_UNKNOWN { get { if (!_LOCATION_UNKNOWNReady) { _LOCATION_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "LOCATION_UNKNOWN"); _LOCATION_UNKNOWNReady = true; } return _LOCATION_UNKNOWNContent; } }
        private static int _LOCATION_UNKNOWNContent = default;
        private static bool _LOCATION_UNKNOWNReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MicrophoneInfo.html#getOrientation()"/>
        /// </summary>
        /// <returns><see cref="Android.Media.MicrophoneInfo.Coordinate3F"/></returns>
        public Android.Media.MicrophoneInfo.Coordinate3F GetOrientation()
        {
            return IExecuteWithSignature<Android.Media.MicrophoneInfo.Coordinate3F>("getOrientation", "()Landroid/media/MicrophoneInfo$Coordinate3F;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MicrophoneInfo.html#getPosition()"/>
        /// </summary>
        /// <returns><see cref="Android.Media.MicrophoneInfo.Coordinate3F"/></returns>
        public Android.Media.MicrophoneInfo.Coordinate3F GetPosition()
        {
            return IExecuteWithSignature<Android.Media.MicrophoneInfo.Coordinate3F>("getPosition", "()Landroid/media/MicrophoneInfo$Coordinate3F;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MicrophoneInfo.html#getMaxSpl()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetMaxSpl()
        {
            return IExecuteWithSignature<float>("getMaxSpl", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MicrophoneInfo.html#getMinSpl()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetMinSpl()
        {
            return IExecuteWithSignature<float>("getMinSpl", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MicrophoneInfo.html#getSensitivity()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetSensitivity()
        {
            return IExecuteWithSignature<float>("getSensitivity", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MicrophoneInfo.html#getDirectionality()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDirectionality()
        {
            return IExecuteWithSignature<int>("getDirectionality", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MicrophoneInfo.html#getGroup()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetGroup()
        {
            return IExecuteWithSignature<int>("getGroup", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MicrophoneInfo.html#getId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetId()
        {
            return IExecuteWithSignature<int>("getId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MicrophoneInfo.html#getIndexInTheGroup()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetIndexInTheGroup()
        {
            return IExecuteWithSignature<int>("getIndexInTheGroup", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MicrophoneInfo.html#getLocation()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetLocation()
        {
            return IExecuteWithSignature<int>("getLocation", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MicrophoneInfo.html#getType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetType()
        {
            return IExecuteWithSignature<int>("getType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MicrophoneInfo.html#getAddress()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetAddress()
        {
            return IExecuteWithSignature<Java.Lang.String>("getAddress", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MicrophoneInfo.html#getDescription()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetDescription()
        {
            return IExecuteWithSignature<Java.Lang.String>("getDescription", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MicrophoneInfo.html#getFrequencyResponse()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Util.Pair<Java.Lang.Float, Java.Lang.Float>> GetFrequencyResponse()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Util.Pair<Java.Lang.Float, Java.Lang.Float>>>("getFrequencyResponse", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MicrophoneInfo.html#getChannelMapping()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Util.Pair<Java.Lang.Integer, Java.Lang.Integer>> GetChannelMapping()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Util.Pair<Java.Lang.Integer, Java.Lang.Integer>>>("getChannelMapping", "()Ljava/util/List;");
        }

        #endregion

        #region Nested classes
        #region Coordinate3F implementation
        public partial class Coordinate3F
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/MicrophoneInfo.Coordinate3F.html#x"/>
            /// </summary>
            public float x { get { if (!_xReady) { _xContent = IGetField<float>("x"); _xReady = true; } return _xContent; } }
            private float _xContent = default;
            private bool _xReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/MicrophoneInfo.Coordinate3F.html#y"/>
            /// </summary>
            public float y { get { if (!_yReady) { _yContent = IGetField<float>("y"); _yReady = true; } return _yContent; } }
            private float _yContent = default;
            private bool _yReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/MicrophoneInfo.Coordinate3F.html#z"/>
            /// </summary>
            public float z { get { if (!_zReady) { _zContent = IGetField<float>("z"); _zReady = true; } return _zContent; } }
            private float _zContent = default;
            private bool _zReady = false; // this is used because in case of generics 

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

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}