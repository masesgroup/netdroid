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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Net
{
    #region HttpCookie
    public partial class HttpCookie
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/HttpCookie.html#%3Cinit%3E(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public HttpCookie(Java.Lang.String arg0, Java.Lang.String arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/HttpCookie.html#domainMatches(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool DomainMatches(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "domainMatches", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/HttpCookie.html#parse(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public static Java.Util.List<Java.Net.HttpCookie> Parse(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Util.List<Java.Net.HttpCookie>>(LocalBridgeClazz, "parse", "(Ljava/lang/String;)Ljava/util/List;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/HttpCookie.html#getDiscard()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetDiscard()
        {
            return IExecuteWithSignature<bool>("getDiscard", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/HttpCookie.html#getSecure()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetSecure()
        {
            return IExecuteWithSignature<bool>("getSecure", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/HttpCookie.html#hasExpired()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasExpired()
        {
            return IExecuteWithSignature<bool>("hasExpired", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/HttpCookie.html#isHttpOnly()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsHttpOnly()
        {
            return IExecuteWithSignature<bool>("isHttpOnly", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/HttpCookie.html#getVersion()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetVersion()
        {
            return IExecuteWithSignature<int>("getVersion", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/HttpCookie.html#getComment()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetComment()
        {
            return IExecuteWithSignature<Java.Lang.String>("getComment", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/HttpCookie.html#getCommentURL()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetCommentURL()
        {
            return IExecuteWithSignature<Java.Lang.String>("getCommentURL", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/HttpCookie.html#getDomain()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetDomain()
        {
            return IExecuteWithSignature<Java.Lang.String>("getDomain", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/HttpCookie.html#getName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/HttpCookie.html#getPath()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetPath()
        {
            return IExecuteWithSignature<Java.Lang.String>("getPath", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/HttpCookie.html#getPortlist()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetPortlist()
        {
            return IExecuteWithSignature<Java.Lang.String>("getPortlist", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/HttpCookie.html#getValue()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetValue()
        {
            return IExecuteWithSignature<Java.Lang.String>("getValue", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/HttpCookie.html#getMaxAge()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetMaxAge()
        {
            return IExecuteWithSignature<long>("getMaxAge", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/HttpCookie.html#setComment(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetComment(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setComment", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/HttpCookie.html#setCommentURL(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetCommentURL(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setCommentURL", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/HttpCookie.html#setDiscard(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetDiscard(bool arg0)
        {
            IExecuteWithSignature("setDiscard", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/HttpCookie.html#setDomain(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetDomain(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setDomain", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/HttpCookie.html#setHttpOnly(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetHttpOnly(bool arg0)
        {
            IExecuteWithSignature("setHttpOnly", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/HttpCookie.html#setMaxAge(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void SetMaxAge(long arg0)
        {
            IExecuteWithSignature("setMaxAge", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/HttpCookie.html#setPath(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetPath(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setPath", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/HttpCookie.html#setPortlist(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetPortlist(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setPortlist", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/HttpCookie.html#setSecure(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetSecure(bool arg0)
        {
            IExecuteWithSignature("setSecure", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/HttpCookie.html#setValue(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetValue(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setValue", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/HttpCookie.html#setVersion(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetVersion(int arg0)
        {
            IExecuteWithSignature("setVersion", "(I)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}