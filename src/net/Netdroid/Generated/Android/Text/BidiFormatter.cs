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

namespace Android.Text
{
    #region BidiFormatter
    public partial class BidiFormatter
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/BidiFormatter.html#getInstance()"/>
        /// </summary>
        /// <returns><see cref="Android.Text.BidiFormatter"/></returns>
        public static Android.Text.BidiFormatter GetInstance()
        {
            return SExecuteWithSignature<Android.Text.BidiFormatter>(LocalBridgeClazz, "getInstance", "()Landroid/text/BidiFormatter;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/BidiFormatter.html#getInstance(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="Android.Text.BidiFormatter"/></returns>
        public static Android.Text.BidiFormatter GetInstance(bool arg0)
        {
            return SExecuteWithSignature<Android.Text.BidiFormatter>(LocalBridgeClazz, "getInstance", "(Z)Landroid/text/BidiFormatter;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/BidiFormatter.html#getInstance(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Android.Text.BidiFormatter"/></returns>
        public static Android.Text.BidiFormatter GetInstance(Java.Util.Locale arg0)
        {
            return SExecuteWithSignature<Android.Text.BidiFormatter>(LocalBridgeClazz, "getInstance", "(Ljava/util/Locale;)Landroid/text/BidiFormatter;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/BidiFormatter.html#getStereoReset()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetStereoReset()
        {
            return IExecuteWithSignature<bool>("getStereoReset", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/BidiFormatter.html#isRtl(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsRtl(Java.Lang.CharSequence arg0)
        {
            return IExecuteWithSignature<bool>("isRtl", "(Ljava/lang/CharSequence;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/BidiFormatter.html#isRtl(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsRtl(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("isRtl", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/BidiFormatter.html#isRtlContext()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsRtlContext()
        {
            return IExecuteWithSignature<bool>("isRtlContext", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/BidiFormatter.html#unicodeWrap(java.lang.CharSequence,android.text.TextDirectionHeuristic,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Android.Text.TextDirectionHeuristic"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence UnicodeWrap(Java.Lang.CharSequence arg0, Android.Text.TextDirectionHeuristic arg1, bool arg2)
        {
            return IExecute<Java.Lang.CharSequence>("unicodeWrap", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/BidiFormatter.html#unicodeWrap(java.lang.CharSequence,android.text.TextDirectionHeuristic)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Android.Text.TextDirectionHeuristic"/></param>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence UnicodeWrap(Java.Lang.CharSequence arg0, Android.Text.TextDirectionHeuristic arg1)
        {
            return IExecute<Java.Lang.CharSequence>("unicodeWrap", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/BidiFormatter.html#unicodeWrap(java.lang.CharSequence,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence UnicodeWrap(Java.Lang.CharSequence arg0, bool arg1)
        {
            return IExecute<Java.Lang.CharSequence>("unicodeWrap", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/BidiFormatter.html#unicodeWrap(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence UnicodeWrap(Java.Lang.CharSequence arg0)
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("unicodeWrap", "(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/BidiFormatter.html#unicodeWrap(java.lang.String,android.text.TextDirectionHeuristic,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Text.TextDirectionHeuristic"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String UnicodeWrap(Java.Lang.String arg0, Android.Text.TextDirectionHeuristic arg1, bool arg2)
        {
            return IExecute<Java.Lang.String>("unicodeWrap", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/BidiFormatter.html#unicodeWrap(java.lang.String,android.text.TextDirectionHeuristic)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Text.TextDirectionHeuristic"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String UnicodeWrap(Java.Lang.String arg0, Android.Text.TextDirectionHeuristic arg1)
        {
            return IExecute<Java.Lang.String>("unicodeWrap", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/BidiFormatter.html#unicodeWrap(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String UnicodeWrap(Java.Lang.String arg0, bool arg1)
        {
            return IExecute<Java.Lang.String>("unicodeWrap", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/BidiFormatter.html#unicodeWrap(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String UnicodeWrap(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("unicodeWrap", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }

        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/BidiFormatter.Builder.html#%3Cinit%3E(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            public Builder(bool arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/BidiFormatter.Builder.html#%3Cinit%3E(java.util.Locale)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
            public Builder(Java.Util.Locale arg0)
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
            /// <see href="https://developer.android.com/reference/android/text/BidiFormatter.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Text.BidiFormatter"/></returns>
            public Android.Text.BidiFormatter Build()
            {
                return IExecuteWithSignature<Android.Text.BidiFormatter>("build", "()Landroid/text/BidiFormatter;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/BidiFormatter.Builder.html#setTextDirectionHeuristic(android.text.TextDirectionHeuristic)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Text.TextDirectionHeuristic"/></param>
            /// <returns><see cref="Android.Text.BidiFormatter.Builder"/></returns>
            public Android.Text.BidiFormatter.Builder SetTextDirectionHeuristic(Android.Text.TextDirectionHeuristic arg0)
            {
                return IExecuteWithSignature<Android.Text.BidiFormatter.Builder>("setTextDirectionHeuristic", "(Landroid/text/TextDirectionHeuristic;)Landroid/text/BidiFormatter$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/BidiFormatter.Builder.html#stereoReset(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Text.BidiFormatter.Builder"/></returns>
            public Android.Text.BidiFormatter.Builder StereoReset(bool arg0)
            {
                return IExecuteWithSignature<Android.Text.BidiFormatter.Builder>("stereoReset", "(Z)Landroid/text/BidiFormatter$Builder;", arg0);
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