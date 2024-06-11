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

namespace Java.Time.Chrono
{
    #region MinguoEra
    public partial class MinguoEra
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Time.Chrono.MinguoEra"/> to <see cref="Java.Time.Chrono.Era"/>
        /// </summary>
        public static implicit operator Java.Time.Chrono.Era(Java.Time.Chrono.MinguoEra t) => t.Cast<Java.Time.Chrono.Era>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/MinguoEra.html#BEFORE_ROC"/>
        /// </summary>
        public static Java.Time.Chrono.MinguoEra BEFORE_ROC { get { if (!_BEFORE_ROCReady) { _BEFORE_ROCContent = SGetField<Java.Time.Chrono.MinguoEra>(LocalBridgeClazz, "BEFORE_ROC"); _BEFORE_ROCReady = true; } return _BEFORE_ROCContent; } }
        private static Java.Time.Chrono.MinguoEra _BEFORE_ROCContent = default;
        private static bool _BEFORE_ROCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/MinguoEra.html#ROC"/>
        /// </summary>
        public static Java.Time.Chrono.MinguoEra ROC { get { if (!_ROCReady) { _ROCContent = SGetField<Java.Time.Chrono.MinguoEra>(LocalBridgeClazz, "ROC"); _ROCReady = true; } return _ROCContent; } }
        private static Java.Time.Chrono.MinguoEra _ROCContent = default;
        private static bool _ROCReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/MinguoEra.html#of(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Time.Chrono.MinguoEra"/></returns>
        public static Java.Time.Chrono.MinguoEra Of(int arg0)
        {
            return SExecuteWithSignature<Java.Time.Chrono.MinguoEra>(LocalBridgeClazz, "of", "(I)Ljava/time/chrono/MinguoEra;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/MinguoEra.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Time.Chrono.MinguoEra"/></returns>
        public static Java.Time.Chrono.MinguoEra ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Time.Chrono.MinguoEra>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/time/chrono/MinguoEra;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/MinguoEra.html#values()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Chrono.MinguoEra"/></returns>
        public static Java.Time.Chrono.MinguoEra[] Values()
        {
            return SExecuteWithSignatureArray<Java.Time.Chrono.MinguoEra>(LocalBridgeClazz, "values", "()[Ljava/time/chrono/MinguoEra;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/MinguoEra.html#getValue()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetValue()
        {
            return IExecuteWithSignature<int>("getValue", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/chrono/MinguoEra.html#getDisplayName(java.time.format.TextStyle,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Format.TextStyle"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetDisplayName(Java.Time.Format.TextStyle arg0, Java.Util.Locale arg1)
        {
            return IExecute<Java.Lang.String>("getDisplayName", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}