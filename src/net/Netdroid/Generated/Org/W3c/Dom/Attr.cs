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

namespace Org.W3c.Dom
{
    #region IAttr
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IAttr : Org.W3c.Dom.INode
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Attr
    public partial class Attr : Org.W3c.Dom.IAttr
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
        /// <see href="https://developer.android.com/reference/org/w3c/dom/Attr.html#getSpecified()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetSpecified()
        {
            return IExecuteWithSignature<bool>("getSpecified", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/w3c/dom/Attr.html#isId()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsId()
        {
            return IExecuteWithSignature<bool>("isId", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/w3c/dom/Attr.html#getName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/w3c/dom/Attr.html#getValue()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetValue()
        {
            return IExecuteWithSignature<Java.Lang.String>("getValue", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/w3c/dom/Attr.html#getOwnerElement()"/>
        /// </summary>
        /// <returns><see cref="Org.W3c.Dom.Element"/></returns>
        public Org.W3c.Dom.Element GetOwnerElement()
        {
            return IExecuteWithSignature<Org.W3c.Dom.Element>("getOwnerElement", "()Lorg/w3c/dom/Element;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/w3c/dom/Attr.html#getSchemaTypeInfo()"/>
        /// </summary>
        /// <returns><see cref="Org.W3c.Dom.TypeInfo"/></returns>
        public Org.W3c.Dom.TypeInfo GetSchemaTypeInfo()
        {
            return IExecuteWithSignature<Org.W3c.Dom.TypeInfo>("getSchemaTypeInfo", "()Lorg/w3c/dom/TypeInfo;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/w3c/dom/Attr.html#setValue(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public void SetValue(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setValue", "(Ljava/lang/String;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}