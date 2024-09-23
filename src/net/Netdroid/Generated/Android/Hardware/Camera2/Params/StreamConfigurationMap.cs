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
    #region StreamConfigurationMap declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/StreamConfigurationMap.html"/>
    /// </summary>
    public partial class StreamConfigurationMap : MASES.JCOBridge.C2JBridge.JVMBridgeBase<StreamConfigurationMap>
    {
        const string _bridgeClassName = "android.hardware.camera2.params.StreamConfigurationMap";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public StreamConfigurationMap() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public StreamConfigurationMap(params object[] args) : base(args) { }
    
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

    #region StreamConfigurationMap implementation
    public partial class StreamConfigurationMap
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/StreamConfigurationMap.html#isOutputSupportedFor(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsOutputSupportedFor(Java.Lang.Class arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isOutputSupportedFor", "(Ljava/lang/Class;)Z", arg0);
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/StreamConfigurationMap.html#getOutputSizes(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Android.Util.Size"/></returns>
        public Android.Util.Size[] GetOutputSizes(Java.Lang.Class arg0)
        {
            return IExecuteWithSignatureArray<Android.Util.Size>("getOutputSizes", "(Ljava/lang/Class;)[Landroid/util/Size;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/StreamConfigurationMap.html#getOutputMinFrameDuration(java.lang.Class,android.util.Size)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="Android.Util.Size"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetOutputMinFrameDuration(Java.Lang.Class arg0, Android.Util.Size arg1)
        {
            return IExecute<long>("getOutputMinFrameDuration", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/StreamConfigurationMap.html#getOutputStallDuration(java.lang.Class,android.util.Size)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="Android.Util.Size"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetOutputStallDuration(Java.Lang.Class arg0, Android.Util.Size arg1)
        {
            return IExecute<long>("getOutputStallDuration", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/StreamConfigurationMap.html#getHighResolutionOutputSizes(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Util.Size"/></returns>
        public Android.Util.Size[] GetHighResolutionOutputSizes(int arg0)
        {
            return IExecuteWithSignatureArray<Android.Util.Size>("getHighResolutionOutputSizes", "(I)[Landroid/util/Size;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/StreamConfigurationMap.html#getHighSpeedVideoSizes()"/>
        /// </summary>
        /// <returns><see cref="Android.Util.Size"/></returns>
        public Android.Util.Size[] GetHighSpeedVideoSizes()
        {
            return IExecuteWithSignatureArray<Android.Util.Size>("getHighSpeedVideoSizes", "()[Landroid/util/Size;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/StreamConfigurationMap.html#getInputSizes(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Util.Size"/></returns>
        public Android.Util.Size[] GetInputSizes(int arg0)
        {
            return IExecuteWithSignatureArray<Android.Util.Size>("getInputSizes", "(I)[Landroid/util/Size;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/StreamConfigurationMap.html#getOutputSizes(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Util.Size"/></returns>
        public Android.Util.Size[] GetOutputSizes(int arg0)
        {
            return IExecuteWithSignatureArray<Android.Util.Size>("getOutputSizes", "(I)[Landroid/util/Size;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/StreamConfigurationMap.html#isOutputSupportedFor(android.view.Surface)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Surface"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsOutputSupportedFor(Android.View.Surface arg0)
        {
            return IExecuteWithSignature<bool>("isOutputSupportedFor", "(Landroid/view/Surface;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/StreamConfigurationMap.html#isOutputSupportedFor(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsOutputSupportedFor(int arg0)
        {
            return IExecuteWithSignature<bool>("isOutputSupportedFor", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/StreamConfigurationMap.html#getInputFormats()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int[] GetInputFormats()
        {
            return IExecuteWithSignatureArray<int>("getInputFormats", "()[I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/StreamConfigurationMap.html#getOutputFormats()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int[] GetOutputFormats()
        {
            return IExecuteWithSignatureArray<int>("getOutputFormats", "()[I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/StreamConfigurationMap.html#getValidOutputFormatsForInput(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int[] GetValidOutputFormatsForInput(int arg0)
        {
            return IExecuteWithSignatureArray<int>("getValidOutputFormatsForInput", "(I)[I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/StreamConfigurationMap.html#getOutputMinFrameDuration(int,android.util.Size)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Util.Size"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetOutputMinFrameDuration(int arg0, Android.Util.Size arg1)
        {
            return IExecute<long>("getOutputMinFrameDuration", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/StreamConfigurationMap.html#getOutputStallDuration(int,android.util.Size)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Util.Size"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetOutputStallDuration(int arg0, Android.Util.Size arg1)
        {
            return IExecute<long>("getOutputStallDuration", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}