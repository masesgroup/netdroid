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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Hardware.Camera2.Params
{
    #region DynamicRangeProfiles
    public partial class DynamicRangeProfiles
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/DynamicRangeProfiles.html#%3Cinit%3E(long[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public DynamicRangeProfiles(long[] arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/DynamicRangeProfiles.html#DOLBY_VISION_10B_HDR_OEM"/>
        /// </summary>
        public static long DOLBY_VISION_10B_HDR_OEM { get { if (!_DOLBY_VISION_10B_HDR_OEMReady) { _DOLBY_VISION_10B_HDR_OEMContent = SGetField<long>(LocalBridgeClazz, "DOLBY_VISION_10B_HDR_OEM"); _DOLBY_VISION_10B_HDR_OEMReady = true; } return _DOLBY_VISION_10B_HDR_OEMContent; } }
        private static long _DOLBY_VISION_10B_HDR_OEMContent = default;
        private static bool _DOLBY_VISION_10B_HDR_OEMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/DynamicRangeProfiles.html#DOLBY_VISION_10B_HDR_OEM_PO"/>
        /// </summary>
        public static long DOLBY_VISION_10B_HDR_OEM_PO { get { if (!_DOLBY_VISION_10B_HDR_OEM_POReady) { _DOLBY_VISION_10B_HDR_OEM_POContent = SGetField<long>(LocalBridgeClazz, "DOLBY_VISION_10B_HDR_OEM_PO"); _DOLBY_VISION_10B_HDR_OEM_POReady = true; } return _DOLBY_VISION_10B_HDR_OEM_POContent; } }
        private static long _DOLBY_VISION_10B_HDR_OEM_POContent = default;
        private static bool _DOLBY_VISION_10B_HDR_OEM_POReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/DynamicRangeProfiles.html#DOLBY_VISION_10B_HDR_REF"/>
        /// </summary>
        public static long DOLBY_VISION_10B_HDR_REF { get { if (!_DOLBY_VISION_10B_HDR_REFReady) { _DOLBY_VISION_10B_HDR_REFContent = SGetField<long>(LocalBridgeClazz, "DOLBY_VISION_10B_HDR_REF"); _DOLBY_VISION_10B_HDR_REFReady = true; } return _DOLBY_VISION_10B_HDR_REFContent; } }
        private static long _DOLBY_VISION_10B_HDR_REFContent = default;
        private static bool _DOLBY_VISION_10B_HDR_REFReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/DynamicRangeProfiles.html#DOLBY_VISION_10B_HDR_REF_PO"/>
        /// </summary>
        public static long DOLBY_VISION_10B_HDR_REF_PO { get { if (!_DOLBY_VISION_10B_HDR_REF_POReady) { _DOLBY_VISION_10B_HDR_REF_POContent = SGetField<long>(LocalBridgeClazz, "DOLBY_VISION_10B_HDR_REF_PO"); _DOLBY_VISION_10B_HDR_REF_POReady = true; } return _DOLBY_VISION_10B_HDR_REF_POContent; } }
        private static long _DOLBY_VISION_10B_HDR_REF_POContent = default;
        private static bool _DOLBY_VISION_10B_HDR_REF_POReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/DynamicRangeProfiles.html#DOLBY_VISION_8B_HDR_OEM"/>
        /// </summary>
        public static long DOLBY_VISION_8B_HDR_OEM { get { if (!_DOLBY_VISION_8B_HDR_OEMReady) { _DOLBY_VISION_8B_HDR_OEMContent = SGetField<long>(LocalBridgeClazz, "DOLBY_VISION_8B_HDR_OEM"); _DOLBY_VISION_8B_HDR_OEMReady = true; } return _DOLBY_VISION_8B_HDR_OEMContent; } }
        private static long _DOLBY_VISION_8B_HDR_OEMContent = default;
        private static bool _DOLBY_VISION_8B_HDR_OEMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/DynamicRangeProfiles.html#DOLBY_VISION_8B_HDR_OEM_PO"/>
        /// </summary>
        public static long DOLBY_VISION_8B_HDR_OEM_PO { get { if (!_DOLBY_VISION_8B_HDR_OEM_POReady) { _DOLBY_VISION_8B_HDR_OEM_POContent = SGetField<long>(LocalBridgeClazz, "DOLBY_VISION_8B_HDR_OEM_PO"); _DOLBY_VISION_8B_HDR_OEM_POReady = true; } return _DOLBY_VISION_8B_HDR_OEM_POContent; } }
        private static long _DOLBY_VISION_8B_HDR_OEM_POContent = default;
        private static bool _DOLBY_VISION_8B_HDR_OEM_POReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/DynamicRangeProfiles.html#DOLBY_VISION_8B_HDR_REF"/>
        /// </summary>
        public static long DOLBY_VISION_8B_HDR_REF { get { if (!_DOLBY_VISION_8B_HDR_REFReady) { _DOLBY_VISION_8B_HDR_REFContent = SGetField<long>(LocalBridgeClazz, "DOLBY_VISION_8B_HDR_REF"); _DOLBY_VISION_8B_HDR_REFReady = true; } return _DOLBY_VISION_8B_HDR_REFContent; } }
        private static long _DOLBY_VISION_8B_HDR_REFContent = default;
        private static bool _DOLBY_VISION_8B_HDR_REFReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/DynamicRangeProfiles.html#DOLBY_VISION_8B_HDR_REF_PO"/>
        /// </summary>
        public static long DOLBY_VISION_8B_HDR_REF_PO { get { if (!_DOLBY_VISION_8B_HDR_REF_POReady) { _DOLBY_VISION_8B_HDR_REF_POContent = SGetField<long>(LocalBridgeClazz, "DOLBY_VISION_8B_HDR_REF_PO"); _DOLBY_VISION_8B_HDR_REF_POReady = true; } return _DOLBY_VISION_8B_HDR_REF_POContent; } }
        private static long _DOLBY_VISION_8B_HDR_REF_POContent = default;
        private static bool _DOLBY_VISION_8B_HDR_REF_POReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/DynamicRangeProfiles.html#HDR10"/>
        /// </summary>
        public static long HDR10 { get { if (!_HDR10Ready) { _HDR10Content = SGetField<long>(LocalBridgeClazz, "HDR10"); _HDR10Ready = true; } return _HDR10Content; } }
        private static long _HDR10Content = default;
        private static bool _HDR10Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/DynamicRangeProfiles.html#HDR10_PLUS"/>
        /// </summary>
        public static long HDR10_PLUS { get { if (!_HDR10_PLUSReady) { _HDR10_PLUSContent = SGetField<long>(LocalBridgeClazz, "HDR10_PLUS"); _HDR10_PLUSReady = true; } return _HDR10_PLUSContent; } }
        private static long _HDR10_PLUSContent = default;
        private static bool _HDR10_PLUSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/DynamicRangeProfiles.html#HLG10"/>
        /// </summary>
        public static long HLG10 { get { if (!_HLG10Ready) { _HLG10Content = SGetField<long>(LocalBridgeClazz, "HLG10"); _HLG10Ready = true; } return _HLG10Content; } }
        private static long _HLG10Content = default;
        private static bool _HLG10Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/DynamicRangeProfiles.html#PUBLIC_MAX"/>
        /// </summary>
        public static long PUBLIC_MAX { get { if (!_PUBLIC_MAXReady) { _PUBLIC_MAXContent = SGetField<long>(LocalBridgeClazz, "PUBLIC_MAX"); _PUBLIC_MAXReady = true; } return _PUBLIC_MAXContent; } }
        private static long _PUBLIC_MAXContent = default;
        private static bool _PUBLIC_MAXReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/DynamicRangeProfiles.html#STANDARD"/>
        /// </summary>
        public static long STANDARD { get { if (!_STANDARDReady) { _STANDARDContent = SGetField<long>(LocalBridgeClazz, "STANDARD"); _STANDARDReady = true; } return _STANDARDContent; } }
        private static long _STANDARDContent = default;
        private static bool _STANDARDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/DynamicRangeProfiles.html#isExtraLatencyPresent(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsExtraLatencyPresent(long arg0)
        {
            return IExecuteWithSignature<bool>("isExtraLatencyPresent", "(J)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/DynamicRangeProfiles.html#getProfileCaptureRequestConstraints(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.Long> GetProfileCaptureRequestConstraints(long arg0)
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.Long>>("getProfileCaptureRequestConstraints", "(J)Ljava/util/Set;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/DynamicRangeProfiles.html#getSupportedProfiles()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.Long> GetSupportedProfiles()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.Long>>("getSupportedProfiles", "()Ljava/util/Set;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}