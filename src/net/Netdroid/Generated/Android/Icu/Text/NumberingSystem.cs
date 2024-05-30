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
    #region NumberingSystem
    public partial class NumberingSystem
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/NumberingSystem.html#LATIN"/>
        /// </summary>
        public static Android.Icu.Text.NumberingSystem LATIN { get { if (!_LATINReady) { _LATINContent = SGetField<Android.Icu.Text.NumberingSystem>(LocalBridgeClazz, "LATIN"); _LATINReady = true; } return _LATINContent; } }
        private static Android.Icu.Text.NumberingSystem _LATINContent = default;
        private static bool _LATINReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/NumberingSystem.html#getAvailableNames()"/> 
        /// </summary>
        public static Java.Lang.String[] AvailableNames
        {
            get { return SExecuteWithSignatureArray<Java.Lang.String>(LocalBridgeClazz, "getAvailableNames", "()[Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/NumberingSystem.html#getInstance()"/> 
        /// </summary>
        public static Android.Icu.Text.NumberingSystem Instance
        {
            get { return SExecuteWithSignature<Android.Icu.Text.NumberingSystem>(LocalBridgeClazz, "getInstance", "()Landroid/icu/text/NumberingSystem;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/NumberingSystem.html#getInstance(android.icu.util.ULocale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.ULocale"/></param>
        /// <returns><see cref="Android.Icu.Text.NumberingSystem"/></returns>
        public static Android.Icu.Text.NumberingSystem GetInstance(Android.Icu.Util.ULocale arg0)
        {
            return SExecuteWithSignature<Android.Icu.Text.NumberingSystem>(LocalBridgeClazz, "getInstance", "(Landroid/icu/util/ULocale;)Landroid/icu/text/NumberingSystem;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/NumberingSystem.html#getInstance(int,boolean,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Icu.Text.NumberingSystem"/></returns>
        public static Android.Icu.Text.NumberingSystem GetInstance(int arg0, bool arg1, Java.Lang.String arg2)
        {
            return SExecute<Android.Icu.Text.NumberingSystem>(LocalBridgeClazz, "getInstance", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/NumberingSystem.html#getInstance(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Android.Icu.Text.NumberingSystem"/></returns>
        public static Android.Icu.Text.NumberingSystem GetInstance(Java.Util.Locale arg0)
        {
            return SExecuteWithSignature<Android.Icu.Text.NumberingSystem>(LocalBridgeClazz, "getInstance", "(Ljava/util/Locale;)Landroid/icu/text/NumberingSystem;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/NumberingSystem.html#getInstanceByName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Icu.Text.NumberingSystem"/></returns>
        public static Android.Icu.Text.NumberingSystem GetInstanceByName(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Android.Icu.Text.NumberingSystem>(LocalBridgeClazz, "getInstanceByName", "(Ljava/lang/String;)Landroid/icu/text/NumberingSystem;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/NumberingSystem.html#isValidDigitString(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsValidDigitString(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isValidDigitString", "(Ljava/lang/String;)Z", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/NumberingSystem.html#getDescription()"/> 
        /// </summary>
        public Java.Lang.String Description
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getDescription", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/NumberingSystem.html#getName()"/> 
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/NumberingSystem.html#getRadix()"/> 
        /// </summary>
        public int Radix
        {
            get { return IExecuteWithSignature<int>("getRadix", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/NumberingSystem.html#isAlgorithmic()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsAlgorithmic()
        {
            return IExecuteWithSignature<bool>("isAlgorithmic", "()Z");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}