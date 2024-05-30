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

namespace Java.Nio.File
{
    #region DirectoryStream
    public partial class DirectoryStream
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Nio.File.DirectoryStream"/> to <see cref="Java.Io.Closeable"/>
        /// </summary>
        public static implicit operator Java.Io.Closeable(Java.Nio.File.DirectoryStream t) => t.Cast<Java.Io.Closeable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/file/DirectoryStream.html#iterator()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public Java.Util.Iterator Iterator()
        {
            return IExecuteWithSignature<Java.Util.Iterator>("iterator", "()Ljava/util/Iterator;");
        }

        #endregion

        #region Nested classes
        #region Filter
        public partial class Filter
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
            /// <see href="https://developer.android.com/reference/java.base/java/nio/file/DirectoryStream.Filter.html#accept(java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            /// <returns><see cref="bool"/></returns>
            /// <exception cref="Java.Io.IOException"/>
            public bool Accept(object arg0)
            {
                return IExecuteWithSignature<bool>("accept", "(Ljava/lang/Object;)Z", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Filter<T>
        public partial class Filter<T>
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Java.Nio.File.DirectoryStream.Filter{T}"/> to <see cref="Java.Nio.File.DirectoryStream.Filter"/>
            /// </summary>
            public static implicit operator Java.Nio.File.DirectoryStream.Filter(Java.Nio.File.DirectoryStream.Filter<T> t) => t.Cast<Java.Nio.File.DirectoryStream.Filter>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/java.base/java/nio/file/DirectoryStream.Filter.html#accept(java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><typeparamref name="T"/></param>
            /// <returns><see cref="bool"/></returns>
            /// <exception cref="Java.Io.IOException"/>
            public bool Accept(T arg0)
            {
                return IExecuteWithSignature<bool>("accept", "(Ljava/lang/Object;)Z", arg0);
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

    #region IDirectoryStream<T>
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IDirectoryStream<T>
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/file/DirectoryStream.html#iterator()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        Java.Util.Iterator<T> Iterator();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DirectoryStream<T>
    public partial class DirectoryStream<T> : Java.Nio.File.IDirectoryStream<T>, Java.Io.ICloseable, Java.Lang.IIterable<T>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Nio.File.DirectoryStream{T}"/> to <see cref="Java.Io.Closeable"/>
        /// </summary>
        public static implicit operator Java.Io.Closeable(Java.Nio.File.DirectoryStream<T> t) => t.Cast<Java.Io.Closeable>();
        /// <summary>
        /// Converter from <see cref="Java.Nio.File.DirectoryStream{T}"/> to <see cref="Java.Nio.File.DirectoryStream"/>
        /// </summary>
        public static implicit operator Java.Nio.File.DirectoryStream(Java.Nio.File.DirectoryStream<T> t) => t.Cast<Java.Nio.File.DirectoryStream>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/file/DirectoryStream.html#iterator()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public Java.Util.Iterator<T> Iterator()
        {
            return IExecuteWithSignature<Java.Util.Iterator<T>>("iterator", "()Ljava/util/Iterator;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}