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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Xml.Transform.Dom
{
    #region DOMResult
    public partial class DOMResult
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/dom/DOMResult.html#%3Cinit%3E(org.w3c.dom.Node,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public DOMResult(Org.W3c.Dom.Node arg0, Java.Lang.String arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/dom/DOMResult.html#%3Cinit%3E(org.w3c.dom.Node,org.w3c.dom.Node,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <param name="arg1"><see cref="Org.W3c.Dom.Node"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        public DOMResult(Org.W3c.Dom.Node arg0, Org.W3c.Dom.Node arg1, Java.Lang.String arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/dom/DOMResult.html#%3Cinit%3E(org.w3c.dom.Node,org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <param name="arg1"><see cref="Org.W3c.Dom.Node"/></param>
        public DOMResult(Org.W3c.Dom.Node arg0, Org.W3c.Dom.Node arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/dom/DOMResult.html#%3Cinit%3E(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        public DOMResult(Org.W3c.Dom.Node arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/dom/DOMResult.html#FEATURE"/>
        /// </summary>
        public static Java.Lang.String FEATURE { get { if (!_FEATUREReady) { _FEATUREContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "FEATURE"); _FEATUREReady = true; } return _FEATUREContent; } }
        private static Java.Lang.String _FEATUREContent = default;
        private static bool _FEATUREReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/dom/DOMResult.html#getSystemId()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetSystemId()
        {
            return IExecuteWithSignature<Java.Lang.String>("getSystemId", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/dom/DOMResult.html#getNextSibling()"/>
        /// </summary>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        public Org.W3c.Dom.Node GetNextSibling()
        {
            return IExecuteWithSignature<Org.W3c.Dom.Node>("getNextSibling", "()Lorg/w3c/dom/Node;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/dom/DOMResult.html#getNode()"/>
        /// </summary>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        public Org.W3c.Dom.Node GetNode()
        {
            return IExecuteWithSignature<Org.W3c.Dom.Node>("getNode", "()Lorg/w3c/dom/Node;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/dom/DOMResult.html#setNextSibling(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        public void SetNextSibling(Org.W3c.Dom.Node arg0)
        {
            IExecuteWithSignature("setNextSibling", "(Lorg/w3c/dom/Node;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/dom/DOMResult.html#setNode(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        public void SetNode(Org.W3c.Dom.Node arg0)
        {
            IExecuteWithSignature("setNode", "(Lorg/w3c/dom/Node;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/transform/dom/DOMResult.html#setSystemId(java.lang.String)"/>
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