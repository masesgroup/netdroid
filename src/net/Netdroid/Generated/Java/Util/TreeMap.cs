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
    #region TreeMap
    public partial class TreeMap
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeMap.html#%3Cinit%3E(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public TreeMap(Java.Util.Map arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeMap.html#%3Cinit%3E(java.util.SortedMap)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.SortedMap"/></param>
        public TreeMap(Java.Util.SortedMap arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.TreeMap"/> to <see cref="Java.Util.NavigableMap"/>
        /// </summary>
        public static implicit operator Java.Util.NavigableMap(Java.Util.TreeMap t) => t.Cast<Java.Util.NavigableMap>();
        /// <summary>
        /// Converter from <see cref="Java.Util.TreeMap"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Util.TreeMap t) => t.Cast<Java.Lang.Cloneable>();
        /// <summary>
        /// Converter from <see cref="Java.Util.TreeMap"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Util.TreeMap t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeMap.html#ceilingEntry(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Map.Entry"/></returns>
        public Java.Util.Map.Entry CeilingEntry(object arg0)
        {
            return IExecuteWithSignature<Java.Util.Map.Entry>("ceilingEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeMap.html#firstEntry()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map.Entry"/></returns>
        public Java.Util.Map.Entry FirstEntry()
        {
            return IExecuteWithSignature<Java.Util.Map.Entry>("firstEntry", "()Ljava/util/Map$Entry;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeMap.html#floorEntry(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Map.Entry"/></returns>
        public Java.Util.Map.Entry FloorEntry(object arg0)
        {
            return IExecuteWithSignature<Java.Util.Map.Entry>("floorEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeMap.html#higherEntry(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Map.Entry"/></returns>
        public Java.Util.Map.Entry HigherEntry(object arg0)
        {
            return IExecuteWithSignature<Java.Util.Map.Entry>("higherEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeMap.html#lastEntry()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map.Entry"/></returns>
        public Java.Util.Map.Entry LastEntry()
        {
            return IExecuteWithSignature<Java.Util.Map.Entry>("lastEntry", "()Ljava/util/Map$Entry;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeMap.html#lowerEntry(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Map.Entry"/></returns>
        public Java.Util.Map.Entry LowerEntry(object arg0)
        {
            return IExecuteWithSignature<Java.Util.Map.Entry>("lowerEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeMap.html#pollFirstEntry()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map.Entry"/></returns>
        public Java.Util.Map.Entry PollFirstEntry()
        {
            return IExecuteWithSignature<Java.Util.Map.Entry>("pollFirstEntry", "()Ljava/util/Map$Entry;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeMap.html#pollLastEntry()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map.Entry"/></returns>
        public Java.Util.Map.Entry PollLastEntry()
        {
            return IExecuteWithSignature<Java.Util.Map.Entry>("pollLastEntry", "()Ljava/util/Map$Entry;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeMap.html#descendingMap()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.NavigableMap"/></returns>
        public Java.Util.NavigableMap DescendingMap()
        {
            return IExecuteWithSignature<Java.Util.NavigableMap>("descendingMap", "()Ljava/util/NavigableMap;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeMap.html#headMap(java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.NavigableMap"/></returns>
        public Java.Util.NavigableMap HeadMap(object arg0, bool arg1)
        {
            return IExecute<Java.Util.NavigableMap>("headMap", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeMap.html#subMap(java.lang.Object,boolean,java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.NavigableMap"/></returns>
        public Java.Util.NavigableMap SubMap(object arg0, bool arg1, object arg2, bool arg3)
        {
            return IExecute<Java.Util.NavigableMap>("subMap", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeMap.html#tailMap(java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.NavigableMap"/></returns>
        public Java.Util.NavigableMap TailMap(object arg0, bool arg1)
        {
            return IExecute<Java.Util.NavigableMap>("tailMap", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeMap.html#descendingKeySet()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.NavigableSet"/></returns>
        public Java.Util.NavigableSet DescendingKeySet()
        {
            return IExecuteWithSignature<Java.Util.NavigableSet>("descendingKeySet", "()Ljava/util/NavigableSet;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeMap.html#navigableKeySet()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.NavigableSet"/></returns>
        public Java.Util.NavigableSet NavigableKeySet()
        {
            return IExecuteWithSignature<Java.Util.NavigableSet>("navigableKeySet", "()Ljava/util/NavigableSet;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeMap.html#headMap(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.SortedMap"/></returns>
        public Java.Util.SortedMap HeadMap(object arg0)
        {
            return IExecuteWithSignature<Java.Util.SortedMap>("headMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeMap.html#subMap(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.SortedMap"/></returns>
        public Java.Util.SortedMap SubMap(object arg0, object arg1)
        {
            return IExecute<Java.Util.SortedMap>("subMap", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeMap.html#tailMap(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.SortedMap"/></returns>
        public Java.Util.SortedMap TailMap(object arg0)
        {
            return IExecuteWithSignature<Java.Util.SortedMap>("tailMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeMap.html#ceilingKey(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object CeilingKey(object arg0)
        {
            return IExecuteWithSignature("ceilingKey", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeMap.html#firstKey()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object FirstKey()
        {
            return IExecuteWithSignature("firstKey", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeMap.html#floorKey(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object FloorKey(object arg0)
        {
            return IExecuteWithSignature("floorKey", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeMap.html#higherKey(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object HigherKey(object arg0)
        {
            return IExecuteWithSignature("higherKey", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeMap.html#lastKey()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object LastKey()
        {
            return IExecuteWithSignature("lastKey", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeMap.html#lowerKey(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object LowerKey(object arg0)
        {
            return IExecuteWithSignature("lowerKey", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TreeMap<K, V>
    public partial class TreeMap<K, V> : Java.Util.INavigableMap<K, V>, Java.Lang.ICloneable, Java.Io.ISerializable
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeMap.html#%3Cinit%3E(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public TreeMap(Java.Util.Map<K, V> arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeMap.html#%3Cinit%3E(java.util.SortedMap)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.SortedMap"/></param>
        public TreeMap(Java.Util.SortedMap<K, V> arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.TreeMap{K, V}"/> to <see cref="Java.Util.NavigableMap{K, V}"/>
        /// </summary>
        public static implicit operator Java.Util.NavigableMap<K, V>(Java.Util.TreeMap<K, V> t) => t.Cast<Java.Util.NavigableMap<K, V>>();
        /// <summary>
        /// Converter from <see cref="Java.Util.TreeMap{K, V}"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Util.TreeMap<K, V> t) => t.Cast<Java.Lang.Cloneable>();
        /// <summary>
        /// Converter from <see cref="Java.Util.TreeMap{K, V}"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Util.TreeMap<K, V> t) => t.Cast<Java.Io.Serializable>();
        /// <summary>
        /// Converter from <see cref="Java.Util.TreeMap{K, V}"/> to <see cref="Java.Util.TreeMap"/>
        /// </summary>
        public static implicit operator Java.Util.TreeMap(Java.Util.TreeMap<K, V> t) => t.Cast<Java.Util.TreeMap>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeMap.html#ceilingEntry(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <returns><see cref="Java.Util.Map.Entry"/></returns>
        public Java.Util.Map.Entry<K, V> CeilingEntry(K arg0)
        {
            return IExecuteWithSignature<Java.Util.Map.Entry<K, V>>("ceilingEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeMap.html#firstEntry()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map.Entry"/></returns>
        public Java.Util.Map.Entry<K, V> FirstEntry()
        {
            return IExecuteWithSignature<Java.Util.Map.Entry<K, V>>("firstEntry", "()Ljava/util/Map$Entry;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeMap.html#floorEntry(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <returns><see cref="Java.Util.Map.Entry"/></returns>
        public Java.Util.Map.Entry<K, V> FloorEntry(K arg0)
        {
            return IExecuteWithSignature<Java.Util.Map.Entry<K, V>>("floorEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeMap.html#higherEntry(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <returns><see cref="Java.Util.Map.Entry"/></returns>
        public Java.Util.Map.Entry<K, V> HigherEntry(K arg0)
        {
            return IExecuteWithSignature<Java.Util.Map.Entry<K, V>>("higherEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeMap.html#lastEntry()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map.Entry"/></returns>
        public Java.Util.Map.Entry<K, V> LastEntry()
        {
            return IExecuteWithSignature<Java.Util.Map.Entry<K, V>>("lastEntry", "()Ljava/util/Map$Entry;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeMap.html#lowerEntry(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <returns><see cref="Java.Util.Map.Entry"/></returns>
        public Java.Util.Map.Entry<K, V> LowerEntry(K arg0)
        {
            return IExecuteWithSignature<Java.Util.Map.Entry<K, V>>("lowerEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeMap.html#pollFirstEntry()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map.Entry"/></returns>
        public Java.Util.Map.Entry<K, V> PollFirstEntry()
        {
            return IExecuteWithSignature<Java.Util.Map.Entry<K, V>>("pollFirstEntry", "()Ljava/util/Map$Entry;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeMap.html#pollLastEntry()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map.Entry"/></returns>
        public Java.Util.Map.Entry<K, V> PollLastEntry()
        {
            return IExecuteWithSignature<Java.Util.Map.Entry<K, V>>("pollLastEntry", "()Ljava/util/Map$Entry;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeMap.html#descendingMap()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.NavigableMap"/></returns>
        public Java.Util.NavigableMap<K, V> DescendingMap()
        {
            return IExecuteWithSignature<Java.Util.NavigableMap<K, V>>("descendingMap", "()Ljava/util/NavigableMap;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeMap.html#headMap(java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.NavigableMap"/></returns>
        public Java.Util.NavigableMap<K, V> HeadMap(K arg0, bool arg1)
        {
            return IExecute<Java.Util.NavigableMap<K, V>>("headMap", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeMap.html#subMap(java.lang.Object,boolean,java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><typeparamref name="K"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.NavigableMap"/></returns>
        public Java.Util.NavigableMap<K, V> SubMap(K arg0, bool arg1, K arg2, bool arg3)
        {
            return IExecute<Java.Util.NavigableMap<K, V>>("subMap", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeMap.html#tailMap(java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.NavigableMap"/></returns>
        public Java.Util.NavigableMap<K, V> TailMap(K arg0, bool arg1)
        {
            return IExecute<Java.Util.NavigableMap<K, V>>("tailMap", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeMap.html#descendingKeySet()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.NavigableSet"/></returns>
        public Java.Util.NavigableSet<K> DescendingKeySet()
        {
            return IExecuteWithSignature<Java.Util.NavigableSet<K>>("descendingKeySet", "()Ljava/util/NavigableSet;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeMap.html#navigableKeySet()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.NavigableSet"/></returns>
        public Java.Util.NavigableSet<K> NavigableKeySet()
        {
            return IExecuteWithSignature<Java.Util.NavigableSet<K>>("navigableKeySet", "()Ljava/util/NavigableSet;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeMap.html#headMap(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <returns><see cref="Java.Util.SortedMap"/></returns>
        public Java.Util.SortedMap<K, V> HeadMap(K arg0)
        {
            return IExecuteWithSignature<Java.Util.SortedMap<K, V>>("headMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeMap.html#subMap(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><typeparamref name="K"/></param>
        /// <returns><see cref="Java.Util.SortedMap"/></returns>
        public Java.Util.SortedMap<K, V> SubMap(K arg0, K arg1)
        {
            return IExecute<Java.Util.SortedMap<K, V>>("subMap", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeMap.html#tailMap(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <returns><see cref="Java.Util.SortedMap"/></returns>
        public Java.Util.SortedMap<K, V> TailMap(K arg0)
        {
            return IExecuteWithSignature<Java.Util.SortedMap<K, V>>("tailMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeMap.html#ceilingKey(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <returns><typeparamref name="K"/></returns>
        public K CeilingKey(K arg0)
        {
            return IExecuteWithSignature<K>("ceilingKey", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeMap.html#firstKey()"/>
        /// </summary>
        /// <returns><typeparamref name="K"/></returns>
        public K FirstKey()
        {
            return IExecuteWithSignature<K>("firstKey", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeMap.html#floorKey(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <returns><typeparamref name="K"/></returns>
        public K FloorKey(K arg0)
        {
            return IExecuteWithSignature<K>("floorKey", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeMap.html#higherKey(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <returns><typeparamref name="K"/></returns>
        public K HigherKey(K arg0)
        {
            return IExecuteWithSignature<K>("higherKey", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeMap.html#lastKey()"/>
        /// </summary>
        /// <returns><typeparamref name="K"/></returns>
        public K LastKey()
        {
            return IExecuteWithSignature<K>("lastKey", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/TreeMap.html#lowerKey(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <returns><typeparamref name="K"/></returns>
        public K LowerKey(K arg0)
        {
            return IExecuteWithSignature<K>("lowerKey", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}