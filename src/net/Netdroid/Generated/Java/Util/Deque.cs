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

namespace Java.Util
{
    #region Deque
    public partial class Deque
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
        /// <see href="https://developer.android.com/reference/java/util/Deque.html#add(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Add(object arg0)
        {
            return IExecuteWithSignature<bool>("add", "(Ljava/lang/Object;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Deque.html#addAll(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool AddAll(Java.Util.Collection arg0)
        {
            return IExecuteWithSignature<bool>("addAll", "(Ljava/util/Collection;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Deque.html#contains(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Contains(object arg0)
        {
            return IExecuteWithSignature<bool>("contains", "(Ljava/lang/Object;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Deque.html#offer(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Offer(object arg0)
        {
            return IExecuteWithSignature<bool>("offer", "(Ljava/lang/Object;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Deque.html#offerFirst(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OfferFirst(object arg0)
        {
            return IExecuteWithSignature<bool>("offerFirst", "(Ljava/lang/Object;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Deque.html#offerLast(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OfferLast(object arg0)
        {
            return IExecuteWithSignature<bool>("offerLast", "(Ljava/lang/Object;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Deque.html#remove(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Remove(object arg0)
        {
            return IExecuteWithSignature<bool>("remove", "(Ljava/lang/Object;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Deque.html#removeFirstOccurrence(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RemoveFirstOccurrence(object arg0)
        {
            return IExecuteWithSignature<bool>("removeFirstOccurrence", "(Ljava/lang/Object;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Deque.html#removeLastOccurrence(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RemoveLastOccurrence(object arg0)
        {
            return IExecuteWithSignature<bool>("removeLastOccurrence", "(Ljava/lang/Object;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Deque.html#element()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object Element()
        {
            return IExecuteWithSignature("element", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Deque.html#getFirst()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object GetFirst()
        {
            return IExecuteWithSignature("getFirst", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Deque.html#getLast()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object GetLast()
        {
            return IExecuteWithSignature("getLast", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Deque.html#peek()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object Peek()
        {
            return IExecuteWithSignature("peek", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Deque.html#peekFirst()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object PeekFirst()
        {
            return IExecuteWithSignature("peekFirst", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Deque.html#peekLast()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object PeekLast()
        {
            return IExecuteWithSignature("peekLast", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Deque.html#poll()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object Poll()
        {
            return IExecuteWithSignature("poll", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Deque.html#pollFirst()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object PollFirst()
        {
            return IExecuteWithSignature("pollFirst", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Deque.html#pollLast()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object PollLast()
        {
            return IExecuteWithSignature("pollLast", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Deque.html#pop()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object Pop()
        {
            return IExecuteWithSignature("pop", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Deque.html#remove()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object Remove()
        {
            return IExecuteWithSignature("remove", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Deque.html#removeFirst()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object RemoveFirst()
        {
            return IExecuteWithSignature("removeFirst", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Deque.html#removeLast()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object RemoveLast()
        {
            return IExecuteWithSignature("removeLast", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Deque.html#size()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Size()
        {
            return IExecuteWithSignature<int>("size", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Deque.html#descendingIterator()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public Java.Util.Iterator DescendingIterator()
        {
            return IExecuteWithSignature<Java.Util.Iterator>("descendingIterator", "()Ljava/util/Iterator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Deque.html#iterator()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public Java.Util.Iterator Iterator()
        {
            return IExecuteWithSignature<Java.Util.Iterator>("iterator", "()Ljava/util/Iterator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Deque.html#addFirst(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void AddFirst(object arg0)
        {
            IExecuteWithSignature("addFirst", "(Ljava/lang/Object;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Deque.html#addLast(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void AddLast(object arg0)
        {
            IExecuteWithSignature("addLast", "(Ljava/lang/Object;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Deque.html#push(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void Push(object arg0)
        {
            IExecuteWithSignature("push", "(Ljava/lang/Object;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IDeque<E>
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IDeque<E> : Java.Util.IQueue<E>
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Deque<E>
    public partial class Deque<E> : Java.Util.IDeque<E>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Deque{E}"/> to <see cref="Java.Util.Deque"/>
        /// </summary>
        public static implicit operator Java.Util.Deque(Java.Util.Deque<E> t) => t.Cast<Java.Util.Deque>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Deque.html#add(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Add(E arg0)
        {
            return IExecuteWithSignature<bool>("add", "(Ljava/lang/Object;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Deque.html#addAll(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <typeparam name="Arg0ExtendsE"><typeparamref name="E"/></typeparam>
        /// <returns><see cref="bool"/></returns>
        public bool AddAll<Arg0ExtendsE>(Java.Util.Collection<Arg0ExtendsE> arg0) where Arg0ExtendsE : E
        {
            return IExecuteWithSignature<bool>("addAll", "(Ljava/util/Collection;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Deque.html#contains(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Contains(object arg0)
        {
            return IExecuteWithSignature<bool>("contains", "(Ljava/lang/Object;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Deque.html#offer(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Offer(E arg0)
        {
            return IExecuteWithSignature<bool>("offer", "(Ljava/lang/Object;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Deque.html#offerFirst(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OfferFirst(E arg0)
        {
            return IExecuteWithSignature<bool>("offerFirst", "(Ljava/lang/Object;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Deque.html#offerLast(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OfferLast(E arg0)
        {
            return IExecuteWithSignature<bool>("offerLast", "(Ljava/lang/Object;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Deque.html#remove(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Remove(object arg0)
        {
            return IExecuteWithSignature<bool>("remove", "(Ljava/lang/Object;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Deque.html#removeFirstOccurrence(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RemoveFirstOccurrence(object arg0)
        {
            return IExecuteWithSignature<bool>("removeFirstOccurrence", "(Ljava/lang/Object;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Deque.html#removeLastOccurrence(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RemoveLastOccurrence(object arg0)
        {
            return IExecuteWithSignature<bool>("removeLastOccurrence", "(Ljava/lang/Object;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Deque.html#element()"/>
        /// </summary>
        /// <returns><typeparamref name="E"/></returns>
        public E Element()
        {
            return IExecuteWithSignature<E>("element", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Deque.html#getFirst()"/>
        /// </summary>
        /// <returns><typeparamref name="E"/></returns>
        public E GetFirst()
        {
            return IExecuteWithSignature<E>("getFirst", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Deque.html#getLast()"/>
        /// </summary>
        /// <returns><typeparamref name="E"/></returns>
        public E GetLast()
        {
            return IExecuteWithSignature<E>("getLast", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Deque.html#peek()"/>
        /// </summary>
        /// <returns><typeparamref name="E"/></returns>
        public E Peek()
        {
            return IExecuteWithSignature<E>("peek", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Deque.html#peekFirst()"/>
        /// </summary>
        /// <returns><typeparamref name="E"/></returns>
        public E PeekFirst()
        {
            return IExecuteWithSignature<E>("peekFirst", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Deque.html#peekLast()"/>
        /// </summary>
        /// <returns><typeparamref name="E"/></returns>
        public E PeekLast()
        {
            return IExecuteWithSignature<E>("peekLast", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Deque.html#poll()"/>
        /// </summary>
        /// <returns><typeparamref name="E"/></returns>
        public E Poll()
        {
            return IExecuteWithSignature<E>("poll", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Deque.html#pollFirst()"/>
        /// </summary>
        /// <returns><typeparamref name="E"/></returns>
        public E PollFirst()
        {
            return IExecuteWithSignature<E>("pollFirst", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Deque.html#pollLast()"/>
        /// </summary>
        /// <returns><typeparamref name="E"/></returns>
        public E PollLast()
        {
            return IExecuteWithSignature<E>("pollLast", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Deque.html#pop()"/>
        /// </summary>
        /// <returns><typeparamref name="E"/></returns>
        public E Pop()
        {
            return IExecuteWithSignature<E>("pop", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Deque.html#remove()"/>
        /// </summary>
        /// <returns><typeparamref name="E"/></returns>
        public E Remove()
        {
            return IExecuteWithSignature<E>("remove", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Deque.html#removeFirst()"/>
        /// </summary>
        /// <returns><typeparamref name="E"/></returns>
        public E RemoveFirst()
        {
            return IExecuteWithSignature<E>("removeFirst", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Deque.html#removeLast()"/>
        /// </summary>
        /// <returns><typeparamref name="E"/></returns>
        public E RemoveLast()
        {
            return IExecuteWithSignature<E>("removeLast", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Deque.html#size()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Size()
        {
            return IExecuteWithSignature<int>("size", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Deque.html#descendingIterator()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public Java.Util.Iterator<E> DescendingIterator()
        {
            return IExecuteWithSignature<Java.Util.Iterator<E>>("descendingIterator", "()Ljava/util/Iterator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Deque.html#iterator()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public Java.Util.Iterator<E> Iterator()
        {
            return IExecuteWithSignature<Java.Util.Iterator<E>>("iterator", "()Ljava/util/Iterator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Deque.html#addFirst(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        public void AddFirst(E arg0)
        {
            IExecuteWithSignature("addFirst", "(Ljava/lang/Object;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Deque.html#addLast(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        public void AddLast(E arg0)
        {
            IExecuteWithSignature("addLast", "(Ljava/lang/Object;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Deque.html#push(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        public void Push(E arg0)
        {
            IExecuteWithSignature("push", "(Ljava/lang/Object;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}