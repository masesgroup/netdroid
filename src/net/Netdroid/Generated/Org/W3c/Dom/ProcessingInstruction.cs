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
    #region IProcessingInstruction
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IProcessingInstruction : Org.W3c.Dom.INode
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/ProcessingInstruction.html#getData()"/> <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/ProcessingInstruction.html#setData(java.lang.String)"/>
        /// </summary>
        Java.Lang.String Data { get; set; }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/ProcessingInstruction.html#getTarget()"/> 
        /// </summary>
        Java.Lang.String Target { get; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ProcessingInstruction
    public partial class ProcessingInstruction : Org.W3c.Dom.IProcessingInstruction
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
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/ProcessingInstruction.html#getData()"/> <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/ProcessingInstruction.html#setData(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Data
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getData", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setData", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/org/w3c/dom/ProcessingInstruction.html#getTarget()"/> 
        /// </summary>
        public Java.Lang.String Target
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getTarget", "()Ljava/lang/String;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}