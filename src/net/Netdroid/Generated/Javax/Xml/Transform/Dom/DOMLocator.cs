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

namespace Javax.Xml.Transform.Dom
{
    #region IDOMLocator
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IDOMLocator : Javax.Xml.Transform.ISourceLocator
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/javax/xml/transform/dom/DOMLocator.html#getOriginatingNode()"/> 
        /// </summary>
        Org.W3c.Dom.Node OriginatingNode { get; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DOMLocator
    public partial class DOMLocator : Javax.Xml.Transform.Dom.IDOMLocator
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
        /// <see href="https://developer.android.com/reference/java.xml/javax/xml/transform/dom/DOMLocator.html#getOriginatingNode()"/> 
        /// </summary>
        public Org.W3c.Dom.Node OriginatingNode
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.Node>("getOriginatingNode", "()Lorg/w3c/dom/Node;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}