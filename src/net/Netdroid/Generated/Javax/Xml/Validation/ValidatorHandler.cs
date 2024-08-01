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

namespace Javax.Xml.Validation
{
    #region ValidatorHandler
    public partial class ValidatorHandler
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
        /// <see href="https://developer.android.com/reference/javax/xml/validation/ValidatorHandler.html#getTypeInfoProvider()"/>
        /// </summary>
        /// <returns><see cref="Javax.Xml.Validation.TypeInfoProvider"/></returns>
        public Javax.Xml.Validation.TypeInfoProvider GetTypeInfoProvider()
        {
            return IExecuteWithSignature<Javax.Xml.Validation.TypeInfoProvider>("getTypeInfoProvider", "()Ljavax/xml/validation/TypeInfoProvider;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/validation/ValidatorHandler.html#getResourceResolver()"/>
        /// </summary>
        /// <returns><see cref="Org.W3c.Dom.Ls.LSResourceResolver"/></returns>
        public Org.W3c.Dom.Ls.LSResourceResolver GetResourceResolver()
        {
            return IExecuteWithSignature<Org.W3c.Dom.Ls.LSResourceResolver>("getResourceResolver", "()Lorg/w3c/dom/ls/LSResourceResolver;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/validation/ValidatorHandler.html#getContentHandler()"/>
        /// </summary>
        /// <returns><see cref="Org.Xml.Sax.ContentHandler"/></returns>
        public Org.Xml.Sax.ContentHandler GetContentHandler()
        {
            return IExecuteWithSignature<Org.Xml.Sax.ContentHandler>("getContentHandler", "()Lorg/xml/sax/ContentHandler;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/validation/ValidatorHandler.html#getErrorHandler()"/>
        /// </summary>
        /// <returns><see cref="Org.Xml.Sax.ErrorHandler"/></returns>
        public Org.Xml.Sax.ErrorHandler GetErrorHandler()
        {
            return IExecuteWithSignature<Org.Xml.Sax.ErrorHandler>("getErrorHandler", "()Lorg/xml/sax/ErrorHandler;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/validation/ValidatorHandler.html#setContentHandler(org.xml.sax.ContentHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.ContentHandler"/></param>
        public void SetContentHandler(Org.Xml.Sax.ContentHandler arg0)
        {
            IExecuteWithSignature("setContentHandler", "(Lorg/xml/sax/ContentHandler;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/validation/ValidatorHandler.html#setErrorHandler(org.xml.sax.ErrorHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.ErrorHandler"/></param>
        public void SetErrorHandler(Org.Xml.Sax.ErrorHandler arg0)
        {
            IExecuteWithSignature("setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/validation/ValidatorHandler.html#setResourceResolver(org.w3c.dom.ls.LSResourceResolver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Ls.LSResourceResolver"/></param>
        public void SetResourceResolver(Org.W3c.Dom.Ls.LSResourceResolver arg0)
        {
            IExecuteWithSignature("setResourceResolver", "(Lorg/w3c/dom/ls/LSResourceResolver;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/validation/ValidatorHandler.html#getFeature(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Org.Xml.Sax.SAXNotRecognizedException"/>
        /// <exception cref="Org.Xml.Sax.SAXNotSupportedException"/>
        public bool GetFeature(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("getFeature", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/validation/ValidatorHandler.html#getProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Org.Xml.Sax.SAXNotRecognizedException"/>
        /// <exception cref="Org.Xml.Sax.SAXNotSupportedException"/>
        public object GetProperty(Java.Lang.String arg0)
        {
            return IExecuteWithSignature("getProperty", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/validation/ValidatorHandler.html#setFeature(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <exception cref="Org.Xml.Sax.SAXNotRecognizedException"/>
        /// <exception cref="Org.Xml.Sax.SAXNotSupportedException"/>
        public void SetFeature(Java.Lang.String arg0, bool arg1)
        {
            IExecute("setFeature", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/validation/ValidatorHandler.html#setProperty(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <exception cref="Org.Xml.Sax.SAXNotRecognizedException"/>
        /// <exception cref="Org.Xml.Sax.SAXNotSupportedException"/>
        public void SetProperty(Java.Lang.String arg0, object arg1)
        {
            IExecute("setProperty", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}