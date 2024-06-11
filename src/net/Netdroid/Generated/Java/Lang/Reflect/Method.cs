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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang.Reflect
{
    #region Method
    public partial class Method
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
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Method.html#isBridge()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsBridge()
        {
            return IExecuteWithSignature<bool>("isBridge", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Method.html#isDefault()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsDefault()
        {
            return IExecuteWithSignature<bool>("isDefault", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Method.html#getReturnType()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Class"/></returns>
        public Java.Lang.Class GetReturnType()
        {
            return IExecuteWithSignature<Java.Lang.Class>("getReturnType", "()Ljava/lang/Class;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Method.html#getDefaultValue()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object GetDefaultValue()
        {
            return IExecuteWithSignature("getDefaultValue", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Method.html#invoke(java.lang.Object,java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Lang.IllegalAccessException"/>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.Reflect.InvocationTargetException"/>
        public object Invoke(object arg0, params object[] arg1)
        {
            if (arg1.Length == 0) return IExecute("invoke", arg0); else return IExecute("invoke", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Method.html#getGenericReturnType()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Reflect.Type"/></returns>
        public Java.Lang.Reflect.Type GetGenericReturnType()
        {
            return IExecuteWithSignature<Java.Lang.Reflect.Type>("getGenericReturnType", "()Ljava/lang/reflect/Type;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}