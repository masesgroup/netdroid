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

namespace Android.Text
{
    #region PrecomputedText declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/text/PrecomputedText.html"/>
    /// </summary>
    public partial class PrecomputedText : Android.Text.Spannable
    {
        const string _bridgeClassName = "android.text.PrecomputedText";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public PrecomputedText() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public PrecomputedText(params object[] args) : base(args) { }

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
        #region Params declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/PrecomputedText.Params.html"/>
        /// </summary>
        public partial class Params : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Params>
        {
            const string _bridgeClassName = "android.text.PrecomputedText$Params";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Params() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Params(params object[] args) : base(args) { }

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
            #region Builder declaration
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/PrecomputedText.Params.Builder.html"/>
            /// </summary>
            public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
            {
                const string _bridgeClassName = "android.text.PrecomputedText$Params$Builder";
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

    
    }
    #endregion

    #region PrecomputedText implementation
    public partial class PrecomputedText
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/PrecomputedText.html#create(java.lang.CharSequence,android.text.PrecomputedText.Params)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Android.Text.PrecomputedText.Params"/></param>
        /// <returns><see cref="Android.Text.PrecomputedText"/></returns>
        public static Android.Text.PrecomputedText Create(Java.Lang.CharSequence arg0, Android.Text.PrecomputedText.Params arg1)
        {
            return SExecuteWithSignature<Android.Text.PrecomputedText>(LocalBridgeClazz, "create", "(Ljava/lang/CharSequence;Landroid/text/PrecomputedText$Params;)Landroid/text/PrecomputedText;", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/PrecomputedText.html#getSpans(int,int,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public T[] GetSpans<T>(int arg0, int arg1, Java.Lang.Class arg2)
        {
            return IExecuteWithSignatureArray<T>("getSpans", "(IILjava/lang/Class;)[Ljava/lang/Object;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/PrecomputedText.html#getParams()"/>
        /// </summary>
        /// <returns><see cref="Android.Text.PrecomputedText.Params"/></returns>
        public Android.Text.PrecomputedText.Params GetParams()
        {
            return IExecuteWithSignature<Android.Text.PrecomputedText.Params>("getParams", "()Landroid/text/PrecomputedText$Params;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/PrecomputedText.html#charAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="char"/></returns>
        public char CharAt(int arg0)
        {
            return IExecuteWithSignature<char>("charAt", "(I)C", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/PrecomputedText.html#getWidth(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetWidth(int arg0, int arg1)
        {
            return IExecuteWithSignature<float>("getWidth", "(II)F", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/PrecomputedText.html#getParagraphCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetParagraphCount()
        {
            return IExecuteWithSignature<int>("getParagraphCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/PrecomputedText.html#getParagraphEnd(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetParagraphEnd(int arg0)
        {
            return IExecuteWithSignature<int>("getParagraphEnd", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/PrecomputedText.html#getParagraphStart(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetParagraphStart(int arg0)
        {
            return IExecuteWithSignature<int>("getParagraphStart", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/PrecomputedText.html#getSpanEnd(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetSpanEnd(object arg0)
        {
            return IExecuteWithSignature<int>("getSpanEnd", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/PrecomputedText.html#getSpanFlags(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetSpanFlags(object arg0)
        {
            return IExecuteWithSignature<int>("getSpanFlags", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/PrecomputedText.html#getSpanStart(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetSpanStart(object arg0)
        {
            return IExecuteWithSignature<int>("getSpanStart", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/PrecomputedText.html#length()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Length()
        {
            return IExecuteWithSignature<int>("length", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/PrecomputedText.html#nextSpanTransition(int,int,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="int"/></returns>
        public int NextSpanTransition(int arg0, int arg1, Java.Lang.Class arg2)
        {
            return IExecuteWithSignature<int>("nextSpanTransition", "(IILjava/lang/Class;)I", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/PrecomputedText.html#subSequence(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence SubSequence(int arg0, int arg1)
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("subSequence", "(II)Ljava/lang/CharSequence;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/PrecomputedText.html#getBounds(int,int,android.graphics.Rect)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.Graphics.Rect"/></param>
        public void GetBounds(int arg0, int arg1, Android.Graphics.Rect arg2)
        {
            IExecuteWithSignature("getBounds", "(IILandroid/graphics/Rect;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/PrecomputedText.html#getFontMetricsInt(int,int,android.graphics.Paint.FontMetricsInt)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.Graphics.Paint.FontMetricsInt"/></param>
        public void GetFontMetricsInt(int arg0, int arg1, Android.Graphics.Paint.FontMetricsInt arg2)
        {
            IExecuteWithSignature("getFontMetricsInt", "(IILandroid/graphics/Paint$FontMetricsInt;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/PrecomputedText.html#removeSpan(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void RemoveSpan(object arg0)
        {
            IExecuteWithSignature("removeSpan", "(Ljava/lang/Object;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/PrecomputedText.html#setSpan(java.lang.Object,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public void SetSpan(object arg0, int arg1, int arg2, int arg3)
        {
            IExecuteWithSignature("setSpan", "(Ljava/lang/Object;III)V", arg0, arg1, arg2, arg3);
        }

        #endregion

        #region Nested classes
        #region Params implementation
        public partial class Params
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
            /// <see href="https://developer.android.com/reference/android/text/PrecomputedText.Params.html#getLineBreakConfig()"/>
            /// </summary>
            /// <returns><see cref="Android.Graphics.Text.LineBreakConfig"/></returns>
            public Android.Graphics.Text.LineBreakConfig GetLineBreakConfig()
            {
                return IExecuteWithSignature<Android.Graphics.Text.LineBreakConfig>("getLineBreakConfig", "()Landroid/graphics/text/LineBreakConfig;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/PrecomputedText.Params.html#getTextDirection()"/>
            /// </summary>
            /// <returns><see cref="Android.Text.TextDirectionHeuristic"/></returns>
            public Android.Text.TextDirectionHeuristic GetTextDirection()
            {
                return IExecuteWithSignature<Android.Text.TextDirectionHeuristic>("getTextDirection", "()Landroid/text/TextDirectionHeuristic;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/PrecomputedText.Params.html#getTextPaint()"/>
            /// </summary>
            /// <returns><see cref="Android.Text.TextPaint"/></returns>
            public Android.Text.TextPaint GetTextPaint()
            {
                return IExecuteWithSignature<Android.Text.TextPaint>("getTextPaint", "()Landroid/text/TextPaint;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/PrecomputedText.Params.html#getBreakStrategy()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetBreakStrategy()
            {
                return IExecuteWithSignature<int>("getBreakStrategy", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/PrecomputedText.Params.html#getHyphenationFrequency()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetHyphenationFrequency()
            {
                return IExecuteWithSignature<int>("getHyphenationFrequency", "()I");
            }

            #endregion

            #region Nested classes
            #region Builder implementation
            public partial class Builder
            {
                #region Constructors
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/text/PrecomputedText.Params.Builder.html#%3Cinit%3E(android.text.PrecomputedText.Params)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Android.Text.PrecomputedText.Params"/></param>
                public Builder(Android.Text.PrecomputedText.Params arg0)
                    : base(arg0)
                {
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/text/PrecomputedText.Params.Builder.html#%3Cinit%3E(android.text.TextPaint)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Android.Text.TextPaint"/></param>
                public Builder(Android.Text.TextPaint arg0)
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
                /// <see href="https://developer.android.com/reference/android/text/PrecomputedText.Params.Builder.html#build()"/>
                /// </summary>
                /// <returns><see cref="Android.Text.PrecomputedText.Params"/></returns>
                public Android.Text.PrecomputedText.Params Build()
                {
                    return IExecute<Android.Text.PrecomputedText.Params>("build");
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/text/PrecomputedText.Params.Builder.html#setBreakStrategy(int)"/>
                /// </summary>
                /// <param name="arg0"><see cref="int"/></param>
                /// <returns><see cref="Android.Text.PrecomputedText.Params.Builder"/></returns>
                public Android.Text.PrecomputedText.Params.Builder SetBreakStrategy(int arg0)
                {
                    return IExecute<Android.Text.PrecomputedText.Params.Builder>("setBreakStrategy", arg0);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/text/PrecomputedText.Params.Builder.html#setHyphenationFrequency(int)"/>
                /// </summary>
                /// <param name="arg0"><see cref="int"/></param>
                /// <returns><see cref="Android.Text.PrecomputedText.Params.Builder"/></returns>
                public Android.Text.PrecomputedText.Params.Builder SetHyphenationFrequency(int arg0)
                {
                    return IExecute<Android.Text.PrecomputedText.Params.Builder>("setHyphenationFrequency", arg0);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/text/PrecomputedText.Params.Builder.html#setLineBreakConfig(android.graphics.text.LineBreakConfig)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Android.Graphics.Text.LineBreakConfig"/></param>
                /// <returns><see cref="Android.Text.PrecomputedText.Params.Builder"/></returns>
                public Android.Text.PrecomputedText.Params.Builder SetLineBreakConfig(Android.Graphics.Text.LineBreakConfig arg0)
                {
                    return IExecute<Android.Text.PrecomputedText.Params.Builder>("setLineBreakConfig", arg0);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/text/PrecomputedText.Params.Builder.html#setTextDirection(android.text.TextDirectionHeuristic)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Android.Text.TextDirectionHeuristic"/></param>
                /// <returns><see cref="Android.Text.PrecomputedText.Params.Builder"/></returns>
                public Android.Text.PrecomputedText.Params.Builder SetTextDirection(Android.Text.TextDirectionHeuristic arg0)
                {
                    return IExecute<Android.Text.PrecomputedText.Params.Builder>("setTextDirection", arg0);
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

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}