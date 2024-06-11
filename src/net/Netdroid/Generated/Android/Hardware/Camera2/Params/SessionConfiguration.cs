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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Hardware.Camera2.Params
{
    #region SessionConfiguration
    public partial class SessionConfiguration
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/SessionConfiguration.html#%3Cinit%3E(int,java.util.List,java.util.concurrent.Executor,android.hardware.camera2.CameraCaptureSession.StateCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Util.List"/></param>
        /// <param name="arg2"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg3"><see cref="Android.Hardware.Camera2.CameraCaptureSession.StateCallback"/></param>
        public SessionConfiguration(int arg0, Java.Util.List<Android.Hardware.Camera2.Params.OutputConfiguration> arg1, Java.Util.Concurrent.Executor arg2, Android.Hardware.Camera2.CameraCaptureSession.StateCallback arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/SessionConfiguration.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/SessionConfiguration.html#SESSION_HIGH_SPEED"/>
        /// </summary>
        public static int SESSION_HIGH_SPEED { get { if (!_SESSION_HIGH_SPEEDReady) { _SESSION_HIGH_SPEEDContent = SGetField<int>(LocalBridgeClazz, "SESSION_HIGH_SPEED"); _SESSION_HIGH_SPEEDReady = true; } return _SESSION_HIGH_SPEEDContent; } }
        private static int _SESSION_HIGH_SPEEDContent = default;
        private static bool _SESSION_HIGH_SPEEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/SessionConfiguration.html#SESSION_REGULAR"/>
        /// </summary>
        public static int SESSION_REGULAR { get { if (!_SESSION_REGULARReady) { _SESSION_REGULARContent = SGetField<int>(LocalBridgeClazz, "SESSION_REGULAR"); _SESSION_REGULARReady = true; } return _SESSION_REGULARContent; } }
        private static int _SESSION_REGULARContent = default;
        private static bool _SESSION_REGULARReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/SessionConfiguration.html#getColorSpace()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.ColorSpace"/></returns>
        public Android.Graphics.ColorSpace GetColorSpace()
        {
            return IExecuteWithSignature<Android.Graphics.ColorSpace>("getColorSpace", "()Landroid/graphics/ColorSpace;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/SessionConfiguration.html#getStateCallback()"/>
        /// </summary>
        /// <returns><see cref="Android.Hardware.Camera2.CameraCaptureSession.StateCallback"/></returns>
        public Android.Hardware.Camera2.CameraCaptureSession.StateCallback GetStateCallback()
        {
            return IExecuteWithSignature<Android.Hardware.Camera2.CameraCaptureSession.StateCallback>("getStateCallback", "()Landroid/hardware/camera2/CameraCaptureSession$StateCallback;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/SessionConfiguration.html#getSessionParameters()"/>
        /// </summary>
        /// <returns><see cref="Android.Hardware.Camera2.CaptureRequest"/></returns>
        public Android.Hardware.Camera2.CaptureRequest GetSessionParameters()
        {
            return IExecuteWithSignature<Android.Hardware.Camera2.CaptureRequest>("getSessionParameters", "()Landroid/hardware/camera2/CaptureRequest;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/SessionConfiguration.html#getInputConfiguration()"/>
        /// </summary>
        /// <returns><see cref="Android.Hardware.Camera2.Params.InputConfiguration"/></returns>
        public Android.Hardware.Camera2.Params.InputConfiguration GetInputConfiguration()
        {
            return IExecuteWithSignature<Android.Hardware.Camera2.Params.InputConfiguration>("getInputConfiguration", "()Landroid/hardware/camera2/params/InputConfiguration;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/SessionConfiguration.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/SessionConfiguration.html#getSessionType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSessionType()
        {
            return IExecuteWithSignature<int>("getSessionType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/SessionConfiguration.html#getExecutor()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.Executor"/></returns>
        public Java.Util.Concurrent.Executor GetExecutor()
        {
            return IExecuteWithSignature<Java.Util.Concurrent.Executor>("getExecutor", "()Ljava/util/concurrent/Executor;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/SessionConfiguration.html#getOutputConfigurations()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Hardware.Camera2.Params.OutputConfiguration> GetOutputConfigurations()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Hardware.Camera2.Params.OutputConfiguration>>("getOutputConfigurations", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/SessionConfiguration.html#clearColorSpace()"/>
        /// </summary>
        public void ClearColorSpace()
        {
            IExecuteWithSignature("clearColorSpace", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/SessionConfiguration.html#setColorSpace(android.graphics.ColorSpace.Named)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.ColorSpace.Named"/></param>
        public void SetColorSpace(Android.Graphics.ColorSpace.Named arg0)
        {
            IExecuteWithSignature("setColorSpace", "(Landroid/graphics/ColorSpace$Named;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/SessionConfiguration.html#setInputConfiguration(android.hardware.camera2.params.InputConfiguration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.Camera2.Params.InputConfiguration"/></param>
        public void SetInputConfiguration(Android.Hardware.Camera2.Params.InputConfiguration arg0)
        {
            IExecuteWithSignature("setInputConfiguration", "(Landroid/hardware/camera2/params/InputConfiguration;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/SessionConfiguration.html#setSessionParameters(android.hardware.camera2.CaptureRequest)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.Camera2.CaptureRequest"/></param>
        public void SetSessionParameters(Android.Hardware.Camera2.CaptureRequest arg0)
        {
            IExecuteWithSignature("setSessionParameters", "(Landroid/hardware/camera2/CaptureRequest;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/SessionConfiguration.html#writeToParcel(android.os.Parcel,int)"/>
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