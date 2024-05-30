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

namespace Java.Lang
{
    #region StackTraceElement
    public partial class StackTraceElement
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StackTraceElement.html#%3Cinit%3E(java.lang.String,java.lang.String,java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public StackTraceElement(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StackTraceElement.html#%3Cinit%3E(java.lang.String,java.lang.String,java.lang.String,java.lang.String,java.lang.String,java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="Java.Lang.String"/></param>
        /// <param name="arg5"><see cref="Java.Lang.String"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        public StackTraceElement(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Lang.String arg3, Java.Lang.String arg4, Java.Lang.String arg5, int arg6)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StackTraceElement.html#getClassLoaderName()"/> 
        /// </summary>
        public Java.Lang.String ClassLoaderName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getClassLoaderName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StackTraceElement.html#getClassName()"/> 
        /// </summary>
        public Java.Lang.String ClassName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getClassName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StackTraceElement.html#getFileName()"/> 
        /// </summary>
        public Java.Lang.String FileName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getFileName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StackTraceElement.html#getLineNumber()"/> 
        /// </summary>
        public int LineNumber
        {
            get { return IExecuteWithSignature<int>("getLineNumber", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StackTraceElement.html#getMethodName()"/> 
        /// </summary>
        public Java.Lang.String MethodName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getMethodName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StackTraceElement.html#getModuleName()"/> 
        /// </summary>
        public Java.Lang.String ModuleName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getModuleName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StackTraceElement.html#getModuleVersion()"/> 
        /// </summary>
        public Java.Lang.String ModuleVersion
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getModuleVersion", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/lang/StackTraceElement.html#isNativeMethod()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsNativeMethod()
        {
            return IExecuteWithSignature<bool>("isNativeMethod", "()Z");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}