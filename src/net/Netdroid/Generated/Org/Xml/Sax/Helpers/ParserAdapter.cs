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

namespace Org.Xml.Sax.Helpers
{
    #region ParserAdapter
    public partial class ParserAdapter : Org.Xml.Sax.IXMLReader, Org.Xml.Sax.IDocumentHandler
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
        /// Handlers initializer for <see cref="ParserAdapter"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("getFeature", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Lang.String>>>(GetFeatureEventHandler));
            AddEventHandler("getProperty", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Lang.String>>>(GetPropertyEventHandler));
            AddEventHandler("getContentHandler", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(GetContentHandlerEventHandler));
            AddEventHandler("getDTDHandler", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(GetDTDHandlerEventHandler));
            AddEventHandler("getEntityResolver", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(GetEntityResolverEventHandler));
            AddEventHandler("getErrorHandler", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(GetErrorHandlerEventHandler));
            AddEventHandler("characters", new System.EventHandler<CLRListenerEventArgs<CLREventData<char[]>>>(CharactersEventHandler));
            AddEventHandler("endDocument", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(EndDocumentEventHandler));
            AddEventHandler("endElement", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Lang.String>>>(EndElementEventHandler));
            AddEventHandler("ignorableWhitespace", new System.EventHandler<CLRListenerEventArgs<CLREventData<char[]>>>(IgnorableWhitespaceEventHandler));
            AddEventHandler("parse", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Lang.String>>>(ParseEventHandler));
            AddEventHandler("parse1", new System.EventHandler<CLRListenerEventArgs<CLREventData<Org.Xml.Sax.InputSource>>>(Parse1EventHandler));
            AddEventHandler("processingInstruction", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Lang.String>>>(ProcessingInstructionEventHandler));
            AddEventHandler("setContentHandler", new System.EventHandler<CLRListenerEventArgs<CLREventData<Org.Xml.Sax.ContentHandler>>>(SetContentHandlerEventHandler));
            AddEventHandler("setDocumentLocator", new System.EventHandler<CLRListenerEventArgs<CLREventData<Org.Xml.Sax.Locator>>>(SetDocumentLocatorEventHandler));
            AddEventHandler("setDTDHandler", new System.EventHandler<CLRListenerEventArgs<CLREventData<Org.Xml.Sax.DTDHandler>>>(SetDTDHandlerEventHandler));
            AddEventHandler("setEntityResolver", new System.EventHandler<CLRListenerEventArgs<CLREventData<Org.Xml.Sax.EntityResolver>>>(SetEntityResolverEventHandler));
            AddEventHandler("setErrorHandler", new System.EventHandler<CLRListenerEventArgs<CLREventData<Org.Xml.Sax.ErrorHandler>>>(SetErrorHandlerEventHandler));
            AddEventHandler("setFeature", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Lang.String>>>(SetFeatureEventHandler));
            AddEventHandler("setProperty", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Lang.String>>>(SetPropertyEventHandler));
            AddEventHandler("startDocument", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(StartDocumentEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#getFeature(java.lang.String)"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetFeature"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<Java.Lang.String, bool> OnGetFeature { get; set; } = null;

        void GetFeatureEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Lang.String>> data)
        {
            var methodToExecute = (OnGetFeature != null) ? OnGetFeature : GetFeature;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#getFeature(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Org.Xml.Sax.SAXNotRecognizedException"/>
        /// <exception cref="Org.Xml.Sax.SAXNotSupportedException"/>
        public virtual bool GetFeature(Java.Lang.String arg0)
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#getProperty(java.lang.String)"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetProperty"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<Java.Lang.String, object> OnGetProperty { get; set; } = null;

        void GetPropertyEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Lang.String>> data)
        {
            var methodToExecute = (OnGetProperty != null) ? OnGetProperty : GetProperty;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#getProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Org.Xml.Sax.SAXNotRecognizedException"/>
        /// <exception cref="Org.Xml.Sax.SAXNotSupportedException"/>
        public virtual object GetProperty(Java.Lang.String arg0)
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#getContentHandler()"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetContentHandler"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<Org.Xml.Sax.ContentHandler> OnGetContentHandler { get; set; } = null;

        void GetContentHandlerEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnGetContentHandler != null) ? OnGetContentHandler : GetContentHandler;
            var executionResult = methodToExecute.Invoke();
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#getContentHandler()"/>
        /// </summary>
        /// <returns><see cref="Org.Xml.Sax.ContentHandler"/></returns>
        public virtual Org.Xml.Sax.ContentHandler GetContentHandler()
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#getDTDHandler()"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetDTDHandler"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<Org.Xml.Sax.DTDHandler> OnGetDTDHandler { get; set; } = null;

        void GetDTDHandlerEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnGetDTDHandler != null) ? OnGetDTDHandler : GetDTDHandler;
            var executionResult = methodToExecute.Invoke();
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#getDTDHandler()"/>
        /// </summary>
        /// <returns><see cref="Org.Xml.Sax.DTDHandler"/></returns>
        public virtual Org.Xml.Sax.DTDHandler GetDTDHandler()
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#getEntityResolver()"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetEntityResolver"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<Org.Xml.Sax.EntityResolver> OnGetEntityResolver { get; set; } = null;

