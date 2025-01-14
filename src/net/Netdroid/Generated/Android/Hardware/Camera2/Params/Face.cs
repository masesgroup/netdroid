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

namespace Android.Hardware.Camera2.Params
{
    #region Face declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/Face.html"/>
    /// </summary>
    public partial class Face : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Face>
    {
        const string _bridgeClassName = "android.hardware.camera2.params.Face";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Face() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Face(params object[] args) : base(args) { }
    
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
        #region Builder declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/Face.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.hardware.camera2.params.Face$Builder";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Builder() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Builder(params object[] args) : base(args) { }
        
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

    #region Face implementation
    public partial class Face
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/Face.html#ID_UNSUPPORTED"/>
        /// </summary>
        public static int ID_UNSUPPORTED { get { if (!_ID_UNSUPPORTEDReady) { _ID_UNSUPPORTEDContent = SGetField<int>(LocalBridgeClazz, "ID_UNSUPPORTED"); _ID_UNSUPPORTEDReady = true; } return _ID_UNSUPPORTEDContent; } }
        private static int _ID_UNSUPPORTEDContent = default;
        private static bool _ID_UNSUPPORTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/Face.html#SCORE_MAX"/>
        /// </summary>
        public static int SCORE_MAX { get { if (!_SCORE_MAXReady) { _SCORE_MAXContent = SGetField<int>(LocalBridgeClazz, "SCORE_MAX"); _SCORE_MAXReady = true; } return _SCORE_MAXContent; } }
        private static int _SCORE_MAXContent = default;
        private static bool _SCORE_MAXReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/Face.html#SCORE_MIN"/>
        /// </summary>
        public static int SCORE_MIN { get { if (!_SCORE_MINReady) { _SCORE_MINContent = SGetField<int>(LocalBridgeClazz, "SCORE_MIN"); _SCORE_MINReady = true; } return _SCORE_MINContent; } }
        private static int _SCORE_MINContent = default;
        private static bool _SCORE_MINReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/Face.html#getLeftEyePosition()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Point"/></returns>
        public Android.Graphics.Point GetLeftEyePosition()
        {
            return IExecuteWithSignature<Android.Graphics.Point>("getLeftEyePosition", "()Landroid/graphics/Point;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/Face.html#getMouthPosition()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Point"/></returns>
        public Android.Graphics.Point GetMouthPosition()
        {
            return IExecuteWithSignature<Android.Graphics.Point>("getMouthPosition", "()Landroid/graphics/Point;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/Face.html#getRightEyePosition()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Point"/></returns>
        public Android.Graphics.Point GetRightEyePosition()
        {
            return IExecuteWithSignature<Android.Graphics.Point>("getRightEyePosition", "()Landroid/graphics/Point;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/Face.html#getBounds()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Rect"/></returns>
        public Android.Graphics.Rect GetBounds()
        {
            return IExecuteWithSignature<Android.Graphics.Rect>("getBounds", "()Landroid/graphics/Rect;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/Face.html#getId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetId()
        {
            return IExecuteWithSignature<int>("getId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/Face.html#getScore()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetScore()
        {
            return IExecuteWithSignature<int>("getScore", "()I");
        }
    
        #endregion
    
        #region Nested classes
        #region Builder implementation
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/Face.Builder.html#%3Cinit%3E(android.hardware.camera2.params.Face)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Hardware.Camera2.Params.Face"/></param>
            public Builder(Android.Hardware.Camera2.Params.Face arg0)
                : base(arg0)
            {
            }
        
            #endregion
        
            #region Class/Interface conversion operators
        
            #endregion
        
            #region Fields
        
            #endregion
        
            #region Static methods
        
            #endregion
        
            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/Face.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Hardware.Camera2.Params.Face"/></returns>
            public Android.Hardware.Camera2.Params.Face Build()
            {
                return IExecuteWithSignature<Android.Hardware.Camera2.Params.Face>("build", "()Landroid/hardware/camera2/params/Face;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/Face.Builder.html#setBounds(android.graphics.Rect)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.Rect"/></param>
            /// <returns><see cref="Android.Hardware.Camera2.Params.Face.Builder"/></returns>
            public Android.Hardware.Camera2.Params.Face.Builder SetBounds(Android.Graphics.Rect arg0)
            {
                return IExecuteWithSignature<Android.Hardware.Camera2.Params.Face.Builder>("setBounds", "(Landroid/graphics/Rect;)Landroid/hardware/camera2/params/Face$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/Face.Builder.html#setId(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Hardware.Camera2.Params.Face.Builder"/></returns>
            public Android.Hardware.Camera2.Params.Face.Builder SetId(int arg0)
            {
                return IExecuteWithSignature<Android.Hardware.Camera2.Params.Face.Builder>("setId", "(I)Landroid/hardware/camera2/params/Face$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/Face.Builder.html#setLeftEyePosition(android.graphics.Point)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.Point"/></param>
            /// <returns><see cref="Android.Hardware.Camera2.Params.Face.Builder"/></returns>
            public Android.Hardware.Camera2.Params.Face.Builder SetLeftEyePosition(Android.Graphics.Point arg0)
            {
                return IExecuteWithSignature<Android.Hardware.Camera2.Params.Face.Builder>("setLeftEyePosition", "(Landroid/graphics/Point;)Landroid/hardware/camera2/params/Face$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/Face.Builder.html#setMouthPosition(android.graphics.Point)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.Point"/></param>
            /// <returns><see cref="Android.Hardware.Camera2.Params.Face.Builder"/></returns>
            public Android.Hardware.Camera2.Params.Face.Builder SetMouthPosition(Android.Graphics.Point arg0)
            {
                return IExecuteWithSignature<Android.Hardware.Camera2.Params.Face.Builder>("setMouthPosition", "(Landroid/graphics/Point;)Landroid/hardware/camera2/params/Face$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/Face.Builder.html#setRightEyePosition(android.graphics.Point)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.Point"/></param>
            /// <returns><see cref="Android.Hardware.Camera2.Params.Face.Builder"/></returns>
            public Android.Hardware.Camera2.Params.Face.Builder SetRightEyePosition(Android.Graphics.Point arg0)
            {
                return IExecuteWithSignature<Android.Hardware.Camera2.Params.Face.Builder>("setRightEyePosition", "(Landroid/graphics/Point;)Landroid/hardware/camera2/params/Face$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/camera2/params/Face.Builder.html#setScore(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Hardware.Camera2.Params.Face.Builder"/></returns>
            public Android.Hardware.Camera2.Params.Face.Builder SetScore(int arg0)
            {
                return IExecuteWithSignature<Android.Hardware.Camera2.Params.Face.Builder>("setScore", "(I)Landroid/hardware/camera2/params/Face$Builder;", arg0);
            }
        
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