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
    #region SyncParams declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/media/SyncParams.html"/>
    /// </summary>
    public partial class SyncParams : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SyncParams>
    {
        const string _bridgeClassName = "android.media.SyncParams";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SyncParams() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SyncParams(params object[] args) : base(args) { }

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

    #region SyncParams implementation
    public partial class SyncParams
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/SyncParams.html#AUDIO_ADJUST_MODE_DEFAULT"/>
        /// </summary>
        public static int AUDIO_ADJUST_MODE_DEFAULT { get { if (!_AUDIO_ADJUST_MODE_DEFAULTReady) { _AUDIO_ADJUST_MODE_DEFAULTContent = SGetField<int>(LocalBridgeClazz, "AUDIO_ADJUST_MODE_DEFAULT"); _AUDIO_ADJUST_MODE_DEFAULTReady = true; } return _AUDIO_ADJUST_MODE_DEFAULTContent; } }
        private static int _AUDIO_ADJUST_MODE_DEFAULTContent = default;
        private static bool _AUDIO_ADJUST_MODE_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/SyncParams.html#AUDIO_ADJUST_MODE_RESAMPLE"/>
        /// </summary>
        public static int AUDIO_ADJUST_MODE_RESAMPLE { get { if (!_AUDIO_ADJUST_MODE_RESAMPLEReady) { _AUDIO_ADJUST_MODE_RESAMPLEContent = SGetField<int>(LocalBridgeClazz, "AUDIO_ADJUST_MODE_RESAMPLE"); _AUDIO_ADJUST_MODE_RESAMPLEReady = true; } return _AUDIO_ADJUST_MODE_RESAMPLEContent; } }
        private static int _AUDIO_ADJUST_MODE_RESAMPLEContent = default;
        private static bool _AUDIO_ADJUST_MODE_RESAMPLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/SyncParams.html#AUDIO_ADJUST_MODE_STRETCH"/>
        /// </summary>
        public static int AUDIO_ADJUST_MODE_STRETCH { get { if (!_AUDIO_ADJUST_MODE_STRETCHReady) { _AUDIO_ADJUST_MODE_STRETCHContent = SGetField<int>(LocalBridgeClazz, "AUDIO_ADJUST_MODE_STRETCH"); _AUDIO_ADJUST_MODE_STRETCHReady = true; } return _AUDIO_ADJUST_MODE_STRETCHContent; } }
        private static int _AUDIO_ADJUST_MODE_STRETCHContent = default;
        private static bool _AUDIO_ADJUST_MODE_STRETCHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/SyncParams.html#SYNC_SOURCE_AUDIO"/>
        /// </summary>
        public static int SYNC_SOURCE_AUDIO { get { if (!_SYNC_SOURCE_AUDIOReady) { _SYNC_SOURCE_AUDIOContent = SGetField<int>(LocalBridgeClazz, "SYNC_SOURCE_AUDIO"); _SYNC_SOURCE_AUDIOReady = true; } return _SYNC_SOURCE_AUDIOContent; } }
        private static int _SYNC_SOURCE_AUDIOContent = default;
        private static bool _SYNC_SOURCE_AUDIOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/SyncParams.html#SYNC_SOURCE_DEFAULT"/>
        /// </summary>
        public static int SYNC_SOURCE_DEFAULT { get { if (!_SYNC_SOURCE_DEFAULTReady) { _SYNC_SOURCE_DEFAULTContent = SGetField<int>(LocalBridgeClazz, "SYNC_SOURCE_DEFAULT"); _SYNC_SOURCE_DEFAULTReady = true; } return _SYNC_SOURCE_DEFAULTContent; } }
        private static int _SYNC_SOURCE_DEFAULTContent = default;
        private static bool _SYNC_SOURCE_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/SyncParams.html#SYNC_SOURCE_SYSTEM_CLOCK"/>
        /// </summary>
        public static int SYNC_SOURCE_SYSTEM_CLOCK { get { if (!_SYNC_SOURCE_SYSTEM_CLOCKReady) { _SYNC_SOURCE_SYSTEM_CLOCKContent = SGetField<int>(LocalBridgeClazz, "SYNC_SOURCE_SYSTEM_CLOCK"); _SYNC_SOURCE_SYSTEM_CLOCKReady = true; } return _SYNC_SOURCE_SYSTEM_CLOCKContent; } }
        private static int _SYNC_SOURCE_SYSTEM_CLOCKContent = default;
        private static bool _SYNC_SOURCE_SYSTEM_CLOCKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/SyncParams.html#SYNC_SOURCE_VSYNC"/>
        /// </summary>
        public static int SYNC_SOURCE_VSYNC { get { if (!_SYNC_SOURCE_VSYNCReady) { _SYNC_SOURCE_VSYNCContent = SGetField<int>(LocalBridgeClazz, "SYNC_SOURCE_VSYNC"); _SYNC_SOURCE_VSYNCReady = true; } return _SYNC_SOURCE_VSYNCContent; } }
        private static int _SYNC_SOURCE_VSYNCContent = default;
        private static bool _SYNC_SOURCE_VSYNCReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/SyncParams.html#allowDefaults()"/>
        /// </summary>
        /// <returns><see cref="Android.Media.SyncParams"/></returns>
        public Android.Media.SyncParams AllowDefaults()
        {
            return IExecuteWithSignature<Android.Media.SyncParams>("allowDefaults", "()Landroid/media/SyncParams;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/SyncParams.html#setAudioAdjustMode(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Media.SyncParams"/></returns>
        public Android.Media.SyncParams SetAudioAdjustMode(int arg0)
        {
            return IExecuteWithSignature<Android.Media.SyncParams>("setAudioAdjustMode", "(I)Landroid/media/SyncParams;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/SyncParams.html#setFrameRate(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="Android.Media.SyncParams"/></returns>
        public Android.Media.SyncParams SetFrameRate(float arg0)
        {
            return IExecuteWithSignature<Android.Media.SyncParams>("setFrameRate", "(F)Landroid/media/SyncParams;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/SyncParams.html#setSyncSource(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Media.SyncParams"/></returns>
        public Android.Media.SyncParams SetSyncSource(int arg0)
        {
            return IExecuteWithSignature<Android.Media.SyncParams>("setSyncSource", "(I)Landroid/media/SyncParams;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/SyncParams.html#setTolerance(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="Android.Media.SyncParams"/></returns>
        public Android.Media.SyncParams SetTolerance(float arg0)
        {
            return IExecuteWithSignature<Android.Media.SyncParams>("setTolerance", "(F)Landroid/media/SyncParams;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/SyncParams.html#getFrameRate()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetFrameRate()
        {
            return IExecuteWithSignature<float>("getFrameRate", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/SyncParams.html#getTolerance()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetTolerance()
        {
            return IExecuteWithSignature<float>("getTolerance", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/SyncParams.html#getAudioAdjustMode()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetAudioAdjustMode()
        {
            return IExecuteWithSignature<int>("getAudioAdjustMode", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/SyncParams.html#getSyncSource()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSyncSource()
        {
            return IExecuteWithSignature<int>("getSyncSource", "()I");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}