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
    #region OutputConfiguration declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/OutputConfiguration.html"/>
    /// </summary>
    public partial class OutputConfiguration : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.hardware.camera2.params.OutputConfiguration";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public OutputConfiguration() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public OutputConfiguration(params object[] args) : base(args) { }

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

    #region OutputConfiguration implementation
    public partial class OutputConfiguration
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/OutputConfiguration.html#%3Cinit%3E(android.util.Size,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Util.Size"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        public OutputConfiguration(Android.Util.Size arg0, Java.Lang.Class arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/OutputConfiguration.html#%3Cinit%3E(android.view.Surface)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Surface"/></param>
        public OutputConfiguration(Android.View.Surface arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/OutputConfiguration.html#%3Cinit%3E(int,android.util.Size,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Util.Size"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        public OutputConfiguration(int arg0, Android.Util.Size arg1, long arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/OutputConfiguration.html#%3Cinit%3E(int,android.util.Size)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Util.Size"/></param>
        public OutputConfiguration(int arg0, Android.Util.Size arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/OutputConfiguration.html#%3Cinit%3E(int,android.view.Surface)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.View.Surface"/></param>
        public OutputConfiguration(int arg0, Android.View.Surface arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/OutputConfiguration.html#%3Cinit%3E(int,int,android.util.Size,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.Util.Size"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        public OutputConfiguration(int arg0, int arg1, Android.Util.Size arg2, long arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/OutputConfiguration.html#%3Cinit%3E(int,int,android.util.Size)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.Util.Size"/></param>
        public OutputConfiguration(int arg0, int arg1, Android.Util.Size arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/OutputConfiguration.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/OutputConfiguration.html#MIRROR_MODE_AUTO"/>
        /// </summary>
        public static int MIRROR_MODE_AUTO { get { if (!_MIRROR_MODE_AUTOReady) { _MIRROR_MODE_AUTOContent = SGetField<int>(LocalBridgeClazz, "MIRROR_MODE_AUTO"); _MIRROR_MODE_AUTOReady = true; } return _MIRROR_MODE_AUTOContent; } }
        private static int _MIRROR_MODE_AUTOContent = default;
        private static bool _MIRROR_MODE_AUTOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/OutputConfiguration.html#MIRROR_MODE_H"/>
        /// </summary>
        public static int MIRROR_MODE_H { get { if (!_MIRROR_MODE_HReady) { _MIRROR_MODE_HContent = SGetField<int>(LocalBridgeClazz, "MIRROR_MODE_H"); _MIRROR_MODE_HReady = true; } return _MIRROR_MODE_HContent; } }
        private static int _MIRROR_MODE_HContent = default;
        private static bool _MIRROR_MODE_HReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/OutputConfiguration.html#MIRROR_MODE_NONE"/>
        /// </summary>
        public static int MIRROR_MODE_NONE { get { if (!_MIRROR_MODE_NONEReady) { _MIRROR_MODE_NONEContent = SGetField<int>(LocalBridgeClazz, "MIRROR_MODE_NONE"); _MIRROR_MODE_NONEReady = true; } return _MIRROR_MODE_NONEContent; } }
        private static int _MIRROR_MODE_NONEContent = default;
        private static bool _MIRROR_MODE_NONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/OutputConfiguration.html#MIRROR_MODE_V"/>
        /// </summary>
        public static int MIRROR_MODE_V { get { if (!_MIRROR_MODE_VReady) { _MIRROR_MODE_VContent = SGetField<int>(LocalBridgeClazz, "MIRROR_MODE_V"); _MIRROR_MODE_VReady = true; } return _MIRROR_MODE_VContent; } }
        private static int _MIRROR_MODE_VContent = default;
        private static bool _MIRROR_MODE_VReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/OutputConfiguration.html#SURFACE_GROUP_ID_NONE"/>
        /// </summary>
        public static int SURFACE_GROUP_ID_NONE { get { if (!_SURFACE_GROUP_ID_NONEReady) { _SURFACE_GROUP_ID_NONEContent = SGetField<int>(LocalBridgeClazz, "SURFACE_GROUP_ID_NONE"); _SURFACE_GROUP_ID_NONEReady = true; } return _SURFACE_GROUP_ID_NONEContent; } }
        private static int _SURFACE_GROUP_ID_NONEContent = default;
        private static bool _SURFACE_GROUP_ID_NONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/OutputConfiguration.html#TIMESTAMP_BASE_CHOREOGRAPHER_SYNCED"/>
        /// </summary>
        public static int TIMESTAMP_BASE_CHOREOGRAPHER_SYNCED { get { if (!_TIMESTAMP_BASE_CHOREOGRAPHER_SYNCEDReady) { _TIMESTAMP_BASE_CHOREOGRAPHER_SYNCEDContent = SGetField<int>(LocalBridgeClazz, "TIMESTAMP_BASE_CHOREOGRAPHER_SYNCED"); _TIMESTAMP_BASE_CHOREOGRAPHER_SYNCEDReady = true; } return _TIMESTAMP_BASE_CHOREOGRAPHER_SYNCEDContent; } }
        private static int _TIMESTAMP_BASE_CHOREOGRAPHER_SYNCEDContent = default;
        private static bool _TIMESTAMP_BASE_CHOREOGRAPHER_SYNCEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/OutputConfiguration.html#TIMESTAMP_BASE_DEFAULT"/>
        /// </summary>
        public static int TIMESTAMP_BASE_DEFAULT { get { if (!_TIMESTAMP_BASE_DEFAULTReady) { _TIMESTAMP_BASE_DEFAULTContent = SGetField<int>(LocalBridgeClazz, "TIMESTAMP_BASE_DEFAULT"); _TIMESTAMP_BASE_DEFAULTReady = true; } return _TIMESTAMP_BASE_DEFAULTContent; } }
        private static int _TIMESTAMP_BASE_DEFAULTContent = default;
        private static bool _TIMESTAMP_BASE_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/OutputConfiguration.html#TIMESTAMP_BASE_MONOTONIC"/>
        /// </summary>
        public static int TIMESTAMP_BASE_MONOTONIC { get { if (!_TIMESTAMP_BASE_MONOTONICReady) { _TIMESTAMP_BASE_MONOTONICContent = SGetField<int>(LocalBridgeClazz, "TIMESTAMP_BASE_MONOTONIC"); _TIMESTAMP_BASE_MONOTONICReady = true; } return _TIMESTAMP_BASE_MONOTONICContent; } }
        private static int _TIMESTAMP_BASE_MONOTONICContent = default;
        private static bool _TIMESTAMP_BASE_MONOTONICReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/OutputConfiguration.html#TIMESTAMP_BASE_REALTIME"/>
        /// </summary>
        public static int TIMESTAMP_BASE_REALTIME { get { if (!_TIMESTAMP_BASE_REALTIMEReady) { _TIMESTAMP_BASE_REALTIMEContent = SGetField<int>(LocalBridgeClazz, "TIMESTAMP_BASE_REALTIME"); _TIMESTAMP_BASE_REALTIMEReady = true; } return _TIMESTAMP_BASE_REALTIMEContent; } }
        private static int _TIMESTAMP_BASE_REALTIMEContent = default;
        private static bool _TIMESTAMP_BASE_REALTIMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/OutputConfiguration.html#TIMESTAMP_BASE_SENSOR"/>
        /// </summary>
        public static int TIMESTAMP_BASE_SENSOR { get { if (!_TIMESTAMP_BASE_SENSORReady) { _TIMESTAMP_BASE_SENSORContent = SGetField<int>(LocalBridgeClazz, "TIMESTAMP_BASE_SENSOR"); _TIMESTAMP_BASE_SENSORReady = true; } return _TIMESTAMP_BASE_SENSORContent; } }
        private static int _TIMESTAMP_BASE_SENSORContent = default;
        private static bool _TIMESTAMP_BASE_SENSORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/OutputConfiguration.html#createInstancesForMultiResolutionOutput(android.hardware.camera2.MultiResolutionImageReader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.Camera2.MultiResolutionImageReader"/></param>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        public static Java.Util.Collection<Android.Hardware.Camera2.Params.OutputConfiguration> CreateInstancesForMultiResolutionOutput(Android.Hardware.Camera2.MultiResolutionImageReader arg0)
        {
            return SExecuteWithSignature<Java.Util.Collection<Android.Hardware.Camera2.Params.OutputConfiguration>>(LocalBridgeClazz, "createInstancesForMultiResolutionOutput", "(Landroid/hardware/camera2/MultiResolutionImageReader;)Ljava/util/Collection;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/OutputConfiguration.html#createInstancesForMultiResolutionOutput(java.util.Collection,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public static Java.Util.List<Android.Hardware.Camera2.Params.OutputConfiguration> CreateInstancesForMultiResolutionOutput(Java.Util.Collection<Android.Hardware.Camera2.Params.MultiResolutionStreamInfo> arg0, int arg1)
        {
            return SExecute<Java.Util.List<Android.Hardware.Camera2.Params.OutputConfiguration>>(LocalBridgeClazz, "createInstancesForMultiResolutionOutput", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/OutputConfiguration.html#setSurfacesForMultiResolutionOutput(java.util.Collection,android.hardware.camera2.MultiResolutionImageReader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <param name="arg1"><see cref="Android.Hardware.Camera2.MultiResolutionImageReader"/></param>
        public static void SetSurfacesForMultiResolutionOutput(Java.Util.Collection<Android.Hardware.Camera2.Params.OutputConfiguration> arg0, Android.Hardware.Camera2.MultiResolutionImageReader arg1)
        {
            SExecute(LocalBridgeClazz, "setSurfacesForMultiResolutionOutput", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/OutputConfiguration.html#getSurface()"/>
        /// </summary>
        /// <returns><see cref="Android.View.Surface"/></returns>
        public Android.View.Surface GetSurface()
        {
            return IExecuteWithSignature<Android.View.Surface>("getSurface", "()Landroid/view/Surface;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/OutputConfiguration.html#isReadoutTimestampEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsReadoutTimestampEnabled()
        {
            return IExecuteWithSignature<bool>("isReadoutTimestampEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/OutputConfiguration.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/OutputConfiguration.html#getMaxSharedSurfaceCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMaxSharedSurfaceCount()
        {
            return IExecuteWithSignature<int>("getMaxSharedSurfaceCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/OutputConfiguration.html#getMirrorMode()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMirrorMode()
        {
            return IExecuteWithSignature<int>("getMirrorMode", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/OutputConfiguration.html#getSurfaceGroupId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSurfaceGroupId()
        {
            return IExecuteWithSignature<int>("getSurfaceGroupId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/OutputConfiguration.html#getTimestampBase()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetTimestampBase()
        {
            return IExecuteWithSignature<int>("getTimestampBase", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/OutputConfiguration.html#getSurfaces()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.View.Surface> GetSurfaces()
        {
            return IExecuteWithSignature<Java.Util.List<Android.View.Surface>>("getSurfaces", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/OutputConfiguration.html#getDynamicRangeProfile()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetDynamicRangeProfile()
        {
            return IExecuteWithSignature<long>("getDynamicRangeProfile", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/OutputConfiguration.html#getStreamUseCase()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetStreamUseCase()
        {
            return IExecuteWithSignature<long>("getStreamUseCase", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/OutputConfiguration.html#addSensorPixelModeUsed(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void AddSensorPixelModeUsed(int arg0)
        {
            IExecuteWithSignature("addSensorPixelModeUsed", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/OutputConfiguration.html#addSurface(android.view.Surface)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Surface"/></param>
        public void AddSurface(Android.View.Surface arg0)
        {
            IExecuteWithSignature("addSurface", "(Landroid/view/Surface;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/OutputConfiguration.html#enableSurfaceSharing()"/>
        /// </summary>
        public void EnableSurfaceSharing()
        {
            IExecuteWithSignature("enableSurfaceSharing", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/OutputConfiguration.html#removeSensorPixelModeUsed(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void RemoveSensorPixelModeUsed(int arg0)
        {
            IExecuteWithSignature("removeSensorPixelModeUsed", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/OutputConfiguration.html#removeSurface(android.view.Surface)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Surface"/></param>
        public void RemoveSurface(Android.View.Surface arg0)
        {
            IExecuteWithSignature("removeSurface", "(Landroid/view/Surface;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/OutputConfiguration.html#setDynamicRangeProfile(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void SetDynamicRangeProfile(long arg0)
        {
            IExecuteWithSignature("setDynamicRangeProfile", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/OutputConfiguration.html#setMirrorMode(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetMirrorMode(int arg0)
        {
            IExecuteWithSignature("setMirrorMode", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/OutputConfiguration.html#setPhysicalCameraId(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetPhysicalCameraId(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setPhysicalCameraId", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/OutputConfiguration.html#setReadoutTimestampEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetReadoutTimestampEnabled(bool arg0)
        {
            IExecuteWithSignature("setReadoutTimestampEnabled", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/OutputConfiguration.html#setStreamUseCase(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void SetStreamUseCase(long arg0)
        {
            IExecuteWithSignature("setStreamUseCase", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/OutputConfiguration.html#setTimestampBase(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetTimestampBase(int arg0)
        {
            IExecuteWithSignature("setTimestampBase", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/OutputConfiguration.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}