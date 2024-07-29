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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Text.Util
{
    #region Rfc822Tokenizer
    public partial class Rfc822Tokenizer
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/util/Rfc822Tokenizer.html#tokenize(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Android.Text.Util.Rfc822Token"/></returns>
        public static Android.Text.Util.Rfc822Token[] Tokenize(Java.Lang.CharSequence arg0)
        {
            return SExecuteWithSignatureArray<Android.Text.Util.Rfc822Token>(LocalBridgeClazz, "tokenize", "(Ljava/lang/CharSequence;)[Landroid/text/util/Rfc822Token;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/util/Rfc822Tokenizer.html#tokenize(java.lang.CharSequence,java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Java.Util.Collection"/></param>
        public static void Tokenize(Java.Lang.CharSequence arg0, Java.Util.Collection<Android.Text.Util.Rfc822Token> arg1)
        {
            SExecute(LocalBridgeClazz, "tokenize", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/util/Rfc822Tokenizer.html#findTokenEnd(java.lang.CharSequence,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int FindTokenEnd(Java.Lang.CharSequence arg0, int arg1)
        {
            return IExecute<int>("findTokenEnd", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/util/Rfc822Tokenizer.html#findTokenStart(java.lang.CharSequence,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int FindTokenStart(Java.Lang.CharSequence arg0, int arg1)
        {
            return IExecute<int>("findTokenStart", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/util/Rfc822Tokenizer.html#terminateToken(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence TerminateToken(Java.Lang.CharSequence arg0)
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("terminateToken", "(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}