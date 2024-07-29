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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Text
{
    #region StaticLayout
    public partial class StaticLayout
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/StaticLayout.html#%3Cinit%3E(java.lang.CharSequence,android.text.TextPaint,int,android.text.Layout.Alignment,float,float,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Android.Text.TextPaint"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Android.Text.Layout.Alignment"/></param>
        /// <param name="arg4"><see cref="float"/></param>
        /// <param name="arg5"><see cref="float"/></param>
        /// <param name="arg6"><see cref="bool"/></param>
        [global::System.Obsolete()]
        public StaticLayout(Java.Lang.CharSequence arg0, Android.Text.TextPaint arg1, int arg2, Android.Text.Layout.Alignment arg3, float arg4, float arg5, bool arg6)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/StaticLayout.html#%3Cinit%3E(java.lang.CharSequence,int,int,android.text.TextPaint,int,android.text.Layout.Alignment,float,float,boolean,android.text.TextUtils.TruncateAt,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Android.Text.TextPaint"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="Android.Text.Layout.Alignment"/></param>
        /// <param name="arg6"><see cref="float"/></param>
        /// <param name="arg7"><see cref="float"/></param>
        /// <param name="arg8"><see cref="bool"/></param>
        /// <param name="arg9"><see cref="Android.Text.TextUtils.TruncateAt"/></param>
        /// <param name="arg10"><see cref="int"/></param>
        [global::System.Obsolete()]
        public StaticLayout(Java.Lang.CharSequence arg0, int arg1, int arg2, Android.Text.TextPaint arg3, int arg4, Android.Text.Layout.Alignment arg5, float arg6, float arg7, bool arg8, Android.Text.TextUtils.TruncateAt arg9, int arg10)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/StaticLayout.html#%3Cinit%3E(java.lang.CharSequence,int,int,android.text.TextPaint,int,android.text.Layout.Alignment,float,float,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Android.Text.TextPaint"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="Android.Text.Layout.Alignment"/></param>
        /// <param name="arg6"><see cref="float"/></param>
        /// <param name="arg7"><see cref="float"/></param>
        /// <param name="arg8"><see cref="bool"/></param>
        [global::System.Obsolete()]
        public StaticLayout(Java.Lang.CharSequence arg0, int arg1, int arg2, Android.Text.TextPaint arg3, int arg4, Android.Text.Layout.Alignment arg5, float arg6, float arg7, bool arg8)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8)
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

        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/StaticLayout.Builder.html#obtain(java.lang.CharSequence,int,int,android.text.TextPaint,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="Android.Text.TextPaint"/></param>
            /// <param name="arg4"><see cref="int"/></param>
            /// <returns><see cref="Android.Text.StaticLayout.Builder"/></returns>
            public static Android.Text.StaticLayout.Builder Obtain(Java.Lang.CharSequence arg0, int arg1, int arg2, Android.Text.TextPaint arg3, int arg4)
            {
                return SExecute<Android.Text.StaticLayout.Builder>(LocalBridgeClazz, "obtain", arg0, arg1, arg2, arg3, arg4);
            }

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/StaticLayout.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Text.StaticLayout"/></returns>
            public Android.Text.StaticLayout Build()
            {
                return IExecuteWithSignature<Android.Text.StaticLayout>("build", "()Landroid/text/StaticLayout;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/StaticLayout.Builder.html#setAlignment(android.text.Layout.Alignment)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Text.Layout.Alignment"/></param>
            /// <returns><see cref="Android.Text.StaticLayout.Builder"/></returns>
            public Android.Text.StaticLayout.Builder SetAlignment(Android.Text.Layout.Alignment arg0)
            {
                return IExecuteWithSignature<Android.Text.StaticLayout.Builder>("setAlignment", "(Landroid/text/Layout$Alignment;)Landroid/text/StaticLayout$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/StaticLayout.Builder.html#setBreakStrategy(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Text.StaticLayout.Builder"/></returns>
            public Android.Text.StaticLayout.Builder SetBreakStrategy(int arg0)
            {
                return IExecuteWithSignature<Android.Text.StaticLayout.Builder>("setBreakStrategy", "(I)Landroid/text/StaticLayout$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/StaticLayout.Builder.html#setEllipsize(android.text.TextUtils.TruncateAt)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Text.TextUtils.TruncateAt"/></param>
            /// <returns><see cref="Android.Text.StaticLayout.Builder"/></returns>
            public Android.Text.StaticLayout.Builder SetEllipsize(Android.Text.TextUtils.TruncateAt arg0)
            {
                return IExecuteWithSignature<Android.Text.StaticLayout.Builder>("setEllipsize", "(Landroid/text/TextUtils$TruncateAt;)Landroid/text/StaticLayout$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/StaticLayout.Builder.html#setEllipsizedWidth(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Text.StaticLayout.Builder"/></returns>
            public Android.Text.StaticLayout.Builder SetEllipsizedWidth(int arg0)
            {
                return IExecuteWithSignature<Android.Text.StaticLayout.Builder>("setEllipsizedWidth", "(I)Landroid/text/StaticLayout$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/StaticLayout.Builder.html#setHyphenationFrequency(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Text.StaticLayout.Builder"/></returns>
            public Android.Text.StaticLayout.Builder SetHyphenationFrequency(int arg0)
            {
                return IExecuteWithSignature<Android.Text.StaticLayout.Builder>("setHyphenationFrequency", "(I)Landroid/text/StaticLayout$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/StaticLayout.Builder.html#setIncludePad(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Text.StaticLayout.Builder"/></returns>
            public Android.Text.StaticLayout.Builder SetIncludePad(bool arg0)
            {
                return IExecuteWithSignature<Android.Text.StaticLayout.Builder>("setIncludePad", "(Z)Landroid/text/StaticLayout$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/StaticLayout.Builder.html#setIndents(int[],int[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <returns><see cref="Android.Text.StaticLayout.Builder"/></returns>
            public Android.Text.StaticLayout.Builder SetIndents(int[] arg0, int[] arg1)
            {
                return IExecute<Android.Text.StaticLayout.Builder>("setIndents", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/StaticLayout.Builder.html#setJustificationMode(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Text.StaticLayout.Builder"/></returns>
            public Android.Text.StaticLayout.Builder SetJustificationMode(int arg0)
            {
                return IExecuteWithSignature<Android.Text.StaticLayout.Builder>("setJustificationMode", "(I)Landroid/text/StaticLayout$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/StaticLayout.Builder.html#setLineBreakConfig(android.graphics.text.LineBreakConfig)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.Text.LineBreakConfig"/></param>
            /// <returns><see cref="Android.Text.StaticLayout.Builder"/></returns>
            public Android.Text.StaticLayout.Builder SetLineBreakConfig(Android.Graphics.Text.LineBreakConfig arg0)
            {
                return IExecuteWithSignature<Android.Text.StaticLayout.Builder>("setLineBreakConfig", "(Landroid/graphics/text/LineBreakConfig;)Landroid/text/StaticLayout$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/StaticLayout.Builder.html#setLineSpacing(float,float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="float"/></param>
            /// <param name="arg1"><see cref="float"/></param>
            /// <returns><see cref="Android.Text.StaticLayout.Builder"/></returns>
            public Android.Text.StaticLayout.Builder SetLineSpacing(float arg0, float arg1)
            {
                return IExecute<Android.Text.StaticLayout.Builder>("setLineSpacing", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/StaticLayout.Builder.html#setMaxLines(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Text.StaticLayout.Builder"/></returns>
            public Android.Text.StaticLayout.Builder SetMaxLines(int arg0)
            {
                return IExecuteWithSignature<Android.Text.StaticLayout.Builder>("setMaxLines", "(I)Landroid/text/StaticLayout$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/StaticLayout.Builder.html#setMinimumFontMetrics(android.graphics.Paint.FontMetrics)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.Paint.FontMetrics"/></param>
            /// <returns><see cref="Android.Text.StaticLayout.Builder"/></returns>
            public Android.Text.StaticLayout.Builder SetMinimumFontMetrics(Android.Graphics.Paint.FontMetrics arg0)
            {
                return IExecuteWithSignature<Android.Text.StaticLayout.Builder>("setMinimumFontMetrics", "(Landroid/graphics/Paint$FontMetrics;)Landroid/text/StaticLayout$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/StaticLayout.Builder.html#setShiftDrawingOffsetForStartOverhang(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Text.StaticLayout.Builder"/></returns>
            public Android.Text.StaticLayout.Builder SetShiftDrawingOffsetForStartOverhang(bool arg0)
            {
                return IExecuteWithSignature<Android.Text.StaticLayout.Builder>("setShiftDrawingOffsetForStartOverhang", "(Z)Landroid/text/StaticLayout$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/StaticLayout.Builder.html#setText(java.lang.CharSequence)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
            /// <returns><see cref="Android.Text.StaticLayout.Builder"/></returns>
            public Android.Text.StaticLayout.Builder SetText(Java.Lang.CharSequence arg0)
            {
                return IExecuteWithSignature<Android.Text.StaticLayout.Builder>("setText", "(Ljava/lang/CharSequence;)Landroid/text/StaticLayout$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/StaticLayout.Builder.html#setTextDirection(android.text.TextDirectionHeuristic)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Text.TextDirectionHeuristic"/></param>
            /// <returns><see cref="Android.Text.StaticLayout.Builder"/></returns>
            public Android.Text.StaticLayout.Builder SetTextDirection(Android.Text.TextDirectionHeuristic arg0)
            {
                return IExecuteWithSignature<Android.Text.StaticLayout.Builder>("setTextDirection", "(Landroid/text/TextDirectionHeuristic;)Landroid/text/StaticLayout$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/StaticLayout.Builder.html#setUseBoundsForWidth(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Text.StaticLayout.Builder"/></returns>
            public Android.Text.StaticLayout.Builder SetUseBoundsForWidth(bool arg0)
            {
                return IExecuteWithSignature<Android.Text.StaticLayout.Builder>("setUseBoundsForWidth", "(Z)Landroid/text/StaticLayout$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/StaticLayout.Builder.html#setUseLineSpacingFromFallbacks(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Text.StaticLayout.Builder"/></returns>
            public Android.Text.StaticLayout.Builder SetUseLineSpacingFromFallbacks(bool arg0)
            {
                return IExecuteWithSignature<Android.Text.StaticLayout.Builder>("setUseLineSpacingFromFallbacks", "(Z)Landroid/text/StaticLayout$Builder;", arg0);
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