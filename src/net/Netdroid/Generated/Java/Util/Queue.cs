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

namespace Java.Util
{
    #region Queue
    public partial class Queue
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
        /// <see href="https://developer.android.com/reference/java/util/Queue.html#add(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Add(object arg0)
        {
            return IExecuteWithSignature<bool>("add", "(Ljava/lang/Object;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Queue.html#offer(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Offer(object arg0)
        {
            return IExecuteWithSignature<bool>("offer", "(Ljava/lang/Object;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Queue.html#element()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object Element()
        {
            return IExecuteWithSignature("element", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Queue.html#peek()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object Peek()
        {
            return IExecuteWithSignature("peek", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Queue.html#poll()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object Poll()
        {
            return IExecuteWithSignature("poll", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Queue.html#remove()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object Remove()
        {
            return IExecuteWithSignature("remove", "()Ljava/lang/Object;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IQueue<E>
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IQueue<E> : Java.Util.ICollection<E>
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Queue<E>
    public partial class Queue<E> : Java.Util.IQueue<E>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Queue{E}"/> to <see cref="Java.Util.Queue"/>
        /// </summary>
        public static implicit operator Java.Util.Queue(Java.Util.Queue<E> t) => t.Cast<Java.Util.Queue>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Queue.html#add(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Add(E arg0)
        {
            return IExecuteWithSignature<bool>("add", "(Ljava/lang/Object;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Queue.html#offer(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Offer(E arg0)
        {
            return IExecuteWithSignature<bool>("offer", "(Ljava/lang/Object;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Queue.html#element()"/>
        /// </summary>
        /// <returns><typeparamref name="E"/></returns>
        public E Element()
        {
            return IExecuteWithSignature<E>("element", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Queue.html#peek()"/>
        /// </summary>
        /// <returns><typeparamref name="E"/></returns>
        public E Peek()
        {
            return IExecuteWithSignature<E>("peek", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Queue.html#poll()"/>
        /// </summary>
        /// <returns><typeparamref name="E"/></returns>
        public E Poll()
        {
            return IExecuteWithSignature<E>("poll", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Queue.html#remove()"/>
        /// </summary>
        /// <returns><typeparamref name="E"/></returns>
        public E Remove()
        {
            return IExecuteWithSignature<E>("remove", "()Ljava/lang/Object;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}