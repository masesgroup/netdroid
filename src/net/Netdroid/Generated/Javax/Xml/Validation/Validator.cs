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

namespace Javax.Xml.Validation
{
    #region Validator
    public partial class Validator
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
        /// <see href="https://developer.android.com/reference/java.xml/javax/xml/validation/Validator.html#getErrorHandler()"/> <see href="https://developer.android.com/reference/java.xml/javax/xml/validation/Validator.html#setErrorHandler(org.xml.sax.ErrorHandler)"/>
        /// </summary>
        public Org.Xml.Sax.ErrorHandler ErrorHandler
        {
            get { return IExecuteWithSignature<Org.Xml.Sax.ErrorHandler>("getErrorHandler", "()Lorg/xml/sax/ErrorHandler;"); } set { IExecuteWithSignature("setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/javax/xml/validation/Validator.html#getResourceResolver()"/> <see href="https://developer.android.com/reference/java.xml/javax/xml/validation/Validator.html#setResourceResolver(org.w3c.dom.ls.LSResourceResolver)"/>
        /// </summary>
        public Org.W3c.Dom.Ls.LSResourceResolver ResourceResolver
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.Ls.LSResourceResolver>("getResourceResolver", "()Lorg/w3c/dom/ls/LSResourceResolver;"); } set { IExecuteWithSignature("setResourceResolver", "(Lorg/w3c/dom/ls/LSResourceResolver;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/javax/xml/validation/Validator.html#reset()"/>
        /// </summary>
        public void Reset()
        {
            IExecuteWithSignature("reset", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/javax/xml/validation/Validator.html#validate(javax.xml.transform.Source,javax.xml.transform.Result)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Transform.Source"/></param>
        /// <param name="arg1"><see cref="Javax.Xml.Transform.Result"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        /// <exception cref="Java.Io.IOException"/>
        public void Validate(Javax.Xml.Transform.Source arg0, Javax.Xml.Transform.Result arg1)
        {
            IExecute("validate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/javax/xml/validation/Validator.html#getFeature(java.lang.String)"/>
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
        /// <see href="https://developer.android.com/reference/java.xml/javax/xml/validation/Validator.html#getProperty(java.lang.String)"/>
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
        /// <see href="https://developer.android.com/reference/java.xml/javax/xml/validation/Validator.html#setFeature(java.lang.String,boolean)"/>
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
        /// <see href="https://developer.android.com/reference/java.xml/javax/xml/validation/Validator.html#setProperty(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <exception cref="Org.Xml.Sax.SAXNotRecognizedException"/>
        /// <exception cref="Org.Xml.Sax.SAXNotSupportedException"/>
        public void SetProperty(Java.Lang.String arg0, object arg1)
        {
            IExecute("setProperty", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/javax/xml/validation/Validator.html#validate(javax.xml.transform.Source)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Transform.Source"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        /// <exception cref="Java.Io.IOException"/>
        public void Validate(Javax.Xml.Transform.Source arg0)
        {
            IExecuteWithSignature("validate", "(Ljavax/xml/transform/Source;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}