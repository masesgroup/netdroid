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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Concurrent
{
    #region CopyOnWriteArrayList
    public partial class CopyOnWriteArrayList
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#%3Cinit%3E(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        public CopyOnWriteArrayList(Java.Util.Collection arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.CopyOnWriteArrayList"/> to <see cref="Java.Util.List"/>
        /// </summary>
        public static implicit operator Java.Util.List(Java.Util.Concurrent.CopyOnWriteArrayList t) => t.Cast<Java.Util.List>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.CopyOnWriteArrayList"/> to <see cref="Java.Util.RandomAccess"/>
        /// </summary>
        public static implicit operator Java.Util.RandomAccess(Java.Util.Concurrent.CopyOnWriteArrayList t) => t.Cast<Java.Util.RandomAccess>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.CopyOnWriteArrayList"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Util.Concurrent.CopyOnWriteArrayList t) => t.Cast<Java.Lang.Cloneable>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.CopyOnWriteArrayList"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Util.Concurrent.CopyOnWriteArrayList t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#toArray(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object[] ToArray(object[] arg0)
        {
            return IExecuteWithSignatureArray<object>("toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#add(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Add(object arg0)
        {
            return IExecuteWithSignature<bool>("add", "(Ljava/lang/Object;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#addAll(int,java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool AddAll(int arg0, Java.Util.Collection arg1)
        {
            return IExecute<bool>("addAll", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#addAll(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool AddAll(Java.Util.Collection arg0)
        {
            return IExecuteWithSignature<bool>("addAll", "(Ljava/util/Collection;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#addIfAbsent(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool AddIfAbsent(object arg0)
        {
            return IExecuteWithSignature<bool>("addIfAbsent", "(Ljava/lang/Object;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#contains(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Contains(object arg0)
        {
            return IExecuteWithSignature<bool>("contains", "(Ljava/lang/Object;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#containsAll(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ContainsAll(Java.Util.Collection arg0)
        {
            return IExecuteWithSignature<bool>("containsAll", "(Ljava/util/Collection;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#isEmpty()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsEmpty()
        {
            return IExecuteWithSignature<bool>("isEmpty", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#remove(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Remove(object arg0)
        {
            return IExecuteWithSignature<bool>("remove", "(Ljava/lang/Object;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#removeAll(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RemoveAll(Java.Util.Collection arg0)
        {
            return IExecuteWithSignature<bool>("removeAll", "(Ljava/util/Collection;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#removeIf(java.util.function.Predicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Predicate"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RemoveIf(Java.Util.Function.Predicate arg0)
        {
            return IExecuteWithSignature<bool>("removeIf", "(Ljava/util/function/Predicate;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#retainAll(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RetainAll(Java.Util.Collection arg0)
        {
            return IExecuteWithSignature<bool>("retainAll", "(Ljava/util/Collection;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#get(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="object"/></returns>
        public object Get(int arg0)
        {
            return IExecuteWithSignature("get", "(I)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#remove(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="object"/></returns>
        public object Remove(int arg0)
        {
            return IExecuteWithSignature("remove", "(I)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#set(int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Set(int arg0, object arg1)
        {
            return IExecute("set", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#addAllAbsent(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="int"/></returns>
        public int AddAllAbsent(Java.Util.Collection arg0)
        {
            return IExecuteWithSignature<int>("addAllAbsent", "(Ljava/util/Collection;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#indexOf(java.lang.Object,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int IndexOf(object arg0, int arg1)
        {
            return IExecute<int>("indexOf", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#indexOf(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int IndexOf(object arg0)
        {
            return IExecuteWithSignature<int>("indexOf", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#lastIndexOf(java.lang.Object,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int LastIndexOf(object arg0, int arg1)
        {
            return IExecute<int>("lastIndexOf", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#lastIndexOf(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int LastIndexOf(object arg0)
        {
            return IExecuteWithSignature<int>("lastIndexOf", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#size()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Size()
        {
            return IExecuteWithSignature<int>("size", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#toArray()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object[] ToArray()
        {
            return IExecuteWithSignatureArray<object>("toArray", "()[Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#iterator()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public Java.Util.Iterator Iterator()
        {
            return IExecuteWithSignature<Java.Util.Iterator>("iterator", "()Ljava/util/Iterator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#subList(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List SubList(int arg0, int arg1)
        {
            return IExecute<Java.Util.List>("subList", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#listIterator()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.ListIterator"/></returns>
        public Java.Util.ListIterator ListIterator()
        {
            return IExecuteWithSignature<Java.Util.ListIterator>("listIterator", "()Ljava/util/ListIterator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#listIterator(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.ListIterator"/></returns>
        public Java.Util.ListIterator ListIterator(int arg0)
        {
            return IExecuteWithSignature<Java.Util.ListIterator>("listIterator", "(I)Ljava/util/ListIterator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#spliterator()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Spliterator"/></returns>
        public Java.Util.Spliterator Spliterator()
        {
            return IExecuteWithSignature<Java.Util.Spliterator>("spliterator", "()Ljava/util/Spliterator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#add(int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void Add(int arg0, object arg1)
        {
            IExecute("add", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#clear()"/>
        /// </summary>
        public void Clear()
        {
            IExecuteWithSignature("clear", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#forEach(java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
        public void ForEach(Java.Util.Function.Consumer arg0)
        {
            IExecuteWithSignature("forEach", "(Ljava/util/function/Consumer;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#replaceAll(java.util.function.UnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.UnaryOperator"/></param>
        public void ReplaceAll(Java.Util.Function.UnaryOperator arg0)
        {
            IExecuteWithSignature("replaceAll", "(Ljava/util/function/UnaryOperator;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region CopyOnWriteArrayList<E>
    public partial class CopyOnWriteArrayList<E> : Java.Util.IList<E>, Java.Util.IRandomAccess, Java.Lang.ICloneable, Java.Io.ISerializable
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#%3Cinit%3E(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        public CopyOnWriteArrayList(E[] arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#%3Cinit%3E(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        public CopyOnWriteArrayList(Java.Util.Collection<E> arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.CopyOnWriteArrayList{E}"/> to <see cref="Java.Util.List{E}"/>
        /// </summary>
        public static implicit operator Java.Util.List<E>(Java.Util.Concurrent.CopyOnWriteArrayList<E> t) => t.Cast<Java.Util.List<E>>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.CopyOnWriteArrayList{E}"/> to <see cref="Java.Util.RandomAccess"/>
        /// </summary>
        public static implicit operator Java.Util.RandomAccess(Java.Util.Concurrent.CopyOnWriteArrayList<E> t) => t.Cast<Java.Util.RandomAccess>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.CopyOnWriteArrayList{E}"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Util.Concurrent.CopyOnWriteArrayList<E> t) => t.Cast<Java.Lang.Cloneable>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.CopyOnWriteArrayList{E}"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Util.Concurrent.CopyOnWriteArrayList<E> t) => t.Cast<Java.Io.Serializable>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.CopyOnWriteArrayList{E}"/> to <see cref="Java.Util.Concurrent.CopyOnWriteArrayList"/>
        /// </summary>
        public static implicit operator Java.Util.Concurrent.CopyOnWriteArrayList(Java.Util.Concurrent.CopyOnWriteArrayList<E> t) => t.Cast<Java.Util.Concurrent.CopyOnWriteArrayList>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#toArray(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public T[] ToArray<T>(T[] arg0)
        {
            return IExecuteWithSignatureArray<T>("toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#add(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Add(E arg0)
        {
            return IExecuteWithSignature<bool>("add", "(Ljava/lang/Object;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#addAll(int,java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Util.Collection"/></param>
        /// <typeparam name="Arg1ExtendsE"><typeparamref name="E"/></typeparam>
        /// <returns><see cref="bool"/></returns>
        public bool AddAll<Arg1ExtendsE>(int arg0, Java.Util.Collection<Arg1ExtendsE> arg1) where Arg1ExtendsE : E
        {
            return IExecute<bool>("addAll", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#addAll(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <typeparam name="Arg0ExtendsE"><typeparamref name="E"/></typeparam>
        /// <returns><see cref="bool"/></returns>
        public bool AddAll<Arg0ExtendsE>(Java.Util.Collection<Arg0ExtendsE> arg0) where Arg0ExtendsE : E
        {
            return IExecuteWithSignature<bool>("addAll", "(Ljava/util/Collection;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#addIfAbsent(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool AddIfAbsent(E arg0)
        {
            return IExecuteWithSignature<bool>("addIfAbsent", "(Ljava/lang/Object;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#contains(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Contains(object arg0)
        {
            return IExecuteWithSignature<bool>("contains", "(Ljava/lang/Object;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#containsAll(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ContainsAll(Java.Util.Collection<object> arg0)
        {
            return IExecuteWithSignature<bool>("containsAll", "(Ljava/util/Collection;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#isEmpty()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsEmpty()
        {
            return IExecuteWithSignature<bool>("isEmpty", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#remove(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Remove(object arg0)
        {
            return IExecuteWithSignature<bool>("remove", "(Ljava/lang/Object;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#removeAll(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RemoveAll(Java.Util.Collection<object> arg0)
        {
            return IExecuteWithSignature<bool>("removeAll", "(Ljava/util/Collection;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#removeIf(java.util.function.Predicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Predicate"/></param>
        /// <typeparam name="Arg0objectSuperE"><typeparamref name="E"/></typeparam>
        /// <returns><see cref="bool"/></returns>
        public bool RemoveIf<Arg0objectSuperE>(Java.Util.Function.Predicate<Arg0objectSuperE> arg0) where Arg0objectSuperE : E
        {
            return IExecuteWithSignature<bool>("removeIf", "(Ljava/util/function/Predicate;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#retainAll(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RetainAll(Java.Util.Collection<object> arg0)
        {
            return IExecuteWithSignature<bool>("retainAll", "(Ljava/util/Collection;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#get(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><typeparamref name="E"/></returns>
        public E Get(int arg0)
        {
            return IExecuteWithSignature<E>("get", "(I)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#remove(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><typeparamref name="E"/></returns>
        public E Remove(int arg0)
        {
            return IExecuteWithSignature<E>("remove", "(I)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#set(int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><typeparamref name="E"/></param>
        /// <returns><typeparamref name="E"/></returns>
        public E Set(int arg0, E arg1)
        {
            return IExecute<E>("set", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#addAllAbsent(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <typeparam name="Arg0ExtendsE"><typeparamref name="E"/></typeparam>
        /// <returns><see cref="int"/></returns>
        public int AddAllAbsent<Arg0ExtendsE>(Java.Util.Collection<Arg0ExtendsE> arg0) where Arg0ExtendsE : E
        {
            return IExecuteWithSignature<int>("addAllAbsent", "(Ljava/util/Collection;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#indexOf(java.lang.Object,int)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int IndexOf(E arg0, int arg1)
        {
            return IExecute<int>("indexOf", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#indexOf(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int IndexOf(object arg0)
        {
            return IExecuteWithSignature<int>("indexOf", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#lastIndexOf(java.lang.Object,int)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int LastIndexOf(E arg0, int arg1)
        {
            return IExecute<int>("lastIndexOf", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#lastIndexOf(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int LastIndexOf(object arg0)
        {
            return IExecuteWithSignature<int>("lastIndexOf", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#size()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Size()
        {
            return IExecuteWithSignature<int>("size", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#toArray()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object[] ToArray()
        {
            return IExecuteWithSignatureArray<object>("toArray", "()[Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#iterator()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public Java.Util.Iterator<E> Iterator()
        {
            return IExecuteWithSignature<Java.Util.Iterator<E>>("iterator", "()Ljava/util/Iterator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#subList(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<E> SubList(int arg0, int arg1)
        {
            return IExecute<Java.Util.List<E>>("subList", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#listIterator()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.ListIterator"/></returns>
        public Java.Util.ListIterator<E> ListIterator()
        {
            return IExecuteWithSignature<Java.Util.ListIterator<E>>("listIterator", "()Ljava/util/ListIterator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#listIterator(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.ListIterator"/></returns>
        public Java.Util.ListIterator<E> ListIterator(int arg0)
        {
            return IExecuteWithSignature<Java.Util.ListIterator<E>>("listIterator", "(I)Ljava/util/ListIterator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#spliterator()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Spliterator"/></returns>
        public Java.Util.Spliterator<E> Spliterator()
        {
            return IExecuteWithSignature<Java.Util.Spliterator<E>>("spliterator", "()Ljava/util/Spliterator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#add(int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><typeparamref name="E"/></param>
        public void Add(int arg0, E arg1)
        {
            IExecute("add", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#clear()"/>
        /// </summary>
        public void Clear()
        {
            IExecuteWithSignature("clear", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#forEach(java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
        /// <typeparam name="Arg0objectSuperE"><typeparamref name="E"/></typeparam>
        public void ForEach<Arg0objectSuperE>(Java.Util.Function.Consumer<Arg0objectSuperE> arg0) where Arg0objectSuperE : E
        {
            IExecuteWithSignature("forEach", "(Ljava/util/function/Consumer;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/concurrent/CopyOnWriteArrayList.html#replaceAll(java.util.function.UnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.UnaryOperator"/></param>
        public void ReplaceAll(Java.Util.Function.UnaryOperator<E> arg0)
        {
            IExecuteWithSignature("replaceAll", "(Ljava/util/function/UnaryOperator;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}