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

namespace Java.Util
{
    #region Currency
    public partial class Currency
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Currency.html#getInstance(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Currency"/></returns>
        public static Java.Util.Currency GetInstance(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Util.Currency>(LocalBridgeClazz, "getInstance", "(Ljava/lang/String;)Ljava/util/Currency;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Currency.html#getInstance(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Util.Currency"/></returns>
        public static Java.Util.Currency GetInstance(Java.Util.Locale arg0)
        {
            return SExecuteWithSignature<Java.Util.Currency>(LocalBridgeClazz, "getInstance", "(Ljava/util/Locale;)Ljava/util/Currency;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Currency.html#getAvailableCurrencies()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public static Java.Util.Set<Java.Util.Currency> GetAvailableCurrencies()
        {
            return SExecuteWithSignature<Java.Util.Set<Java.Util.Currency>>(LocalBridgeClazz, "getAvailableCurrencies", "()Ljava/util/Set;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Currency.html#getDefaultFractionDigits()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDefaultFractionDigits()
        {
            return IExecuteWithSignature<int>("getDefaultFractionDigits", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Currency.html#getNumericCode()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetNumericCode()
        {
            return IExecuteWithSignature<int>("getNumericCode", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Currency.html#getCurrencyCode()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetCurrencyCode()
        {
            return IExecuteWithSignature<Java.Lang.String>("getCurrencyCode", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Currency.html#getDisplayName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetDisplayName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getDisplayName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Currency.html#getDisplayName(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetDisplayName(Java.Util.Locale arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getDisplayName", "(Ljava/util/Locale;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Currency.html#getNumericCodeAsString()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetNumericCodeAsString()
        {
            return IExecuteWithSignature<Java.Lang.String>("getNumericCodeAsString", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Currency.html#getSymbol()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetSymbol()
        {
            return IExecuteWithSignature<Java.Lang.String>("getSymbol", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Currency.html#getSymbol(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetSymbol(Java.Util.Locale arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getSymbol", "(Ljava/util/Locale;)Ljava/lang/String;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}