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

namespace Org.Xml.Sax.Helpers
{
    #region DefaultHandler
    public partial class DefaultHandler : Org.Xml.Sax.IEntityResolver, Org.Xml.Sax.IDTDHandler, Org.Xml.Sax.IContentHandler, Org.Xml.Sax.IErrorHandler
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Xml.Sax.Helpers.DefaultHandler"/> to <see cref="Org.Xml.Sax.EntityResolver"/>
        /// </summary>
        public static implicit operator Org.Xml.Sax.EntityResolver(Org.Xml.Sax.Helpers.DefaultHandler t) => t.Cast<Org.Xml.Sax.EntityResolver>();
        /// <summary>
        /// Converter from <see cref="Org.Xml.Sax.Helpers.DefaultHandler"/> to <see cref="Org.Xml.Sax.DTDHandler"/>
        /// </summary>
        public static implicit operator Org.Xml.Sax.DTDHandler(Org.Xml.Sax.Helpers.DefaultHandler t) => t.Cast<Org.Xml.Sax.DTDHandler>();
        /// <summary>
        /// Converter from <see cref="Org.Xml.Sax.Helpers.DefaultHandler"/> to <see cref="Org.Xml.Sax.ContentHandler"/>
        /// </summary>
        public static implicit operator Org.Xml.Sax.ContentHandler(Org.Xml.Sax.Helpers.DefaultHandler t) => t.Cast<Org.Xml.Sax.ContentHandler>();
        /// <summary>
        /// Converter from <see cref="Org.Xml.Sax.Helpers.DefaultHandler"/> to <see cref="Org.Xml.Sax.ErrorHandler"/>
        /// </summary>
        public static implicit operator Org.Xml.Sax.ErrorHandler(Org.Xml.Sax.Helpers.DefaultHandler t) => t.Cast<Org.Xml.Sax.ErrorHandler>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xml/sax/helpers/DefaultHandler.html#resolveEntity(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Xml.Sax.InputSource"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public Org.Xml.Sax.InputSource ResolveEntity(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute<Org.Xml.Sax.InputSource>("resolveEntity", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xml/sax/helpers/DefaultHandler.html#characters(char[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public void Characters(char[] arg0, int arg1, int arg2)
        {
            IExecute("characters", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xml/sax/helpers/DefaultHandler.html#endDocument()"/>
        /// </summary>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public void EndDocument()
        {
            IExecuteWithSignature("endDocument", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xml/sax/helpers/DefaultHandler.html#endElement(java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public void EndElement(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2)
        {
            IExecute("endElement", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xml/sax/helpers/DefaultHandler.html#endPrefixMapping(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public void EndPrefixMapping(Java.Lang.String arg0)
        {
            IExecuteWithSignature("endPrefixMapping", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xml/sax/helpers/DefaultHandler.html#error(org.xml.sax.SAXParseException)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.SAXParseException"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public void Error(MASES.JCOBridge.C2JBridge.JVMBridgeException arg0)
        {
            IExecuteWithSignature("error", "(Lorg/xml/sax/SAXParseException;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xml/sax/helpers/DefaultHandler.html#fatalError(org.xml.sax.SAXParseException)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.SAXParseException"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public void FatalError(MASES.JCOBridge.C2JBridge.JVMBridgeException arg0)
        {
            IExecuteWithSignature("fatalError", "(Lorg/xml/sax/SAXParseException;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xml/sax/helpers/DefaultHandler.html#ignorableWhitespace(char[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public void IgnorableWhitespace(char[] arg0, int arg1, int arg2)
        {
            IExecute("ignorableWhitespace", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xml/sax/helpers/DefaultHandler.html#notationDecl(java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public void NotationDecl(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2)
        {
            IExecute("notationDecl", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xml/sax/helpers/DefaultHandler.html#processingInstruction(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public void ProcessingInstruction(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            IExecute("processingInstruction", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xml/sax/helpers/DefaultHandler.html#setDocumentLocator(org.xml.sax.Locator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.Locator"/></param>
        public void SetDocumentLocator(Org.Xml.Sax.Locator arg0)
        {
            IExecuteWithSignature("setDocumentLocator", "(Lorg/xml/sax/Locator;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xml/sax/helpers/DefaultHandler.html#skippedEntity(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public void SkippedEntity(Java.Lang.String arg0)
        {
            IExecuteWithSignature("skippedEntity", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xml/sax/helpers/DefaultHandler.html#startDocument()"/>
        /// </summary>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public void StartDocument()
        {
            IExecuteWithSignature("startDocument", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xml/sax/helpers/DefaultHandler.html#startElement(java.lang.String,java.lang.String,java.lang.String,org.xml.sax.Attributes)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Org.Xml.Sax.Attributes"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public void StartElement(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2, Org.Xml.Sax.Attributes arg3)
        {
            IExecute("startElement", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xml/sax/helpers/DefaultHandler.html#startPrefixMapping(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public void StartPrefixMapping(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            IExecute("startPrefixMapping", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xml/sax/helpers/DefaultHandler.html#unparsedEntityDecl(java.lang.String,java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public void UnparsedEntityDecl(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Lang.String arg3)
        {
            IExecute("unparsedEntityDecl", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/xml/sax/helpers/DefaultHandler.html#warning(org.xml.sax.SAXParseException)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.SAXParseException"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public void Warning(MASES.JCOBridge.C2JBridge.JVMBridgeException arg0)
        {
            IExecuteWithSignature("warning", "(Lorg/xml/sax/SAXParseException;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}