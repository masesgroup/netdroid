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

namespace Java.Util
{
    #region Stack
    public partial class Stack
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
        /// <see href="https://developer.android.com/reference/java/util/Stack.html#empty()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool Empty()
        {
            return IExecuteWithSignature<bool>("empty", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Stack.html#push(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Push(object arg0)
        {
            return IExecuteWithSignature("push", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Stack.html#peek()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object Peek()
        {
            return IExecuteWithSignature("peek", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Stack.html#pop()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object Pop()
        {
            return IExecuteWithSignature("pop", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Stack.html#search(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int Search(object arg0)
        {
            return IExecuteWithSignature<int>("search", "(Ljava/lang/Object;)I", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Stack<E>
    public partial class Stack<E>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Stack{E}"/> to <see cref="Java.Util.Stack"/>
        /// </summary>
        public static implicit operator Java.Util.Stack(Java.Util.Stack<E> t) => t.Cast<Java.Util.Stack>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Stack.html#empty()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool Empty()
        {
            return IExecuteWithSignature<bool>("empty", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Stack.html#push(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <returns><typeparamref name="E"/></returns>
        public E Push(E arg0)
        {
            return IExecuteWithSignature<E>("push", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Stack.html#peek()"/>
        /// </summary>
        /// <returns><typeparamref name="E"/></returns>
        public E Peek()
        {
            return IExecuteWithSignature<E>("peek", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Stack.html#pop()"/>
        /// </summary>
        /// <returns><typeparamref name="E"/></returns>
        public E Pop()
        {
            return IExecuteWithSignature<E>("pop", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Stack.html#search(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int Search(object arg0)
        {
            return IExecuteWithSignature<int>("search", "(Ljava/lang/Object;)I", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}