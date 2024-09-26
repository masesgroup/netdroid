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
    #region SimpleDateFormat declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/icu/text/SimpleDateFormat.html"/>
    /// </summary>
    public partial class SimpleDateFormat : Android.Icu.Text.DateFormat
    {
        const string _bridgeClassName = "android.icu.text.SimpleDateFormat";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SimpleDateFormat() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SimpleDateFormat(params object[] args) : base(args) { }

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

    #region SimpleDateFormat implementation
    public partial class SimpleDateFormat
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/SimpleDateFormat.html#%3Cinit%3E(java.lang.String,android.icu.text.DateFormatSymbols)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Text.DateFormatSymbols"/></param>
        public SimpleDateFormat(Java.Lang.String arg0, Android.Icu.Text.DateFormatSymbols arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/SimpleDateFormat.html#%3Cinit%3E(java.lang.String,android.icu.util.ULocale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Util.ULocale"/></param>
        public SimpleDateFormat(Java.Lang.String arg0, Android.Icu.Util.ULocale arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/SimpleDateFormat.html#%3Cinit%3E(java.lang.String,java.lang.String,android.icu.util.ULocale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Android.Icu.Util.ULocale"/></param>
        public SimpleDateFormat(Java.Lang.String arg0, Java.Lang.String arg1, Android.Icu.Util.ULocale arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/SimpleDateFormat.html#%3Cinit%3E(java.lang.String,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        public SimpleDateFormat(Java.Lang.String arg0, Java.Util.Locale arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/SimpleDateFormat.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public SimpleDateFormat(Java.Lang.String arg0)
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
        /// <see href="https://developer.android.com/reference/android/icu/text/SimpleDateFormat.html#getDateFormatSymbols()"/>
        /// </summary>
        /// <returns><see cref="Android.Icu.Text.DateFormatSymbols"/></returns>
        public Android.Icu.Text.DateFormatSymbols GetDateFormatSymbols()
        {
            return IExecuteWithSignature<Android.Icu.Text.DateFormatSymbols>("getDateFormatSymbols", "()Landroid/icu/text/DateFormatSymbols;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/SimpleDateFormat.html#getNumberFormat(char)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <returns><see cref="Android.Icu.Text.NumberFormat"/></returns>
        public Android.Icu.Text.NumberFormat GetNumberFormat(char arg0)
        {
            return IExecuteWithSignature<Android.Icu.Text.NumberFormat>("getNumberFormat", "(C)Landroid/icu/text/NumberFormat;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/SimpleDateFormat.html#getTimeZoneFormat()"/>
        /// </summary>
        /// <returns><see cref="Android.Icu.Text.TimeZoneFormat"/></returns>
        public Android.Icu.Text.TimeZoneFormat GetTimeZoneFormat()
        {
            return IExecuteWithSignature<Android.Icu.Text.TimeZoneFormat>("getTimeZoneFormat", "()Landroid/icu/text/TimeZoneFormat;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/SimpleDateFormat.html#toLocalizedPattern()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ToLocalizedPattern()
        {
            return IExecuteWithSignature<Java.Lang.String>("toLocalizedPattern", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/SimpleDateFormat.html#toPattern()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ToPattern()
        {
            return IExecuteWithSignature<Java.Lang.String>("toPattern", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/SimpleDateFormat.html#get2DigitYearStart()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Date"/></returns>
        public Java.Util.Date Get2DigitYearStart()
        {
            return IExecuteWithSignature<Java.Util.Date>("get2DigitYearStart", "()Ljava/util/Date;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/SimpleDateFormat.html#applyLocalizedPattern(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void ApplyLocalizedPattern(Java.Lang.String arg0)
        {
            IExecuteWithSignature("applyLocalizedPattern", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/SimpleDateFormat.html#applyPattern(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void ApplyPattern(Java.Lang.String arg0)
        {
            IExecuteWithSignature("applyPattern", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/SimpleDateFormat.html#set2DigitYearStart(java.util.Date)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Date"/></param>
        public void Set2DigitYearStart(Java.Util.Date arg0)
        {
            IExecuteWithSignature("set2DigitYearStart", "(Ljava/util/Date;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/SimpleDateFormat.html#setDateFormatSymbols(android.icu.text.DateFormatSymbols)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Text.DateFormatSymbols"/></param>
        public void SetDateFormatSymbols(Android.Icu.Text.DateFormatSymbols arg0)
        {
            IExecuteWithSignature("setDateFormatSymbols", "(Landroid/icu/text/DateFormatSymbols;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/SimpleDateFormat.html#setNumberFormat(java.lang.String,android.icu.text.NumberFormat)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Text.NumberFormat"/></param>
        public void SetNumberFormat(Java.Lang.String arg0, Android.Icu.Text.NumberFormat arg1)
        {
            IExecuteWithSignature("setNumberFormat", "(Ljava/lang/String;Landroid/icu/text/NumberFormat;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/SimpleDateFormat.html#setTimeZoneFormat(android.icu.text.TimeZoneFormat)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Text.TimeZoneFormat"/></param>
        public void SetTimeZoneFormat(Android.Icu.Text.TimeZoneFormat arg0)
        {
            IExecuteWithSignature("setTimeZoneFormat", "(Landroid/icu/text/TimeZoneFormat;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}