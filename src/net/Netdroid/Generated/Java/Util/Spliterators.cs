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

namespace Java.Util
{
    #region Spliterators
    public partial class Spliterators
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Spliterators.html#iterator(java.util.Spliterator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Spliterator"/></param>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="Arg0ExtendsT"><typeparamref name="T"/></typeparam>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public static Java.Util.Iterator<T> Iterator<T, Arg0ExtendsT>(Java.Util.Spliterator<Arg0ExtendsT> arg0) where Arg0ExtendsT : T
        {
            return SExecuteWithSignature<Java.Util.Iterator<T>>(LocalBridgeClazz, "iterator", "(Ljava/util/Spliterator;)Ljava/util/Iterator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Spliterators.html#emptySpliterator()"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Java.Util.Spliterator"/></returns>
        public static Java.Util.Spliterator<T> EmptySpliterator<T>()
        {
            return SExecuteWithSignature<Java.Util.Spliterator<T>>(LocalBridgeClazz, "emptySpliterator", "()Ljava/util/Spliterator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Spliterators.html#spliterator(java.lang.Object[],int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Java.Util.Spliterator"/></returns>
        public static Java.Util.Spliterator<T> Spliterator<T>(object[] arg0, int arg1, int arg2, int arg3)
        {
            return SExecute<Java.Util.Spliterator<T>>(LocalBridgeClazz, "spliterator", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Spliterators.html#spliterator(java.lang.Object[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Java.Util.Spliterator"/></returns>
        public static Java.Util.Spliterator<T> Spliterator<T>(object[] arg0, int arg1)
        {
            return SExecute<Java.Util.Spliterator<T>>(LocalBridgeClazz, "spliterator", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Spliterators.html#spliterator(java.util.Collection,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="Arg0ExtendsT"><typeparamref name="T"/></typeparam>
        /// <returns><see cref="Java.Util.Spliterator"/></returns>
        public static Java.Util.Spliterator<T> Spliterator<T, Arg0ExtendsT>(Java.Util.Collection<Arg0ExtendsT> arg0, int arg1) where Arg0ExtendsT : T
        {
            return SExecute<Java.Util.Spliterator<T>>(LocalBridgeClazz, "spliterator", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Spliterators.html#spliterator(java.util.Iterator,long,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Iterator"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="Arg0ExtendsT"><typeparamref name="T"/></typeparam>
        /// <returns><see cref="Java.Util.Spliterator"/></returns>
        public static Java.Util.Spliterator<T> Spliterator<T, Arg0ExtendsT>(Java.Util.Iterator<Arg0ExtendsT> arg0, long arg1, int arg2) where Arg0ExtendsT : T
        {
            return SExecute<Java.Util.Spliterator<T>>(LocalBridgeClazz, "spliterator", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Spliterators.html#spliteratorUnknownSize(java.util.Iterator,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Iterator"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="Arg0ExtendsT"><typeparamref name="T"/></typeparam>
        /// <returns><see cref="Java.Util.Spliterator"/></returns>
        public static Java.Util.Spliterator<T> SpliteratorUnknownSize<T, Arg0ExtendsT>(Java.Util.Iterator<Arg0ExtendsT> arg0, int arg1) where Arg0ExtendsT : T
        {
            return SExecute<Java.Util.Spliterator<T>>(LocalBridgeClazz, "spliteratorUnknownSize", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Spliterators.html#iterator(java.util.Spliterator.OfDouble)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Spliterator.OfDouble"/></param>
        /// <returns><see cref="Java.Util.PrimitiveIterator.OfDouble"/></returns>
        public static Java.Util.PrimitiveIterator.OfDouble Iterator(Java.Util.Spliterator.OfDouble arg0)
        {
            return SExecuteWithSignature<Java.Util.PrimitiveIterator.OfDouble>(LocalBridgeClazz, "iterator", "(Ljava/util/Spliterator$OfDouble;)Ljava/util/PrimitiveIterator$OfDouble;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Spliterators.html#iterator(java.util.Spliterator.OfInt)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Spliterator.OfInt"/></param>
        /// <returns><see cref="Java.Util.PrimitiveIterator.OfInt"/></returns>
        public static Java.Util.PrimitiveIterator.OfInt Iterator(Java.Util.Spliterator.OfInt arg0)
        {
            return SExecuteWithSignature<Java.Util.PrimitiveIterator.OfInt>(LocalBridgeClazz, "iterator", "(Ljava/util/Spliterator$OfInt;)Ljava/util/PrimitiveIterator$OfInt;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Spliterators.html#iterator(java.util.Spliterator.OfLong)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Spliterator.OfLong"/></param>
        /// <returns><see cref="Java.Util.PrimitiveIterator.OfLong"/></returns>
        public static Java.Util.PrimitiveIterator.OfLong Iterator(Java.Util.Spliterator.OfLong arg0)
        {
            return SExecuteWithSignature<Java.Util.PrimitiveIterator.OfLong>(LocalBridgeClazz, "iterator", "(Ljava/util/Spliterator$OfLong;)Ljava/util/PrimitiveIterator$OfLong;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Spliterators.html#emptyDoubleSpliterator()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Spliterator.OfDouble"/></returns>
        public static Java.Util.Spliterator.OfDouble EmptyDoubleSpliterator()
        {
            return SExecuteWithSignature<Java.Util.Spliterator.OfDouble>(LocalBridgeClazz, "emptyDoubleSpliterator", "()Ljava/util/Spliterator$OfDouble;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Spliterators.html#spliterator(double[],int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Spliterator.OfDouble"/></returns>
        public static Java.Util.Spliterator.OfDouble Spliterator(double[] arg0, int arg1, int arg2, int arg3)
        {
            return SExecute<Java.Util.Spliterator.OfDouble>(LocalBridgeClazz, "spliterator", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Spliterators.html#spliterator(double[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Spliterator.OfDouble"/></returns>
        public static Java.Util.Spliterator.OfDouble Spliterator(double[] arg0, int arg1)
        {
            return SExecute<Java.Util.Spliterator.OfDouble>(LocalBridgeClazz, "spliterator", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Spliterators.html#spliterator(java.util.PrimitiveIterator.OfDouble,long,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.PrimitiveIterator.OfDouble"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Spliterator.OfDouble"/></returns>
        public static Java.Util.Spliterator.OfDouble Spliterator(Java.Util.PrimitiveIterator.OfDouble arg0, long arg1, int arg2)
        {
            return SExecute<Java.Util.Spliterator.OfDouble>(LocalBridgeClazz, "spliterator", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Spliterators.html#spliteratorUnknownSize(java.util.PrimitiveIterator.OfDouble,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.PrimitiveIterator.OfDouble"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Spliterator.OfDouble"/></returns>
        public static Java.Util.Spliterator.OfDouble SpliteratorUnknownSize(Java.Util.PrimitiveIterator.OfDouble arg0, int arg1)
        {
            return SExecute<Java.Util.Spliterator.OfDouble>(LocalBridgeClazz, "spliteratorUnknownSize", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Spliterators.html#emptyIntSpliterator()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Spliterator.OfInt"/></returns>
        public static Java.Util.Spliterator.OfInt EmptyIntSpliterator()
        {
            return SExecuteWithSignature<Java.Util.Spliterator.OfInt>(LocalBridgeClazz, "emptyIntSpliterator", "()Ljava/util/Spliterator$OfInt;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Spliterators.html#spliterator(int[],int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Spliterator.OfInt"/></returns>
        public static Java.Util.Spliterator.OfInt Spliterator(int[] arg0, int arg1, int arg2, int arg3)
        {
            return SExecute<Java.Util.Spliterator.OfInt>(LocalBridgeClazz, "spliterator", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Spliterators.html#spliterator(int[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Spliterator.OfInt"/></returns>
        public static Java.Util.Spliterator.OfInt Spliterator(int[] arg0, int arg1)
        {
            return SExecute<Java.Util.Spliterator.OfInt>(LocalBridgeClazz, "spliterator", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Spliterators.html#spliterator(java.util.PrimitiveIterator.OfInt,long,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.PrimitiveIterator.OfInt"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Spliterator.OfInt"/></returns>
        public static Java.Util.Spliterator.OfInt Spliterator(Java.Util.PrimitiveIterator.OfInt arg0, long arg1, int arg2)
        {
            return SExecute<Java.Util.Spliterator.OfInt>(LocalBridgeClazz, "spliterator", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Spliterators.html#spliteratorUnknownSize(java.util.PrimitiveIterator.OfInt,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.PrimitiveIterator.OfInt"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Spliterator.OfInt"/></returns>
        public static Java.Util.Spliterator.OfInt SpliteratorUnknownSize(Java.Util.PrimitiveIterator.OfInt arg0, int arg1)
        {
            return SExecute<Java.Util.Spliterator.OfInt>(LocalBridgeClazz, "spliteratorUnknownSize", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Spliterators.html#emptyLongSpliterator()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Spliterator.OfLong"/></returns>
        public static Java.Util.Spliterator.OfLong EmptyLongSpliterator()
        {
            return SExecuteWithSignature<Java.Util.Spliterator.OfLong>(LocalBridgeClazz, "emptyLongSpliterator", "()Ljava/util/Spliterator$OfLong;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Spliterators.html#spliterator(java.util.PrimitiveIterator.OfLong,long,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.PrimitiveIterator.OfLong"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Spliterator.OfLong"/></returns>
        public static Java.Util.Spliterator.OfLong Spliterator(Java.Util.PrimitiveIterator.OfLong arg0, long arg1, int arg2)
        {
            return SExecute<Java.Util.Spliterator.OfLong>(LocalBridgeClazz, "spliterator", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Spliterators.html#spliterator(long[],int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Spliterator.OfLong"/></returns>
        public static Java.Util.Spliterator.OfLong Spliterator(long[] arg0, int arg1, int arg2, int arg3)
        {
            return SExecute<Java.Util.Spliterator.OfLong>(LocalBridgeClazz, "spliterator", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Spliterators.html#spliterator(long[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Spliterator.OfLong"/></returns>
        public static Java.Util.Spliterator.OfLong Spliterator(long[] arg0, int arg1)
        {
            return SExecute<Java.Util.Spliterator.OfLong>(LocalBridgeClazz, "spliterator", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/Spliterators.html#spliteratorUnknownSize(java.util.PrimitiveIterator.OfLong,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.PrimitiveIterator.OfLong"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Spliterator.OfLong"/></returns>
        public static Java.Util.Spliterator.OfLong SpliteratorUnknownSize(Java.Util.PrimitiveIterator.OfLong arg0, int arg1)
        {
            return SExecute<Java.Util.Spliterator.OfLong>(LocalBridgeClazz, "spliteratorUnknownSize", arg0, arg1);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes
        #region AbstractDoubleSpliterator
        public partial class AbstractDoubleSpliterator
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
            /// <see href="https://developer.android.com/reference/java/util/Spliterators.AbstractDoubleSpliterator.html#characteristics()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int Characteristics()
            {
                return IExecuteWithSignature<int>("characteristics", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/util/Spliterators.AbstractDoubleSpliterator.html#trySplit()"/>
            /// </summary>
            /// <returns><see cref="Java.Util.Spliterator.OfDouble"/></returns>
            public Java.Util.Spliterator.OfDouble TrySplit()
            {
                return IExecuteWithSignature<Java.Util.Spliterator.OfDouble>("trySplit", "()Ljava/util/Spliterator$OfDouble;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/util/Spliterators.AbstractDoubleSpliterator.html#estimateSize()"/>
            /// </summary>
            /// <returns><see cref="long"/></returns>
            public long EstimateSize()
            {
                return IExecuteWithSignature<long>("estimateSize", "()J");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region AbstractIntSpliterator
        public partial class AbstractIntSpliterator
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
            /// <see href="https://developer.android.com/reference/java/util/Spliterators.AbstractIntSpliterator.html#characteristics()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int Characteristics()
            {
                return IExecuteWithSignature<int>("characteristics", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/util/Spliterators.AbstractIntSpliterator.html#trySplit()"/>
            /// </summary>
            /// <returns><see cref="Java.Util.Spliterator.OfInt"/></returns>
            public Java.Util.Spliterator.OfInt TrySplit()
            {
                return IExecuteWithSignature<Java.Util.Spliterator.OfInt>("trySplit", "()Ljava/util/Spliterator$OfInt;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/util/Spliterators.AbstractIntSpliterator.html#estimateSize()"/>
            /// </summary>
            /// <returns><see cref="long"/></returns>
            public long EstimateSize()
            {
                return IExecuteWithSignature<long>("estimateSize", "()J");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region AbstractLongSpliterator
        public partial class AbstractLongSpliterator
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
            /// <see href="https://developer.android.com/reference/java/util/Spliterators.AbstractLongSpliterator.html#characteristics()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int Characteristics()
            {
                return IExecuteWithSignature<int>("characteristics", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/util/Spliterators.AbstractLongSpliterator.html#trySplit()"/>
            /// </summary>
            /// <returns><see cref="Java.Util.Spliterator.OfLong"/></returns>
            public Java.Util.Spliterator.OfLong TrySplit()
            {
                return IExecuteWithSignature<Java.Util.Spliterator.OfLong>("trySplit", "()Ljava/util/Spliterator$OfLong;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/util/Spliterators.AbstractLongSpliterator.html#estimateSize()"/>
            /// </summary>
            /// <returns><see cref="long"/></returns>
            public long EstimateSize()
            {
                return IExecuteWithSignature<long>("estimateSize", "()J");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region AbstractSpliterator
        public partial class AbstractSpliterator
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
            /// <see href="https://developer.android.com/reference/java/util/Spliterators.AbstractSpliterator.html#characteristics()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int Characteristics()
            {
                return IExecuteWithSignature<int>("characteristics", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/util/Spliterators.AbstractSpliterator.html#trySplit()"/>
            /// </summary>
            /// <returns><see cref="Java.Util.Spliterator"/></returns>
            public Java.Util.Spliterator TrySplit()
            {
                return IExecuteWithSignature<Java.Util.Spliterator>("trySplit", "()Ljava/util/Spliterator;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/util/Spliterators.AbstractSpliterator.html#estimateSize()"/>
            /// </summary>
            /// <returns><see cref="long"/></returns>
            public long EstimateSize()
            {
                return IExecuteWithSignature<long>("estimateSize", "()J");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region AbstractSpliterator<T>
        public partial class AbstractSpliterator<T>
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Java.Util.Spliterators.AbstractSpliterator{T}"/> to <see cref="Java.Util.Spliterators.AbstractSpliterator"/>
            /// </summary>
            public static implicit operator Java.Util.Spliterators.AbstractSpliterator(Java.Util.Spliterators.AbstractSpliterator<T> t) => t.Cast<Java.Util.Spliterators.AbstractSpliterator>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/util/Spliterators.AbstractSpliterator.html#characteristics()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int Characteristics()
            {
                return IExecuteWithSignature<int>("characteristics", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/util/Spliterators.AbstractSpliterator.html#trySplit()"/>
            /// </summary>
            /// <returns><see cref="Java.Util.Spliterator"/></returns>
            public Java.Util.Spliterator<T> TrySplit()
            {
                return IExecuteWithSignature<Java.Util.Spliterator<T>>("trySplit", "()Ljava/util/Spliterator;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java/util/Spliterators.AbstractSpliterator.html#estimateSize()"/>
            /// </summary>
            /// <returns><see cref="long"/></returns>
            public long EstimateSize()
            {
                return IExecuteWithSignature<long>("estimateSize", "()J");
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
}