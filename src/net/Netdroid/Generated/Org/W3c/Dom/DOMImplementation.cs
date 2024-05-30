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
    #region IDOMImplementation
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IDOMImplementation
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/DOMImplementation.html#hasFeature(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        bool HasFeature(Java.Lang.String arg0, Java.Lang.String arg1);
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/DOMImplementation.html#getFeature(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        object GetFeature(Java.Lang.String arg0, Java.Lang.String arg1);
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/DOMImplementation.html#createDocument(java.lang.String,java.lang.String,org.w3c.dom.DocumentType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Org.W3c.Dom.DocumentType"/></param>
        /// <returns><see cref="Org.W3c.Dom.Document"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        Org.W3c.Dom.Document CreateDocument(Java.Lang.String arg0, Java.Lang.String arg1, Org.W3c.Dom.DocumentType arg2);
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/DOMImplementation.html#createDocumentType(java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.W3c.Dom.DocumentType"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        Org.W3c.Dom.DocumentType CreateDocumentType(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DOMImplementation
    public partial class DOMImplementation : Org.W3c.Dom.IDOMImplementation
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
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/DOMImplementation.html#hasFeature(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasFeature(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute<bool>("hasFeature", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/DOMImplementation.html#getFeature(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetFeature(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute("getFeature", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/DOMImplementation.html#createDocument(java.lang.String,java.lang.String,org.w3c.dom.DocumentType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Org.W3c.Dom.DocumentType"/></param>
        /// <returns><see cref="Org.W3c.Dom.Document"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public Org.W3c.Dom.Document CreateDocument(Java.Lang.String arg0, Java.Lang.String arg1, Org.W3c.Dom.DocumentType arg2)
        {
            return IExecute<Org.W3c.Dom.Document>("createDocument", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/DOMImplementation.html#createDocumentType(java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.W3c.Dom.DocumentType"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public Org.W3c.Dom.DocumentType CreateDocumentType(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2)
        {
            return IExecute<Org.W3c.Dom.DocumentType>("createDocumentType", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}