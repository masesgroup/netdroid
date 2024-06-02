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

namespace Dalvik.Annotation
{
    #region ITestTarget
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ITestTarget : Java.Lang.Annotation.IAnnotation
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TestTarget
    public partial class TestTarget : Dalvik.Annotation.ITestTarget
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
        /// <see href="https://developer.android.com/reference/dalvik/annotation/TestTarget.html#methodArgs()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Class"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.Class[] MethodArgs()
        {
            return IExecuteWithSignatureArray<Java.Lang.Class>("methodArgs", "()[Ljava/lang/Class;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/dalvik/annotation/TestTarget.html#conceptName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.String ConceptName()
        {
            return IExecuteWithSignature<Java.Lang.String>("conceptName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/dalvik/annotation/TestTarget.html#methodName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.String MethodName()
        {
            return IExecuteWithSignature<Java.Lang.String>("methodName", "()Ljava/lang/String;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}