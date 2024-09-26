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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Xml.Validation
{
    #region SchemaFactory declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/javax/xml/validation/SchemaFactory.html"/>
    /// </summary>
    public partial class SchemaFactory : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SchemaFactory>
    {
        const string _bridgeClassName = "javax.xml.validation.SchemaFactory";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("SchemaFactory class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public SchemaFactory() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("SchemaFactory class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public SchemaFactory(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region SchemaFactory implementation
    public partial class SchemaFactory
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/validation/SchemaFactory.html#newDefaultInstance()"/>
        /// </summary>
        /// <returns><see cref="Javax.Xml.Validation.SchemaFactory"/></returns>
        public static Javax.Xml.Validation.SchemaFactory NewDefaultInstance()
        {
            return SExecuteWithSignature<Javax.Xml.Validation.SchemaFactory>(LocalBridgeClazz, "newDefaultInstance", "()Ljavax/xml/validation/SchemaFactory;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/validation/SchemaFactory.html#newInstance(java.lang.String,java.lang.String,java.lang.ClassLoader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.ClassLoader"/></param>
        /// <returns><see cref="Javax.Xml.Validation.SchemaFactory"/></returns>
        public static Javax.Xml.Validation.SchemaFactory NewInstance(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.ClassLoader arg2)
        {
            return SExecuteWithSignature<Javax.Xml.Validation.SchemaFactory>(LocalBridgeClazz, "newInstance", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/ClassLoader;)Ljavax/xml/validation/SchemaFactory;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/validation/SchemaFactory.html#newInstance(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Xml.Validation.SchemaFactory"/></returns>
        public static Javax.Xml.Validation.SchemaFactory NewInstance(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Javax.Xml.Validation.SchemaFactory>(LocalBridgeClazz, "newInstance", "(Ljava/lang/String;)Ljavax/xml/validation/SchemaFactory;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/validation/SchemaFactory.html#isSchemaLanguageSupported(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSchemaLanguageSupported(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("isSchemaLanguageSupported", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/validation/SchemaFactory.html#newSchema()"/>
        /// </summary>
        /// <returns><see cref="Javax.Xml.Validation.Schema"/></returns>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public Javax.Xml.Validation.Schema NewSchema()
        {
            return IExecuteWithSignature<Javax.Xml.Validation.Schema>("newSchema", "()Ljavax/xml/validation/Schema;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/validation/SchemaFactory.html#newSchema(javax.xml.transform.Source[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Transform.Source"/></param>
        /// <returns><see cref="Javax.Xml.Validation.Schema"/></returns>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public Javax.Xml.Validation.Schema NewSchema(Javax.Xml.Transform.Source[] arg0)
        {
            return IExecuteWithSignature<Javax.Xml.Validation.Schema>("newSchema", "([Ljavax/xml/transform/Source;)Ljavax/xml/validation/Schema;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/validation/SchemaFactory.html#getResourceResolver()"/>
        /// </summary>
        /// <returns><see cref="Org.W3c.Dom.Ls.LSResourceResolver"/></returns>
        public Org.W3c.Dom.Ls.LSResourceResolver GetResourceResolver()
        {
            return IExecuteWithSignature<Org.W3c.Dom.Ls.LSResourceResolver>("getResourceResolver", "()Lorg/w3c/dom/ls/LSResourceResolver;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/validation/SchemaFactory.html#getErrorHandler()"/>
        /// </summary>
        /// <returns><see cref="Org.Xml.Sax.ErrorHandler"/></returns>
        public Org.Xml.Sax.ErrorHandler GetErrorHandler()
        {
            return IExecuteWithSignature<Org.Xml.Sax.ErrorHandler>("getErrorHandler", "()Lorg/xml/sax/ErrorHandler;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/validation/SchemaFactory.html#setErrorHandler(org.xml.sax.ErrorHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.ErrorHandler"/></param>
        public void SetErrorHandler(Org.Xml.Sax.ErrorHandler arg0)
        {
            IExecuteWithSignature("setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/validation/SchemaFactory.html#setResourceResolver(org.w3c.dom.ls.LSResourceResolver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Ls.LSResourceResolver"/></param>
        public void SetResourceResolver(Org.W3c.Dom.Ls.LSResourceResolver arg0)
        {
            IExecuteWithSignature("setResourceResolver", "(Lorg/w3c/dom/ls/LSResourceResolver;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/validation/SchemaFactory.html#getFeature(java.lang.String)"/>
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
        /// <see href="https://developer.android.com/reference/javax/xml/validation/SchemaFactory.html#getProperty(java.lang.String)"/>
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
        /// <see href="https://developer.android.com/reference/javax/xml/validation/SchemaFactory.html#newSchema(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="Javax.Xml.Validation.Schema"/></returns>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public Javax.Xml.Validation.Schema NewSchema(Java.Io.File arg0)
        {
            return IExecuteWithSignature<Javax.Xml.Validation.Schema>("newSchema", "(Ljava/io/File;)Ljavax/xml/validation/Schema;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/validation/SchemaFactory.html#newSchema(java.net.URL)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        /// <returns><see cref="Javax.Xml.Validation.Schema"/></returns>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public Javax.Xml.Validation.Schema NewSchema(Java.Net.URL arg0)
        {
            return IExecuteWithSignature<Javax.Xml.Validation.Schema>("newSchema", "(Ljava/net/URL;)Ljavax/xml/validation/Schema;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/validation/SchemaFactory.html#newSchema(javax.xml.transform.Source)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Transform.Source"/></param>
        /// <returns><see cref="Javax.Xml.Validation.Schema"/></returns>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public Javax.Xml.Validation.Schema NewSchema(Javax.Xml.Transform.Source arg0)
        {
            return IExecuteWithSignature<Javax.Xml.Validation.Schema>("newSchema", "(Ljavax/xml/transform/Source;)Ljavax/xml/validation/Schema;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/validation/SchemaFactory.html#setFeature(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <exception cref="Org.Xml.Sax.SAXNotRecognizedException"/>
        /// <exception cref="Org.Xml.Sax.SAXNotSupportedException"/>
        public void SetFeature(Java.Lang.String arg0, bool arg1)
        {
            IExecuteWithSignature("setFeature", "(Ljava/lang/String;Z)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/validation/SchemaFactory.html#setProperty(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <exception cref="Org.Xml.Sax.SAXNotRecognizedException"/>
        /// <exception cref="Org.Xml.Sax.SAXNotSupportedException"/>
        public void SetProperty(Java.Lang.String arg0, object arg1)
        {
            IExecuteWithSignature("setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}