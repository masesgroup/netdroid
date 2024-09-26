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

namespace Java.Text
{
    #region DateFormatSymbols declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/text/DateFormatSymbols.html"/>
    /// </summary>
    public partial class DateFormatSymbols : MASES.JCOBridge.C2JBridge.JVMBridgeBase<DateFormatSymbols>
    {
        const string _bridgeClassName = "java.text.DateFormatSymbols";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public DateFormatSymbols() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public DateFormatSymbols(params object[] args) : base(args) { }

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

    #region DateFormatSymbols implementation
    public partial class DateFormatSymbols : Java.Io.ISerializable, Java.Lang.ICloneable
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/DateFormatSymbols.html#%3Cinit%3E(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        public DateFormatSymbols(Java.Util.Locale arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Text.DateFormatSymbols"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Text.DateFormatSymbols t) => t.Cast<Java.Io.Serializable>();
        /// <summary>
        /// Converter from <see cref="Java.Text.DateFormatSymbols"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Text.DateFormatSymbols t) => t.Cast<Java.Lang.Cloneable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/DateFormatSymbols.html#getInstance()"/>
        /// </summary>
        /// <returns><see cref="Java.Text.DateFormatSymbols"/></returns>
        public static Java.Text.DateFormatSymbols GetInstance()
        {
            return SExecuteWithSignature<Java.Text.DateFormatSymbols>(LocalBridgeClazz, "getInstance", "()Ljava/text/DateFormatSymbols;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/DateFormatSymbols.html#getInstance(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Text.DateFormatSymbols"/></returns>
        public static Java.Text.DateFormatSymbols GetInstance(Java.Util.Locale arg0)
        {
            return SExecuteWithSignature<Java.Text.DateFormatSymbols>(LocalBridgeClazz, "getInstance", "(Ljava/util/Locale;)Ljava/text/DateFormatSymbols;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/DateFormatSymbols.html#getAvailableLocales()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Locale"/></returns>
        public static Java.Util.Locale[] GetAvailableLocales()
        {
            return SExecuteWithSignatureArray<Java.Util.Locale>(LocalBridgeClazz, "getAvailableLocales", "()[Ljava/util/Locale;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/DateFormatSymbols.html#getLocalPatternChars()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetLocalPatternChars()
        {
            return IExecuteWithSignature<Java.Lang.String>("getLocalPatternChars", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/DateFormatSymbols.html#getAmPmStrings()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String[] GetAmPmStrings()
        {
            return IExecuteWithSignatureArray<Java.Lang.String>("getAmPmStrings", "()[Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/DateFormatSymbols.html#getEras()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String[] GetEras()
        {
            return IExecuteWithSignatureArray<Java.Lang.String>("getEras", "()[Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/DateFormatSymbols.html#getMonths()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String[] GetMonths()
        {
            return IExecuteWithSignatureArray<Java.Lang.String>("getMonths", "()[Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/DateFormatSymbols.html#getShortMonths()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String[] GetShortMonths()
        {
            return IExecuteWithSignatureArray<Java.Lang.String>("getShortMonths", "()[Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/DateFormatSymbols.html#getShortWeekdays()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String[] GetShortWeekdays()
        {
            return IExecuteWithSignatureArray<Java.Lang.String>("getShortWeekdays", "()[Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/DateFormatSymbols.html#getWeekdays()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String[] GetWeekdays()
        {
            return IExecuteWithSignatureArray<Java.Lang.String>("getWeekdays", "()[Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/DateFormatSymbols.html#getZoneStrings()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String[] GetZoneStrings()
        {
            return IExecuteWithSignatureArray<Java.Lang.String>("getZoneStrings", "()[[Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/DateFormatSymbols.html#setAmPmStrings(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetAmPmStrings(Java.Lang.String[] arg0)
        {
            IExecuteWithSignature("setAmPmStrings", "([Ljava/lang/String;)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/DateFormatSymbols.html#setEras(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetEras(Java.Lang.String[] arg0)
        {
            IExecuteWithSignature("setEras", "([Ljava/lang/String;)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/DateFormatSymbols.html#setLocalPatternChars(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetLocalPatternChars(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setLocalPatternChars", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/DateFormatSymbols.html#setMonths(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetMonths(Java.Lang.String[] arg0)
        {
            IExecuteWithSignature("setMonths", "([Ljava/lang/String;)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/DateFormatSymbols.html#setShortMonths(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetShortMonths(Java.Lang.String[] arg0)
        {
            IExecuteWithSignature("setShortMonths", "([Ljava/lang/String;)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/DateFormatSymbols.html#setShortWeekdays(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetShortWeekdays(Java.Lang.String[] arg0)
        {
            IExecuteWithSignature("setShortWeekdays", "([Ljava/lang/String;)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/DateFormatSymbols.html#setWeekdays(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetWeekdays(Java.Lang.String[] arg0)
        {
            IExecuteWithSignature("setWeekdays", "([Ljava/lang/String;)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/DateFormatSymbols.html#setZoneStrings(java.lang.String[][])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetZoneStrings(Java.Lang.String[][] arg0)
        {
            IExecuteWithSignature("setZoneStrings", "([[Ljava/lang/String;)V", new object[] { arg0 });
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}