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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Icu.Text
{
    #region CompactDecimalFormat
    public partial class CompactDecimalFormat
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/CompactDecimalFormat.html#getInstance(android.icu.util.ULocale,android.icu.text.CompactDecimalFormat.CompactStyle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.ULocale"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Text.CompactDecimalFormat.CompactStyle"/></param>
        /// <returns><see cref="Android.Icu.Text.CompactDecimalFormat"/></returns>
        public static Android.Icu.Text.CompactDecimalFormat GetInstance(Android.Icu.Util.ULocale arg0, Android.Icu.Text.CompactDecimalFormat.CompactStyle arg1)
        {
            return SExecute<Android.Icu.Text.CompactDecimalFormat>(LocalBridgeClazz, "getInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/CompactDecimalFormat.html#getInstance(java.util.Locale,android.icu.text.CompactDecimalFormat.CompactStyle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Text.CompactDecimalFormat.CompactStyle"/></param>
        /// <returns><see cref="Android.Icu.Text.CompactDecimalFormat"/></returns>
        public static Android.Icu.Text.CompactDecimalFormat GetInstance(Java.Util.Locale arg0, Android.Icu.Text.CompactDecimalFormat.CompactStyle arg1)
        {
            return SExecute<Android.Icu.Text.CompactDecimalFormat>(LocalBridgeClazz, "getInstance", arg0, arg1);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes
        #region CompactStyle
        public partial class CompactStyle
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/CompactDecimalFormat.CompactStyle.html#LONG"/>
            /// </summary>
            public static Android.Icu.Text.CompactDecimalFormat.CompactStyle LONG { get { if (!_LONGReady) { _LONGContent = SGetField<Android.Icu.Text.CompactDecimalFormat.CompactStyle>(LocalBridgeClazz, "LONG"); _LONGReady = true; } return _LONGContent; } }
            private static Android.Icu.Text.CompactDecimalFormat.CompactStyle _LONGContent = default;
            private static bool _LONGReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/CompactDecimalFormat.CompactStyle.html#SHORT"/>
            /// </summary>
            public static Android.Icu.Text.CompactDecimalFormat.CompactStyle SHORT { get { if (!_SHORTReady) { _SHORTContent = SGetField<Android.Icu.Text.CompactDecimalFormat.CompactStyle>(LocalBridgeClazz, "SHORT"); _SHORTReady = true; } return _SHORTContent; } }
            private static Android.Icu.Text.CompactDecimalFormat.CompactStyle _SHORTContent = default;
            private static bool _SHORTReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/CompactDecimalFormat.CompactStyle.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Icu.Text.CompactDecimalFormat.CompactStyle"/></returns>
            public static Android.Icu.Text.CompactDecimalFormat.CompactStyle ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Android.Icu.Text.CompactDecimalFormat.CompactStyle>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Landroid/icu/text/CompactDecimalFormat$CompactStyle;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/CompactDecimalFormat.CompactStyle.html#values()"/>
            /// </summary>
            /// <returns><see cref="Android.Icu.Text.CompactDecimalFormat.CompactStyle"/></returns>
            public static Android.Icu.Text.CompactDecimalFormat.CompactStyle[] Values()
            {
                return SExecuteWithSignatureArray<Android.Icu.Text.CompactDecimalFormat.CompactStyle>(LocalBridgeClazz, "values", "()[Landroid/icu/text/CompactDecimalFormat$CompactStyle;");
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