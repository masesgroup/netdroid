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
    #region TreeSet
    public partial class TreeSet
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeSet.html#%3Cinit%3E(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        public TreeSet(Java.Util.Collection arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeSet.html#%3Cinit%3E(java.util.SortedSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.SortedSet"/></param>
        public TreeSet(Java.Util.SortedSet arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.TreeSet"/> to <see cref="Java.Util.NavigableSet"/>
        /// </summary>
        public static implicit operator Java.Util.NavigableSet(Java.Util.TreeSet t) => t.Cast<Java.Util.NavigableSet>();
        /// <summary>
        /// Converter from <see cref="Java.Util.TreeSet"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Util.TreeSet t) => t.Cast<Java.Lang.Cloneable>();
        /// <summary>
        /// Converter from <see cref="Java.Util.TreeSet"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Util.TreeSet t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeSet.html#ceiling(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Ceiling(object arg0)
        {
            return IExecuteWithSignature("ceiling", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeSet.html#first()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object First()
        {
            return IExecuteWithSignature("first", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeSet.html#floor(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Floor(object arg0)
        {
            return IExecuteWithSignature("floor", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeSet.html#higher(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Higher(object arg0)
        {
            return IExecuteWithSignature("higher", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeSet.html#last()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object Last()
        {
            return IExecuteWithSignature("last", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeSet.html#lower(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Lower(object arg0)
        {
            return IExecuteWithSignature("lower", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeSet.html#pollFirst()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object PollFirst()
        {
            return IExecuteWithSignature("pollFirst", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeSet.html#pollLast()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object PollLast()
        {
            return IExecuteWithSignature("pollLast", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeSet.html#descendingIterator()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public Java.Util.Iterator DescendingIterator()
        {
            return IExecuteWithSignature<Java.Util.Iterator>("descendingIterator", "()Ljava/util/Iterator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeSet.html#descendingSet()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.NavigableSet"/></returns>
        public Java.Util.NavigableSet DescendingSet()
        {
            return IExecuteWithSignature<Java.Util.NavigableSet>("descendingSet", "()Ljava/util/NavigableSet;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeSet.html#headSet(java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.NavigableSet"/></returns>
        public Java.Util.NavigableSet HeadSet(object arg0, bool arg1)
        {
            return IExecute<Java.Util.NavigableSet>("headSet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeSet.html#subSet(java.lang.Object,boolean,java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.NavigableSet"/></returns>
        public Java.Util.NavigableSet SubSet(object arg0, bool arg1, object arg2, bool arg3)
        {
            return IExecute<Java.Util.NavigableSet>("subSet", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeSet.html#tailSet(java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.NavigableSet"/></returns>
        public Java.Util.NavigableSet TailSet(object arg0, bool arg1)
        {
            return IExecute<Java.Util.NavigableSet>("tailSet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeSet.html#headSet(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.SortedSet"/></returns>
        public Java.Util.SortedSet HeadSet(object arg0)
        {
            return IExecuteWithSignature<Java.Util.SortedSet>("headSet", "(Ljava/lang/Object;)Ljava/util/SortedSet;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeSet.html#subSet(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.SortedSet"/></returns>
        public Java.Util.SortedSet SubSet(object arg0, object arg1)
        {
            return IExecute<Java.Util.SortedSet>("subSet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeSet.html#tailSet(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.SortedSet"/></returns>
        public Java.Util.SortedSet TailSet(object arg0)
        {
            return IExecuteWithSignature<Java.Util.SortedSet>("tailSet", "(Ljava/lang/Object;)Ljava/util/SortedSet;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TreeSet<E>
    public partial class TreeSet<E> : Java.Util.INavigableSet<E>, Java.Lang.ICloneable, Java.Io.ISerializable
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeSet.html#%3Cinit%3E(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        public TreeSet(Java.Util.Collection<E> arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeSet.html#%3Cinit%3E(java.util.SortedSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.SortedSet"/></param>
        public TreeSet(Java.Util.SortedSet<E> arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.TreeSet{E}"/> to <see cref="Java.Util.NavigableSet{E}"/>
        /// </summary>
        public static implicit operator Java.Util.NavigableSet<E>(Java.Util.TreeSet<E> t) => t.Cast<Java.Util.NavigableSet<E>>();
        /// <summary>
        /// Converter from <see cref="Java.Util.TreeSet{E}"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Util.TreeSet<E> t) => t.Cast<Java.Lang.Cloneable>();
        /// <summary>
        /// Converter from <see cref="Java.Util.TreeSet{E}"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Util.TreeSet<E> t) => t.Cast<Java.Io.Serializable>();
        /// <summary>
        /// Converter from <see cref="Java.Util.TreeSet{E}"/> to <see cref="Java.Util.TreeSet"/>
        /// </summary>
        public static implicit operator Java.Util.TreeSet(Java.Util.TreeSet<E> t) => t.Cast<Java.Util.TreeSet>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeSet.html#ceiling(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <returns><typeparamref name="E"/></returns>
        public E Ceiling(E arg0)
        {
            return IExecuteWithSignature<E>("ceiling", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeSet.html#first()"/>
        /// </summary>
        /// <returns><typeparamref name="E"/></returns>
        public E First()
        {
            return IExecuteWithSignature<E>("first", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeSet.html#floor(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <returns><typeparamref name="E"/></returns>
        public E Floor(E arg0)
        {
            return IExecuteWithSignature<E>("floor", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeSet.html#higher(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <returns><typeparamref name="E"/></returns>
        public E Higher(E arg0)
        {
            return IExecuteWithSignature<E>("higher", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeSet.html#last()"/>
        /// </summary>
        /// <returns><typeparamref name="E"/></returns>
        public E Last()
        {
            return IExecuteWithSignature<E>("last", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeSet.html#lower(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <returns><typeparamref name="E"/></returns>
        public E Lower(E arg0)
        {
            return IExecuteWithSignature<E>("lower", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeSet.html#pollFirst()"/>
        /// </summary>
        /// <returns><typeparamref name="E"/></returns>
        public E PollFirst()
        {
            return IExecuteWithSignature<E>("pollFirst", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeSet.html#pollLast()"/>
        /// </summary>
        /// <returns><typeparamref name="E"/></returns>
        public E PollLast()
        {
            return IExecuteWithSignature<E>("pollLast", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeSet.html#descendingIterator()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public Java.Util.Iterator<E> DescendingIterator()
        {
            return IExecuteWithSignature<Java.Util.Iterator<E>>("descendingIterator", "()Ljava/util/Iterator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeSet.html#descendingSet()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.NavigableSet"/></returns>
        public Java.Util.NavigableSet<E> DescendingSet()
        {
            return IExecuteWithSignature<Java.Util.NavigableSet<E>>("descendingSet", "()Ljava/util/NavigableSet;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeSet.html#headSet(java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.NavigableSet"/></returns>
        public Java.Util.NavigableSet<E> HeadSet(E arg0, bool arg1)
        {
            return IExecute<Java.Util.NavigableSet<E>>("headSet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeSet.html#subSet(java.lang.Object,boolean,java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><typeparamref name="E"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.NavigableSet"/></returns>
        public Java.Util.NavigableSet<E> SubSet(E arg0, bool arg1, E arg2, bool arg3)
        {
            return IExecute<Java.Util.NavigableSet<E>>("subSet", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeSet.html#tailSet(java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.NavigableSet"/></returns>
        public Java.Util.NavigableSet<E> TailSet(E arg0, bool arg1)
        {
            return IExecute<Java.Util.NavigableSet<E>>("tailSet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeSet.html#headSet(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <returns><see cref="Java.Util.SortedSet"/></returns>
        public Java.Util.SortedSet<E> HeadSet(E arg0)
        {
            return IExecuteWithSignature<Java.Util.SortedSet<E>>("headSet", "(Ljava/lang/Object;)Ljava/util/SortedSet;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeSet.html#subSet(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <param name="arg1"><typeparamref name="E"/></param>
        /// <returns><see cref="Java.Util.SortedSet"/></returns>
        public Java.Util.SortedSet<E> SubSet(E arg0, E arg1)
        {
            return IExecute<Java.Util.SortedSet<E>>("subSet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeSet.html#tailSet(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <returns><see cref="Java.Util.SortedSet"/></returns>
        public Java.Util.SortedSet<E> TailSet(E arg0)
        {
            return IExecuteWithSignature<Java.Util.SortedSet<E>>("tailSet", "(Ljava/lang/Object;)Ljava/util/SortedSet;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}