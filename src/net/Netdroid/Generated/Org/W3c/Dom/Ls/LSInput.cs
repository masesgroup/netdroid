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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.W3c.Dom.Ls
{
    #region ILSInput
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ILSInput
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region LSInput
    public partial class LSInput : Org.W3c.Dom.Ls.ILSInput
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/w3c/dom/ls/LSInput.html#getCertifiedText()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetCertifiedText()
        {
            return IExecuteWithSignature<bool>("getCertifiedText", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/w3c/dom/ls/LSInput.html#getByteStream()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.InputStream"/></returns>
        public Java.Io.InputStream GetByteStream()
        {
            return IExecuteWithSignature<Java.Io.InputStream>("getByteStream", "()Ljava/io/InputStream;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/w3c/dom/ls/LSInput.html#getCharacterStream()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.Reader"/></returns>
        public Java.Io.Reader GetCharacterStream()
        {
            return IExecuteWithSignature<Java.Io.Reader>("getCharacterStream", "()Ljava/io/Reader;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/w3c/dom/ls/LSInput.html#getBaseURI()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetBaseURI()
        {
            return IExecuteWithSignature<Java.Lang.String>("getBaseURI", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/w3c/dom/ls/LSInput.html#getEncoding()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetEncoding()
        {
            return IExecuteWithSignature<Java.Lang.String>("getEncoding", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/w3c/dom/ls/LSInput.html#getPublicId()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetPublicId()
        {
            return IExecuteWithSignature<Java.Lang.String>("getPublicId", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/w3c/dom/ls/LSInput.html#getStringData()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetStringData()
        {
            return IExecuteWithSignature<Java.Lang.String>("getStringData", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/w3c/dom/ls/LSInput.html#getSystemId()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetSystemId()
        {
            return IExecuteWithSignature<Java.Lang.String>("getSystemId", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/w3c/dom/ls/LSInput.html#setBaseURI(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetBaseURI(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setBaseURI", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/w3c/dom/ls/LSInput.html#setByteStream(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        public void SetByteStream(Java.Io.InputStream arg0)
        {
            IExecuteWithSignature("setByteStream", "(Ljava/io/InputStream;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/w3c/dom/ls/LSInput.html#setCertifiedText(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetCertifiedText(bool arg0)
        {
            IExecuteWithSignature("setCertifiedText", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/w3c/dom/ls/LSInput.html#setCharacterStream(java.io.Reader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.Reader"/></param>
        public void SetCharacterStream(Java.Io.Reader arg0)
        {
            IExecuteWithSignature("setCharacterStream", "(Ljava/io/Reader;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/w3c/dom/ls/LSInput.html#setEncoding(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetEncoding(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setEncoding", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/w3c/dom/ls/LSInput.html#setPublicId(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetPublicId(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setPublicId", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/w3c/dom/ls/LSInput.html#setStringData(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetStringData(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setStringData", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/w3c/dom/ls/LSInput.html#setSystemId(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetSystemId(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setSystemId", "(Ljava/lang/String;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}