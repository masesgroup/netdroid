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

namespace Java.Nio.File
{
    #region FileVisitResult
    public partial class FileVisitResult
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/file/FileVisitResult.html#CONTINUE"/>
        /// </summary>
        public static Java.Nio.File.FileVisitResult CONTINUE { get { if (!_CONTINUEReady) { _CONTINUEContent = SGetField<Java.Nio.File.FileVisitResult>(LocalBridgeClazz, "CONTINUE"); _CONTINUEReady = true; } return _CONTINUEContent; } }
        private static Java.Nio.File.FileVisitResult _CONTINUEContent = default;
        private static bool _CONTINUEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/file/FileVisitResult.html#SKIP_SIBLINGS"/>
        /// </summary>
        public static Java.Nio.File.FileVisitResult SKIP_SIBLINGS { get { if (!_SKIP_SIBLINGSReady) { _SKIP_SIBLINGSContent = SGetField<Java.Nio.File.FileVisitResult>(LocalBridgeClazz, "SKIP_SIBLINGS"); _SKIP_SIBLINGSReady = true; } return _SKIP_SIBLINGSContent; } }
        private static Java.Nio.File.FileVisitResult _SKIP_SIBLINGSContent = default;
        private static bool _SKIP_SIBLINGSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/file/FileVisitResult.html#SKIP_SUBTREE"/>
        /// </summary>
        public static Java.Nio.File.FileVisitResult SKIP_SUBTREE { get { if (!_SKIP_SUBTREEReady) { _SKIP_SUBTREEContent = SGetField<Java.Nio.File.FileVisitResult>(LocalBridgeClazz, "SKIP_SUBTREE"); _SKIP_SUBTREEReady = true; } return _SKIP_SUBTREEContent; } }
        private static Java.Nio.File.FileVisitResult _SKIP_SUBTREEContent = default;
        private static bool _SKIP_SUBTREEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/file/FileVisitResult.html#TERMINATE"/>
        /// </summary>
        public static Java.Nio.File.FileVisitResult TERMINATE { get { if (!_TERMINATEReady) { _TERMINATEContent = SGetField<Java.Nio.File.FileVisitResult>(LocalBridgeClazz, "TERMINATE"); _TERMINATEReady = true; } return _TERMINATEContent; } }
        private static Java.Nio.File.FileVisitResult _TERMINATEContent = default;
        private static bool _TERMINATEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/file/FileVisitResult.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Nio.File.FileVisitResult"/></returns>
        public static Java.Nio.File.FileVisitResult ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Nio.File.FileVisitResult>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/nio/file/FileVisitResult;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/file/FileVisitResult.html#values()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.File.FileVisitResult"/></returns>
        public static Java.Nio.File.FileVisitResult[] Values()
        {
            return SExecuteWithSignatureArray<Java.Nio.File.FileVisitResult>(LocalBridgeClazz, "values", "()[Ljava/nio/file/FileVisitResult;");
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}