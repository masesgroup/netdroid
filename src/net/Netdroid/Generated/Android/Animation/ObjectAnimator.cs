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

namespace Android.Animation
{
    #region ObjectAnimator declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/animation/ObjectAnimator.html"/>
    /// </summary>
    public partial class ObjectAnimator : Android.Animation.ValueAnimator
    {
        const string _bridgeClassName = "android.animation.ObjectAnimator";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ObjectAnimator() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ObjectAnimator(params object[] args) : base(args) { }

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

    #region ObjectAnimator implementation
    public partial class ObjectAnimator
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/ObjectAnimator.html#ofObject(java.lang.Object,android.util.Property,android.animation.TypeConverter,android.animation.TypeEvaluator,java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="Android.Util.Property"/></param>
        /// <param name="arg2"><see cref="Android.Animation.TypeConverter"/></param>
        /// <param name="arg3"><see cref="Android.Animation.TypeEvaluator"/></param>
        /// <param name="arg4"><typeparamref name="V"/></param>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="P"></typeparam>
        /// <typeparam name="V"></typeparam>
        /// <returns><see cref="Android.Animation.ObjectAnimator"/></returns>
        public static Android.Animation.ObjectAnimator OfObject<T, P, V>(T arg0, Android.Util.Property<T, P> arg1, Android.Animation.TypeConverter<V, P> arg2, Android.Animation.TypeEvaluator<V> arg3, params V[] arg4)
        {
            if (arg4.Length == 0) return SExecuteWithSignature<Android.Animation.ObjectAnimator>(LocalBridgeClazz, "ofObject", "(Ljava/lang/Object;Landroid/util/Property;Landroid/animation/TypeConverter;Landroid/animation/TypeEvaluator;[Ljava/lang/Object;)Landroid/animation/ObjectAnimator;", arg0, arg1, arg2, arg3); else return SExecuteWithSignature<Android.Animation.ObjectAnimator>(LocalBridgeClazz, "ofObject", "(Ljava/lang/Object;Landroid/util/Property;Landroid/animation/TypeConverter;Landroid/animation/TypeEvaluator;[Ljava/lang/Object;)Landroid/animation/ObjectAnimator;", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/ObjectAnimator.html#ofObject(java.lang.Object,android.util.Property,android.animation.TypeConverter,android.graphics.Path)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="Android.Util.Property"/></param>
        /// <param name="arg2"><see cref="Android.Animation.TypeConverter"/></param>
        /// <param name="arg3"><see cref="Android.Graphics.Path"/></param>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="V"></typeparam>
        /// <returns><see cref="Android.Animation.ObjectAnimator"/></returns>
        public static Android.Animation.ObjectAnimator OfObject<T, V>(T arg0, Android.Util.Property<T, V> arg1, Android.Animation.TypeConverter<Android.Graphics.PointF, V> arg2, Android.Graphics.Path arg3)
        {
            return SExecuteWithSignature<Android.Animation.ObjectAnimator>(LocalBridgeClazz, "ofObject", "(Ljava/lang/Object;Landroid/util/Property;Landroid/animation/TypeConverter;Landroid/graphics/Path;)Landroid/animation/ObjectAnimator;", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/ObjectAnimator.html#ofObject(java.lang.Object,android.util.Property,android.animation.TypeEvaluator,java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="Android.Util.Property"/></param>
        /// <param name="arg2"><see cref="Android.Animation.TypeEvaluator"/></param>
        /// <param name="arg3"><typeparamref name="V"/></param>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="V"></typeparam>
        /// <returns><see cref="Android.Animation.ObjectAnimator"/></returns>
        public static Android.Animation.ObjectAnimator OfObject<T, V>(T arg0, Android.Util.Property<T, V> arg1, Android.Animation.TypeEvaluator<V> arg2, params V[] arg3)
        {
            if (arg3.Length == 0) return SExecuteWithSignature<Android.Animation.ObjectAnimator>(LocalBridgeClazz, "ofObject", "(Ljava/lang/Object;Landroid/util/Property;Landroid/animation/TypeEvaluator;[Ljava/lang/Object;)Landroid/animation/ObjectAnimator;", arg0, arg1, arg2); else return SExecuteWithSignature<Android.Animation.ObjectAnimator>(LocalBridgeClazz, "ofObject", "(Ljava/lang/Object;Landroid/util/Property;Landroid/animation/TypeEvaluator;[Ljava/lang/Object;)Landroid/animation/ObjectAnimator;", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/ObjectAnimator.html#ofArgb(java.lang.Object,android.util.Property,int[])"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="Android.Util.Property"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Android.Animation.ObjectAnimator"/></returns>
        public static Android.Animation.ObjectAnimator OfArgb<T>(T arg0, Android.Util.Property<T, Java.Lang.Integer> arg1, params int[] arg2)
        {
            if (arg2.Length == 0) return SExecuteWithSignature<Android.Animation.ObjectAnimator>(LocalBridgeClazz, "ofArgb", "(Ljava/lang/Object;Landroid/util/Property;[I)Landroid/animation/ObjectAnimator;", arg0, arg1); else return SExecuteWithSignature<Android.Animation.ObjectAnimator>(LocalBridgeClazz, "ofArgb", "(Ljava/lang/Object;Landroid/util/Property;[I)Landroid/animation/ObjectAnimator;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/ObjectAnimator.html#ofFloat(java.lang.Object,android.util.Property,android.util.Property,android.graphics.Path)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="Android.Util.Property"/></param>
        /// <param name="arg2"><see cref="Android.Util.Property"/></param>
        /// <param name="arg3"><see cref="Android.Graphics.Path"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Android.Animation.ObjectAnimator"/></returns>
        public static Android.Animation.ObjectAnimator OfFloat<T>(T arg0, Android.Util.Property<T, Java.Lang.Float> arg1, Android.Util.Property<T, Java.Lang.Float> arg2, Android.Graphics.Path arg3)
        {
            return SExecuteWithSignature<Android.Animation.ObjectAnimator>(LocalBridgeClazz, "ofFloat", "(Ljava/lang/Object;Landroid/util/Property;Landroid/util/Property;Landroid/graphics/Path;)Landroid/animation/ObjectAnimator;", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/ObjectAnimator.html#ofFloat(java.lang.Object,android.util.Property,float[])"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="Android.Util.Property"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Android.Animation.ObjectAnimator"/></returns>
        public static Android.Animation.ObjectAnimator OfFloat<T>(T arg0, Android.Util.Property<T, Java.Lang.Float> arg1, params float[] arg2)
        {
            if (arg2.Length == 0) return SExecuteWithSignature<Android.Animation.ObjectAnimator>(LocalBridgeClazz, "ofFloat", "(Ljava/lang/Object;Landroid/util/Property;[F)Landroid/animation/ObjectAnimator;", arg0, arg1); else return SExecuteWithSignature<Android.Animation.ObjectAnimator>(LocalBridgeClazz, "ofFloat", "(Ljava/lang/Object;Landroid/util/Property;[F)Landroid/animation/ObjectAnimator;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/ObjectAnimator.html#ofInt(java.lang.Object,android.util.Property,android.util.Property,android.graphics.Path)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="Android.Util.Property"/></param>
        /// <param name="arg2"><see cref="Android.Util.Property"/></param>
        /// <param name="arg3"><see cref="Android.Graphics.Path"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Android.Animation.ObjectAnimator"/></returns>
        public static Android.Animation.ObjectAnimator OfInt<T>(T arg0, Android.Util.Property<T, Java.Lang.Integer> arg1, Android.Util.Property<T, Java.Lang.Integer> arg2, Android.Graphics.Path arg3)
        {
            return SExecuteWithSignature<Android.Animation.ObjectAnimator>(LocalBridgeClazz, "ofInt", "(Ljava/lang/Object;Landroid/util/Property;Landroid/util/Property;Landroid/graphics/Path;)Landroid/animation/ObjectAnimator;", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/ObjectAnimator.html#ofInt(java.lang.Object,android.util.Property,int[])"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="Android.Util.Property"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Android.Animation.ObjectAnimator"/></returns>
        public static Android.Animation.ObjectAnimator OfInt<T>(T arg0, Android.Util.Property<T, Java.Lang.Integer> arg1, params int[] arg2)
        {
            if (arg2.Length == 0) return SExecuteWithSignature<Android.Animation.ObjectAnimator>(LocalBridgeClazz, "ofInt", "(Ljava/lang/Object;Landroid/util/Property;[I)Landroid/animation/ObjectAnimator;", arg0, arg1); else return SExecuteWithSignature<Android.Animation.ObjectAnimator>(LocalBridgeClazz, "ofInt", "(Ljava/lang/Object;Landroid/util/Property;[I)Landroid/animation/ObjectAnimator;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/ObjectAnimator.html#ofMultiFloat(java.lang.Object,java.lang.String,android.animation.TypeConverter,android.animation.TypeEvaluator,java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Android.Animation.TypeConverter"/></param>
        /// <param name="arg3"><see cref="Android.Animation.TypeEvaluator"/></param>
        /// <param name="arg4"><typeparamref name="T"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Android.Animation.ObjectAnimator"/></returns>
        public static Android.Animation.ObjectAnimator OfMultiFloat<T>(object arg0, Java.Lang.String arg1, Android.Animation.TypeConverter<T, float[]> arg2, Android.Animation.TypeEvaluator<T> arg3, params T[] arg4)
        {
            if (arg4.Length == 0) return SExecuteWithSignature<Android.Animation.ObjectAnimator>(LocalBridgeClazz, "ofMultiFloat", "(Ljava/lang/Object;Ljava/lang/String;Landroid/animation/TypeConverter;Landroid/animation/TypeEvaluator;[Ljava/lang/Object;)Landroid/animation/ObjectAnimator;", arg0, arg1, arg2, arg3); else return SExecuteWithSignature<Android.Animation.ObjectAnimator>(LocalBridgeClazz, "ofMultiFloat", "(Ljava/lang/Object;Ljava/lang/String;Landroid/animation/TypeConverter;Landroid/animation/TypeEvaluator;[Ljava/lang/Object;)Landroid/animation/ObjectAnimator;", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/ObjectAnimator.html#ofMultiInt(java.lang.Object,java.lang.String,android.animation.TypeConverter,android.animation.TypeEvaluator,java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Android.Animation.TypeConverter"/></param>
        /// <param name="arg3"><see cref="Android.Animation.TypeEvaluator"/></param>
        /// <param name="arg4"><typeparamref name="T"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Android.Animation.ObjectAnimator"/></returns>
        public static Android.Animation.ObjectAnimator OfMultiInt<T>(object arg0, Java.Lang.String arg1, Android.Animation.TypeConverter<T, int[]> arg2, Android.Animation.TypeEvaluator<T> arg3, params T[] arg4)
        {
            if (arg4.Length == 0) return SExecuteWithSignature<Android.Animation.ObjectAnimator>(LocalBridgeClazz, "ofMultiInt", "(Ljava/lang/Object;Ljava/lang/String;Landroid/animation/TypeConverter;Landroid/animation/TypeEvaluator;[Ljava/lang/Object;)Landroid/animation/ObjectAnimator;", arg0, arg1, arg2, arg3); else return SExecuteWithSignature<Android.Animation.ObjectAnimator>(LocalBridgeClazz, "ofMultiInt", "(Ljava/lang/Object;Ljava/lang/String;Landroid/animation/TypeConverter;Landroid/animation/TypeEvaluator;[Ljava/lang/Object;)Landroid/animation/ObjectAnimator;", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/ObjectAnimator.html#ofArgb(java.lang.Object,java.lang.String,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Android.Animation.ObjectAnimator"/></returns>
        public static Android.Animation.ObjectAnimator OfArgb(object arg0, Java.Lang.String arg1, params int[] arg2)
        {
            if (arg2.Length == 0) return SExecuteWithSignature<Android.Animation.ObjectAnimator>(LocalBridgeClazz, "ofArgb", "(Ljava/lang/Object;Ljava/lang/String;[I)Landroid/animation/ObjectAnimator;", arg0, arg1); else return SExecuteWithSignature<Android.Animation.ObjectAnimator>(LocalBridgeClazz, "ofArgb", "(Ljava/lang/Object;Ljava/lang/String;[I)Landroid/animation/ObjectAnimator;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/ObjectAnimator.html#ofFloat(java.lang.Object,java.lang.String,float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <returns><see cref="Android.Animation.ObjectAnimator"/></returns>
        public static Android.Animation.ObjectAnimator OfFloat(object arg0, Java.Lang.String arg1, params float[] arg2)
        {
            if (arg2.Length == 0) return SExecuteWithSignature<Android.Animation.ObjectAnimator>(LocalBridgeClazz, "ofFloat", "(Ljava/lang/Object;Ljava/lang/String;[F)Landroid/animation/ObjectAnimator;", arg0, arg1); else return SExecuteWithSignature<Android.Animation.ObjectAnimator>(LocalBridgeClazz, "ofFloat", "(Ljava/lang/Object;Ljava/lang/String;[F)Landroid/animation/ObjectAnimator;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/ObjectAnimator.html#ofFloat(java.lang.Object,java.lang.String,java.lang.String,android.graphics.Path)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Android.Graphics.Path"/></param>
        /// <returns><see cref="Android.Animation.ObjectAnimator"/></returns>
        public static Android.Animation.ObjectAnimator OfFloat(object arg0, Java.Lang.String arg1, Java.Lang.String arg2, Android.Graphics.Path arg3)
        {
            return SExecuteWithSignature<Android.Animation.ObjectAnimator>(LocalBridgeClazz, "ofFloat", "(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/String;Landroid/graphics/Path;)Landroid/animation/ObjectAnimator;", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/ObjectAnimator.html#ofInt(java.lang.Object,java.lang.String,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Android.Animation.ObjectAnimator"/></returns>
        public static Android.Animation.ObjectAnimator OfInt(object arg0, Java.Lang.String arg1, params int[] arg2)
        {
            if (arg2.Length == 0) return SExecuteWithSignature<Android.Animation.ObjectAnimator>(LocalBridgeClazz, "ofInt", "(Ljava/lang/Object;Ljava/lang/String;[I)Landroid/animation/ObjectAnimator;", arg0, arg1); else return SExecuteWithSignature<Android.Animation.ObjectAnimator>(LocalBridgeClazz, "ofInt", "(Ljava/lang/Object;Ljava/lang/String;[I)Landroid/animation/ObjectAnimator;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/ObjectAnimator.html#ofInt(java.lang.Object,java.lang.String,java.lang.String,android.graphics.Path)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Android.Graphics.Path"/></param>
        /// <returns><see cref="Android.Animation.ObjectAnimator"/></returns>
        public static Android.Animation.ObjectAnimator OfInt(object arg0, Java.Lang.String arg1, Java.Lang.String arg2, Android.Graphics.Path arg3)
        {
            return SExecuteWithSignature<Android.Animation.ObjectAnimator>(LocalBridgeClazz, "ofInt", "(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/String;Landroid/graphics/Path;)Landroid/animation/ObjectAnimator;", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/ObjectAnimator.html#ofMultiFloat(java.lang.Object,java.lang.String,android.graphics.Path)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Android.Graphics.Path"/></param>
        /// <returns><see cref="Android.Animation.ObjectAnimator"/></returns>
        public static Android.Animation.ObjectAnimator OfMultiFloat(object arg0, Java.Lang.String arg1, Android.Graphics.Path arg2)
        {
            return SExecuteWithSignature<Android.Animation.ObjectAnimator>(LocalBridgeClazz, "ofMultiFloat", "(Ljava/lang/Object;Ljava/lang/String;Landroid/graphics/Path;)Landroid/animation/ObjectAnimator;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/ObjectAnimator.html#ofMultiFloat(java.lang.Object,java.lang.String,float[][])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <returns><see cref="Android.Animation.ObjectAnimator"/></returns>
        public static Android.Animation.ObjectAnimator OfMultiFloat(object arg0, Java.Lang.String arg1, float[][] arg2)
        {
            return SExecuteWithSignature<Android.Animation.ObjectAnimator>(LocalBridgeClazz, "ofMultiFloat", "(Ljava/lang/Object;Ljava/lang/String;[[F)Landroid/animation/ObjectAnimator;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/ObjectAnimator.html#ofMultiInt(java.lang.Object,java.lang.String,android.graphics.Path)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Android.Graphics.Path"/></param>
        /// <returns><see cref="Android.Animation.ObjectAnimator"/></returns>
        public static Android.Animation.ObjectAnimator OfMultiInt(object arg0, Java.Lang.String arg1, Android.Graphics.Path arg2)
        {
            return SExecuteWithSignature<Android.Animation.ObjectAnimator>(LocalBridgeClazz, "ofMultiInt", "(Ljava/lang/Object;Ljava/lang/String;Landroid/graphics/Path;)Landroid/animation/ObjectAnimator;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/ObjectAnimator.html#ofMultiInt(java.lang.Object,java.lang.String,int[][])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Android.Animation.ObjectAnimator"/></returns>
        public static Android.Animation.ObjectAnimator OfMultiInt(object arg0, Java.Lang.String arg1, int[][] arg2)
        {
            return SExecuteWithSignature<Android.Animation.ObjectAnimator>(LocalBridgeClazz, "ofMultiInt", "(Ljava/lang/Object;Ljava/lang/String;[[I)Landroid/animation/ObjectAnimator;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/ObjectAnimator.html#ofObject(java.lang.Object,java.lang.String,android.animation.TypeConverter,android.graphics.Path)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Android.Animation.TypeConverter"/></param>
        /// <param name="arg3"><see cref="Android.Graphics.Path"/></param>
        /// <returns><see cref="Android.Animation.ObjectAnimator"/></returns>
        public static Android.Animation.ObjectAnimator OfObject(object arg0, Java.Lang.String arg1, Android.Animation.TypeConverter<Android.Graphics.PointF, object> arg2, Android.Graphics.Path arg3)
        {
            return SExecuteWithSignature<Android.Animation.ObjectAnimator>(LocalBridgeClazz, "ofObject", "(Ljava/lang/Object;Ljava/lang/String;Landroid/animation/TypeConverter;Landroid/graphics/Path;)Landroid/animation/ObjectAnimator;", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/ObjectAnimator.html#ofObject(java.lang.Object,java.lang.String,android.animation.TypeEvaluator,java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Android.Animation.TypeEvaluator"/></param>
        /// <param name="arg3"><see cref="object"/></param>
        /// <returns><see cref="Android.Animation.ObjectAnimator"/></returns>
        public static Android.Animation.ObjectAnimator OfObject(object arg0, Java.Lang.String arg1, Android.Animation.TypeEvaluator arg2, params object[] arg3)
        {
            if (arg3.Length == 0) return SExecuteWithSignature<Android.Animation.ObjectAnimator>(LocalBridgeClazz, "ofObject", "(Ljava/lang/Object;Ljava/lang/String;Landroid/animation/TypeEvaluator;[Ljava/lang/Object;)Landroid/animation/ObjectAnimator;", arg0, arg1, arg2); else return SExecuteWithSignature<Android.Animation.ObjectAnimator>(LocalBridgeClazz, "ofObject", "(Ljava/lang/Object;Ljava/lang/String;Landroid/animation/TypeEvaluator;[Ljava/lang/Object;)Landroid/animation/ObjectAnimator;", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/ObjectAnimator.html#ofPropertyValuesHolder(java.lang.Object,android.animation.PropertyValuesHolder[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Android.Animation.PropertyValuesHolder"/></param>
        /// <returns><see cref="Android.Animation.ObjectAnimator"/></returns>
        public static Android.Animation.ObjectAnimator OfPropertyValuesHolder(object arg0, params Android.Animation.PropertyValuesHolder[] arg1)
        {
            if (arg1.Length == 0) return SExecuteWithSignature<Android.Animation.ObjectAnimator>(LocalBridgeClazz, "ofPropertyValuesHolder", "(Ljava/lang/Object;[Landroid/animation/PropertyValuesHolder;)Landroid/animation/ObjectAnimator;", arg0); else return SExecuteWithSignature<Android.Animation.ObjectAnimator>(LocalBridgeClazz, "ofPropertyValuesHolder", "(Ljava/lang/Object;[Landroid/animation/PropertyValuesHolder;)Landroid/animation/ObjectAnimator;", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/ObjectAnimator.html#getTarget()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object GetTarget()
        {
            return IExecuteWithSignature("getTarget", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/ObjectAnimator.html#getPropertyName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetPropertyName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getPropertyName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/ObjectAnimator.html#setAutoCancel(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetAutoCancel(bool arg0)
        {
            IExecuteWithSignature("setAutoCancel", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/ObjectAnimator.html#setProperty(android.util.Property)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Util.Property"/></param>
        public void SetProperty(Android.Util.Property arg0)
        {
            IExecuteWithSignature("setProperty", "(Landroid/util/Property;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/animation/ObjectAnimator.html#setPropertyName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetPropertyName(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setPropertyName", "(Ljava/lang/String;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}