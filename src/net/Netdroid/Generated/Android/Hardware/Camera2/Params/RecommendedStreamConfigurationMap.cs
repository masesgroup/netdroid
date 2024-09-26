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

namespace Android.Hardware.Camera2.Params
{
    #region RecommendedStreamConfigurationMap declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/RecommendedStreamConfigurationMap.html"/>
    /// </summary>
    public partial class RecommendedStreamConfigurationMap : MASES.JCOBridge.C2JBridge.JVMBridgeBase<RecommendedStreamConfigurationMap>
    {
        const string _bridgeClassName = "android.hardware.camera2.params.RecommendedStreamConfigurationMap";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public RecommendedStreamConfigurationMap() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public RecommendedStreamConfigurationMap(params object[] args) : base(args) { }

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

    #region RecommendedStreamConfigurationMap implementation
    public partial class RecommendedStreamConfigurationMap
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/RecommendedStreamConfigurationMap.html#USECASE_10BIT_OUTPUT"/>
        /// </summary>
        public static int USECASE_10BIT_OUTPUT { get { if (!_USECASE_10BIT_OUTPUTReady) { _USECASE_10BIT_OUTPUTContent = SGetField<int>(LocalBridgeClazz, "USECASE_10BIT_OUTPUT"); _USECASE_10BIT_OUTPUTReady = true; } return _USECASE_10BIT_OUTPUTContent; } }
        private static int _USECASE_10BIT_OUTPUTContent = default;
        private static bool _USECASE_10BIT_OUTPUTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/RecommendedStreamConfigurationMap.html#USECASE_LOW_LATENCY_SNAPSHOT"/>
        /// </summary>
        public static int USECASE_LOW_LATENCY_SNAPSHOT { get { if (!_USECASE_LOW_LATENCY_SNAPSHOTReady) { _USECASE_LOW_LATENCY_SNAPSHOTContent = SGetField<int>(LocalBridgeClazz, "USECASE_LOW_LATENCY_SNAPSHOT"); _USECASE_LOW_LATENCY_SNAPSHOTReady = true; } return _USECASE_LOW_LATENCY_SNAPSHOTContent; } }
        private static int _USECASE_LOW_LATENCY_SNAPSHOTContent = default;
        private static bool _USECASE_LOW_LATENCY_SNAPSHOTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/RecommendedStreamConfigurationMap.html#USECASE_PREVIEW"/>
        /// </summary>
        public static int USECASE_PREVIEW { get { if (!_USECASE_PREVIEWReady) { _USECASE_PREVIEWContent = SGetField<int>(LocalBridgeClazz, "USECASE_PREVIEW"); _USECASE_PREVIEWReady = true; } return _USECASE_PREVIEWContent; } }
        private static int _USECASE_PREVIEWContent = default;
        private static bool _USECASE_PREVIEWReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/RecommendedStreamConfigurationMap.html#USECASE_RAW"/>
        /// </summary>
        public static int USECASE_RAW { get { if (!_USECASE_RAWReady) { _USECASE_RAWContent = SGetField<int>(LocalBridgeClazz, "USECASE_RAW"); _USECASE_RAWReady = true; } return _USECASE_RAWContent; } }
        private static int _USECASE_RAWContent = default;
        private static bool _USECASE_RAWReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/RecommendedStreamConfigurationMap.html#USECASE_RECORD"/>
        /// </summary>
        public static int USECASE_RECORD { get { if (!_USECASE_RECORDReady) { _USECASE_RECORDContent = SGetField<int>(LocalBridgeClazz, "USECASE_RECORD"); _USECASE_RECORDReady = true; } return _USECASE_RECORDContent; } }
        private static int _USECASE_RECORDContent = default;
        private static bool _USECASE_RECORDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/RecommendedStreamConfigurationMap.html#USECASE_SNAPSHOT"/>
        /// </summary>
        public static int USECASE_SNAPSHOT { get { if (!_USECASE_SNAPSHOTReady) { _USECASE_SNAPSHOTContent = SGetField<int>(LocalBridgeClazz, "USECASE_SNAPSHOT"); _USECASE_SNAPSHOTReady = true; } return _USECASE_SNAPSHOTContent; } }
        private static int _USECASE_SNAPSHOTContent = default;
        private static bool _USECASE_SNAPSHOTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/RecommendedStreamConfigurationMap.html#USECASE_VIDEO_SNAPSHOT"/>
        /// </summary>
        public static int USECASE_VIDEO_SNAPSHOT { get { if (!_USECASE_VIDEO_SNAPSHOTReady) { _USECASE_VIDEO_SNAPSHOTContent = SGetField<int>(LocalBridgeClazz, "USECASE_VIDEO_SNAPSHOT"); _USECASE_VIDEO_SNAPSHOTReady = true; } return _USECASE_VIDEO_SNAPSHOTContent; } }
        private static int _USECASE_VIDEO_SNAPSHOTContent = default;
        private static bool _USECASE_VIDEO_SNAPSHOTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/RecommendedStreamConfigurationMap.html#USECASE_ZSL"/>
        /// </summary>
        public static int USECASE_ZSL { get { if (!_USECASE_ZSLReady) { _USECASE_ZSLContent = SGetField<int>(LocalBridgeClazz, "USECASE_ZSL"); _USECASE_ZSLReady = true; } return _USECASE_ZSLContent; } }
        private static int _USECASE_ZSLContent = default;
        private static bool _USECASE_ZSLReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/RecommendedStreamConfigurationMap.html#getOutputSizes(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Android.Util.Size> GetOutputSizes(Java.Lang.Class arg0)
        {
            return IExecuteWithSignature<Java.Util.Set<Android.Util.Size>>("getOutputSizes", "(Ljava/lang/Class;)Ljava/util/Set;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/RecommendedStreamConfigurationMap.html#getOutputMinFrameDuration(java.lang.Class,android.util.Size)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="Android.Util.Size"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetOutputMinFrameDuration(Java.Lang.Class arg0, Android.Util.Size arg1)
        {
            return IExecuteWithSignature<long>("getOutputMinFrameDuration", "(Ljava/lang/Class;Landroid/util/Size;)J", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/RecommendedStreamConfigurationMap.html#getOutputStallDuration(java.lang.Class,android.util.Size)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="Android.Util.Size"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetOutputStallDuration(Java.Lang.Class arg0, Android.Util.Size arg1)
        {
            return IExecuteWithSignature<long>("getOutputStallDuration", "(Ljava/lang/Class;Landroid/util/Size;)J", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/RecommendedStreamConfigurationMap.html#isOutputSupportedFor(android.view.Surface)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Surface"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsOutputSupportedFor(Android.View.Surface arg0)
        {
            return IExecuteWithSignature<bool>("isOutputSupportedFor", "(Landroid/view/Surface;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/RecommendedStreamConfigurationMap.html#isOutputSupportedFor(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsOutputSupportedFor(int arg0)
        {
            return IExecuteWithSignature<bool>("isOutputSupportedFor", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/RecommendedStreamConfigurationMap.html#getRecommendedUseCase()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetRecommendedUseCase()
        {
            return IExecuteWithSignature<int>("getRecommendedUseCase", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/RecommendedStreamConfigurationMap.html#getHighResolutionOutputSizes(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Android.Util.Size> GetHighResolutionOutputSizes(int arg0)
        {
            return IExecuteWithSignature<Java.Util.Set<Android.Util.Size>>("getHighResolutionOutputSizes", "(I)Ljava/util/Set;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/RecommendedStreamConfigurationMap.html#getHighSpeedVideoSizes()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Android.Util.Size> GetHighSpeedVideoSizes()
        {
            return IExecuteWithSignature<Java.Util.Set<Android.Util.Size>>("getHighSpeedVideoSizes", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/RecommendedStreamConfigurationMap.html#getInputSizes(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Android.Util.Size> GetInputSizes(int arg0)
        {
            return IExecuteWithSignature<Java.Util.Set<Android.Util.Size>>("getInputSizes", "(I)Ljava/util/Set;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/RecommendedStreamConfigurationMap.html#getOutputSizes(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Android.Util.Size> GetOutputSizes(int arg0)
        {
            return IExecuteWithSignature<Java.Util.Set<Android.Util.Size>>("getOutputSizes", "(I)Ljava/util/Set;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/RecommendedStreamConfigurationMap.html#getInputFormats()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.Integer> GetInputFormats()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.Integer>>("getInputFormats", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/RecommendedStreamConfigurationMap.html#getOutputFormats()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.Integer> GetOutputFormats()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.Integer>>("getOutputFormats", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/RecommendedStreamConfigurationMap.html#getValidOutputFormatsForInput(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.Integer> GetValidOutputFormatsForInput(int arg0)
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.Integer>>("getValidOutputFormatsForInput", "(I)Ljava/util/Set;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/RecommendedStreamConfigurationMap.html#getOutputMinFrameDuration(int,android.util.Size)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Util.Size"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetOutputMinFrameDuration(int arg0, Android.Util.Size arg1)
        {
            return IExecuteWithSignature<long>("getOutputMinFrameDuration", "(ILandroid/util/Size;)J", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/RecommendedStreamConfigurationMap.html#getOutputStallDuration(int,android.util.Size)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Util.Size"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetOutputStallDuration(int arg0, Android.Util.Size arg1)
        {
            return IExecuteWithSignature<long>("getOutputStallDuration", "(ILandroid/util/Size;)J", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}