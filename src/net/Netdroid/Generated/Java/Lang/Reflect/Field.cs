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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang.Reflect
{
    #region Field
    public partial class Field
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Lang.Reflect.Field"/> to <see cref="Java.Lang.Reflect.Member"/>
        /// </summary>
        public static implicit operator Java.Lang.Reflect.Member(Java.Lang.Reflect.Field t) => t.Cast<Java.Lang.Reflect.Member>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Field.html#getBoolean(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.IllegalAccessException"/>
        public bool GetBoolean(object arg0)
        {
            return IExecuteWithSignature<bool>("getBoolean", "(Ljava/lang/Object;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Field.html#isEnumConstant()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsEnumConstant()
        {
            return IExecuteWithSignature<bool>("isEnumConstant", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Field.html#isSynthetic()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsSynthetic()
        {
            return IExecuteWithSignature<bool>("isSynthetic", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Field.html#getByte(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.IllegalAccessException"/>
        public byte GetByte(object arg0)
        {
            return IExecuteWithSignature<byte>("getByte", "(Ljava/lang/Object;)B", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Field.html#getChar(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="char"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.IllegalAccessException"/>
        public char GetChar(object arg0)
        {
            return IExecuteWithSignature<char>("getChar", "(Ljava/lang/Object;)C", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Field.html#getDouble(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="double"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.IllegalAccessException"/>
        public double GetDouble(object arg0)
        {
            return IExecuteWithSignature<double>("getDouble", "(Ljava/lang/Object;)D", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Field.html#getFloat(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="float"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.IllegalAccessException"/>
        public float GetFloat(object arg0)
        {
            return IExecuteWithSignature<float>("getFloat", "(Ljava/lang/Object;)F", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Field.html#getInt(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.IllegalAccessException"/>
        public int GetInt(object arg0)
        {
            return IExecuteWithSignature<int>("getInt", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Field.html#getModifiers()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetModifiers()
        {
            return IExecuteWithSignature<int>("getModifiers", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Field.html#getDeclaringClass()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Class"/></returns>
        public Java.Lang.Class GetDeclaringClass()
        {
            return IExecuteWithSignature<Java.Lang.Class>("getDeclaringClass", "()Ljava/lang/Class;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Field.html#getType()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Class"/></returns>
        public Java.Lang.Class GetType()
        {
            return IExecuteWithSignature<Java.Lang.Class>("getType", "()Ljava/lang/Class;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Field.html#get(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.IllegalAccessException"/>
        public object Get(object arg0)
        {
            return IExecuteWithSignature("get", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Field.html#getGenericType()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Reflect.Type"/></returns>
        public Java.Lang.Reflect.Type GetGenericType()
        {
            return IExecuteWithSignature<Java.Lang.Reflect.Type>("getGenericType", "()Ljava/lang/reflect/Type;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Field.html#getName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Field.html#toGenericString()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ToGenericString()
        {
            return IExecuteWithSignature<Java.Lang.String>("toGenericString", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Field.html#getLong(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.IllegalAccessException"/>
        public long GetLong(object arg0)
        {
            return IExecuteWithSignature<long>("getLong", "(Ljava/lang/Object;)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Field.html#getShort(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="short"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.IllegalAccessException"/>
        public short GetShort(object arg0)
        {
            return IExecuteWithSignature<short>("getShort", "(Ljava/lang/Object;)S", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Field.html#set(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.IllegalAccessException"/>
        public void Set(object arg0, object arg1)
        {
            IExecute("set", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Field.html#setBoolean(java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.IllegalAccessException"/>
        public void SetBoolean(object arg0, bool arg1)
        {
            IExecute("setBoolean", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Field.html#setByte(java.lang.Object,byte)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.IllegalAccessException"/>
        public void SetByte(object arg0, byte arg1)
        {
            IExecute("setByte", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Field.html#setChar(java.lang.Object,char)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="char"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.IllegalAccessException"/>
        public void SetChar(object arg0, char arg1)
        {
            IExecute("setChar", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Field.html#setDouble(java.lang.Object,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.IllegalAccessException"/>
        public void SetDouble(object arg0, double arg1)
        {
            IExecute("setDouble", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Field.html#setFloat(java.lang.Object,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.IllegalAccessException"/>
        public void SetFloat(object arg0, float arg1)
        {
            IExecute("setFloat", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Field.html#setInt(java.lang.Object,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.IllegalAccessException"/>
        public void SetInt(object arg0, int arg1)
        {
            IExecute("setInt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Field.html#setLong(java.lang.Object,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.IllegalAccessException"/>
        public void SetLong(object arg0, long arg1)
        {
            IExecute("setLong", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Field.html#setShort(java.lang.Object,short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="short"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.IllegalAccessException"/>
        public void SetShort(object arg0, short arg1)
        {
            IExecute("setShort", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}