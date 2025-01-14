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

namespace Android.Graphics
{
    #region Interpolator declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/graphics/Interpolator.html"/>
    /// </summary>
    public partial class Interpolator : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Interpolator>
    {
        const string _bridgeClassName = "android.graphics.Interpolator";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Interpolator() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Interpolator(params object[] args) : base(args) { }
    
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
        #region Result declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Interpolator.Result.html"/>
        /// </summary>
        public partial class Result : Java.Lang.Enum<Android.Graphics.Interpolator.Result>
        {
            const string _bridgeClassName = "android.graphics.Interpolator$Result";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Result() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Result(params object[] args) : base(args) { }
        
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

    #region Interpolator implementation
    public partial class Interpolator
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Interpolator.html#%3Cinit%3E(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public Interpolator(int arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Interpolator.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public Interpolator(int arg0)
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
        /// <see href="https://developer.android.com/reference/android/graphics/Interpolator.html#timeToValues(float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="Android.Graphics.Interpolator.Result"/></returns>
        public Android.Graphics.Interpolator.Result TimeToValues(float[] arg0)
        {
            return IExecuteWithSignature<Android.Graphics.Interpolator.Result>("timeToValues", "([F)Landroid/graphics/Interpolator$Result;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Interpolator.html#timeToValues(int,float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="Android.Graphics.Interpolator.Result"/></returns>
        public Android.Graphics.Interpolator.Result TimeToValues(int arg0, float[] arg1)
        {
            return IExecuteWithSignature<Android.Graphics.Interpolator.Result>("timeToValues", "(I[F)Landroid/graphics/Interpolator$Result;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Interpolator.html#getKeyFrameCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetKeyFrameCount()
        {
            return IExecuteWithSignature<int>("getKeyFrameCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Interpolator.html#getValueCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetValueCount()
        {
            return IExecuteWithSignature<int>("getValueCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Interpolator.html#reset(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void Reset(int arg0, int arg1)
        {
            IExecuteWithSignature("reset", "(II)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Interpolator.html#reset(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void Reset(int arg0)
        {
            IExecuteWithSignature("reset", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Interpolator.html#setKeyFrame(int,int,float[],float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        public void SetKeyFrame(int arg0, int arg1, float[] arg2, float[] arg3)
        {
            IExecuteWithSignature("setKeyFrame", "(II[F[F)V", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Interpolator.html#setKeyFrame(int,int,float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        public void SetKeyFrame(int arg0, int arg1, float[] arg2)
        {
            IExecuteWithSignature("setKeyFrame", "(II[F)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Interpolator.html#setRepeatMirror(float,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public void SetRepeatMirror(float arg0, bool arg1)
        {
            IExecuteWithSignature("setRepeatMirror", "(FZ)V", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
        #region Result implementation
        public partial class Result
        {
            #region Constructors
        
            #endregion
        
            #region Class/Interface conversion operators
        
            #endregion
        
            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/Interpolator.Result.html#FREEZE_END"/>
            /// </summary>
            public static Android.Graphics.Interpolator.Result FREEZE_END { get { if (!_FREEZE_ENDReady) { _FREEZE_ENDContent = SGetField<Android.Graphics.Interpolator.Result>(LocalBridgeClazz, "FREEZE_END"); _FREEZE_ENDReady = true; } return _FREEZE_ENDContent; } }
            private static Android.Graphics.Interpolator.Result _FREEZE_ENDContent = default;
            private static bool _FREEZE_ENDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/Interpolator.Result.html#FREEZE_START"/>
            /// </summary>
            public static Android.Graphics.Interpolator.Result FREEZE_START { get { if (!_FREEZE_STARTReady) { _FREEZE_STARTContent = SGetField<Android.Graphics.Interpolator.Result>(LocalBridgeClazz, "FREEZE_START"); _FREEZE_STARTReady = true; } return _FREEZE_STARTContent; } }
            private static Android.Graphics.Interpolator.Result _FREEZE_STARTContent = default;
            private static bool _FREEZE_STARTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/Interpolator.Result.html#NORMAL"/>
            /// </summary>
            public static Android.Graphics.Interpolator.Result NORMAL { get { if (!_NORMALReady) { _NORMALContent = SGetField<Android.Graphics.Interpolator.Result>(LocalBridgeClazz, "NORMAL"); _NORMALReady = true; } return _NORMALContent; } }
            private static Android.Graphics.Interpolator.Result _NORMALContent = default;
            private static bool _NORMALReady = false; // this is used because in case of generics 
        
            #endregion
        
            #region Static methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/Interpolator.Result.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Graphics.Interpolator.Result"/></returns>
            public static Android.Graphics.Interpolator.Result ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Android.Graphics.Interpolator.Result>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Interpolator$Result;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/Interpolator.Result.html#values()"/>
            /// </summary>
            /// <returns><see cref="Android.Graphics.Interpolator.Result"/></returns>
            public static Android.Graphics.Interpolator.Result[] Values()
            {
                return SExecuteWithSignatureArray<Android.Graphics.Interpolator.Result>(LocalBridgeClazz, "values", "()[Landroid/graphics/Interpolator$Result;");
            }
        
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