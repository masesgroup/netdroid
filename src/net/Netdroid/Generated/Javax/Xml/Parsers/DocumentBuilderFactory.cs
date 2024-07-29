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

namespace Javax.Xml.Parsers
{
    #region DocumentBuilderFactory
    public partial class DocumentBuilderFactory
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/parsers/DocumentBuilderFactory.html#newDefaultInstance()"/>
        /// </summary>
        /// <returns><see cref="Javax.Xml.Parsers.DocumentBuilderFactory"/></returns>
        public static Javax.Xml.Parsers.DocumentBuilderFactory NewDefaultInstance()
        {
            return SExecuteWithSignature<Javax.Xml.Parsers.DocumentBuilderFactory>(LocalBridgeClazz, "newDefaultInstance", "()Ljavax/xml/parsers/DocumentBuilderFactory;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/parsers/DocumentBuilderFactory.html#newDefaultNSInstance()"/>
        /// </summary>
        /// <returns><see cref="Javax.Xml.Parsers.DocumentBuilderFactory"/></returns>
        public static Javax.Xml.Parsers.DocumentBuilderFactory NewDefaultNSInstance()
        {
            return SExecuteWithSignature<Javax.Xml.Parsers.DocumentBuilderFactory>(LocalBridgeClazz, "newDefaultNSInstance", "()Ljavax/xml/parsers/DocumentBuilderFactory;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/parsers/DocumentBuilderFactory.html#newInstance()"/>
        /// </summary>
        /// <returns><see cref="Javax.Xml.Parsers.DocumentBuilderFactory"/></returns>
        public static Javax.Xml.Parsers.DocumentBuilderFactory NewInstance()
        {
            return SExecuteWithSignature<Javax.Xml.Parsers.DocumentBuilderFactory>(LocalBridgeClazz, "newInstance", "()Ljavax/xml/parsers/DocumentBuilderFactory;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/parsers/DocumentBuilderFactory.html#newInstance(java.lang.String,java.lang.ClassLoader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.ClassLoader"/></param>
        /// <returns><see cref="Javax.Xml.Parsers.DocumentBuilderFactory"/></returns>
        public static Javax.Xml.Parsers.DocumentBuilderFactory NewInstance(Java.Lang.String arg0, Java.Lang.ClassLoader arg1)
        {
            return SExecute<Javax.Xml.Parsers.DocumentBuilderFactory>(LocalBridgeClazz, "newInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/parsers/DocumentBuilderFactory.html#newNSInstance()"/>
        /// </summary>
        /// <returns><see cref="Javax.Xml.Parsers.DocumentBuilderFactory"/></returns>
        public static Javax.Xml.Parsers.DocumentBuilderFactory NewNSInstance()
        {
            return SExecuteWithSignature<Javax.Xml.Parsers.DocumentBuilderFactory>(LocalBridgeClazz, "newNSInstance", "()Ljavax/xml/parsers/DocumentBuilderFactory;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/parsers/DocumentBuilderFactory.html#newNSInstance(java.lang.String,java.lang.ClassLoader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.ClassLoader"/></param>
        /// <returns><see cref="Javax.Xml.Parsers.DocumentBuilderFactory"/></returns>
        public static Javax.Xml.Parsers.DocumentBuilderFactory NewNSInstance(Java.Lang.String arg0, Java.Lang.ClassLoader arg1)
        {
            return SExecute<Javax.Xml.Parsers.DocumentBuilderFactory>(LocalBridgeClazz, "newNSInstance", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/parsers/DocumentBuilderFactory.html#getFeature(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Javax.Xml.Parsers.ParserConfigurationException"/>
        public bool GetFeature(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("getFeature", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/parsers/DocumentBuilderFactory.html#getAttribute(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public object GetAttribute(Java.Lang.String arg0)
        {
            return IExecuteWithSignature("getAttribute", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/parsers/DocumentBuilderFactory.html#newDocumentBuilder()"/>
        /// </summary>
        /// <returns><see cref="Javax.Xml.Parsers.DocumentBuilder"/></returns>
        /// <exception cref="Javax.Xml.Parsers.ParserConfigurationException"/>
        public Javax.Xml.Parsers.DocumentBuilder NewDocumentBuilder()
        {
            return IExecuteWithSignature<Javax.Xml.Parsers.DocumentBuilder>("newDocumentBuilder", "()Ljavax/xml/parsers/DocumentBuilder;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/parsers/DocumentBuilderFactory.html#setAttribute(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public void SetAttribute(Java.Lang.String arg0, object arg1)
        {
            IExecute("setAttribute", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/parsers/DocumentBuilderFactory.html#setFeature(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <exception cref="Javax.Xml.Parsers.ParserConfigurationException"/>
        public void SetFeature(Java.Lang.String arg0, bool arg1)
        {
            IExecute("setFeature", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/parsers/DocumentBuilderFactory.html#isCoalescing()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsCoalescing()
        {
            return IExecuteWithSignature<bool>("isCoalescing", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/parsers/DocumentBuilderFactory.html#isExpandEntityReferences()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsExpandEntityReferences()
        {
            return IExecuteWithSignature<bool>("isExpandEntityReferences", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/parsers/DocumentBuilderFactory.html#isIgnoringComments()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsIgnoringComments()
        {
            return IExecuteWithSignature<bool>("isIgnoringComments", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/parsers/DocumentBuilderFactory.html#isIgnoringElementContentWhitespace()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsIgnoringElementContentWhitespace()
        {
            return IExecuteWithSignature<bool>("isIgnoringElementContentWhitespace", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/parsers/DocumentBuilderFactory.html#isNamespaceAware()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsNamespaceAware()
        {
            return IExecuteWithSignature<bool>("isNamespaceAware", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/parsers/DocumentBuilderFactory.html#isValidating()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsValidating()
        {
            return IExecuteWithSignature<bool>("isValidating", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/parsers/DocumentBuilderFactory.html#isXIncludeAware()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsXIncludeAware()
        {
            return IExecuteWithSignature<bool>("isXIncludeAware", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/parsers/DocumentBuilderFactory.html#getSchema()"/>
        /// </summary>
        /// <returns><see cref="Javax.Xml.Validation.Schema"/></returns>
        public Javax.Xml.Validation.Schema GetSchema()
        {
            return IExecuteWithSignature<Javax.Xml.Validation.Schema>("getSchema", "()Ljavax/xml/validation/Schema;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/parsers/DocumentBuilderFactory.html#setCoalescing(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetCoalescing(bool arg0)
        {
            IExecuteWithSignature("setCoalescing", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/parsers/DocumentBuilderFactory.html#setExpandEntityReferences(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetExpandEntityReferences(bool arg0)
        {
            IExecuteWithSignature("setExpandEntityReferences", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/parsers/DocumentBuilderFactory.html#setIgnoringComments(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetIgnoringComments(bool arg0)
        {
            IExecuteWithSignature("setIgnoringComments", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/parsers/DocumentBuilderFactory.html#setIgnoringElementContentWhitespace(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetIgnoringElementContentWhitespace(bool arg0)
        {
            IExecuteWithSignature("setIgnoringElementContentWhitespace", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/parsers/DocumentBuilderFactory.html#setNamespaceAware(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetNamespaceAware(bool arg0)
        {
            IExecuteWithSignature("setNamespaceAware", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/parsers/DocumentBuilderFactory.html#setSchema(javax.xml.validation.Schema)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Validation.Schema"/></param>
        public void SetSchema(Javax.Xml.Validation.Schema arg0)
        {
            IExecuteWithSignature("setSchema", "(Ljavax/xml/validation/Schema;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/parsers/DocumentBuilderFactory.html#setValidating(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetValidating(bool arg0)
        {
            IExecuteWithSignature("setValidating", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/parsers/DocumentBuilderFactory.html#setXIncludeAware(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetXIncludeAware(bool arg0)
        {
            IExecuteWithSignature("setXIncludeAware", "(Z)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}