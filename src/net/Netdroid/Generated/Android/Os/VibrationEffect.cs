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

namespace Android.Os
{
    #region VibrationEffect declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/os/VibrationEffect.html"/>
    /// </summary>
    public partial class VibrationEffect : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.os.VibrationEffect";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("VibrationEffect class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public VibrationEffect() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("VibrationEffect class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public VibrationEffect(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
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
        #region Composition declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/VibrationEffect.Composition.html"/>
        /// </summary>
        public partial class Composition : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Composition>
        {
            const string _bridgeClassName = "android.os.VibrationEffect$Composition";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Composition() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Composition(params object[] args) : base(args) { }

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

    #region VibrationEffect implementation
    public partial class VibrationEffect
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/VibrationEffect.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/VibrationEffect.html#DEFAULT_AMPLITUDE"/>
        /// </summary>
        public static int DEFAULT_AMPLITUDE { get { if (!_DEFAULT_AMPLITUDEReady) { _DEFAULT_AMPLITUDEContent = SGetField<int>(LocalBridgeClazz, "DEFAULT_AMPLITUDE"); _DEFAULT_AMPLITUDEReady = true; } return _DEFAULT_AMPLITUDEContent; } }
        private static int _DEFAULT_AMPLITUDEContent = default;
        private static bool _DEFAULT_AMPLITUDEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/VibrationEffect.html#EFFECT_CLICK"/>
        /// </summary>
        public static int EFFECT_CLICK { get { if (!_EFFECT_CLICKReady) { _EFFECT_CLICKContent = SGetField<int>(LocalBridgeClazz, "EFFECT_CLICK"); _EFFECT_CLICKReady = true; } return _EFFECT_CLICKContent; } }
        private static int _EFFECT_CLICKContent = default;
        private static bool _EFFECT_CLICKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/VibrationEffect.html#EFFECT_DOUBLE_CLICK"/>
        /// </summary>
        public static int EFFECT_DOUBLE_CLICK { get { if (!_EFFECT_DOUBLE_CLICKReady) { _EFFECT_DOUBLE_CLICKContent = SGetField<int>(LocalBridgeClazz, "EFFECT_DOUBLE_CLICK"); _EFFECT_DOUBLE_CLICKReady = true; } return _EFFECT_DOUBLE_CLICKContent; } }
        private static int _EFFECT_DOUBLE_CLICKContent = default;
        private static bool _EFFECT_DOUBLE_CLICKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/VibrationEffect.html#EFFECT_HEAVY_CLICK"/>
        /// </summary>
        public static int EFFECT_HEAVY_CLICK { get { if (!_EFFECT_HEAVY_CLICKReady) { _EFFECT_HEAVY_CLICKContent = SGetField<int>(LocalBridgeClazz, "EFFECT_HEAVY_CLICK"); _EFFECT_HEAVY_CLICKReady = true; } return _EFFECT_HEAVY_CLICKContent; } }
        private static int _EFFECT_HEAVY_CLICKContent = default;
        private static bool _EFFECT_HEAVY_CLICKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/VibrationEffect.html#EFFECT_TICK"/>
        /// </summary>
        public static int EFFECT_TICK { get { if (!_EFFECT_TICKReady) { _EFFECT_TICKContent = SGetField<int>(LocalBridgeClazz, "EFFECT_TICK"); _EFFECT_TICKReady = true; } return _EFFECT_TICKContent; } }
        private static int _EFFECT_TICKContent = default;
        private static bool _EFFECT_TICKReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/VibrationEffect.html#createOneShot(long,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Android.Os.VibrationEffect"/></returns>
        public static Android.Os.VibrationEffect CreateOneShot(long arg0, int arg1)
        {
            return SExecuteWithSignature<Android.Os.VibrationEffect>(LocalBridgeClazz, "createOneShot", "(JI)Landroid/os/VibrationEffect;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/VibrationEffect.html#createPredefined(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Os.VibrationEffect"/></returns>
        public static Android.Os.VibrationEffect CreatePredefined(int arg0)
        {
            return SExecuteWithSignature<Android.Os.VibrationEffect>(LocalBridgeClazz, "createPredefined", "(I)Landroid/os/VibrationEffect;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/VibrationEffect.html#createWaveform(long[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Android.Os.VibrationEffect"/></returns>
        public static Android.Os.VibrationEffect CreateWaveform(long[] arg0, int arg1)
        {
            return SExecuteWithSignature<Android.Os.VibrationEffect>(LocalBridgeClazz, "createWaveform", "([JI)Landroid/os/VibrationEffect;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/VibrationEffect.html#createWaveform(long[],int[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Android.Os.VibrationEffect"/></returns>
        public static Android.Os.VibrationEffect CreateWaveform(long[] arg0, int[] arg1, int arg2)
        {
            return SExecuteWithSignature<Android.Os.VibrationEffect>(LocalBridgeClazz, "createWaveform", "([J[II)Landroid/os/VibrationEffect;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/VibrationEffect.html#startComposition()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.VibrationEffect.Composition"/></returns>
        public static Android.Os.VibrationEffect.Composition StartComposition()
        {
            return SExecuteWithSignature<Android.Os.VibrationEffect.Composition>(LocalBridgeClazz, "startComposition", "()Landroid/os/VibrationEffect$Composition;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/VibrationEffect.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }

        #endregion

        #region Nested classes
        #region Composition implementation
        public partial class Composition
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/VibrationEffect.Composition.html#PRIMITIVE_CLICK"/>
            /// </summary>
            public static int PRIMITIVE_CLICK { get { if (!_PRIMITIVE_CLICKReady) { _PRIMITIVE_CLICKContent = SGetField<int>(LocalBridgeClazz, "PRIMITIVE_CLICK"); _PRIMITIVE_CLICKReady = true; } return _PRIMITIVE_CLICKContent; } }
            private static int _PRIMITIVE_CLICKContent = default;
            private static bool _PRIMITIVE_CLICKReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/VibrationEffect.Composition.html#PRIMITIVE_LOW_TICK"/>
            /// </summary>
            public static int PRIMITIVE_LOW_TICK { get { if (!_PRIMITIVE_LOW_TICKReady) { _PRIMITIVE_LOW_TICKContent = SGetField<int>(LocalBridgeClazz, "PRIMITIVE_LOW_TICK"); _PRIMITIVE_LOW_TICKReady = true; } return _PRIMITIVE_LOW_TICKContent; } }
            private static int _PRIMITIVE_LOW_TICKContent = default;
            private static bool _PRIMITIVE_LOW_TICKReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/VibrationEffect.Composition.html#PRIMITIVE_QUICK_FALL"/>
            /// </summary>
            public static int PRIMITIVE_QUICK_FALL { get { if (!_PRIMITIVE_QUICK_FALLReady) { _PRIMITIVE_QUICK_FALLContent = SGetField<int>(LocalBridgeClazz, "PRIMITIVE_QUICK_FALL"); _PRIMITIVE_QUICK_FALLReady = true; } return _PRIMITIVE_QUICK_FALLContent; } }
            private static int _PRIMITIVE_QUICK_FALLContent = default;
            private static bool _PRIMITIVE_QUICK_FALLReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/VibrationEffect.Composition.html#PRIMITIVE_QUICK_RISE"/>
            /// </summary>
            public static int PRIMITIVE_QUICK_RISE { get { if (!_PRIMITIVE_QUICK_RISEReady) { _PRIMITIVE_QUICK_RISEContent = SGetField<int>(LocalBridgeClazz, "PRIMITIVE_QUICK_RISE"); _PRIMITIVE_QUICK_RISEReady = true; } return _PRIMITIVE_QUICK_RISEContent; } }
            private static int _PRIMITIVE_QUICK_RISEContent = default;
            private static bool _PRIMITIVE_QUICK_RISEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/VibrationEffect.Composition.html#PRIMITIVE_SLOW_RISE"/>
            /// </summary>
            public static int PRIMITIVE_SLOW_RISE { get { if (!_PRIMITIVE_SLOW_RISEReady) { _PRIMITIVE_SLOW_RISEContent = SGetField<int>(LocalBridgeClazz, "PRIMITIVE_SLOW_RISE"); _PRIMITIVE_SLOW_RISEReady = true; } return _PRIMITIVE_SLOW_RISEContent; } }
            private static int _PRIMITIVE_SLOW_RISEContent = default;
            private static bool _PRIMITIVE_SLOW_RISEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/VibrationEffect.Composition.html#PRIMITIVE_SPIN"/>
            /// </summary>
            public static int PRIMITIVE_SPIN { get { if (!_PRIMITIVE_SPINReady) { _PRIMITIVE_SPINContent = SGetField<int>(LocalBridgeClazz, "PRIMITIVE_SPIN"); _PRIMITIVE_SPINReady = true; } return _PRIMITIVE_SPINContent; } }
            private static int _PRIMITIVE_SPINContent = default;
            private static bool _PRIMITIVE_SPINReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/VibrationEffect.Composition.html#PRIMITIVE_THUD"/>
            /// </summary>
            public static int PRIMITIVE_THUD { get { if (!_PRIMITIVE_THUDReady) { _PRIMITIVE_THUDContent = SGetField<int>(LocalBridgeClazz, "PRIMITIVE_THUD"); _PRIMITIVE_THUDReady = true; } return _PRIMITIVE_THUDContent; } }
            private static int _PRIMITIVE_THUDContent = default;
            private static bool _PRIMITIVE_THUDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/VibrationEffect.Composition.html#PRIMITIVE_TICK"/>
            /// </summary>
            public static int PRIMITIVE_TICK { get { if (!_PRIMITIVE_TICKReady) { _PRIMITIVE_TICKContent = SGetField<int>(LocalBridgeClazz, "PRIMITIVE_TICK"); _PRIMITIVE_TICKReady = true; } return _PRIMITIVE_TICKContent; } }
            private static int _PRIMITIVE_TICKContent = default;
            private static bool _PRIMITIVE_TICKReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/VibrationEffect.Composition.html#compose()"/>
            /// </summary>
            /// <returns><see cref="Android.Os.VibrationEffect"/></returns>
            public Android.Os.VibrationEffect Compose()
            {
                return IExecuteWithSignature<Android.Os.VibrationEffect>("compose", "()Landroid/os/VibrationEffect;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/VibrationEffect.Composition.html#addPrimitive(int,float,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="float"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <returns><see cref="Android.Os.VibrationEffect.Composition"/></returns>
            public Android.Os.VibrationEffect.Composition AddPrimitive(int arg0, float arg1, int arg2)
            {
                return IExecuteWithSignature<Android.Os.VibrationEffect.Composition>("addPrimitive", "(IFI)Landroid/os/VibrationEffect$Composition;", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/VibrationEffect.Composition.html#addPrimitive(int,float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="float"/></param>
            /// <returns><see cref="Android.Os.VibrationEffect.Composition"/></returns>
            public Android.Os.VibrationEffect.Composition AddPrimitive(int arg0, float arg1)
            {
                return IExecuteWithSignature<Android.Os.VibrationEffect.Composition>("addPrimitive", "(IF)Landroid/os/VibrationEffect$Composition;", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/VibrationEffect.Composition.html#addPrimitive(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Os.VibrationEffect.Composition"/></returns>
            public Android.Os.VibrationEffect.Composition AddPrimitive(int arg0)
            {
                return IExecuteWithSignature<Android.Os.VibrationEffect.Composition>("addPrimitive", "(I)Landroid/os/VibrationEffect$Composition;", arg0);
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