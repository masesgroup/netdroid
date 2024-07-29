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
    #region IDOMConfiguration
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IDOMConfiguration
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DOMConfiguration
    public partial class DOMConfiguration : Org.W3c.Dom.IDOMConfiguration
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
        /// <see href="https://developer.android.com/reference/org/w3c/dom/DOMConfiguration.html#canSetParameter(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CanSetParameter(Java.Lang.String arg0, object arg1)
        {
            return IExecute<bool>("canSetParameter", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/w3c/dom/DOMConfiguration.html#getParameter(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public object GetParameter(Java.Lang.String arg0)
        {
            return IExecuteWithSignature("getParameter", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/w3c/dom/DOMConfiguration.html#getParameterNames()"/>
        /// </summary>
        /// <returns><see cref="Org.W3c.Dom.DOMStringList"/></returns>
        public Org.W3c.Dom.DOMStringList GetParameterNames()
        {
            return IExecuteWithSignature<Org.W3c.Dom.DOMStringList>("getParameterNames", "()Lorg/w3c/dom/DOMStringList;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/org/w3c/dom/DOMConfiguration.html#setParameter(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public void SetParameter(Java.Lang.String arg0, object arg1)
        {
            IExecute("setParameter", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}