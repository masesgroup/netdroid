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

namespace Android.Graphics.Text
{
    #region MeasuredText declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/graphics/text/MeasuredText.html"/>
    /// </summary>
    public partial class MeasuredText : MASES.JCOBridge.C2JBridge.JVMBridgeBase<MeasuredText>
    {
        const string _bridgeClassName = "android.graphics.text.MeasuredText";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public MeasuredText() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public MeasuredText(params object[] args) : base(args) { }

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
        /// <see href="https://developer.android.com/reference/android/graphics/text/MeasuredText.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.graphics.text.MeasuredText$Builder";
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

    #region MeasuredText implementation
    public partial class MeasuredText
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/text/MeasuredText.html#getCharWidthAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetCharWidthAt(int arg0)
        {
            return IExecuteWithSignature<float>("getCharWidthAt", "(I)F", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/text/MeasuredText.html#getWidth(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetWidth(int arg0, int arg1)
        {
            return IExecuteWithSignature<float>("getWidth", "(II)F", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/text/MeasuredText.html#getBounds(int,int,android.graphics.Rect)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.Graphics.Rect"/></param>
        public void GetBounds(int arg0, int arg1, Android.Graphics.Rect arg2)
        {
            IExecuteWithSignature("getBounds", "(IILandroid/graphics/Rect;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/text/MeasuredText.html#getFontMetricsInt(int,int,android.graphics.Paint.FontMetricsInt)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.Graphics.Paint.FontMetricsInt"/></param>
        public void GetFontMetricsInt(int arg0, int arg1, Android.Graphics.Paint.FontMetricsInt arg2)
        {
            IExecuteWithSignature("getFontMetricsInt", "(IILandroid/graphics/Paint$FontMetricsInt;)V", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes
        #region Builder implementation
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/text/MeasuredText.Builder.html#%3Cinit%3E(android.graphics.text.MeasuredText)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.Text.MeasuredText"/></param>
            public Builder(Android.Graphics.Text.MeasuredText arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/text/MeasuredText.Builder.html#%3Cinit%3E(char[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="char"/></param>
            public Builder(char[] arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/text/MeasuredText.Builder.html#HYPHENATION_MODE_FAST"/>
            /// </summary>
            public static int HYPHENATION_MODE_FAST { get { if (!_HYPHENATION_MODE_FASTReady) { _HYPHENATION_MODE_FASTContent = SGetField<int>(LocalBridgeClazz, "HYPHENATION_MODE_FAST"); _HYPHENATION_MODE_FASTReady = true; } return _HYPHENATION_MODE_FASTContent; } }
            private static int _HYPHENATION_MODE_FASTContent = default;
            private static bool _HYPHENATION_MODE_FASTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/text/MeasuredText.Builder.html#HYPHENATION_MODE_NONE"/>
            /// </summary>
            public static int HYPHENATION_MODE_NONE { get { if (!_HYPHENATION_MODE_NONEReady) { _HYPHENATION_MODE_NONEContent = SGetField<int>(LocalBridgeClazz, "HYPHENATION_MODE_NONE"); _HYPHENATION_MODE_NONEReady = true; } return _HYPHENATION_MODE_NONEContent; } }
            private static int _HYPHENATION_MODE_NONEContent = default;
            private static bool _HYPHENATION_MODE_NONEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/text/MeasuredText.Builder.html#HYPHENATION_MODE_NORMAL"/>
            /// </summary>
            public static int HYPHENATION_MODE_NORMAL { get { if (!_HYPHENATION_MODE_NORMALReady) { _HYPHENATION_MODE_NORMALContent = SGetField<int>(LocalBridgeClazz, "HYPHENATION_MODE_NORMAL"); _HYPHENATION_MODE_NORMALReady = true; } return _HYPHENATION_MODE_NORMALContent; } }
            private static int _HYPHENATION_MODE_NORMALContent = default;
            private static bool _HYPHENATION_MODE_NORMALReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/text/MeasuredText.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Graphics.Text.MeasuredText"/></returns>
            public Android.Graphics.Text.MeasuredText Build()
            {
                return IExecuteWithSignature<Android.Graphics.Text.MeasuredText>("build", "()Landroid/graphics/text/MeasuredText;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/text/MeasuredText.Builder.html#appendReplacementRun(android.graphics.Paint,int,float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.Paint"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="float"/></param>
            /// <returns><see cref="Android.Graphics.Text.MeasuredText.Builder"/></returns>
            public Android.Graphics.Text.MeasuredText.Builder AppendReplacementRun(Android.Graphics.Paint arg0, int arg1, float arg2)
            {
                return IExecuteWithSignature<Android.Graphics.Text.MeasuredText.Builder>("appendReplacementRun", "(Landroid/graphics/Paint;IF)Landroid/graphics/text/MeasuredText$Builder;", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/text/MeasuredText.Builder.html#appendStyleRun(android.graphics.Paint,android.graphics.text.LineBreakConfig,int,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.Paint"/></param>
            /// <param name="arg1"><see cref="Android.Graphics.Text.LineBreakConfig"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="bool"/></param>
            /// <returns><see cref="Android.Graphics.Text.MeasuredText.Builder"/></returns>
            public Android.Graphics.Text.MeasuredText.Builder AppendStyleRun(Android.Graphics.Paint arg0, Android.Graphics.Text.LineBreakConfig arg1, int arg2, bool arg3)
            {
                return IExecuteWithSignature<Android.Graphics.Text.MeasuredText.Builder>("appendStyleRun", "(Landroid/graphics/Paint;Landroid/graphics/text/LineBreakConfig;IZ)Landroid/graphics/text/MeasuredText$Builder;", arg0, arg1, arg2, arg3);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/text/MeasuredText.Builder.html#appendStyleRun(android.graphics.Paint,int,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.Paint"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="bool"/></param>
            /// <returns><see cref="Android.Graphics.Text.MeasuredText.Builder"/></returns>
            public Android.Graphics.Text.MeasuredText.Builder AppendStyleRun(Android.Graphics.Paint arg0, int arg1, bool arg2)
            {
                return IExecuteWithSignature<Android.Graphics.Text.MeasuredText.Builder>("appendStyleRun", "(Landroid/graphics/Paint;IZ)Landroid/graphics/text/MeasuredText$Builder;", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/text/MeasuredText.Builder.html#setComputeHyphenation(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Graphics.Text.MeasuredText.Builder"/></returns>
            [global::System.Obsolete()]
            public Android.Graphics.Text.MeasuredText.Builder SetComputeHyphenation(bool arg0)
            {
                return IExecuteWithSignature<Android.Graphics.Text.MeasuredText.Builder>("setComputeHyphenation", "(Z)Landroid/graphics/text/MeasuredText$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/text/MeasuredText.Builder.html#setComputeHyphenation(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Graphics.Text.MeasuredText.Builder"/></returns>
            public Android.Graphics.Text.MeasuredText.Builder SetComputeHyphenation(int arg0)
            {
                return IExecuteWithSignature<Android.Graphics.Text.MeasuredText.Builder>("setComputeHyphenation", "(I)Landroid/graphics/text/MeasuredText$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/text/MeasuredText.Builder.html#setComputeLayout(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Graphics.Text.MeasuredText.Builder"/></returns>
            public Android.Graphics.Text.MeasuredText.Builder SetComputeLayout(bool arg0)
            {
                return IExecuteWithSignature<Android.Graphics.Text.MeasuredText.Builder>("setComputeLayout", "(Z)Landroid/graphics/text/MeasuredText$Builder;", arg0);
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