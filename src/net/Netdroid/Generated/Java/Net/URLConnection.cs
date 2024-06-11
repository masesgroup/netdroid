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

namespace Java.Net
{
    #region URLConnection
    public partial class URLConnection
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLConnection.html#getDefaultAllowUserInteraction()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public static bool GetDefaultAllowUserInteraction()
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "getDefaultAllowUserInteraction", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLConnection.html#getDefaultUseCaches(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool GetDefaultUseCaches(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "getDefaultUseCaches", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLConnection.html#getDefaultRequestProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        [global::System.Obsolete()]
        public static Java.Lang.String GetDefaultRequestProperty(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "getDefaultRequestProperty", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLConnection.html#guessContentTypeFromName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String GuessContentTypeFromName(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "guessContentTypeFromName", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLConnection.html#guessContentTypeFromStream(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Lang.String GuessContentTypeFromStream(Java.Io.InputStream arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "guessContentTypeFromStream", "(Ljava/io/InputStream;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLConnection.html#getFileNameMap()"/>
        /// </summary>
        /// <returns><see cref="Java.Net.FileNameMap"/></returns>
        public static Java.Net.FileNameMap GetFileNameMap()
        {
            return SExecuteWithSignature<Java.Net.FileNameMap>(LocalBridgeClazz, "getFileNameMap", "()Ljava/net/FileNameMap;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLConnection.html#setContentHandlerFactory(java.net.ContentHandlerFactory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.ContentHandlerFactory"/></param>
        public static void SetContentHandlerFactory(Java.Net.ContentHandlerFactory arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "setContentHandlerFactory", "(Ljava/net/ContentHandlerFactory;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLConnection.html#setDefaultAllowUserInteraction(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public static void SetDefaultAllowUserInteraction(bool arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "setDefaultAllowUserInteraction", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLConnection.html#setDefaultRequestProperty(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        [global::System.Obsolete()]
        public static void SetDefaultRequestProperty(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            SExecute(LocalBridgeClazz, "setDefaultRequestProperty", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLConnection.html#setDefaultUseCaches(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public static void SetDefaultUseCaches(Java.Lang.String arg0, bool arg1)
        {
            SExecute(LocalBridgeClazz, "setDefaultUseCaches", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLConnection.html#setFileNameMap(java.net.FileNameMap)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.FileNameMap"/></param>
        public static void SetFileNameMap(Java.Net.FileNameMap arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "setFileNameMap", "(Ljava/net/FileNameMap;)V", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLConnection.html#connect()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Connect()
        {
            IExecuteWithSignature("connect", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLConnection.html#getAllowUserInteraction()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetAllowUserInteraction()
        {
            return IExecuteWithSignature<bool>("getAllowUserInteraction", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLConnection.html#getDefaultUseCaches()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetDefaultUseCaches()
        {
            return IExecuteWithSignature<bool>("getDefaultUseCaches", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLConnection.html#getDoInput()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetDoInput()
        {
            return IExecuteWithSignature<bool>("getDoInput", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLConnection.html#getDoOutput()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetDoOutput()
        {
            return IExecuteWithSignature<bool>("getDoOutput", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLConnection.html#getUseCaches()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetUseCaches()
        {
            return IExecuteWithSignature<bool>("getUseCaches", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLConnection.html#getConnectTimeout()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetConnectTimeout()
        {
            return IExecuteWithSignature<int>("getConnectTimeout", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLConnection.html#getContentLength()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetContentLength()
        {
            return IExecuteWithSignature<int>("getContentLength", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLConnection.html#getHeaderFieldInt(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetHeaderFieldInt(Java.Lang.String arg0, int arg1)
        {
            return IExecute<int>("getHeaderFieldInt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLConnection.html#getReadTimeout()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetReadTimeout()
        {
            return IExecuteWithSignature<int>("getReadTimeout", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLConnection.html#getInputStream()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.InputStream"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Io.InputStream GetInputStream()
        {
            return IExecuteWithSignature<Java.Io.InputStream>("getInputStream", "()Ljava/io/InputStream;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLConnection.html#getOutputStream()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.OutputStream"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Io.OutputStream GetOutputStream()
        {
            return IExecuteWithSignature<Java.Io.OutputStream>("getOutputStream", "()Ljava/io/OutputStream;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLConnection.html#getContent()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public object GetContent()
        {
            return IExecuteWithSignature("getContent", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLConnection.html#getContent(java.lang.Class[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public object GetContent(Java.Lang.Class[] arg0)
        {
            return IExecuteWithSignature("getContent", "([Ljava/lang/Class;)Ljava/lang/Object;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLConnection.html#getContentEncoding()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetContentEncoding()
        {
            return IExecuteWithSignature<Java.Lang.String>("getContentEncoding", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLConnection.html#getContentType()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetContentType()
        {
            return IExecuteWithSignature<Java.Lang.String>("getContentType", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLConnection.html#getHeaderField(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetHeaderField(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getHeaderField", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLConnection.html#getHeaderField(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetHeaderField(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getHeaderField", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLConnection.html#getHeaderFieldKey(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetHeaderFieldKey(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getHeaderFieldKey", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLConnection.html#getRequestProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetRequestProperty(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getRequestProperty", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLConnection.html#getURL()"/>
        /// </summary>
        /// <returns><see cref="Java.Net.URL"/></returns>
        public Java.Net.URL GetURL()
        {
            return IExecuteWithSignature<Java.Net.URL>("getURL", "()Ljava/net/URL;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLConnection.html#getPermission()"/>
        /// </summary>
        /// <returns><see cref="Java.Security.Permission"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Security.Permission GetPermission()
        {
            return IExecuteWithSignature<Java.Security.Permission>("getPermission", "()Ljava/security/Permission;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLConnection.html#getHeaderFields()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.String, Java.Util.List<Java.Lang.String>> GetHeaderFields()
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, Java.Util.List<Java.Lang.String>>>("getHeaderFields", "()Ljava/util/Map;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLConnection.html#getRequestProperties()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.String, Java.Util.List<Java.Lang.String>> GetRequestProperties()
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, Java.Util.List<Java.Lang.String>>>("getRequestProperties", "()Ljava/util/Map;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLConnection.html#getContentLengthLong()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetContentLengthLong()
        {
            return IExecuteWithSignature<long>("getContentLengthLong", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLConnection.html#getDate()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetDate()
        {
            return IExecuteWithSignature<long>("getDate", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLConnection.html#getExpiration()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetExpiration()
        {
            return IExecuteWithSignature<long>("getExpiration", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLConnection.html#getHeaderFieldDate(java.lang.String,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetHeaderFieldDate(Java.Lang.String arg0, long arg1)
        {
            return IExecute<long>("getHeaderFieldDate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLConnection.html#getHeaderFieldLong(java.lang.String,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetHeaderFieldLong(Java.Lang.String arg0, long arg1)
        {
            return IExecute<long>("getHeaderFieldLong", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLConnection.html#getIfModifiedSince()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetIfModifiedSince()
        {
            return IExecuteWithSignature<long>("getIfModifiedSince", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLConnection.html#getLastModified()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetLastModified()
        {
            return IExecuteWithSignature<long>("getLastModified", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLConnection.html#addRequestProperty(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void AddRequestProperty(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            IExecute("addRequestProperty", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLConnection.html#setAllowUserInteraction(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetAllowUserInteraction(bool arg0)
        {
            IExecuteWithSignature("setAllowUserInteraction", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLConnection.html#setConnectTimeout(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetConnectTimeout(int arg0)
        {
            IExecuteWithSignature("setConnectTimeout", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLConnection.html#setDefaultUseCaches(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetDefaultUseCaches(bool arg0)
        {
            IExecuteWithSignature("setDefaultUseCaches", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLConnection.html#setDoInput(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetDoInput(bool arg0)
        {
            IExecuteWithSignature("setDoInput", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLConnection.html#setDoOutput(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetDoOutput(bool arg0)
        {
            IExecuteWithSignature("setDoOutput", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLConnection.html#setIfModifiedSince(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void SetIfModifiedSince(long arg0)
        {
            IExecuteWithSignature("setIfModifiedSince", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLConnection.html#setReadTimeout(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetReadTimeout(int arg0)
        {
            IExecuteWithSignature("setReadTimeout", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLConnection.html#setRequestProperty(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void SetRequestProperty(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            IExecute("setRequestProperty", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/net/URLConnection.html#setUseCaches(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetUseCaches(bool arg0)
        {
            IExecuteWithSignature("setUseCaches", "(Z)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}