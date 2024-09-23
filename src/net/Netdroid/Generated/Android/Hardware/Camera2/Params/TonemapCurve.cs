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
    #region TonemapCurve declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/TonemapCurve.html"/>
    /// </summary>
    public partial class TonemapCurve : MASES.JCOBridge.C2JBridge.JVMBridgeBase<TonemapCurve>
    {
        const string _bridgeClassName = "android.hardware.camera2.params.TonemapCurve";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public TonemapCurve() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public TonemapCurve(params object[] args) : base(args) { }
    
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

    #region TonemapCurve implementation
    public partial class TonemapCurve
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/TonemapCurve.html#%3Cinit%3E(float[],float[],float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        public TonemapCurve(float[] arg0, float[] arg1, float[] arg2)
            : base(arg0, arg1, arg2)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/TonemapCurve.html#LEVEL_BLACK"/>
        /// </summary>
        public static float LEVEL_BLACK { get { if (!_LEVEL_BLACKReady) { _LEVEL_BLACKContent = SGetField<float>(LocalBridgeClazz, "LEVEL_BLACK"); _LEVEL_BLACKReady = true; } return _LEVEL_BLACKContent; } }
        private static float _LEVEL_BLACKContent = default;
        private static bool _LEVEL_BLACKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/TonemapCurve.html#LEVEL_WHITE"/>
        /// </summary>
        public static float LEVEL_WHITE { get { if (!_LEVEL_WHITEReady) { _LEVEL_WHITEContent = SGetField<float>(LocalBridgeClazz, "LEVEL_WHITE"); _LEVEL_WHITEReady = true; } return _LEVEL_WHITEContent; } }
        private static float _LEVEL_WHITEContent = default;
        private static bool _LEVEL_WHITEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/TonemapCurve.html#CHANNEL_BLUE"/>
        /// </summary>
        public static int CHANNEL_BLUE { get { if (!_CHANNEL_BLUEReady) { _CHANNEL_BLUEContent = SGetField<int>(LocalBridgeClazz, "CHANNEL_BLUE"); _CHANNEL_BLUEReady = true; } return _CHANNEL_BLUEContent; } }
        private static int _CHANNEL_BLUEContent = default;
        private static bool _CHANNEL_BLUEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/TonemapCurve.html#CHANNEL_GREEN"/>
        /// </summary>
        public static int CHANNEL_GREEN { get { if (!_CHANNEL_GREENReady) { _CHANNEL_GREENContent = SGetField<int>(LocalBridgeClazz, "CHANNEL_GREEN"); _CHANNEL_GREENReady = true; } return _CHANNEL_GREENContent; } }
        private static int _CHANNEL_GREENContent = default;
        private static bool _CHANNEL_GREENReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/TonemapCurve.html#CHANNEL_RED"/>
        /// </summary>
        public static int CHANNEL_RED { get { if (!_CHANNEL_REDReady) { _CHANNEL_REDContent = SGetField<int>(LocalBridgeClazz, "CHANNEL_RED"); _CHANNEL_REDReady = true; } return _CHANNEL_REDContent; } }
        private static int _CHANNEL_REDContent = default;
        private static bool _CHANNEL_REDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/TonemapCurve.html#POINT_SIZE"/>
        /// </summary>
        public static int POINT_SIZE { get { if (!_POINT_SIZEReady) { _POINT_SIZEContent = SGetField<int>(LocalBridgeClazz, "POINT_SIZE"); _POINT_SIZEReady = true; } return _POINT_SIZEContent; } }
        private static int _POINT_SIZEContent = default;
        private static bool _POINT_SIZEReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/TonemapCurve.html#getPoint(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Android.Graphics.PointF"/></returns>
        public Android.Graphics.PointF GetPoint(int arg0, int arg1)
        {
            return IExecute<Android.Graphics.PointF>("getPoint", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/TonemapCurve.html#getPointCount(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetPointCount(int arg0)
        {
            return IExecuteWithSignature<int>("getPointCount", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/TonemapCurve.html#copyColorCurve(int,float[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void CopyColorCurve(int arg0, float[] arg1, int arg2)
        {
            IExecute("copyColorCurve", arg0, arg1, arg2);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}