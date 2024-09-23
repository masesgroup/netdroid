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

namespace Android.Gesture
{
    #region GestureStroke declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/gesture/GestureStroke.html"/>
    /// </summary>
    public partial class GestureStroke : MASES.JCOBridge.C2JBridge.JVMBridgeBase<GestureStroke>
    {
        const string _bridgeClassName = "android.gesture.GestureStroke";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public GestureStroke() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public GestureStroke(params object[] args) : base(args) { }
    
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

    #region GestureStroke implementation
    public partial class GestureStroke
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/gesture/GestureStroke.html#%3Cinit%3E(java.util.ArrayList)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.ArrayList"/></param>
        public GestureStroke(Java.Util.ArrayList<Android.Gesture.GesturePoint> arg0)
            : base(arg0)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/gesture/GestureStroke.html#boundingBox"/>
        /// </summary>
        public Android.Graphics.RectF boundingBox { get { if (!_boundingBoxReady) { _boundingBoxContent = IGetField<Android.Graphics.RectF>("boundingBox"); _boundingBoxReady = true; } return _boundingBoxContent; } }
        private Android.Graphics.RectF _boundingBoxContent = default;
        private bool _boundingBoxReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/gesture/GestureStroke.html#length"/>
        /// </summary>
        public float length { get { if (!_lengthReady) { _lengthContent = IGetField<float>("length"); _lengthReady = true; } return _lengthContent; } }
        private float _lengthContent = default;
        private bool _lengthReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/gesture/GestureStroke.html#points"/>
        /// </summary>
        public float[] points { get { if (!_pointsReady) { _pointsContent = IGetFieldArray<float>("points"); _pointsReady = true; } return _pointsContent; } }
        private float[] _pointsContent = default;
        private bool _pointsReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/gesture/GestureStroke.html#computeOrientedBoundingBox()"/>
        /// </summary>
        /// <returns><see cref="Android.Gesture.OrientedBoundingBox"/></returns>
        public Android.Gesture.OrientedBoundingBox ComputeOrientedBoundingBox()
        {
            return IExecuteWithSignature<Android.Gesture.OrientedBoundingBox>("computeOrientedBoundingBox", "()Landroid/gesture/OrientedBoundingBox;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/gesture/GestureStroke.html#getPath()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Path"/></returns>
        public Android.Graphics.Path GetPath()
        {
            return IExecuteWithSignature<Android.Graphics.Path>("getPath", "()Landroid/graphics/Path;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/gesture/GestureStroke.html#toPath(float,float,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Android.Graphics.Path"/></returns>
        public Android.Graphics.Path ToPath(float arg0, float arg1, int arg2)
        {
            return IExecute<Android.Graphics.Path>("toPath", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/gesture/GestureStroke.html#clearPath()"/>
        /// </summary>
        public void ClearPath()
        {
            IExecuteWithSignature("clearPath", "()V");
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}