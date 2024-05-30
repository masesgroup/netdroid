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
    #region EnumMap
    public partial class EnumMap
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/EnumMap.html#%3Cinit%3E(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        public EnumMap(Java.Lang.Class arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/EnumMap.html#%3Cinit%3E(java.util.EnumMap)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.EnumMap"/></param>
        public EnumMap(Java.Util.EnumMap arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/EnumMap.html#%3Cinit%3E(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public EnumMap(Java.Util.Map arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.EnumMap"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Util.EnumMap t) => t.Cast<Java.Io.Serializable>();
        /// <summary>
        /// Converter from <see cref="Java.Util.EnumMap"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Util.EnumMap t) => t.Cast<Java.Lang.Cloneable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/EnumMap.html#clone()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.EnumMap"/></returns>
        public Java.Util.EnumMap Clone()
        {
            return IExecuteWithSignature<Java.Util.EnumMap>("clone", "()Ljava/util/EnumMap;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/EnumMap.html#put(java.lang.Enum,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Enum"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Put(Java.Lang.Enum arg0, object arg1)
        {
            return IExecute("put", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region EnumMap<K, V>
    public partial class EnumMap<K, V> : Java.Io.ISerializable, Java.Lang.ICloneable
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/EnumMap.html#%3Cinit%3E(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        public EnumMap(Java.Lang.Class arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/EnumMap.html#%3Cinit%3E(java.util.EnumMap)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.EnumMap"/></param>
        public EnumMap(Java.Util.EnumMap<K, V> arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/EnumMap.html#%3Cinit%3E(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public EnumMap(Java.Util.Map<K, V> arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.EnumMap{K, V}"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Util.EnumMap<K, V> t) => t.Cast<Java.Io.Serializable>();
        /// <summary>
        /// Converter from <see cref="Java.Util.EnumMap{K, V}"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Util.EnumMap<K, V> t) => t.Cast<Java.Lang.Cloneable>();
        /// <summary>
        /// Converter from <see cref="Java.Util.EnumMap{K, V}"/> to <see cref="Java.Util.EnumMap"/>
        /// </summary>
        public static implicit operator Java.Util.EnumMap(Java.Util.EnumMap<K, V> t) => t.Cast<Java.Util.EnumMap>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/EnumMap.html#clone()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.EnumMap"/></returns>
        public Java.Util.EnumMap Clone()
        {
            return IExecuteWithSignature<Java.Util.EnumMap>("clone", "()Ljava/util/EnumMap;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/EnumMap.html#put(java.lang.Enum,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><typeparamref name="V"/></param>
        /// <returns><typeparamref name="V"/></returns>
        public V Put(K arg0, V arg1)
        {
            return IExecute<V>("put", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}