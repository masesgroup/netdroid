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

namespace Android.Text.Method
{
    #region DateTimeKeyListener
    public partial class DateTimeKeyListener
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/DateTimeKeyListener.html#%3Cinit%3E(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        public DateTimeKeyListener(Java.Util.Locale arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/DateTimeKeyListener.html#CHARACTERS"/>
        /// </summary>
        [global::System.Obsolete()]
        public static char[] CHARACTERS { get { if (!_CHARACTERSReady) { _CHARACTERSContent = SGetFieldArray<char>(LocalBridgeClazz, "CHARACTERS"); _CHARACTERSReady = true; } return _CHARACTERSContent; } }
        private static char[] _CHARACTERSContent = default;
        private static bool _CHARACTERSReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/DateTimeKeyListener.html#getInstance()"/>
        /// </summary>
        /// <returns><see cref="Android.Text.Method.DateTimeKeyListener"/></returns>
        [global::System.Obsolete()]
        public static Android.Text.Method.DateTimeKeyListener GetInstance()
        {
            return SExecuteWithSignature<Android.Text.Method.DateTimeKeyListener>(LocalBridgeClazz, "getInstance", "()Landroid/text/method/DateTimeKeyListener;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/method/DateTimeKeyListener.html#getInstance(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Android.Text.Method.DateTimeKeyListener"/></returns>
        public static Android.Text.Method.DateTimeKeyListener GetInstance(Java.Util.Locale arg0)
        {
            return SExecuteWithSignature<Android.Text.Method.DateTimeKeyListener>(LocalBridgeClazz, "getInstance", "(Ljava/util/Locale;)Landroid/text/method/DateTimeKeyListener;", arg0);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}