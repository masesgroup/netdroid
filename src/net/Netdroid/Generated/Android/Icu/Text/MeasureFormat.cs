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

namespace Android.Icu.Text
{
    #region MeasureFormat declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/icu/text/MeasureFormat.html"/>
    /// </summary>
    public partial class MeasureFormat : Android.Icu.Text.UFormat
    {
        const string _bridgeClassName = "android.icu.text.MeasureFormat";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public MeasureFormat() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public MeasureFormat(params object[] args) : base(args) { }

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
        #region FormatWidth declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/MeasureFormat.FormatWidth.html"/>
        /// </summary>
        public partial class FormatWidth : Java.Lang.Enum<Android.Icu.Text.MeasureFormat.FormatWidth>
        {
            const string _bridgeClassName = "android.icu.text.MeasureFormat$FormatWidth";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public FormatWidth() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public FormatWidth(params object[] args) : base(args) { }

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

    #region MeasureFormat implementation
    public partial class MeasureFormat
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/MeasureFormat.html#getCurrencyFormat()"/>
        /// </summary>
        /// <returns><see cref="Android.Icu.Text.MeasureFormat"/></returns>
        public static Android.Icu.Text.MeasureFormat GetCurrencyFormat()
        {
            return SExecuteWithSignature<Android.Icu.Text.MeasureFormat>(LocalBridgeClazz, "getCurrencyFormat", "()Landroid/icu/text/MeasureFormat;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/MeasureFormat.html#getCurrencyFormat(android.icu.util.ULocale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.ULocale"/></param>
        /// <returns><see cref="Android.Icu.Text.MeasureFormat"/></returns>
        public static Android.Icu.Text.MeasureFormat GetCurrencyFormat(Android.Icu.Util.ULocale arg0)
        {
            return SExecuteWithSignature<Android.Icu.Text.MeasureFormat>(LocalBridgeClazz, "getCurrencyFormat", "(Landroid/icu/util/ULocale;)Landroid/icu/text/MeasureFormat;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/MeasureFormat.html#getCurrencyFormat(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Android.Icu.Text.MeasureFormat"/></returns>
        public static Android.Icu.Text.MeasureFormat GetCurrencyFormat(Java.Util.Locale arg0)
        {
            return SExecuteWithSignature<Android.Icu.Text.MeasureFormat>(LocalBridgeClazz, "getCurrencyFormat", "(Ljava/util/Locale;)Landroid/icu/text/MeasureFormat;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/MeasureFormat.html#getInstance(android.icu.util.ULocale,android.icu.text.MeasureFormat.FormatWidth,android.icu.text.NumberFormat)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.ULocale"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Text.MeasureFormat.FormatWidth"/></param>
        /// <param name="arg2"><see cref="Android.Icu.Text.NumberFormat"/></param>
        /// <returns><see cref="Android.Icu.Text.MeasureFormat"/></returns>
        public static Android.Icu.Text.MeasureFormat GetInstance(Android.Icu.Util.ULocale arg0, Android.Icu.Text.MeasureFormat.FormatWidth arg1, Android.Icu.Text.NumberFormat arg2)
        {
            return SExecuteWithSignature<Android.Icu.Text.MeasureFormat>(LocalBridgeClazz, "getInstance", "(Landroid/icu/util/ULocale;Landroid/icu/text/MeasureFormat$FormatWidth;Landroid/icu/text/NumberFormat;)Landroid/icu/text/MeasureFormat;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/MeasureFormat.html#getInstance(android.icu.util.ULocale,android.icu.text.MeasureFormat.FormatWidth)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.ULocale"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Text.MeasureFormat.FormatWidth"/></param>
        /// <returns><see cref="Android.Icu.Text.MeasureFormat"/></returns>
        public static Android.Icu.Text.MeasureFormat GetInstance(Android.Icu.Util.ULocale arg0, Android.Icu.Text.MeasureFormat.FormatWidth arg1)
        {
            return SExecuteWithSignature<Android.Icu.Text.MeasureFormat>(LocalBridgeClazz, "getInstance", "(Landroid/icu/util/ULocale;Landroid/icu/text/MeasureFormat$FormatWidth;)Landroid/icu/text/MeasureFormat;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/MeasureFormat.html#getInstance(java.util.Locale,android.icu.text.MeasureFormat.FormatWidth,android.icu.text.NumberFormat)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Text.MeasureFormat.FormatWidth"/></param>
        /// <param name="arg2"><see cref="Android.Icu.Text.NumberFormat"/></param>
        /// <returns><see cref="Android.Icu.Text.MeasureFormat"/></returns>
        public static Android.Icu.Text.MeasureFormat GetInstance(Java.Util.Locale arg0, Android.Icu.Text.MeasureFormat.FormatWidth arg1, Android.Icu.Text.NumberFormat arg2)
        {
            return SExecuteWithSignature<Android.Icu.Text.MeasureFormat>(LocalBridgeClazz, "getInstance", "(Ljava/util/Locale;Landroid/icu/text/MeasureFormat$FormatWidth;Landroid/icu/text/NumberFormat;)Landroid/icu/text/MeasureFormat;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/MeasureFormat.html#getInstance(java.util.Locale,android.icu.text.MeasureFormat.FormatWidth)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Text.MeasureFormat.FormatWidth"/></param>
        /// <returns><see cref="Android.Icu.Text.MeasureFormat"/></returns>
        public static Android.Icu.Text.MeasureFormat GetInstance(Java.Util.Locale arg0, Android.Icu.Text.MeasureFormat.FormatWidth arg1)
        {
            return SExecuteWithSignature<Android.Icu.Text.MeasureFormat>(LocalBridgeClazz, "getInstance", "(Ljava/util/Locale;Landroid/icu/text/MeasureFormat$FormatWidth;)Landroid/icu/text/MeasureFormat;", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/MeasureFormat.html#getWidth()"/>
        /// </summary>
        /// <returns><see cref="Android.Icu.Text.MeasureFormat.FormatWidth"/></returns>
        public Android.Icu.Text.MeasureFormat.FormatWidth GetWidth()
        {
            return IExecuteWithSignature<Android.Icu.Text.MeasureFormat.FormatWidth>("getWidth", "()Landroid/icu/text/MeasureFormat$FormatWidth;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/MeasureFormat.html#getNumberFormat()"/>
        /// </summary>
        /// <returns><see cref="Android.Icu.Text.NumberFormat"/></returns>
        public Android.Icu.Text.NumberFormat GetNumberFormat()
        {
            return IExecuteWithSignature<Android.Icu.Text.NumberFormat>("getNumberFormat", "()Landroid/icu/text/NumberFormat;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/MeasureFormat.html#getLocale()"/>
        /// </summary>
        /// <returns><see cref="Android.Icu.Util.ULocale"/></returns>
        public Android.Icu.Util.ULocale GetLocale()
        {
            return IExecuteWithSignature<Android.Icu.Util.ULocale>("getLocale", "()Landroid/icu/util/ULocale;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/MeasureFormat.html#formatMeasures(android.icu.util.Measure[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.Measure"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String FormatMeasures(params Android.Icu.Util.Measure[] arg0)
        {
            if (arg0.Length == 0) return IExecuteWithSignature<Java.Lang.String>("formatMeasures", "([Landroid/icu/util/Measure;)Ljava/lang/String;"); else return IExecuteWithSignature<Java.Lang.String>("formatMeasures", "([Landroid/icu/util/Measure;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/MeasureFormat.html#getUnitDisplayName(android.icu.util.MeasureUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.MeasureUnit"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetUnitDisplayName(Android.Icu.Util.MeasureUnit arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getUnitDisplayName", "(Landroid/icu/util/MeasureUnit;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/MeasureFormat.html#formatMeasurePerUnit(android.icu.util.Measure,android.icu.util.MeasureUnit,java.lang.StringBuilder,java.text.FieldPosition)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.Measure"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Util.MeasureUnit"/></param>
        /// <param name="arg2"><see cref="Java.Lang.StringBuilder"/></param>
        /// <param name="arg3"><see cref="Java.Text.FieldPosition"/></param>
        /// <returns><see cref="Java.Lang.StringBuilder"/></returns>
        public Java.Lang.StringBuilder FormatMeasurePerUnit(Android.Icu.Util.Measure arg0, Android.Icu.Util.MeasureUnit arg1, Java.Lang.StringBuilder arg2, Java.Text.FieldPosition arg3)
        {
            return IExecuteWithSignature<Java.Lang.StringBuilder>("formatMeasurePerUnit", "(Landroid/icu/util/Measure;Landroid/icu/util/MeasureUnit;Ljava/lang/StringBuilder;Ljava/text/FieldPosition;)Ljava/lang/StringBuilder;", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/MeasureFormat.html#formatMeasures(java.lang.StringBuilder,java.text.FieldPosition,android.icu.util.Measure[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.StringBuilder"/></param>
        /// <param name="arg1"><see cref="Java.Text.FieldPosition"/></param>
        /// <param name="arg2"><see cref="Android.Icu.Util.Measure"/></param>
        /// <returns><see cref="Java.Lang.StringBuilder"/></returns>
        public Java.Lang.StringBuilder FormatMeasures(Java.Lang.StringBuilder arg0, Java.Text.FieldPosition arg1, params Android.Icu.Util.Measure[] arg2)
        {
            if (arg2.Length == 0) return IExecuteWithSignature<Java.Lang.StringBuilder>("formatMeasures", "(Ljava/lang/StringBuilder;Ljava/text/FieldPosition;[Landroid/icu/util/Measure;)Ljava/lang/StringBuilder;", arg0, arg1); else return IExecuteWithSignature<Java.Lang.StringBuilder>("formatMeasures", "(Ljava/lang/StringBuilder;Ljava/text/FieldPosition;[Landroid/icu/util/Measure;)Ljava/lang/StringBuilder;", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes
        #region FormatWidth implementation
        public partial class FormatWidth
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/MeasureFormat.FormatWidth.html#NARROW"/>
            /// </summary>
            public static Android.Icu.Text.MeasureFormat.FormatWidth NARROW { get { if (!_NARROWReady) { _NARROWContent = SGetField<Android.Icu.Text.MeasureFormat.FormatWidth>(LocalBridgeClazz, "NARROW"); _NARROWReady = true; } return _NARROWContent; } }
            private static Android.Icu.Text.MeasureFormat.FormatWidth _NARROWContent = default;
            private static bool _NARROWReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/MeasureFormat.FormatWidth.html#NUMERIC"/>
            /// </summary>
            public static Android.Icu.Text.MeasureFormat.FormatWidth NUMERIC { get { if (!_NUMERICReady) { _NUMERICContent = SGetField<Android.Icu.Text.MeasureFormat.FormatWidth>(LocalBridgeClazz, "NUMERIC"); _NUMERICReady = true; } return _NUMERICContent; } }
            private static Android.Icu.Text.MeasureFormat.FormatWidth _NUMERICContent = default;
            private static bool _NUMERICReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/MeasureFormat.FormatWidth.html#SHORT"/>
            /// </summary>
            public static Android.Icu.Text.MeasureFormat.FormatWidth SHORT { get { if (!_SHORTReady) { _SHORTContent = SGetField<Android.Icu.Text.MeasureFormat.FormatWidth>(LocalBridgeClazz, "SHORT"); _SHORTReady = true; } return _SHORTContent; } }
            private static Android.Icu.Text.MeasureFormat.FormatWidth _SHORTContent = default;
            private static bool _SHORTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/MeasureFormat.FormatWidth.html#WIDE"/>
            /// </summary>
            public static Android.Icu.Text.MeasureFormat.FormatWidth WIDE { get { if (!_WIDEReady) { _WIDEContent = SGetField<Android.Icu.Text.MeasureFormat.FormatWidth>(LocalBridgeClazz, "WIDE"); _WIDEReady = true; } return _WIDEContent; } }
            private static Android.Icu.Text.MeasureFormat.FormatWidth _WIDEContent = default;
            private static bool _WIDEReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/MeasureFormat.FormatWidth.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Icu.Text.MeasureFormat.FormatWidth"/></returns>
            public static Android.Icu.Text.MeasureFormat.FormatWidth ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Android.Icu.Text.MeasureFormat.FormatWidth>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Landroid/icu/text/MeasureFormat$FormatWidth;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/MeasureFormat.FormatWidth.html#values()"/>
            /// </summary>
            /// <returns><see cref="Android.Icu.Text.MeasureFormat.FormatWidth"/></returns>
            public static Android.Icu.Text.MeasureFormat.FormatWidth[] Values()
            {
                return SExecuteWithSignatureArray<Android.Icu.Text.MeasureFormat.FormatWidth>(LocalBridgeClazz, "values", "()[Landroid/icu/text/MeasureFormat$FormatWidth;");
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