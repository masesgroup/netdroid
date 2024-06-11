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

namespace Org.W3c.Dom
{
    #region INamedNodeMap
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface INamedNodeMap
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region NamedNodeMap
    public partial class NamedNodeMap : Org.W3c.Dom.INamedNodeMap
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
        /// <see href="https://developer.android.com/reference/org/w3c/dom/NamedNodeMap.html#getLength()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetLength()
        {
            return IExecuteWithSignature<int>("getLength", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/w3c/dom/NamedNodeMap.html#getNamedItem(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        public Org.W3c.Dom.Node GetNamedItem(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Org.W3c.Dom.Node>("getNamedItem", "(Ljava/lang/String;)Lorg/w3c/dom/Node;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/w3c/dom/NamedNodeMap.html#getNamedItemNS(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public Org.W3c.Dom.Node GetNamedItemNS(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute<Org.W3c.Dom.Node>("getNamedItemNS", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/w3c/dom/NamedNodeMap.html#item(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        public Org.W3c.Dom.Node Item(int arg0)
        {
            return IExecuteWithSignature<Org.W3c.Dom.Node>("item", "(I)Lorg/w3c/dom/Node;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/w3c/dom/NamedNodeMap.html#removeNamedItem(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public Org.W3c.Dom.Node RemoveNamedItem(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Org.W3c.Dom.Node>("removeNamedItem", "(Ljava/lang/String;)Lorg/w3c/dom/Node;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/w3c/dom/NamedNodeMap.html#removeNamedItemNS(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public Org.W3c.Dom.Node RemoveNamedItemNS(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute<Org.W3c.Dom.Node>("removeNamedItemNS", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/w3c/dom/NamedNodeMap.html#setNamedItem(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public Org.W3c.Dom.Node SetNamedItem(Org.W3c.Dom.Node arg0)
        {
            return IExecuteWithSignature<Org.W3c.Dom.Node>("setNamedItem", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/w3c/dom/NamedNodeMap.html#setNamedItemNS(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public Org.W3c.Dom.Node SetNamedItemNS(Org.W3c.Dom.Node arg0)
        {
            return IExecuteWithSignature<Org.W3c.Dom.Node>("setNamedItemNS", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}