        void GetEntityResolverEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnGetEntityResolver != null) ? OnGetEntityResolver : GetEntityResolver;
            var executionResult = methodToExecute.Invoke();
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#getEntityResolver()"/>
        /// </summary>
        /// <returns><see cref="Org.Xml.Sax.EntityResolver"/></returns>
        public virtual Org.Xml.Sax.EntityResolver GetEntityResolver()
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#getErrorHandler()"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetErrorHandler"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<Org.Xml.Sax.ErrorHandler> OnGetErrorHandler { get; set; } = null;

        void GetErrorHandlerEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnGetErrorHandler != null) ? OnGetErrorHandler : GetErrorHandler;
            var executionResult = methodToExecute.Invoke();
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#getErrorHandler()"/>
        /// </summary>
        /// <returns><see cref="Org.Xml.Sax.ErrorHandler"/></returns>
        public virtual Org.Xml.Sax.ErrorHandler GetErrorHandler()
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#characters(char[],int,int)"/>
        /// </summary>
        /// <remarks>If <see cref="OnCharacters"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<char[], int, int> OnCharacters { get; set; } = null;

        void CharactersEventHandler(object sender, CLRListenerEventArgs<CLREventData<char[]>> data)
        {
            var methodToExecute = (OnCharacters != null) ? OnCharacters : Characters;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<int>(0), data.EventData.GetAt<int>(1));
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#characters(char[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public virtual void Characters(char[] arg0, int arg1, int arg2)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#endDocument()"/>
        /// </summary>
        /// <remarks>If <see cref="OnEndDocument"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action OnEndDocument { get; set; } = null;

        void EndDocumentEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnEndDocument != null) ? OnEndDocument : EndDocument;
            methodToExecute.Invoke();
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#endDocument()"/>
        /// </summary>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public virtual void EndDocument()
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#endElement(java.lang.String)"/>
        /// </summary>
        /// <remarks>If <see cref="OnEndElement"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Java.Lang.String> OnEndElement { get; set; } = null;

        void EndElementEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Lang.String>> data)
        {
            var methodToExecute = (OnEndElement != null) ? OnEndElement : EndElement;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#endElement(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public virtual void EndElement(Java.Lang.String arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#ignorableWhitespace(char[],int,int)"/>
        /// </summary>
        /// <remarks>If <see cref="OnIgnorableWhitespace"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<char[], int, int> OnIgnorableWhitespace { get; set; } = null;

        void IgnorableWhitespaceEventHandler(object sender, CLRListenerEventArgs<CLREventData<char[]>> data)
        {
            var methodToExecute = (OnIgnorableWhitespace != null) ? OnIgnorableWhitespace : IgnorableWhitespace;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<int>(0), data.EventData.GetAt<int>(1));
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#ignorableWhitespace(char[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public virtual void IgnorableWhitespace(char[] arg0, int arg1, int arg2)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#parse(java.lang.String)"/>
        /// </summary>
        /// <remarks>If <see cref="OnParse"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Java.Lang.String> OnParse { get; set; } = null;

        void ParseEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Lang.String>> data)
        {
            var methodToExecute = (OnParse != null) ? OnParse : Parse;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#parse(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public virtual void Parse(Java.Lang.String arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#parse(org.xml.sax.InputSource)"/>
        /// </summary>
        /// <remarks>If <see cref="OnParse1"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Org.Xml.Sax.InputSource> OnParse1 { get; set; } = null;

        void Parse1EventHandler(object sender, CLRListenerEventArgs<CLREventData<Org.Xml.Sax.InputSource>> data)
        {
            var methodToExecute = (OnParse1 != null) ? OnParse1 : Parse;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#parse(org.xml.sax.InputSource)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.InputSource"/></param>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public virtual void Parse(Org.Xml.Sax.InputSource arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#processingInstruction(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <remarks>If <see cref="OnProcessingInstruction"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Java.Lang.String, Java.Lang.String> OnProcessingInstruction { get; set; } = null;

        void ProcessingInstructionEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Lang.String>> data)
        {
            var methodToExecute = (OnProcessingInstruction != null) ? OnProcessingInstruction : ProcessingInstruction;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Java.Lang.String>(0));
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#processingInstruction(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public virtual void ProcessingInstruction(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#setContentHandler(org.xml.sax.ContentHandler)"/>
        /// </summary>
        /// <remarks>If <see cref="OnSetContentHandler"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Org.Xml.Sax.ContentHandler> OnSetContentHandler { get; set; } = null;

        void SetContentHandlerEventHandler(object sender, CLRListenerEventArgs<CLREventData<Org.Xml.Sax.ContentHandler>> data)
        {
            var methodToExecute = (OnSetContentHandler != null) ? OnSetContentHandler : SetContentHandler;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#setContentHandler(org.xml.sax.ContentHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.ContentHandler"/></param>
        public virtual void SetContentHandler(Org.Xml.Sax.ContentHandler arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#setDocumentLocator(org.xml.sax.Locator)"/>
        /// </summary>
        /// <remarks>If <see cref="OnSetDocumentLocator"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Org.Xml.Sax.Locator> OnSetDocumentLocator { get; set; } = null;

        void SetDocumentLocatorEventHandler(object sender, CLRListenerEventArgs<CLREventData<Org.Xml.Sax.Locator>> data)
        {
            var methodToExecute = (OnSetDocumentLocator != null) ? OnSetDocumentLocator : SetDocumentLocator;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#setDocumentLocator(org.xml.sax.Locator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.Locator"/></param>
        public virtual void SetDocumentLocator(Org.Xml.Sax.Locator arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#setDTDHandler(org.xml.sax.DTDHandler)"/>
        /// </summary>
        /// <remarks>If <see cref="OnSetDTDHandler"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Org.Xml.Sax.DTDHandler> OnSetDTDHandler { get; set; } = null;

        void SetDTDHandlerEventHandler(object sender, CLRListenerEventArgs<CLREventData<Org.Xml.Sax.DTDHandler>> data)
        {
            var methodToExecute = (OnSetDTDHandler != null) ? OnSetDTDHandler : SetDTDHandler;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#setDTDHandler(org.xml.sax.DTDHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.DTDHandler"/></param>
        public virtual void SetDTDHandler(Org.Xml.Sax.DTDHandler arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#setEntityResolver(org.xml.sax.EntityResolver)"/>
        /// </summary>
        /// <remarks>If <see cref="OnSetEntityResolver"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Org.Xml.Sax.EntityResolver> OnSetEntityResolver { get; set; } = null;

        void SetEntityResolverEventHandler(object sender, CLRListenerEventArgs<CLREventData<Org.Xml.Sax.EntityResolver>> data)
        {
            var methodToExecute = (OnSetEntityResolver != null) ? OnSetEntityResolver : SetEntityResolver;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#setEntityResolver(org.xml.sax.EntityResolver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.EntityResolver"/></param>
        public virtual void SetEntityResolver(Org.Xml.Sax.EntityResolver arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#setErrorHandler(org.xml.sax.ErrorHandler)"/>
        /// </summary>
        /// <remarks>If <see cref="OnSetErrorHandler"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Org.Xml.Sax.ErrorHandler> OnSetErrorHandler { get; set; } = null;

        void SetErrorHandlerEventHandler(object sender, CLRListenerEventArgs<CLREventData<Org.Xml.Sax.ErrorHandler>> data)
        {
            var methodToExecute = (OnSetErrorHandler != null) ? OnSetErrorHandler : SetErrorHandler;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#setErrorHandler(org.xml.sax.ErrorHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.ErrorHandler"/></param>
        public virtual void SetErrorHandler(Org.Xml.Sax.ErrorHandler arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#setFeature(java.lang.String,boolean)"/>
        /// </summary>
        /// <remarks>If <see cref="OnSetFeature"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Java.Lang.String, bool> OnSetFeature { get; set; } = null;

        void SetFeatureEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Lang.String>> data)
        {
            var methodToExecute = (OnSetFeature != null) ? OnSetFeature : SetFeature;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<bool>(0));
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#setFeature(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <exception cref="Org.Xml.Sax.SAXNotRecognizedException"/>
        /// <exception cref="Org.Xml.Sax.SAXNotSupportedException"/>
        public virtual void SetFeature(Java.Lang.String arg0, bool arg1)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#setProperty(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <remarks>If <see cref="OnSetProperty"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Java.Lang.String, object> OnSetProperty { get; set; } = null;

        void SetPropertyEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Lang.String>> data)
        {
            var methodToExecute = (OnSetProperty != null) ? OnSetProperty : SetProperty;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<object>(0));
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#setProperty(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <exception cref="Org.Xml.Sax.SAXNotRecognizedException"/>
        /// <exception cref="Org.Xml.Sax.SAXNotSupportedException"/>
        public virtual void SetProperty(Java.Lang.String arg0, object arg1)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#startDocument()"/>
        /// </summary>
        /// <remarks>If <see cref="OnStartDocument"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action OnStartDocument { get; set; } = null;

        void StartDocumentEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnStartDocument != null) ? OnStartDocument : StartDocument;
            methodToExecute.Invoke();
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#startDocument()"/>
        /// </summary>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public virtual void StartDocument()
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ParserAdapterDirect
    public partial class ParserAdapterDirect : Org.Xml.Sax.IXMLReader, Org.Xml.Sax.IDocumentHandler
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
        /// <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#getContentHandler()"/> <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#setContentHandler(org.xml.sax.ContentHandler)"/>
        /// </summary>
        public Org.Xml.Sax.ContentHandler ContentHandler
        {
            get { return IExecuteWithSignature<Org.Xml.Sax.ContentHandler>("getContentHandler", "()Lorg/xml/sax/ContentHandler;"); } set { IExecuteWithSignature("setContentHandler", "(Lorg/xml/sax/ContentHandler;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#getDTDHandler()"/> <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#setDTDHandler(org.xml.sax.DTDHandler)"/>
        /// </summary>
        public Org.Xml.Sax.DTDHandler DTDHandler
        {
            get { return IExecuteWithSignature<Org.Xml.Sax.DTDHandler>("getDTDHandler", "()Lorg/xml/sax/DTDHandler;"); } set { IExecuteWithSignature("setDTDHandler", "(Lorg/xml/sax/DTDHandler;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#getEntityResolver()"/> <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#setEntityResolver(org.xml.sax.EntityResolver)"/>
        /// </summary>
        public Org.Xml.Sax.EntityResolver EntityResolver
        {
            get { return IExecuteWithSignature<Org.Xml.Sax.EntityResolver>("getEntityResolver", "()Lorg/xml/sax/EntityResolver;"); } set { IExecuteWithSignature("setEntityResolver", "(Lorg/xml/sax/EntityResolver;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#getErrorHandler()"/> <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#setErrorHandler(org.xml.sax.ErrorHandler)"/>
        /// </summary>
        public Org.Xml.Sax.ErrorHandler ErrorHandler
        {
            get { return IExecuteWithSignature<Org.Xml.Sax.ErrorHandler>("getErrorHandler", "()Lorg/xml/sax/ErrorHandler;"); } set { IExecuteWithSignature("setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#getFeature(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Org.Xml.Sax.SAXNotRecognizedException"/>
        /// <exception cref="Org.Xml.Sax.SAXNotSupportedException"/>
        public override bool GetFeature(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("getFeature", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#getProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Org.Xml.Sax.SAXNotRecognizedException"/>
        /// <exception cref="Org.Xml.Sax.SAXNotSupportedException"/>
        public override object GetProperty(Java.Lang.String arg0)
        {
            return IExecuteWithSignature("getProperty", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#characters(char[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public override void Characters(char[] arg0, int arg1, int arg2)
        {
            IExecute("characters", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#endDocument()"/>
        /// </summary>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public override void EndDocument()
        {
            IExecuteWithSignature("endDocument", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#endElement(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public override void EndElement(Java.Lang.String arg0)
        {
            IExecuteWithSignature("endElement", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#ignorableWhitespace(char[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public override void IgnorableWhitespace(char[] arg0, int arg1, int arg2)
        {
            IExecute("ignorableWhitespace", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#parse(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public override void Parse(Java.Lang.String arg0)
        {
            IExecuteWithSignature("parse", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#parse(org.xml.sax.InputSource)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.InputSource"/></param>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public override void Parse(Org.Xml.Sax.InputSource arg0)
        {
            IExecuteWithSignature("parse", "(Lorg/xml/sax/InputSource;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#processingInstruction(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public override void ProcessingInstruction(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            IExecute("processingInstruction", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#setDocumentLocator(org.xml.sax.Locator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Xml.Sax.Locator"/></param>
        public override void SetDocumentLocator(Org.Xml.Sax.Locator arg0)
        {
            IExecuteWithSignature("setDocumentLocator", "(Lorg/xml/sax/Locator;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#setFeature(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <exception cref="Org.Xml.Sax.SAXNotRecognizedException"/>
        /// <exception cref="Org.Xml.Sax.SAXNotSupportedException"/>
        public override void SetFeature(Java.Lang.String arg0, bool arg1)
        {
            IExecute("setFeature", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#setProperty(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <exception cref="Org.Xml.Sax.SAXNotRecognizedException"/>
        /// <exception cref="Org.Xml.Sax.SAXNotSupportedException"/>
        public override void SetProperty(Java.Lang.String arg0, object arg1)
        {
            IExecute("setProperty", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/xml/sax/helpers/ParserAdapter.html#startDocument()"/>
        /// </summary>
        /// <exception cref="Org.Xml.Sax.SAXException"/>
        public override void StartDocument()
        {
            IExecuteWithSignature("startDocument", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}