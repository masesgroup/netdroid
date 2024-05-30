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
    #region TypeInfoProvider
    public partial class TypeInfoProvider
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
        /// <see href="https://developer.android.com/reference/java.xml/javax/xml/validation/TypeInfoProvider.html#getElementTypeInfo()"/> 
        /// </summary>
        public Org.W3c.Dom.TypeInfo ElementTypeInfo
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.TypeInfo>("getElementTypeInfo", "()Lorg/w3c/dom/TypeInfo;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/javax/xml/validation/TypeInfoProvider.html#isIdAttribute(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsIdAttribute(int arg0)
        {
            return IExecuteWithSignature<bool>("isIdAttribute", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/javax/xml/validation/TypeInfoProvider.html#isSpecified(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSpecified(int arg0)
        {
            return IExecuteWithSignature<bool>("isSpecified", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/javax/xml/validation/TypeInfoProvider.html#getAttributeTypeInfo(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Org.W3c.Dom.TypeInfo"/></returns>
        public Org.W3c.Dom.TypeInfo GetAttributeTypeInfo(int arg0)
        {
            return IExecuteWithSignature<Org.W3c.Dom.TypeInfo>("getAttributeTypeInfo", "(I)Lorg/w3c/dom/TypeInfo;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}