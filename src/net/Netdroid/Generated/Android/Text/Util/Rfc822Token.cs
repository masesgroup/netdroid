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

namespace Android.Text.Util
{
    #region Rfc822Token
    public partial class Rfc822Token
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/util/Rfc822Token.html#%3Cinit%3E(java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        public Rfc822Token(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/util/Rfc822Token.html#quoteComment(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String QuoteComment(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "quoteComment", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/util/Rfc822Token.html#quoteName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String QuoteName(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "quoteName", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/util/Rfc822Token.html#quoteNameIfNecessary(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String QuoteNameIfNecessary(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "quoteNameIfNecessary", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/util/Rfc822Token.html#getAddress()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetAddress()
        {
            return IExecuteWithSignature<Java.Lang.String>("getAddress", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/util/Rfc822Token.html#getComment()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetComment()
        {
            return IExecuteWithSignature<Java.Lang.String>("getComment", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/util/Rfc822Token.html#getName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/util/Rfc822Token.html#setAddress(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetAddress(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setAddress", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/util/Rfc822Token.html#setComment(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetComment(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setComment", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/util/Rfc822Token.html#setName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetName(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setName", "(Ljava/lang/String;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}