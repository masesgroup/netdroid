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

namespace Java.Util.Stream
{
    #region ILongStream
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ILongStream : Java.Util.Stream.IBaseStream<Java.Lang.Long, Java.Util.Stream.LongStream>
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region LongStream
    public partial class LongStream : Java.Util.Stream.ILongStream
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/LongStream.html#concat(java.util.stream.LongStream,java.util.stream.LongStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Stream.LongStream"/></param>
        /// <param name="arg1"><see cref="Java.Util.Stream.LongStream"/></param>
        /// <returns><see cref="Java.Util.Stream.LongStream"/></returns>
        public static Java.Util.Stream.LongStream Concat(Java.Util.Stream.LongStream arg0, Java.Util.Stream.LongStream arg1)
        {
            return SExecute<Java.Util.Stream.LongStream>(LocalBridgeClazz, "concat", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/LongStream.html#empty()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Stream.LongStream"/></returns>
        public static Java.Util.Stream.LongStream Empty()
        {
            return SExecuteWithSignature<Java.Util.Stream.LongStream>(LocalBridgeClazz, "empty", "()Ljava/util/stream/LongStream;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/LongStream.html#generate(java.util.function.LongSupplier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongSupplier"/></param>
        /// <returns><see cref="Java.Util.Stream.LongStream"/></returns>
        public static Java.Util.Stream.LongStream Generate(Java.Util.Function.LongSupplier arg0)
        {
            return SExecuteWithSignature<Java.Util.Stream.LongStream>(LocalBridgeClazz, "generate", "(Ljava/util/function/LongSupplier;)Ljava/util/stream/LongStream;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/LongStream.html#iterate(long,java.util.function.LongPredicate,java.util.function.LongUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.LongPredicate"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.LongUnaryOperator"/></param>
        /// <returns><see cref="Java.Util.Stream.LongStream"/></returns>
        public static Java.Util.Stream.LongStream Iterate(long arg0, Java.Util.Function.LongPredicate arg1, Java.Util.Function.LongUnaryOperator arg2)
        {
            return SExecute<Java.Util.Stream.LongStream>(LocalBridgeClazz, "iterate", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/LongStream.html#iterate(long,java.util.function.LongUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.LongUnaryOperator"/></param>
        /// <returns><see cref="Java.Util.Stream.LongStream"/></returns>
        public static Java.Util.Stream.LongStream Iterate(long arg0, Java.Util.Function.LongUnaryOperator arg1)
        {
            return SExecute<Java.Util.Stream.LongStream>(LocalBridgeClazz, "iterate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/LongStream.html#of(long[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Util.Stream.LongStream"/></returns>
        public static Java.Util.Stream.LongStream Of(params long[] arg0)
        {
            if (arg0.Length == 0) return SExecuteWithSignature<Java.Util.Stream.LongStream>(LocalBridgeClazz, "of", "([J)Ljava/util/stream/LongStream;"); else return SExecuteWithSignature<Java.Util.Stream.LongStream>(LocalBridgeClazz, "of", "([J)Ljava/util/stream/LongStream;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/LongStream.html#of(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Util.Stream.LongStream"/></returns>
        public static Java.Util.Stream.LongStream Of(long arg0)
        {
            return SExecuteWithSignature<Java.Util.Stream.LongStream>(LocalBridgeClazz, "of", "(J)Ljava/util/stream/LongStream;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/LongStream.html#range(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="Java.Util.Stream.LongStream"/></returns>
        public static Java.Util.Stream.LongStream Range(long arg0, long arg1)
        {
            return SExecute<Java.Util.Stream.LongStream>(LocalBridgeClazz, "range", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/LongStream.html#rangeClosed(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="Java.Util.Stream.LongStream"/></returns>
        public static Java.Util.Stream.LongStream RangeClosed(long arg0, long arg1)
        {
            return SExecute<Java.Util.Stream.LongStream>(LocalBridgeClazz, "rangeClosed", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/LongStream.html#collect(java.util.function.Supplier,java.util.function.ObjLongConsumer,java.util.function.BiConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Supplier"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.ObjLongConsumer"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.BiConsumer"/></param>
        /// <typeparam name="R"></typeparam>
        /// <returns><typeparamref name="R"/></returns>
        public R Collect<R>(Java.Util.Function.Supplier<R> arg0, Java.Util.Function.ObjLongConsumer<R> arg1, Java.Util.Function.BiConsumer<R, R> arg2)
        {
            return IExecute<R>("collect", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/LongStream.html#mapToObj(java.util.function.LongFunction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongFunction"/></param>
        /// <typeparam name="U"></typeparam>
        /// <typeparam name="Arg0ExtendsU"><typeparamref name="U"/></typeparam>
        /// <returns><see cref="Java.Util.Stream.Stream"/></returns>
        public Java.Util.Stream.Stream<U> MapToObj<U, Arg0ExtendsU>(Java.Util.Function.LongFunction<Arg0ExtendsU> arg0) where Arg0ExtendsU : U
        {
            return IExecuteWithSignature<Java.Util.Stream.Stream<U>>("mapToObj", "(Ljava/util/function/LongFunction;)Ljava/util/stream/Stream;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/LongStream.html#allMatch(java.util.function.LongPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongPredicate"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool AllMatch(Java.Util.Function.LongPredicate arg0)
        {
            return IExecuteWithSignature<bool>("allMatch", "(Ljava/util/function/LongPredicate;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/LongStream.html#anyMatch(java.util.function.LongPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongPredicate"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool AnyMatch(Java.Util.Function.LongPredicate arg0)
        {
            return IExecuteWithSignature<bool>("anyMatch", "(Ljava/util/function/LongPredicate;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/LongStream.html#noneMatch(java.util.function.LongPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongPredicate"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool NoneMatch(Java.Util.Function.LongPredicate arg0)
        {
            return IExecuteWithSignature<bool>("noneMatch", "(Ljava/util/function/LongPredicate;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/LongStream.html#summaryStatistics()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.LongSummaryStatistics"/></returns>
        public Java.Util.LongSummaryStatistics SummaryStatistics()
        {
            return IExecuteWithSignature<Java.Util.LongSummaryStatistics>("summaryStatistics", "()Ljava/util/LongSummaryStatistics;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/LongStream.html#average()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.OptionalDouble"/></returns>
        public Java.Util.OptionalDouble Average()
        {
            return IExecuteWithSignature<Java.Util.OptionalDouble>("average", "()Ljava/util/OptionalDouble;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/LongStream.html#findAny()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.OptionalLong"/></returns>
        public Java.Util.OptionalLong FindAny()
        {
            return IExecuteWithSignature<Java.Util.OptionalLong>("findAny", "()Ljava/util/OptionalLong;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/LongStream.html#findFirst()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.OptionalLong"/></returns>
        public Java.Util.OptionalLong FindFirst()
        {
            return IExecuteWithSignature<Java.Util.OptionalLong>("findFirst", "()Ljava/util/OptionalLong;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/LongStream.html#max()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.OptionalLong"/></returns>
        public Java.Util.OptionalLong Max()
        {
            return IExecuteWithSignature<Java.Util.OptionalLong>("max", "()Ljava/util/OptionalLong;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/LongStream.html#min()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.OptionalLong"/></returns>
        public Java.Util.OptionalLong Min()
        {
            return IExecuteWithSignature<Java.Util.OptionalLong>("min", "()Ljava/util/OptionalLong;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/LongStream.html#reduce(java.util.function.LongBinaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongBinaryOperator"/></param>
        /// <returns><see cref="Java.Util.OptionalLong"/></returns>
        public Java.Util.OptionalLong Reduce(Java.Util.Function.LongBinaryOperator arg0)
        {
            return IExecuteWithSignature<Java.Util.OptionalLong>("reduce", "(Ljava/util/function/LongBinaryOperator;)Ljava/util/OptionalLong;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/LongStream.html#asDoubleStream()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Stream.DoubleStream"/></returns>
        public Java.Util.Stream.DoubleStream AsDoubleStream()
        {
            return IExecuteWithSignature<Java.Util.Stream.DoubleStream>("asDoubleStream", "()Ljava/util/stream/DoubleStream;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/LongStream.html#mapToDouble(java.util.function.LongToDoubleFunction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongToDoubleFunction"/></param>
        /// <returns><see cref="Java.Util.Stream.DoubleStream"/></returns>
        public Java.Util.Stream.DoubleStream MapToDouble(Java.Util.Function.LongToDoubleFunction arg0)
        {
            return IExecuteWithSignature<Java.Util.Stream.DoubleStream>("mapToDouble", "(Ljava/util/function/LongToDoubleFunction;)Ljava/util/stream/DoubleStream;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/LongStream.html#mapToInt(java.util.function.LongToIntFunction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongToIntFunction"/></param>
        /// <returns><see cref="Java.Util.Stream.IntStream"/></returns>
        public Java.Util.Stream.IntStream MapToInt(Java.Util.Function.LongToIntFunction arg0)
        {
            return IExecuteWithSignature<Java.Util.Stream.IntStream>("mapToInt", "(Ljava/util/function/LongToIntFunction;)Ljava/util/stream/IntStream;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/LongStream.html#distinct()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Stream.LongStream"/></returns>
        public Java.Util.Stream.LongStream Distinct()
        {
            return IExecuteWithSignature<Java.Util.Stream.LongStream>("distinct", "()Ljava/util/stream/LongStream;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/LongStream.html#filter(java.util.function.LongPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongPredicate"/></param>
        /// <returns><see cref="Java.Util.Stream.LongStream"/></returns>
        public Java.Util.Stream.LongStream Filter(Java.Util.Function.LongPredicate arg0)
        {
            return IExecuteWithSignature<Java.Util.Stream.LongStream>("filter", "(Ljava/util/function/LongPredicate;)Ljava/util/stream/LongStream;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/LongStream.html#flatMap(java.util.function.LongFunction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongFunction"/></param>
        /// <typeparam name="Arg0ExtendsJava_Util_Stream_LongStream"><see cref="Java.Util.Stream.LongStream"/></typeparam>
        /// <returns><see cref="Java.Util.Stream.LongStream"/></returns>
        public Java.Util.Stream.LongStream FlatMap<Arg0ExtendsJava_Util_Stream_LongStream>(Java.Util.Function.LongFunction<Arg0ExtendsJava_Util_Stream_LongStream> arg0) where Arg0ExtendsJava_Util_Stream_LongStream : Java.Util.Stream.LongStream
        {
            return IExecuteWithSignature<Java.Util.Stream.LongStream>("flatMap", "(Ljava/util/function/LongFunction;)Ljava/util/stream/LongStream;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/LongStream.html#limit(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Util.Stream.LongStream"/></returns>
        public Java.Util.Stream.LongStream Limit(long arg0)
        {
            return IExecuteWithSignature<Java.Util.Stream.LongStream>("limit", "(J)Ljava/util/stream/LongStream;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/LongStream.html#map(java.util.function.LongUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongUnaryOperator"/></param>
        /// <returns><see cref="Java.Util.Stream.LongStream"/></returns>
        public Java.Util.Stream.LongStream Map(Java.Util.Function.LongUnaryOperator arg0)
        {
            return IExecuteWithSignature<Java.Util.Stream.LongStream>("map", "(Ljava/util/function/LongUnaryOperator;)Ljava/util/stream/LongStream;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/LongStream.html#peek(java.util.function.LongConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongConsumer"/></param>
        /// <returns><see cref="Java.Util.Stream.LongStream"/></returns>
        public Java.Util.Stream.LongStream Peek(Java.Util.Function.LongConsumer arg0)
        {
            return IExecuteWithSignature<Java.Util.Stream.LongStream>("peek", "(Ljava/util/function/LongConsumer;)Ljava/util/stream/LongStream;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/LongStream.html#skip(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Util.Stream.LongStream"/></returns>
        public Java.Util.Stream.LongStream Skip(long arg0)
        {
            return IExecuteWithSignature<Java.Util.Stream.LongStream>("skip", "(J)Ljava/util/stream/LongStream;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/LongStream.html#sorted()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Stream.LongStream"/></returns>
        public Java.Util.Stream.LongStream Sorted()
        {
            return IExecuteWithSignature<Java.Util.Stream.LongStream>("sorted", "()Ljava/util/stream/LongStream;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/LongStream.html#boxed()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Stream.Stream"/></returns>
        public Java.Util.Stream.Stream<Java.Lang.Long> Boxed()
        {
            return IExecuteWithSignature<Java.Util.Stream.Stream<Java.Lang.Long>>("boxed", "()Ljava/util/stream/Stream;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/LongStream.html#count()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long Count()
        {
            return IExecuteWithSignature<long>("count", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/LongStream.html#reduce(long,java.util.function.LongBinaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.LongBinaryOperator"/></param>
        /// <returns><see cref="long"/></returns>
        public long Reduce(long arg0, Java.Util.Function.LongBinaryOperator arg1)
        {
            return IExecute<long>("reduce", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/LongStream.html#sum()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long Sum()
        {
            return IExecuteWithSignature<long>("sum", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/LongStream.html#toArray()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long[] ToArray()
        {
            return IExecuteWithSignatureArray<long>("toArray", "()[J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/LongStream.html#forEach(java.util.function.LongConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongConsumer"/></param>
        public void ForEach(Java.Util.Function.LongConsumer arg0)
        {
            IExecuteWithSignature("forEach", "(Ljava/util/function/LongConsumer;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/LongStream.html#forEachOrdered(java.util.function.LongConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongConsumer"/></param>
        public void ForEachOrdered(Java.Util.Function.LongConsumer arg0)
        {
            IExecuteWithSignature("forEachOrdered", "(Ljava/util/function/LongConsumer;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/LongStream.html#iterator()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public Java.Util.Iterator Iterator()
        {
            return IExecuteWithSignature<Java.Util.Iterator>("iterator", "()Ljava/util/Iterator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/LongStream.html#spliterator()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Spliterator"/></returns>
        public Java.Util.Spliterator Spliterator()
        {
            return IExecuteWithSignature<Java.Util.Spliterator>("spliterator", "()Ljava/util/Spliterator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/LongStream.html#parallel()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Stream.BaseStream"/></returns>
        public Java.Util.Stream.BaseStream Parallel()
        {
            return IExecuteWithSignature<Java.Util.Stream.BaseStream>("parallel", "()Ljava/util/stream/BaseStream;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/LongStream.html#sequential()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Stream.BaseStream"/></returns>
        public Java.Util.Stream.BaseStream Sequential()
        {
            return IExecuteWithSignature<Java.Util.Stream.BaseStream>("sequential", "()Ljava/util/stream/BaseStream;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/LongStream.html#dropWhile(java.util.function.LongPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongPredicate"/></param>
        /// <returns><see cref="Java.Util.Stream.LongStream"/></returns>
        public Java.Util.Stream.LongStream DropWhile(Java.Util.Function.LongPredicate arg0)
        {
            return IExecuteWithSignature<Java.Util.Stream.LongStream>("dropWhile", "(Ljava/util/function/LongPredicate;)Ljava/util/stream/LongStream;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/stream/LongStream.html#takeWhile(java.util.function.LongPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongPredicate"/></param>
        /// <returns><see cref="Java.Util.Stream.LongStream"/></returns>
        public Java.Util.Stream.LongStream TakeWhile(Java.Util.Function.LongPredicate arg0)
        {
            return IExecuteWithSignature<Java.Util.Stream.LongStream>("takeWhile", "(Ljava/util/function/LongPredicate;)Ljava/util/stream/LongStream;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}