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
    #region CurrencyPluralInfo declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/icu/text/CurrencyPluralInfo.html"/>
    /// </summary>
    public partial class CurrencyPluralInfo : MASES.JCOBridge.C2JBridge.JVMBridgeBase<CurrencyPluralInfo>
    {
        const string _bridgeClassName = "android.icu.text.CurrencyPluralInfo";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public CurrencyPluralInfo() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public CurrencyPluralInfo(params object[] args) : base(args) { }

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

    #region CurrencyPluralInfo implementation
    public partial class CurrencyPluralInfo : Java.Lang.ICloneable, Java.Io.ISerializable
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/CurrencyPluralInfo.html#%3Cinit%3E(android.icu.util.ULocale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.ULocale"/></param>
        public CurrencyPluralInfo(Android.Icu.Util.ULocale arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/CurrencyPluralInfo.html#%3Cinit%3E(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        public CurrencyPluralInfo(Java.Util.Locale arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Icu.Text.CurrencyPluralInfo"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Android.Icu.Text.CurrencyPluralInfo t) => t.Cast<Java.Lang.Cloneable>();
        /// <summary>
        /// Converter from <see cref="Android.Icu.Text.CurrencyPluralInfo"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Android.Icu.Text.CurrencyPluralInfo t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/CurrencyPluralInfo.html#getInstance()"/>
        /// </summary>
        /// <returns><see cref="Android.Icu.Text.CurrencyPluralInfo"/></returns>
        public static Android.Icu.Text.CurrencyPluralInfo GetInstance()
        {
            return SExecuteWithSignature<Android.Icu.Text.CurrencyPluralInfo>(LocalBridgeClazz, "getInstance", "()Landroid/icu/text/CurrencyPluralInfo;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/CurrencyPluralInfo.html#getInstance(android.icu.util.ULocale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.ULocale"/></param>
        /// <returns><see cref="Android.Icu.Text.CurrencyPluralInfo"/></returns>
        public static Android.Icu.Text.CurrencyPluralInfo GetInstance(Android.Icu.Util.ULocale arg0)
        {
            return SExecuteWithSignature<Android.Icu.Text.CurrencyPluralInfo>(LocalBridgeClazz, "getInstance", "(Landroid/icu/util/ULocale;)Landroid/icu/text/CurrencyPluralInfo;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/CurrencyPluralInfo.html#getInstance(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Android.Icu.Text.CurrencyPluralInfo"/></returns>
        public static Android.Icu.Text.CurrencyPluralInfo GetInstance(Java.Util.Locale arg0)
        {
            return SExecuteWithSignature<Android.Icu.Text.CurrencyPluralInfo>(LocalBridgeClazz, "getInstance", "(Ljava/util/Locale;)Landroid/icu/text/CurrencyPluralInfo;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/CurrencyPluralInfo.html#getPluralRules()"/>
        /// </summary>
        /// <returns><see cref="Android.Icu.Text.PluralRules"/></returns>
        public Android.Icu.Text.PluralRules GetPluralRules()
        {
            return IExecuteWithSignature<Android.Icu.Text.PluralRules>("getPluralRules", "()Landroid/icu/text/PluralRules;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/CurrencyPluralInfo.html#getLocale()"/>
        /// </summary>
        /// <returns><see cref="Android.Icu.Util.ULocale"/></returns>
        public Android.Icu.Util.ULocale GetLocale()
        {
            return IExecuteWithSignature<Android.Icu.Util.ULocale>("getLocale", "()Landroid/icu/util/ULocale;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/CurrencyPluralInfo.html#getCurrencyPluralPattern(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetCurrencyPluralPattern(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getCurrencyPluralPattern", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/CurrencyPluralInfo.html#setCurrencyPluralPattern(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void SetCurrencyPluralPattern(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            IExecuteWithSignature("setCurrencyPluralPattern", "(Ljava/lang/String;Ljava/lang/String;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/CurrencyPluralInfo.html#setLocale(android.icu.util.ULocale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.ULocale"/></param>
        public void SetLocale(Android.Icu.Util.ULocale arg0)
        {
            IExecuteWithSignature("setLocale", "(Landroid/icu/util/ULocale;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/CurrencyPluralInfo.html#setPluralRules(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetPluralRules(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setPluralRules", "(Ljava/lang/String;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}