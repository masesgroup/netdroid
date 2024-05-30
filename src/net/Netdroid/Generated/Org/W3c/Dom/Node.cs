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

namespace Org.W3c.Dom
{
    #region INode
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface INode
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#getAttributes()"/> 
        /// </summary>
        Org.W3c.Dom.NamedNodeMap Attributes { get; }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#getBaseURI()"/> 
        /// </summary>
        Java.Lang.String BaseURI { get; }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#getChildNodes()"/> 
        /// </summary>
        Org.W3c.Dom.NodeList ChildNodes { get; }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#getFirstChild()"/> 
        /// </summary>
        Org.W3c.Dom.Node FirstChild { get; }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#getLastChild()"/> 
        /// </summary>
        Org.W3c.Dom.Node LastChild { get; }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#getLocalName()"/> 
        /// </summary>
        Java.Lang.String LocalName { get; }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#getNamespaceURI()"/> 
        /// </summary>
        Java.Lang.String NamespaceURI { get; }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#getNextSibling()"/> 
        /// </summary>
        Org.W3c.Dom.Node NextSibling { get; }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#getNodeName()"/> 
        /// </summary>
        Java.Lang.String NodeName { get; }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#getNodeType()"/> 
        /// </summary>
        short NodeType { get; }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#getNodeValue()"/> <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#setNodeValue(java.lang.String)"/>
        /// </summary>
        Java.Lang.String NodeValue { get; set; }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#getOwnerDocument()"/> 
        /// </summary>
        Org.W3c.Dom.Document OwnerDocument { get; }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#getParentNode()"/> 
        /// </summary>
        Org.W3c.Dom.Node ParentNode { get; }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#getPrefix()"/> <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#setPrefix(java.lang.String)"/>
        /// </summary>
        Java.Lang.String Prefix { get; set; }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#getPreviousSibling()"/> 
        /// </summary>
        Org.W3c.Dom.Node PreviousSibling { get; }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#getTextContent()"/> <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#setTextContent(java.lang.String)"/>
        /// </summary>
        Java.Lang.String TextContent { get; set; }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#hasAttributes()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool HasAttributes();
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#hasChildNodes()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool HasChildNodes();
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#isDefaultNamespace(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        bool IsDefaultNamespace(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#isEqualNode(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <returns><see cref="bool"/></returns>
        bool IsEqualNode(Org.W3c.Dom.Node arg0);
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#isSameNode(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <returns><see cref="bool"/></returns>
        bool IsSameNode(Org.W3c.Dom.Node arg0);
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#isSupported(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        bool IsSupported(Java.Lang.String arg0, Java.Lang.String arg1);
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#getFeature(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        object GetFeature(Java.Lang.String arg0, Java.Lang.String arg1);
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#getUserData(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        object GetUserData(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#setUserData(java.lang.String,java.lang.Object,org.w3c.dom.UserDataHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="Org.W3c.Dom.UserDataHandler"/></param>
        /// <returns><see cref="object"/></returns>
        object SetUserData(Java.Lang.String arg0, object arg1, Org.W3c.Dom.UserDataHandler arg2);
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#lookupNamespaceURI(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        Java.Lang.String LookupNamespaceURI(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#lookupPrefix(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        Java.Lang.String LookupPrefix(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#appendChild(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        Org.W3c.Dom.Node AppendChild(Org.W3c.Dom.Node arg0);
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#cloneNode(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        Org.W3c.Dom.Node CloneNode(bool arg0);
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#insertBefore(org.w3c.dom.Node,org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <param name="arg1"><see cref="Org.W3c.Dom.Node"/></param>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        Org.W3c.Dom.Node InsertBefore(Org.W3c.Dom.Node arg0, Org.W3c.Dom.Node arg1);
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#removeChild(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        Org.W3c.Dom.Node RemoveChild(Org.W3c.Dom.Node arg0);
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#replaceChild(org.w3c.dom.Node,org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <param name="arg1"><see cref="Org.W3c.Dom.Node"/></param>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        Org.W3c.Dom.Node ReplaceChild(Org.W3c.Dom.Node arg0, Org.W3c.Dom.Node arg1);
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#compareDocumentPosition(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <returns><see cref="short"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        short CompareDocumentPosition(Org.W3c.Dom.Node arg0);
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#normalize()"/>
        /// </summary>
        void Normalize();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Node
    public partial class Node : Org.W3c.Dom.INode
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#ATTRIBUTE_NODE"/>
        /// </summary>
        public static short ATTRIBUTE_NODE { get { if (!_ATTRIBUTE_NODEReady) { _ATTRIBUTE_NODEContent = SGetField<short>(LocalBridgeClazz, "ATTRIBUTE_NODE"); _ATTRIBUTE_NODEReady = true; } return _ATTRIBUTE_NODEContent; } }
        private static short _ATTRIBUTE_NODEContent = default;
        private static bool _ATTRIBUTE_NODEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#CDATA_SECTION_NODE"/>
        /// </summary>
        public static short CDATA_SECTION_NODE { get { if (!_CDATA_SECTION_NODEReady) { _CDATA_SECTION_NODEContent = SGetField<short>(LocalBridgeClazz, "CDATA_SECTION_NODE"); _CDATA_SECTION_NODEReady = true; } return _CDATA_SECTION_NODEContent; } }
        private static short _CDATA_SECTION_NODEContent = default;
        private static bool _CDATA_SECTION_NODEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#COMMENT_NODE"/>
        /// </summary>
        public static short COMMENT_NODE { get { if (!_COMMENT_NODEReady) { _COMMENT_NODEContent = SGetField<short>(LocalBridgeClazz, "COMMENT_NODE"); _COMMENT_NODEReady = true; } return _COMMENT_NODEContent; } }
        private static short _COMMENT_NODEContent = default;
        private static bool _COMMENT_NODEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#DOCUMENT_FRAGMENT_NODE"/>
        /// </summary>
        public static short DOCUMENT_FRAGMENT_NODE { get { if (!_DOCUMENT_FRAGMENT_NODEReady) { _DOCUMENT_FRAGMENT_NODEContent = SGetField<short>(LocalBridgeClazz, "DOCUMENT_FRAGMENT_NODE"); _DOCUMENT_FRAGMENT_NODEReady = true; } return _DOCUMENT_FRAGMENT_NODEContent; } }
        private static short _DOCUMENT_FRAGMENT_NODEContent = default;
        private static bool _DOCUMENT_FRAGMENT_NODEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#DOCUMENT_NODE"/>
        /// </summary>
        public static short DOCUMENT_NODE { get { if (!_DOCUMENT_NODEReady) { _DOCUMENT_NODEContent = SGetField<short>(LocalBridgeClazz, "DOCUMENT_NODE"); _DOCUMENT_NODEReady = true; } return _DOCUMENT_NODEContent; } }
        private static short _DOCUMENT_NODEContent = default;
        private static bool _DOCUMENT_NODEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#DOCUMENT_POSITION_CONTAINED_BY"/>
        /// </summary>
        public static short DOCUMENT_POSITION_CONTAINED_BY { get { if (!_DOCUMENT_POSITION_CONTAINED_BYReady) { _DOCUMENT_POSITION_CONTAINED_BYContent = SGetField<short>(LocalBridgeClazz, "DOCUMENT_POSITION_CONTAINED_BY"); _DOCUMENT_POSITION_CONTAINED_BYReady = true; } return _DOCUMENT_POSITION_CONTAINED_BYContent; } }
        private static short _DOCUMENT_POSITION_CONTAINED_BYContent = default;
        private static bool _DOCUMENT_POSITION_CONTAINED_BYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#DOCUMENT_POSITION_CONTAINS"/>
        /// </summary>
        public static short DOCUMENT_POSITION_CONTAINS { get { if (!_DOCUMENT_POSITION_CONTAINSReady) { _DOCUMENT_POSITION_CONTAINSContent = SGetField<short>(LocalBridgeClazz, "DOCUMENT_POSITION_CONTAINS"); _DOCUMENT_POSITION_CONTAINSReady = true; } return _DOCUMENT_POSITION_CONTAINSContent; } }
        private static short _DOCUMENT_POSITION_CONTAINSContent = default;
        private static bool _DOCUMENT_POSITION_CONTAINSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#DOCUMENT_POSITION_DISCONNECTED"/>
        /// </summary>
        public static short DOCUMENT_POSITION_DISCONNECTED { get { if (!_DOCUMENT_POSITION_DISCONNECTEDReady) { _DOCUMENT_POSITION_DISCONNECTEDContent = SGetField<short>(LocalBridgeClazz, "DOCUMENT_POSITION_DISCONNECTED"); _DOCUMENT_POSITION_DISCONNECTEDReady = true; } return _DOCUMENT_POSITION_DISCONNECTEDContent; } }
        private static short _DOCUMENT_POSITION_DISCONNECTEDContent = default;
        private static bool _DOCUMENT_POSITION_DISCONNECTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#DOCUMENT_POSITION_FOLLOWING"/>
        /// </summary>
        public static short DOCUMENT_POSITION_FOLLOWING { get { if (!_DOCUMENT_POSITION_FOLLOWINGReady) { _DOCUMENT_POSITION_FOLLOWINGContent = SGetField<short>(LocalBridgeClazz, "DOCUMENT_POSITION_FOLLOWING"); _DOCUMENT_POSITION_FOLLOWINGReady = true; } return _DOCUMENT_POSITION_FOLLOWINGContent; } }
        private static short _DOCUMENT_POSITION_FOLLOWINGContent = default;
        private static bool _DOCUMENT_POSITION_FOLLOWINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#DOCUMENT_POSITION_IMPLEMENTATION_SPECIFIC"/>
        /// </summary>
        public static short DOCUMENT_POSITION_IMPLEMENTATION_SPECIFIC { get { if (!_DOCUMENT_POSITION_IMPLEMENTATION_SPECIFICReady) { _DOCUMENT_POSITION_IMPLEMENTATION_SPECIFICContent = SGetField<short>(LocalBridgeClazz, "DOCUMENT_POSITION_IMPLEMENTATION_SPECIFIC"); _DOCUMENT_POSITION_IMPLEMENTATION_SPECIFICReady = true; } return _DOCUMENT_POSITION_IMPLEMENTATION_SPECIFICContent; } }
        private static short _DOCUMENT_POSITION_IMPLEMENTATION_SPECIFICContent = default;
        private static bool _DOCUMENT_POSITION_IMPLEMENTATION_SPECIFICReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#DOCUMENT_POSITION_PRECEDING"/>
        /// </summary>
        public static short DOCUMENT_POSITION_PRECEDING { get { if (!_DOCUMENT_POSITION_PRECEDINGReady) { _DOCUMENT_POSITION_PRECEDINGContent = SGetField<short>(LocalBridgeClazz, "DOCUMENT_POSITION_PRECEDING"); _DOCUMENT_POSITION_PRECEDINGReady = true; } return _DOCUMENT_POSITION_PRECEDINGContent; } }
        private static short _DOCUMENT_POSITION_PRECEDINGContent = default;
        private static bool _DOCUMENT_POSITION_PRECEDINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#DOCUMENT_TYPE_NODE"/>
        /// </summary>
        public static short DOCUMENT_TYPE_NODE { get { if (!_DOCUMENT_TYPE_NODEReady) { _DOCUMENT_TYPE_NODEContent = SGetField<short>(LocalBridgeClazz, "DOCUMENT_TYPE_NODE"); _DOCUMENT_TYPE_NODEReady = true; } return _DOCUMENT_TYPE_NODEContent; } }
        private static short _DOCUMENT_TYPE_NODEContent = default;
        private static bool _DOCUMENT_TYPE_NODEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#ELEMENT_NODE"/>
        /// </summary>
        public static short ELEMENT_NODE { get { if (!_ELEMENT_NODEReady) { _ELEMENT_NODEContent = SGetField<short>(LocalBridgeClazz, "ELEMENT_NODE"); _ELEMENT_NODEReady = true; } return _ELEMENT_NODEContent; } }
        private static short _ELEMENT_NODEContent = default;
        private static bool _ELEMENT_NODEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#ENTITY_NODE"/>
        /// </summary>
        public static short ENTITY_NODE { get { if (!_ENTITY_NODEReady) { _ENTITY_NODEContent = SGetField<short>(LocalBridgeClazz, "ENTITY_NODE"); _ENTITY_NODEReady = true; } return _ENTITY_NODEContent; } }
        private static short _ENTITY_NODEContent = default;
        private static bool _ENTITY_NODEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#ENTITY_REFERENCE_NODE"/>
        /// </summary>
        public static short ENTITY_REFERENCE_NODE { get { if (!_ENTITY_REFERENCE_NODEReady) { _ENTITY_REFERENCE_NODEContent = SGetField<short>(LocalBridgeClazz, "ENTITY_REFERENCE_NODE"); _ENTITY_REFERENCE_NODEReady = true; } return _ENTITY_REFERENCE_NODEContent; } }
        private static short _ENTITY_REFERENCE_NODEContent = default;
        private static bool _ENTITY_REFERENCE_NODEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#NOTATION_NODE"/>
        /// </summary>
        public static short NOTATION_NODE { get { if (!_NOTATION_NODEReady) { _NOTATION_NODEContent = SGetField<short>(LocalBridgeClazz, "NOTATION_NODE"); _NOTATION_NODEReady = true; } return _NOTATION_NODEContent; } }
        private static short _NOTATION_NODEContent = default;
        private static bool _NOTATION_NODEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#PROCESSING_INSTRUCTION_NODE"/>
        /// </summary>
        public static short PROCESSING_INSTRUCTION_NODE { get { if (!_PROCESSING_INSTRUCTION_NODEReady) { _PROCESSING_INSTRUCTION_NODEContent = SGetField<short>(LocalBridgeClazz, "PROCESSING_INSTRUCTION_NODE"); _PROCESSING_INSTRUCTION_NODEReady = true; } return _PROCESSING_INSTRUCTION_NODEContent; } }
        private static short _PROCESSING_INSTRUCTION_NODEContent = default;
        private static bool _PROCESSING_INSTRUCTION_NODEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#TEXT_NODE"/>
        /// </summary>
        public static short TEXT_NODE { get { if (!_TEXT_NODEReady) { _TEXT_NODEContent = SGetField<short>(LocalBridgeClazz, "TEXT_NODE"); _TEXT_NODEReady = true; } return _TEXT_NODEContent; } }
        private static short _TEXT_NODEContent = default;
        private static bool _TEXT_NODEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#getAttributes()"/> 
        /// </summary>
        public Org.W3c.Dom.NamedNodeMap Attributes
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.NamedNodeMap>("getAttributes", "()Lorg/w3c/dom/NamedNodeMap;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#getBaseURI()"/> 
        /// </summary>
        public Java.Lang.String BaseURI
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getBaseURI", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#getChildNodes()"/> 
        /// </summary>
        public Org.W3c.Dom.NodeList ChildNodes
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.NodeList>("getChildNodes", "()Lorg/w3c/dom/NodeList;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#getFirstChild()"/> 
        /// </summary>
        public Org.W3c.Dom.Node FirstChild
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.Node>("getFirstChild", "()Lorg/w3c/dom/Node;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#getLastChild()"/> 
        /// </summary>
        public Org.W3c.Dom.Node LastChild
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.Node>("getLastChild", "()Lorg/w3c/dom/Node;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#getLocalName()"/> 
        /// </summary>
        public Java.Lang.String LocalName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getLocalName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#getNamespaceURI()"/> 
        /// </summary>
        public Java.Lang.String NamespaceURI
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getNamespaceURI", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#getNextSibling()"/> 
        /// </summary>
        public Org.W3c.Dom.Node NextSibling
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.Node>("getNextSibling", "()Lorg/w3c/dom/Node;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#getNodeName()"/> 
        /// </summary>
        public Java.Lang.String NodeName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getNodeName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#getNodeType()"/> 
        /// </summary>
        public short NodeType
        {
            get { return IExecuteWithSignature<short>("getNodeType", "()S"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#getNodeValue()"/> <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#setNodeValue(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String NodeValue
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getNodeValue", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setNodeValue", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#getOwnerDocument()"/> 
        /// </summary>
        public Org.W3c.Dom.Document OwnerDocument
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.Document>("getOwnerDocument", "()Lorg/w3c/dom/Document;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#getParentNode()"/> 
        /// </summary>
        public Org.W3c.Dom.Node ParentNode
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.Node>("getParentNode", "()Lorg/w3c/dom/Node;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#getPrefix()"/> <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#setPrefix(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Prefix
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getPrefix", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setPrefix", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#getPreviousSibling()"/> 
        /// </summary>
        public Org.W3c.Dom.Node PreviousSibling
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.Node>("getPreviousSibling", "()Lorg/w3c/dom/Node;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#getTextContent()"/> <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#setTextContent(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String TextContent
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getTextContent", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setTextContent", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#hasAttributes()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasAttributes()
        {
            return IExecuteWithSignature<bool>("hasAttributes", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#hasChildNodes()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasChildNodes()
        {
            return IExecuteWithSignature<bool>("hasChildNodes", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#isDefaultNamespace(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsDefaultNamespace(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("isDefaultNamespace", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#isEqualNode(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsEqualNode(Org.W3c.Dom.Node arg0)
        {
            return IExecuteWithSignature<bool>("isEqualNode", "(Lorg/w3c/dom/Node;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#isSameNode(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSameNode(Org.W3c.Dom.Node arg0)
        {
            return IExecuteWithSignature<bool>("isSameNode", "(Lorg/w3c/dom/Node;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#isSupported(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSupported(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute<bool>("isSupported", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#getFeature(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetFeature(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute("getFeature", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#getUserData(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetUserData(Java.Lang.String arg0)
        {
            return IExecuteWithSignature("getUserData", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#setUserData(java.lang.String,java.lang.Object,org.w3c.dom.UserDataHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="Org.W3c.Dom.UserDataHandler"/></param>
        /// <returns><see cref="object"/></returns>
        public object SetUserData(Java.Lang.String arg0, object arg1, Org.W3c.Dom.UserDataHandler arg2)
        {
            return IExecute("setUserData", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#lookupNamespaceURI(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String LookupNamespaceURI(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("lookupNamespaceURI", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#lookupPrefix(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String LookupPrefix(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("lookupPrefix", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#appendChild(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public Org.W3c.Dom.Node AppendChild(Org.W3c.Dom.Node arg0)
        {
            return IExecuteWithSignature<Org.W3c.Dom.Node>("appendChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#cloneNode(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        public Org.W3c.Dom.Node CloneNode(bool arg0)
        {
            return IExecuteWithSignature<Org.W3c.Dom.Node>("cloneNode", "(Z)Lorg/w3c/dom/Node;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#insertBefore(org.w3c.dom.Node,org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <param name="arg1"><see cref="Org.W3c.Dom.Node"/></param>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public Org.W3c.Dom.Node InsertBefore(Org.W3c.Dom.Node arg0, Org.W3c.Dom.Node arg1)
        {
            return IExecute<Org.W3c.Dom.Node>("insertBefore", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#removeChild(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public Org.W3c.Dom.Node RemoveChild(Org.W3c.Dom.Node arg0)
        {
            return IExecuteWithSignature<Org.W3c.Dom.Node>("removeChild", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#replaceChild(org.w3c.dom.Node,org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <param name="arg1"><see cref="Org.W3c.Dom.Node"/></param>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public Org.W3c.Dom.Node ReplaceChild(Org.W3c.Dom.Node arg0, Org.W3c.Dom.Node arg1)
        {
            return IExecute<Org.W3c.Dom.Node>("replaceChild", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#compareDocumentPosition(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <returns><see cref="short"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public short CompareDocumentPosition(Org.W3c.Dom.Node arg0)
        {
            return IExecuteWithSignature<short>("compareDocumentPosition", "(Lorg/w3c/dom/Node;)S", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/Node.html#normalize()"/>
        /// </summary>
        public void Normalize()
        {
            IExecuteWithSignature("normalize", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}