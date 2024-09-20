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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Dalvik.System
{
    #region DexFile
    public partial class DexFile
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/dalvik/system/DexFile.html#%3Cinit%3E(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <exception cref="Java.Io.IOException"/>
        [global::System.Obsolete()]
        public DexFile(Java.Io.File arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/dalvik/system/DexFile.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Io.IOException"/>
        [global::System.Obsolete()]
        public DexFile(Java.Lang.String arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/dalvik/system/DexFile.html#loadDex(java.lang.String,java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Dalvik.System.DexFile"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        [global::System.Obsolete()]
        public static Dalvik.System.DexFile LoadDex(Java.Lang.String arg0, Java.Lang.String arg1, int arg2)
        {
            return SExecute<Dalvik.System.DexFile>(LocalBridgeClazz, "loadDex", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/dalvik/system/DexFile.html#isDexOptNeeded(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.FileNotFoundException"/>
        /// <exception cref="Java.Io.IOException"/>
        [global::System.Obsolete()]
        public static bool IsDexOptNeeded(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isDexOptNeeded", "(Ljava/lang/String;)Z", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/dalvik/system/DexFile.html#loadClass(java.lang.String,java.lang.ClassLoader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.ClassLoader"/></param>
        /// <returns><see cref="Java.Lang.Class"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.Class LoadClass(Java.Lang.String arg0, Java.Lang.ClassLoader arg1)
        {
            return IExecute<Java.Lang.Class>("loadClass", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/dalvik/system/DexFile.html#getName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.String GetName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/dalvik/system/DexFile.html#entries()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Enumeration"/></returns>
        [global::System.Obsolete()]
        public Java.Util.Enumeration<Java.Lang.String> Entries()
        {
            return IExecuteWithSignature<Java.Util.Enumeration<Java.Lang.String>>("entries", "()Ljava/util/Enumeration;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/dalvik/system/DexFile.html#close()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        [global::System.Obsolete()]
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }

        #endregion

        #region Nested classes
        #region OptimizationInfo
        public partial class OptimizationInfo
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
            /// <see href="https://developer.android.com/reference/dalvik/system/DexFile.OptimizationInfo.html#isFullyCompiled()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool IsFullyCompiled()
            {
                return IExecuteWithSignature<bool>("isFullyCompiled", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/dalvik/system/DexFile.OptimizationInfo.html#isOptimized()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool IsOptimized()
            {
                return IExecuteWithSignature<bool>("isOptimized", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/dalvik/system/DexFile.OptimizationInfo.html#isVerified()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool IsVerified()
            {
                return IExecuteWithSignature<bool>("isVerified", "()Z");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}